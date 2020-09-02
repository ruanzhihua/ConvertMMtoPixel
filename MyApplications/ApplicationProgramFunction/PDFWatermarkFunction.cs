using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Web.UI.HtmlControls;
using System.Drawing;

//itextsharp.dll version:5.1.10

namespace ApplicationProgramFunction
{
    class PDFWatermarkFunction
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            string source = @"D:\My.Sample\C#NET\Exoport2PDF\Web2\Chap1011.pdf"; //模板路径
            string output = @"D:\My.Sample\C#NET\Exoport2PDF\Web2\Chap1012.pdf"; //导出水印背景后的PDF
            string watermark = @"D:\My.Sample\C#NET\Exoport2PDF\Web2\gp0.jpg"; // 水印图片

            bool isSurrcess = PDFWatermark(source, output, watermark, 10, 10);

        }
        /// <summary>
        /// 为pdf文件添加水印，使用PDF坐标系，文档的左下角为坐标原点。传入参数为左上角为原点
        /// </summary>
        /// <param name="inputfilepath">输入文件完全名称</param>
        /// <param name="outputfilepath">输出文件完全名称</param>
        /// <param name="ModelPicName">水印图片完全路径</param>
        /// <param name="top">Y轴坐标，</param>
        /// <param name="left">X轴坐标</param>
        /// <param name="rotation">旋转</param>
        /// <returns></returns>
        public bool PDFWatermark(string inputfilepath, string outputfilepath, string ModelPicName, float top, float left,float rotation)

        {
            //throw new NotImplementedException();
            
            iTextSharp.text.pdf.PdfReader pdfReader = null;
            iTextSharp.text.pdf.PdfStamper pdfStamper = null;
            try
            {
                pdfReader = new PdfReader(inputfilepath);

                int numberOfPages = pdfReader.NumberOfPages;

                iTextSharp.text.Rectangle psize = pdfReader.GetPageSize(1);

                float width = psize.Width;

                float height = psize.Height;

                pdfStamper = new PdfStamper(pdfReader, new FileStream(outputfilepath, FileMode.Create));
                
                PdfContentByte waterMarkContent;

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(ModelPicName);

                image.GrayFill = 20;//透明度，灰色填充
                image.Rotation = rotation;//旋转
                //image.RotationDegrees=//旋转角度
                                    //水印的位置 
                if (left < 0)
                {
                    left = width - image.Width + left;
                }
                //第一个参数是X轴坐标，第二个参数是Y轴坐标，使用PDF坐标系，文档的左下角为坐标原点。传入参数为左上角为原点
                image.SetAbsolutePosition(left, (height - image.Height) - top);


                //每一页加水印,也可以设置某一页加水印 
                for (int i = 1; i <= numberOfPages; i++)
                {
                    waterMarkContent = pdfStamper.GetUnderContent(i);

                    waterMarkContent.AddImage(image);
                }
                //strMsg = "success";
                return true;
            }
            catch (Exception ex)
            {
                ex.Message.Trim();
                return false;
            }
            finally
            {

                if (pdfStamper != null)
                    pdfStamper.Close();

                if (pdfReader != null)
                    pdfReader.Close();
            }

        }

        public bool PDFWatermark(string inputfilepath, string outputfilepath, string ModelPicName, float top, float left)

        {
            //throw new NotImplementedException();
            PdfReader pdfReader = null;
            PdfStamper pdfStamper = null;
            try
            {
                pdfReader = new PdfReader(inputfilepath);

                int numberOfPages = pdfReader.NumberOfPages;

                iTextSharp.text.Rectangle psize = pdfReader.GetPageSize(1);

                float width = psize.Width;

                float height = psize.Height;

                pdfStamper = new PdfStamper(pdfReader, new FileStream(outputfilepath, FileMode.Create));

                PdfContentByte waterMarkContent;

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(ModelPicName);

                image.GrayFill = 20;//透明度，灰色填充
                                    //image.Rotation//旋转
                                    //image.RotationDegrees//旋转角度
                                    //水印的位置 
                if (left < 0)
                {
                    left = width - image.Width + left;
                }

                image.SetAbsolutePosition(left, (height - image.Height) - top);


                //每一页加水印,也可以设置某一页加水印 
                for (int i = 1; i <= numberOfPages; i++)
                {
                    waterMarkContent = pdfStamper.GetUnderContent(i);

                    waterMarkContent.AddImage(image);
                }
                //strMsg = "success";
                return true;
            }
            catch (Exception ex)
            {
                ex.Message.Trim();
                return false;
            }
            finally
            {

                if (pdfStamper != null)
                    pdfStamper.Close();

                if (pdfReader != null)
                    pdfReader.Close();
            }

        }
    }
}
