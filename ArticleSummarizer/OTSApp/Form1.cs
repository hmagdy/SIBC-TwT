using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTextSummarizer;

namespace OTSApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SummarizeButton_Click(object sender, EventArgs e)
        {
            //this code will be executed in btn for main doing action
            int sentCount = 1;
            int.TryParse(SentenceCountTextBox.Text, out sentCount);
            SummarizerArguments sumargs = new SummarizerArguments
                                              {
                                                  DictionaryLanguage = "en",
                                                  DisplayLines = sentCount,
                                                  DisplayPercent = 0,
                                                  InputFile = "",
                                                  InputString = OriginalTextBox.Text
                                              };
            SummarizedDocument doc = Summarizer.Summarize(sumargs);
            string summary = string.Join("\r\n\r\n", doc.Sentences.ToArray());
            SummaryTextBox.Text = summary;

        }
    }
}
