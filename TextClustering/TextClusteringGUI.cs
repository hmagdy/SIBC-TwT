using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TextClustering.Lib;
using System;
using System.Xml.Linq;
using System.Xml;
using OpenTextSummarizer;
using System.Xml.Serialization;


namespace TextClustering
{

    public partial class TextClusteringGUI : Form
    {
        private DocumentCollection docCollection;
        List<DocumentVector> vSpace;
        List<ClusterNode> mainCLusterNodeList;
        int maxNoDoc = 100;

        public TextClusteringGUI()
        {
            InitializeComponent();
            docCollection = new DocumentCollection() { DocumentList = new List<string>() };
            mainCLusterNodeList = new List<ClusterNode>();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            int newDoc = 0;
            if (!string.IsNullOrEmpty(txtDoc1.Text))
            {
                docCollection.DocumentList.Add(txtDoc1.Text);
                newDoc++;
            }
            if (!string.IsNullOrEmpty(txtDoc2.Text))
            {
                newDoc++;
                docCollection.DocumentList.Add(txtDoc2.Text);
            }
            if (!string.IsNullOrEmpty(txtDoc3.Text))
            {
                docCollection.DocumentList.Add(txtDoc3.Text);
                newDoc++;
            }
            if (!string.IsNullOrEmpty(txtDoc4.Text))
            {
                newDoc++;
                docCollection.DocumentList.Add(txtDoc4.Text);
            }


            int totalDoc = 0;
            if (int.TryParse(docCollection.DocumentList.Count.ToString(), out totalDoc))
            {
                lblTotalDoc.Text = totalDoc.ToString();
            }

            txtDoc1.Clear();
            txtDoc2.Clear();
            txtDoc3.Clear();
            txtDoc4.Clear();

            if (ddlType.Text == "Incremental" && DocumnetClustering.mainCentroids.Count > 0)
            {
                switch (ddlIncAlg.Text)
                {
                    case "KMeans":
                        List<DocumentVector> vSpace = VectorSpaceModel.ProcessDocumentCollection(docCollection);
                        for (int i = 1; i <= newDoc; i++)
                        {
                            DocumentVector obj = vSpace[vSpace.Count - i];
                            int index = DocumnetClustering.FindClosestClusterCenter(DocumnetClustering.mainCentroids, obj, ddl_sim.Text);
                            DocumnetClustering.mainCentroids[index].GroupedDocument.Add(obj);
                        }
                        break;
                    case "CMeans":
                        List<DocumentVector> vSpace2 = VectorSpaceModel.ProcessDocumentCollection(docCollection);

                        string outFilepath = @"E:\Dropbox\Masters\myMSc\PracticalPart\Sematic_K-MEANSClustering\FCM\HM_data_Out_centers.dat";
                        var reader = new StreamReader(File.OpenRead(outFilepath));
                        List<float[]> values = new List<float[]>();
                        int t = 0;
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            values.Add(Array.ConvertAll(line.Split(','), float.Parse));
                            t++;
                        }

                        for (int i = 0; i < newDoc; i++)
                        {
                            int closeCenter = 0;
                            float min = 1000;
                            int counter = 1;
                            DocumentVector obj2 = vSpace2[vSpace2.Count - newDoc + i];
                            for (int l = 0; l < t; l++)
                            {
                                //                                float s = SimilarityMatrics.FindCosineSimilarity(values[l], obj2.VectorSpace);
                                float s = ArrayDistanceFunction(values[l], obj2.VectorSpace);
                                if (s < min)
                                {
                                    min = s;
                                    closeCenter = counter;
                                }
                                counter++;
                            }

                            MessageBox.Show("Doc:" + (i + 1) + " Close is:" + closeCenter);
                            DocumnetClustering.mainCentroids[closeCenter - 1].GroupedDocument.Add(obj2);
                        }


                        break;
                }
                printAlll();
            }

        }

        private static float ArrayDistanceFunction(float[] array1, float[] array2)
        {
            float total = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                total += Math.Abs(array1[i] - array2[i]);
            }
            return total;
        }
        private void printAlll()
        {
            List<Centroid> resultSet = DocumnetClustering.mainCentroids;
            string msg = string.Empty;
            int countDoc = 1;
            int count = 1;
            double ECS = 0;
            foreach (Centroid c in resultSet)
            {
                msg += String.Format("------------------------------[ CLUSTER {0} ]-----------------------------{1}", count, System.Environment.NewLine);
                int totalNoOfItemsInCluster = c.GroupedDocument.Count;
                List<string> actualClustersOfCLUSTER = new List<string>();
                double Ej = 0;
                foreach (DocumentVector document in c.GroupedDocument)
                {
                    actualClustersOfCLUSTER.AddRange(mainCLusterNodeList.First(item => item.content == document.Content).cLusters);
                }

                var nameGroup = actualClustersOfCLUSTER.GroupBy(x => x);
                var maxCount = nameGroup.Max(g => g.Count());
                var mostCommons = nameGroup.Where(x => x.Count() == maxCount).Select(x => x.Key).ToArray();
                msg += String.Format("------------------------------[ CLUSTER {0} ]-----------------------------{1}", mostCommons[0], System.Environment.NewLine);

                foreach (DocumentVector document in c.GroupedDocument)
                {

                    List<string> cLusters = mainCLusterNodeList.First(item => item.content == document.Content).cLusters;

                    float pij = 0;
                    if (cLusters.Contains(mostCommons[0]))
                    {
                        pij = maxCount / (float)totalNoOfItemsInCluster;
                    }
                    else
                    {
                        pij = (totalNoOfItemsInCluster - maxCount) / (float)totalNoOfItemsInCluster;
                    }
                    Ej += pij * Math.Log(pij);

                    msg += String.Format("{0}------------------------------Doc " + countDoc + ": ------------------------------------------------" + mostCommons[0] + "{0}", System.Environment.NewLine);
                    countDoc++;
                    msg += document.Content + System.Environment.NewLine;
                }

                Ej = -Ej;
                ECS += totalNoOfItemsInCluster * Ej / docCollection.DocumentList.Count;

                msg += "-------------------------------------------------------------------------------" + System.Environment.NewLine;
                count++;
            }
            richTextBox1.Text = msg + System.Environment.NewLine + "Entropy = " + ECS;
            txtEntropy.Text = "Entropy: " + ECS;
        }

        private void btnStartClustering_Click(object sender, EventArgs e)
        {

            int totalIteration = 0;
            DocumnetClustering.mainCentroids = DocumnetClustering.PrepareDocumentCluster(
                int.Parse(txtClusterNo.Text), vSpace, ref  totalIteration, ddl_sim.Text, mainCLusterNodeList, cboxDataSet.Text);
            printAlll();
            lblTotalIteration.Text = totalIteration.ToString();
            //MessageBox.Show("Done");
        }

        private void btnStopProcess_Click(object sender, EventArgs e)
        {
            docCollection = new DocumentCollection();
            this.ClearField();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //this.ClearField();
            //docCollection = new DocumentCollection();
        }


        private void ClearField()
        {
            txtClusterNo.Clear();
            txtDoc1.Clear();
            txtDoc2.Clear();
            txtDoc3.Clear();
            txtDoc4.Clear();
            lblTotalDoc.Text = "";
            lblError.Text = "";
            lblTotalIteration.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearField();
        }

        private void txtClusterNo_TextChanged(object sender, EventArgs e)
        {
            int totalDoc = 0;
            if (int.TryParse(txtClusterNo.Text, out totalDoc))
            {
                lblError.Text = "";
                lblTotalIteration.Text = txtClusterNo.Text;
            }
            else
            {
                lblError.Text = "Enter a valid integer";
                lblTotalIteration.Text = " ";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //read results
            string filepath = @"E:\Dropbox\Masters\myMSc\PracticalPart\Sematic_K-MEANSClustering\FCM\HM_data_Out.dat";

            if (!File.Exists(filepath))
            {
                MessageBox.Show("Plz run prepare FCM first");
                return;
            }
            var reader = new StreamReader(File.OpenRead(filepath));
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            int count = 0;
            string msg = string.Empty;
            double ECS = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split(',');
                int countDoc = 0;
                int index = 1;

                List<string> actualClustersOfCLUSTER = new List<string>();
                double Ej = 0;
                foreach (string document in docCollection.DocumentList)
                {
                    if (values.Contains(index.ToString()))
                    {
                        actualClustersOfCLUSTER.AddRange(mainCLusterNodeList.First(item => item.content == document).cLusters);
                    }
                    index++;
                }

                var nameGroup = actualClustersOfCLUSTER.GroupBy(x => x);
                var maxCount = nameGroup.Max(g => g.Count());
                var mostCommons = nameGroup.Where(x => x.Count() == maxCount).Select(x => x.Key).ToArray();
                int totalNoOfItemsInCluster = values.Length;
                int index2 = 1;

                msg += String.Format("------------------------------[ CLUSTER {0} ]-----------------------------" + mostCommons[0] + "{1}", count + 1, System.Environment.NewLine);
                foreach (string document in docCollection.DocumentList)
                {
                    if (values.Contains(index2.ToString()))
                    {
                        msg += String.Format("{0}------------------------------Doc " + (countDoc + 1) + ": ------------------------------------------------{0}", System.Environment.NewLine);
                        countDoc++;
                        msg += document + System.Environment.NewLine;
                        List<string> cLusters = mainCLusterNodeList.First(item => item.content == document).cLusters;
                        float pij = 0;
                        if (cLusters.Contains(mostCommons[0]))
                        {
                            pij = maxCount / (float)totalNoOfItemsInCluster;
                        }
                        else
                        {
                            pij = (totalNoOfItemsInCluster - maxCount) / (float)totalNoOfItemsInCluster;
                        }
                        Ej += pij * Math.Log(pij);
                    }
                    index2++;
                }
                Ej = -Ej;
                ECS += totalNoOfItemsInCluster * Ej / docCollection.DocumentList.Count;
                msg += "-------------------------------------------------------------------------------" + System.Environment.NewLine;
                count++;
            }
            txtEntropy.Text = "Entropy: " + ECS;
            richTextBox1.Text = msg;
            MessageBox.Show("Done");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string filepath = @"E:\Dropbox\Masters\myMSc\PracticalPart\Sematic_K-MEANSClustering\FCM\HM_data_Out.dat";
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }

            string inputFilepath = @"E:\Dropbox\Masters\myMSc\PracticalPart\Sematic_K-MEANSClustering\FCM\HM_data.dat";
            if (File.Exists(inputFilepath))
            {
                File.Delete(inputFilepath);
            }

            string inputFilepathNoOfClusters = @"E:\Dropbox\Masters\myMSc\PracticalPart\Sematic_K-MEANSClustering\FCM\HM_data_No.dat";
            if (File.Exists(inputFilepathNoOfClusters))
            {
                File.Delete(inputFilepathNoOfClusters);
            }

            string outFilepath = @"E:\Dropbox\Masters\myMSc\PracticalPart\Sematic_K-MEANSClustering\FCM\HM_data_Out_centers.dat";
            if (File.Exists(outFilepath))
            {
                File.Delete(outFilepath);
            }

            using (StreamWriter sw = new StreamWriter(inputFilepathNoOfClusters, true))
            {
                sw.WriteLine(txtClusterNo.Text);
            }

            using (StreamWriter sw = new StreamWriter(inputFilepath, true))
            {
                foreach (DocumentVector item in vSpace)
                {
                    foreach (float v in item.VectorSpace)
                    {
                        sw.Write(v + ",");
                    }
                    sw.WriteLine("");
                }
            }

            //call matlab 
            var process = Process.Start("E:\\Matlab\\bin\\matlab.exe",
                "-nodisplay -nosplash -nodesktop -r run('E:\\Dropbox\\Masters\\myMSc\\PracticalPart\\Sematic_K-MEANSClustering\\FCM\\fcmdemo_codepad.m')");
            process.WaitForExit();
            MessageBox.Show("Plz wait Matlab code");

        }

        private void TextClusteringGUI_Load(object sender, EventArgs e)
        {


        }


        private void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        Console.WriteLine(f);
                        string text = System.IO.File.ReadAllText(f);
                        docCollection.DocumentList.Add(text);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path_data_vSpace = "E:\\Dropbox\\Masters\\myMSc\\PracticalPart\\Sematic_K-MEANSClustering\\MScDataSets\\Reuters21578\\data\\00_" + maxNoDoc + "_vSpace.xml";           
            if (cboxDataSet.Text == "Reu_01")
            {
                path_data_vSpace = "E:\\Dropbox\\Masters\\myMSc\\PracticalPart\\Sematic_K-MEANSClustering\\MScDataSets\\Reuters21578\\data\\01_" + maxNoDoc + "_vSpace.xml";
            }
            else if (cboxDataSet.Text == "Re0")
            {
            }
            else
            {
                //this is test ds so already assigned 
            }

            if (File.Exists(path_data_vSpace))
            {
                vSpace = DeSerializeObject<List<DocumentVector>>(path_data_vSpace);
                
            }
            else
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                vSpace = VectorSpaceModel.ProcessDocumentCollection(docCollection);
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                lblTime.Text = "Time: " + elapsedMs;
                SerializeObject(vSpace, path_data_vSpace);
            }
            MessageBox.Show("Done");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //load train
            string allClasses = @"E:\Dropbox\Masters\myMSc\PracticalPart\Sematic_K-MEANSClustering\MScDataSets\TEST\MainData\TRAIN";
            DirSearch(allClasses);
            int totalDoc = 0;
            if (int.TryParse(docCollection.DocumentList.Count.ToString(), out totalDoc))
            {
                lblTotalDoc.Text = totalDoc.ToString();
            }
            MessageBox.Show("Done");

        }


        private void button3_Click(object sender, EventArgs e)
        {

            string path = "E:\\Dropbox\\Masters\\myMSc\\PracticalPart\\Sematic_K-MEANSClustering\\MScDataSets\\Reuters21578\\00\\000.xml";
            string path_data_docCollection = "E:\\Dropbox\\Masters\\myMSc\\PracticalPart\\Sematic_K-MEANSClustering\\MScDataSets\\Reuters21578\\data\\00_" + maxNoDoc + "_docCollection.xml";
            string path_data_mainCLusterNodeList = "E:\\Dropbox\\Masters\\myMSc\\PracticalPart\\Sematic_K-MEANSClustering\\MScDataSets\\Reuters21578\\data\\00_" + maxNoDoc + "_mainCLusterNodeList.xml";


            if (cboxDataSet.Text == "Reu_01")
            {
                path = "E:\\Dropbox\\Masters\\myMSc\\PracticalPart\\Sematic_K-MEANSClustering\\MScDataSets\\Reuters21578\\Reu_01\\reut2-000_small.xml";
                path_data_docCollection = "E:\\Dropbox\\Masters\\myMSc\\PracticalPart\\Sematic_K-MEANSClustering\\MScDataSets\\Reuters21578\\data\\01_" + maxNoDoc + "_docCollection.xml";
                path_data_mainCLusterNodeList = "E:\\Dropbox\\Masters\\myMSc\\PracticalPart\\Sematic_K-MEANSClustering\\MScDataSets\\Reuters21578\\data\\01_" + maxNoDoc + "_mainCLusterNodeList.xml";
            }
            else if (cboxDataSet.Text == "Re0")
            {
            }
            else
            {
                //this is test ds so already assigned 
            }

            if (File.Exists(path_data_docCollection) && File.Exists(path_data_mainCLusterNodeList))
            {

                docCollection.DocumentList = DeSerializeObject<List<string>>(path_data_docCollection);
                mainCLusterNodeList = DeSerializeObject<List<ClusterNode>>(path_data_docCollection);
            }
            else
            {
                XmlDocument doc2 = new XmlDocument();
                doc2.Load(path);

                XmlNodeList nodelist = doc2.DocumentElement.SelectNodes("/main/REUTERS");
                int n = 1;
                int sentCount = 5;
                foreach (XmlNode node in nodelist)
                {
                    ClusterNode item = new ClusterNode();
                    item.cLusters = new List<string>();
                    XmlNode body = node.SelectSingleNode("TEXT/BODY");
                    if (body == null)
                    {
                        continue;
                    }
                    string text = body.InnerText;
                    if (body.InnerText.Length > 400)
                    {
                        SummarizerArguments sumargs = new SummarizerArguments
                        {
                            DictionaryLanguage = "en",
                            DisplayLines = sentCount,
                            DisplayPercent = 0,
                            InputFile = "",
                            InputString = body.InnerText
                        };
                        SummarizedDocument doc = Summarizer.Summarize(sumargs);
                        string summary = string.Join("\r\n\r\n", doc.Sentences.ToArray());
                        text = summary;
                        int len = summary.Length;
                    }
                    XmlNodeList nodelistPLACES = node.SelectNodes("PLACES/D");
                    foreach (XmlNode place in nodelistPLACES)
                    {
                        item.cLusters.Add(place.InnerText);
                    }
                    //XmlNodeList nodelistTOPICS = node.SelectNodes("TOPICS/D");
                    //foreach (XmlNode topic in nodelistTOPICS)
                    //{
                    //    item.cLusters.Add(topic.InnerText);
                    //}

                    docCollection.DocumentList.Add(text);
                    item.id = n;
                    item.content = text;
                    //item.cLuster = cLuster.InnerXml;
                    mainCLusterNodeList.Add(item);
                    n++;
                    if (n > maxNoDoc)
                    {
                        break;
                    }
                }
                SerializeObject(docCollection.DocumentList, path_data_docCollection);
                SerializeObject(mainCLusterNodeList, path_data_mainCLusterNodeList);
            }
            int totalDoc = 0;
            if (int.TryParse(docCollection.DocumentList.Count.ToString(), out totalDoc))
            {
                lblTotalDoc.Text = totalDoc.ToString();
            }
            MessageBox.Show("Done");
        }


        /// <summary>
        /// Serializes an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObject"></param>
        /// <param name="fileName"></param>
        public void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }
        }


        /// <summary>
        /// Deserializes an xml file into an object list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                        reader.Close();
                    }

                    read.Close();
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }

            return objectOut;
        }

    }
}

