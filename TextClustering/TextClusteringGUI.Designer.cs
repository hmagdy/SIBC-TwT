namespace TextClustering
{
    partial class TextClusteringGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextClusteringGUI));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxDataSet = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtEntropy = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlIncAlg = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddl_sim = new System.Windows.Forms.ComboBox();
            this.lblTotalIteration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalDoc = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnStartClustering = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClusterNo = new System.Windows.Forms.TextBox();
            this.txtDoc4 = new System.Windows.Forms.TextBox();
            this.txtDoc3 = new System.Windows.Forms.TextBox();
            this.txtDoc2 = new System.Windows.Forms.TextBox();
            this.txtDoc1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblFScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblFScore);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cboxDataSet);
            this.splitContainer1.Panel1.Controls.Add(this.lblTime);
            this.splitContainer1.Panel1.Controls.Add(this.txtEntropy);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.ddlIncAlg);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.ddlType);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.ddl_sim);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalIteration);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalDoc);
            this.splitContainer1.Panel1.Controls.Add(this.btnRestart);
            this.splitContainer1.Panel1.Controls.Add(this.lblError);
            this.splitContainer1.Panel1.Controls.Add(this.btnStartClustering);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtClusterNo);
            this.splitContainer1.Panel1.Controls.Add(this.txtDoc4);
            this.splitContainer1.Panel1.Controls.Add(this.txtDoc3);
            this.splitContainer1.Panel1.Controls.Add(this.txtDoc2);
            this.splitContainer1.Panel1.Controls.Add(this.txtDoc1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(867, 432);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "Data Set:";
            // 
            // cboxDataSet
            // 
            this.cboxDataSet.FormattingEnabled = true;
            this.cboxDataSet.Items.AddRange(new object[] {
            "Reu_01",
            "Re0",
            "Re1",
            "Mini_Newsgroup",
            "Test"});
            this.cboxDataSet.Location = new System.Drawing.Point(93, 70);
            this.cboxDataSet.Name = "cboxDataSet";
            this.cboxDataSet.Size = new System.Drawing.Size(65, 21);
            this.cboxDataSet.TabIndex = 33;
            this.cboxDataSet.Text = "Reu_01";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(172, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 14);
            this.lblTime.TabIndex = 32;
            this.lblTime.Text = "Time: ";
            // 
            // txtEntropy
            // 
            this.txtEntropy.AutoSize = true;
            this.txtEntropy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntropy.Location = new System.Drawing.Point(188, 381);
            this.txtEntropy.Name = "txtEntropy";
            this.txtEntropy.Size = new System.Drawing.Size(58, 14);
            this.txtEntropy.TabIndex = 31;
            this.txtEntropy.Text = "Entropy: ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Prep KM";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Load Dataset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 28;
            this.label5.Text = "Inc Alg:";
            // 
            // ddlIncAlg
            // 
            this.ddlIncAlg.FormattingEnabled = true;
            this.ddlIncAlg.Items.AddRange(new object[] {
            "KMeans",
            "CMeans"});
            this.ddlIncAlg.Location = new System.Drawing.Point(226, 15);
            this.ddlIncAlg.Name = "ddlIncAlg";
            this.ddlIncAlg.Size = new System.Drawing.Size(96, 21);
            this.ddlIncAlg.TabIndex = 27;
            this.ddlIncAlg.Text = "KMeans";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Prep FCM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Do FCM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 14);
            this.label8.TabIndex = 24;
            this.label8.Text = "Type:";
            // 
            // ddlType
            // 
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Items.AddRange(new object[] {
            "Normal",
            "Incremental"});
            this.ddlType.Location = new System.Drawing.Point(94, 17);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(65, 21);
            this.ddlType.TabIndex = 23;
            this.ddlType.Text = "Normal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(164, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "Similarity:";
            // 
            // ddl_sim
            // 
            this.ddl_sim.FormattingEnabled = true;
            this.ddl_sim.Items.AddRange(new object[] {
            "Cosine",
            "Semantic"});
            this.ddl_sim.Location = new System.Drawing.Point(226, 44);
            this.ddl_sim.Name = "ddl_sim";
            this.ddl_sim.Size = new System.Drawing.Size(96, 21);
            this.ddl_sim.TabIndex = 21;
            this.ddl_sim.Text = "Cosine";
            // 
            // lblTotalIteration
            // 
            this.lblTotalIteration.AutoSize = true;
            this.lblTotalIteration.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIteration.Location = new System.Drawing.Point(144, 381);
            this.lblTotalIteration.Name = "lblTotalIteration";
            this.lblTotalIteration.Size = new System.Drawing.Size(0, 14);
            this.lblTotalIteration.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "User Defined Cluster:";
            // 
            // lblTotalDoc
            // 
            this.lblTotalDoc.AutoSize = true;
            this.lblTotalDoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDoc.Location = new System.Drawing.Point(140, 356);
            this.lblTotalDoc.Name = "lblTotalDoc";
            this.lblTotalDoc.Size = new System.Drawing.Size(0, 14);
            this.lblTotalDoc.TabIndex = 16;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(260, 404);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(159, 47);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 14);
            this.lblError.TabIndex = 11;
            // 
            // btnStartClustering
            // 
            this.btnStartClustering.Location = new System.Drawing.Point(97, 330);
            this.btnStartClustering.Name = "btnStartClustering";
            this.btnStartClustering.Size = new System.Drawing.Size(75, 23);
            this.btnStartClustering.TabIndex = 9;
            this.btnStartClustering.Text = "Do KMeans";
            this.btnStartClustering.UseVisualStyleBackColor = true;
            this.btnStartClustering.Click += new System.EventHandler(this.btnStartClustering_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total No of Document:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(182, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "No of cluster";
            // 
            // txtClusterNo
            // 
            this.txtClusterNo.Location = new System.Drawing.Point(94, 44);
            this.txtClusterNo.Name = "txtClusterNo";
            this.txtClusterNo.Size = new System.Drawing.Size(64, 20);
            this.txtClusterNo.TabIndex = 0;
            this.txtClusterNo.Text = "2";
            this.txtClusterNo.TextChanged += new System.EventHandler(this.txtClusterNo_TextChanged);
            // 
            // txtDoc4
            // 
            this.txtDoc4.Location = new System.Drawing.Point(13, 275);
            this.txtDoc4.Multiline = true;
            this.txtDoc4.Name = "txtDoc4";
            this.txtDoc4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDoc4.Size = new System.Drawing.Size(309, 48);
            this.txtDoc4.TabIndex = 4;
            this.txtDoc4.Text = resources.GetString("txtDoc4.Text");
            // 
            // txtDoc3
            // 
            this.txtDoc3.Location = new System.Drawing.Point(13, 221);
            this.txtDoc3.Multiline = true;
            this.txtDoc3.Name = "txtDoc3";
            this.txtDoc3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDoc3.Size = new System.Drawing.Size(309, 48);
            this.txtDoc3.TabIndex = 3;
            this.txtDoc3.Text = resources.GetString("txtDoc3.Text");
            // 
            // txtDoc2
            // 
            this.txtDoc2.Location = new System.Drawing.Point(13, 167);
            this.txtDoc2.Multiline = true;
            this.txtDoc2.Name = "txtDoc2";
            this.txtDoc2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDoc2.Size = new System.Drawing.Size(309, 48);
            this.txtDoc2.TabIndex = 2;
            this.txtDoc2.Text = resources.GetString("txtDoc2.Text");
            // 
            // txtDoc1
            // 
            this.txtDoc1.Location = new System.Drawing.Point(13, 113);
            this.txtDoc1.Multiline = true;
            this.txtDoc1.Name = "txtDoc1";
            this.txtDoc1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDoc1.Size = new System.Drawing.Size(309, 48);
            this.txtDoc1.TabIndex = 1;
            this.txtDoc1.Text = resources.GetString("txtDoc1.Text");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(515, 424);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lblFScore
            // 
            this.lblFScore.AutoSize = true;
            this.lblFScore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFScore.Location = new System.Drawing.Point(188, 355);
            this.lblFScore.Name = "lblFScore";
            this.lblFScore.Size = new System.Drawing.Size(52, 14);
            this.lblFScore.TabIndex = 35;
            this.lblFScore.Text = "F-Score:";
            // 
            // TextClusteringGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 456);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TextClusteringGUI";
            this.Text = "Sematic Document Clustering";
            this.Load += new System.EventHandler(this.TextClusteringGUI_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtDoc4;
        private System.Windows.Forms.TextBox txtDoc3;
        private System.Windows.Forms.TextBox txtDoc2;
        private System.Windows.Forms.TextBox txtDoc1;
        private System.Windows.Forms.Button btnStartClustering;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClusterNo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblTotalDoc;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddl_sim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlIncAlg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTotalIteration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtEntropy;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxDataSet;
        private System.Windows.Forms.Label lblFScore;
    }
}

