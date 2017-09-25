namespace OTSApp
{
    partial class Form1
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
            this.SummarizeButton = new System.Windows.Forms.Button();
            this.OriginalTextBox = new System.Windows.Forms.TextBox();
            this.SummaryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SentenceCountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SummarizeButton
            // 
            this.SummarizeButton.Location = new System.Drawing.Point(24, 285);
            this.SummarizeButton.Name = "SummarizeButton";
            this.SummarizeButton.Size = new System.Drawing.Size(75, 23);
            this.SummarizeButton.TabIndex = 0;
            this.SummarizeButton.Text = "Summarize";
            this.SummarizeButton.UseVisualStyleBackColor = true;
            this.SummarizeButton.Click += new System.EventHandler(this.SummarizeButton_Click);
            // 
            // OriginalTextBox
            // 
            this.OriginalTextBox.Location = new System.Drawing.Point(24, 25);
            this.OriginalTextBox.Multiline = true;
            this.OriginalTextBox.Name = "OriginalTextBox";
            this.OriginalTextBox.Size = new System.Drawing.Size(749, 254);
            this.OriginalTextBox.TabIndex = 1;
            // 
            // SummaryTextBox
            // 
            this.SummaryTextBox.Location = new System.Drawing.Point(77, 313);
            this.SummaryTextBox.Multiline = true;
            this.SummaryTextBox.Name = "SummaryTextBox";
            this.SummaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SummaryTextBox.Size = new System.Drawing.Size(696, 75);
            this.SummaryTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sentences: ";
            // 
            // SentenceCountTextBox
            // 
            this.SentenceCountTextBox.Location = new System.Drawing.Point(716, 285);
            this.SentenceCountTextBox.Name = "SentenceCountTextBox";
            this.SentenceCountTextBox.Size = new System.Drawing.Size(23, 20);
            this.SentenceCountTextBox.TabIndex = 6;
            this.SentenceCountTextBox.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 400);
            this.Controls.Add(this.SentenceCountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SummaryTextBox);
            this.Controls.Add(this.OriginalTextBox);
            this.Controls.Add(this.SummarizeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SummarizeButton;
        private System.Windows.Forms.TextBox OriginalTextBox;
        private System.Windows.Forms.TextBox SummaryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SentenceCountTextBox;
    }
}

