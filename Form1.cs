using System;
using System.Drawing;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace OpenCV
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> _currentImage;
        Image<Bgr, byte> _originalImage;

        public Form1()
        {
            InitializeComponent();

            _currentImage = null;
            _originalImage = null;
        }

        private void OpenImage_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                pathImage.Text = openDialog.FileName;

                _originalImage = new Image<Bgr, byte>(openDialog.FileName);
                widthImage.Value = _originalImage.Width;
                heightImage.Value = _originalImage.Height;

                _currentImage = _originalImage;

                sourceImage.Image = ImageProcessing.GetImage(_currentImage);
                groupSettings.Enabled = true;
            }

        }

        private void ApplySetting_Click(object sender, EventArgs e)
        {
            if (sourceImage.Image != null)
            {
                sourceImage.Image = SetImage();
            }
        }

        int GetOddVal(int init)
        {
            return init % 2 == 1 ? init : init + 1;
        }

        Image SetImage()
        {
            Image resultImage = null;

            Image<Bgr, byte> tmpImage = null;

            tmpImage = _originalImage
                .Flip((FlipType)selectRotate.SelectedIndex)
                .Resize((int)widthImage.Value, (int)heightImage.Value, Inter.Nearest)
                .Rotate(trackRotate.Value, new Bgr())
                .SmoothBilateral((int)kernelSize.Value, (int)colorSigma.Value, (int)spaceSigma.Value)
                .SmoothGaussian(GetOddVal(trackGausian.Value))
                .SmoothMedian(GetOddVal(trackGausian.Value));


            if (isFilter.Checked)
            {
                ImageProcessing.FilterImage(_currentImage, (int)numKsize.Value);
            }

            if (trackBlurH.Value >1 || trackBlurV.Value > 1)
            {
                tmpImage = tmpImage.SmoothBlur(trackBlurV.Value, trackBlurH.Value);
            }

            resultImage = ImageProcessing.GetImage(_currentImage);

            Image<Gray, byte> tmpByte = null;


            if (orderX.Value > 0 || orderY.Value > 0)
            {
                tmpImage = tmpImage.Sobel((int)orderX.Value, (int)orderY.Value, GetOddVal(trackSizeSobel.Value)).Convert<Bgr, byte>();
            }

            resultImage = ImageProcessing.GetImage(tmpImage);

            if (gradationGrey.Checked)
            {
                tmpByte = tmpImage.Split()[1];
                resultImage = ImageProcessing.GetImage(tmpByte);

            }


            if (isBinary.Checked)
            {
                Image<Gray, byte> binary = null;

                if (gradationGrey.Checked)
                {
                    binary = ImageProcessing.BinarizationImages(tmpByte);
                }
                else
                {
                    var gray = tmpImage.Split()[1];
                    binary = ImageProcessing.BinarizationImages(gray);
                }

                resultImage = ImageProcessing.GetImage(binary);
            }

            return resultImage;
        }

        

    }
}
