using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.XFeatures2D;

namespace ImageSimilarity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            // Load the images
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the first image";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            Mat img1 = new(ofd.FileName, ImreadModes.Color);

            ofd.Title = "Select the second image";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            Mat img2 = new(ofd.FileName, ImreadModes.Color);

            // Compute similarity score
            double similarityScore = CompareImages(img1, img2);
            labelSimScore.Text= $"Similarity Score: {similarityScore*100:F0}%";

            
        }


        private double CompareImages(Mat img1, Mat img2)
        {
            using Mat resizedImg1 = new Mat();
            using Mat resizedImg2 = new Mat();
            using Mat grayImg1 = new Mat();
            using Mat grayImg2 = new Mat();
            using Mat result = new Mat();

            // Resize the first image to 500x500 pixels to ensure both images have the same size
            Cv2.Resize(img1, resizedImg1, new OpenCvSharp.Size(500, 500));
            // Resize the second image to 500x500 pixels to ensure both images have the same size
            Cv2.Resize(img2, resizedImg2, new OpenCvSharp.Size(500, 500));

            // Convert the resized first image to grayscale
            Cv2.CvtColor(resizedImg1, grayImg1, ColorConversionCodes.BGR2GRAY);
            // Convert the resized second image to grayscale
            Cv2.CvtColor(resizedImg2, grayImg2, ColorConversionCodes.BGR2GRAY);

            // Perform template matching using the normalized cross-correlation method
            Cv2.MatchTemplate(grayImg1, grayImg2, result, TemplateMatchModes.CCoeffNormed);
            // Find the minimum and maximum values in the result matrix to determine the best match
            Cv2.MinMaxLoc(result, out double minVal, out double maxVal);

            // Return the maximum value which represents the similarity score
            return maxVal;
        }
    }
}
