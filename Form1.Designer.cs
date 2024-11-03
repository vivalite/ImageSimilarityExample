namespace ImageSimilarity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLoadImage = new Button();
            labelSimScore = new Label();
            SuspendLayout();
            // 
            // buttonLoadImage
            // 
            buttonLoadImage.Location = new Point(275, 108);
            buttonLoadImage.Name = "buttonLoadImage";
            buttonLoadImage.Size = new Size(164, 69);
            buttonLoadImage.TabIndex = 0;
            buttonLoadImage.Text = "Load Images";
            buttonLoadImage.UseVisualStyleBackColor = true;
            buttonLoadImage.Click += buttonLoadImage_Click;
            // 
            // labelSimScore
            // 
            labelSimScore.AutoSize = true;
            labelSimScore.Location = new Point(277, 224);
            labelSimScore.Name = "labelSimScore";
            labelSimScore.Size = new Size(62, 15);
            labelSimScore.TabIndex = 1;
            labelSimScore.Text = "Similarity: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 404);
            Controls.Add(labelSimScore);
            Controls.Add(buttonLoadImage);
            Name = "Form1";
            Text = "Image Similarity Scroe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLoadImage;
        private Label labelSimScore;
    }
}
