using System.Drawing;
using System.IO;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace OpenCV
{
    public static class ImageProcessing
    {
        /// <summary>
        /// Фильтрация изображения
        /// </summary>
        /// <param name="img">Исходное изображение</param>
        /// <param name="ksize">Размер диафрагмы</param>
        public static void FilterImage(Image<Bgr, byte> img, int ksize) => CvInvoke.MedianBlur(img, img, ksize);

        /// <summary>
        /// Метод бинаризации изображения методом Otsu
        /// </summary>
        /// <param name="img">Исходное изображение</param>
        /// <returns>Бинаризованное изображение</returns>
        public static Image<Gray, byte> BinarizationImages(Image<Gray, byte> img)
        {
            var output = new Image<Gray, byte>(img.Width, img.Height);
            CvInvoke.Threshold(img, output, 50, 255, ThresholdType.Otsu);

            return output;
        }

        /// <summary>
        /// Универсальный метод получения изображения на основе реализованного в EmguCv Image<TColor, IDepth>
        /// работает только с объектами EmguCv
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <param name="img">Исходное изображение</param>
        /// <returns></returns>
        public static Image GetImage<T, R>(Image<T, R> img) where T : struct, IColor where R : new()
        {
            return Image.FromStream(new MemoryStream(img.ToJpegData()));
        }
    }
}
