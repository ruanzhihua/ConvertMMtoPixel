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

//itextsharp.dll version:4.1.6

namespace ApplicationProgramFunction
{
    public class PDFWatermarkFunction
    {
        /// <summary>
        /// pdf文字信息
        /// </summary>
        public List<textInfo> textInfos = new List<textInfo>();
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
        public bool PDFWatermark(string inputfilepath, string outputfilepath, string ModelPicName,float modelPicPercent, float top, float left, float rotation)

        {
            string renamefile = string.Empty;
            string outputfiletype = outputfilepath.Substring(outputfilepath.LastIndexOf('.'));
            //throw new NotImplementedException();
            if(inputfilepath==outputfilepath)
            {
                renamefile = outputfilepath;
                //缓存文件
                outputfilepath = outputfilepath.Replace(outputfiletype, "marked" + outputfiletype);
            }
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
                image.Rotation = rotation;//旋转
                //image.SetDpi(600, 600);//设置dpi
                //image.ScalePercent(40);//设置图片比例
                image.ScalePercent(modelPicPercent);//设置图片比例 24%
                //image.RotationDegrees=//旋转角度
                //水印的位置 
                if (left < 0)
                {
                    left = width - image.Width + left;
                }
                if (top < 0)
                {
                    top = height - image.Height + top;
                }
                //第一个参数是X轴坐标，第二个参数是Y轴坐标，使用PDF坐标系，文档的左下角为坐标原点。传入参数为左上角为原点
                image.SetAbsolutePosition(left, (float)((height - image.Height* modelPicPercent*0.01) - top));


                //每一页加水印,也可以设置某一页加水印 
                for (int i = 1; i <= numberOfPages; i++)
                {
                    waterMarkContent = pdfStamper.GetUnderContent(i);
                    
                    waterMarkContent.AddImage(image);
                }                
                
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
            try
            {
                //替换原有文件
                if (!string.IsNullOrEmpty(renamefile))
                {
                    File.Delete(renamefile);//删除源文件
                    FileInfo fileInfo = new FileInfo(outputfilepath);
                    fileInfo.MoveTo(renamefile);
                }
            }
            catch
            {
                return false;
            }
            return true;

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
        /// <summary>
        /// 获取文字在pdf文件内的位置
        /// </summary>
        /// <param name="inputfilepath"></param>
        /// <param name="text"></param>
        public void GetTextLocationAndSize(String inputfilepath, List<string> texts)
        {
            textInfos.Clear();
            Spire.Pdf.PdfDocument pdfDocument = new Spire.Pdf.PdfDocument();
            pdfDocument.LoadFromFile(inputfilepath);
            Spire.Pdf.General.Find.PdfTextFind[] textCollection = null;
            foreach (Spire.Pdf.PdfPageBase page in pdfDocument.Pages)
            {
                foreach (string text in texts)
                {
                    textCollection = page.FindText(text).Finds;
                    foreach (Spire.Pdf.General.Find.PdfTextFind pdfTextFind in textCollection)
                    {
                        textInfo textInfo = new textInfo();
                        textInfo.textContent = text;
                        textInfo.textLocation.X = pdfTextFind.Position.X;
                        textInfo.textLocation.Y = pdfTextFind.Position.Y;
                        textInfo.textSize.Width = pdfTextFind.Size.Width;
                        textInfo.textSize.Height = pdfTextFind.Size.Height;
                        textInfos.Add(textInfo);
                    }
                }
            }
        }
        /// <summary>
        /// pdf缩放
        /// </summary>
        /// <param name="inputfilepath">输入文件路径</param>
        /// <param name="outputfilepath">输出文件路径</param>
        /// <returns></returns>
        public bool PDFZoom(string inputfilepath, string outputfilepath,iTextSharp.text.Rectangle pageSize)
        {
            string renamefile = string.Empty;
            string outputfiletype = outputfilepath.Substring(outputfilepath.LastIndexOf('.'));
            
            if (inputfilepath == outputfilepath)
            {
                renamefile = outputfilepath;
                //缓存文件
                outputfilepath = outputfilepath.Replace(outputfiletype, "marked" + outputfiletype);
            }
            #region 缩放实现代码
            PdfReader pdfReader = null;
            PdfStamper pdfStamper = null;
            PdfWriter pdfWriter = null;
            try
            {
                pdfReader = new PdfReader(inputfilepath);
                int numberOfPages = pdfReader.NumberOfPages;
                iTextSharp.text.Rectangle psize = pdfReader.GetPageSize(1);
                float width = psize.Width;
                float height = psize.Height;
                Document doc = new Document(pageSize, 0, 0, 0, 0);
                ///pdfStamper = new PdfStamper(pdfReader, new FileStream(outputfilepath, FileMode.Create));
                pdfWriter = PdfWriter.GetInstance(doc, new FileStream(outputfilepath, FileMode.Create));
                doc.Open();
                PdfContentByte waterMarkContent;
                waterMarkContent = pdfWriter.DirectContent;                
                for (int i = 1; i <= numberOfPages; i++)
                {
                    PdfImportedPage pdfImportedPage = pdfWriter.GetImportedPage(pdfReader, i);
                    float scale = 0.67f;
                    waterMarkContent.AddTemplate(pdfImportedPage, scale, 0, 0, scale, 0, 0);
                }
                if (doc != null)
                    doc.Close();

            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {

                if (pdfStamper != null)
                    pdfStamper.Close();

                if (pdfReader != null)
                    pdfReader.Close();
               
            }
            #endregion
            try
            {
                //替换原有文件
                if (!string.IsNullOrEmpty(renamefile))
                {
                    File.Delete(renamefile);//删除源文件
                    FileInfo fileInfo = new FileInfo(outputfilepath);
                    fileInfo.MoveTo(renamefile);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
    /// <summary>
    /// pdf文字属性
    /// </summary>
    public struct textInfo
    {
        /// <summary>
        /// 文字内容
        /// </summary>
        public string textContent;
        /// <summary>
        /// 文字坐标位置
        /// </summary>
        public PointF textLocation;
        /// <summary>
        /// 文字尺寸
        /// </summary>
        public SizeF textSize;
    }
}
