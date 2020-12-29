using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Interop;
using Autodesk.AutoCAD.Interop.Common;
using AutodeskApplication = Autodesk.AutoCAD.ApplicationServices.Application;
using System.Threading;
using System.IO;

namespace MyApplications
{
    public partial class FormConverDWGToPDF : Form
    {
        /// <summary>
        /// CAD实例
        /// </summary>
        private static AcadApplication acadApplication = new AcadApplication();
        private string pdfStorePath = @"D:\pdfStorePath\";
        public FormConverDWGToPDF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PlotToPDF("","");
        }
        public void PlotToPDF(string filenName,string mediaName)
        {            
            if (acadApplication == null)
            {
                acadApplication = new AcadApplication();
                //实例启动时间等待12秒
                Thread.Sleep(12000);
                //(AcadApplication)System.Runtime.InteropServices.Marshal.GetActiveObject("AutoCAD.Application.");
            }        
            
            AcadDocument activeDoc = acadApplication.Documents.Open(string.IsNullOrEmpty(filenName)?@"F:\MyCode\PDFWaterMark\WaterPapper\临水总平面布置示意图.DWG":filenName, false);
            AcadLayout layout = null;
            int circulationTime = 0;
            do
            {
                try
                {
                    circulationTime++;
                    layout = activeDoc.ActiveLayout;
                }
                catch (System.Exception ex)
                {
                    WriteLog("ActiveLayout获取出错，获取次数 " + circulationTime.ToString(), false);
                    Thread.Sleep(2000);
                }
                
            } while (layout == null && circulationTime <= 5);
            if(layout==null)
            {
                WriteLog("ActiveLayout获取出错，获取次数 " + circulationTime.ToString()+"获取失败，程序退出！", false);
                MessageBox.Show("加载文档时出错！");
                return;
            }
            String MediaName = string.IsNullOrEmpty(mediaName)? "ISO_full_bleed_A4_(210.00_x_297.00_MM)" : mediaName;            
            try
            {
                AcadPlotConfiguration oplot = activeDoc.PlotConfigurations.Add("PDF", layout.ModelType);
                oplot.PaperUnits = AcPlotPaperUnits.acMillimeters;
                oplot.StyleSheet = "monochrome.ctb";
                oplot.PlotWithPlotStyles = true;
                oplot.ConfigName = "DWG To PDF.pc3";
                oplot.UseStandardScale = true;
                oplot.StandardScale = AcPlotScale.acScaleToFit;
                oplot.PlotType = AcPlotType.acExtents;
                oplot.CenterPlot = true;// 居中
                Object oMediaNames = layout.GetCanonicalMediaNames();
                ArrayList mediaNames = new ArrayList((string[])oMediaNames);
                foreach (String sName in mediaNames)
                {
                    if (sName.Contains(MediaName))
                    {
                        oplot.CanonicalMediaName = sName;
                        layout.CopyFrom(oplot);
                        layout.PlotRotation = AcPlotRotation.ac0degrees;
                        layout.RefreshPlotDeviceInfo();
                        activeDoc.SetVariable("sdi", 0);
                        activeDoc.SetVariable("Filedia", 0);                        
                        activeDoc.SetVariable("BACKGROUNDPLOT", 0);//前台打印
                        activeDoc.Plot.QuietErrorMode = true;//生成存档，避免报错
                        activeDoc.Plot.PlotToFile(pdfStorePath+activeDoc.Name+".pdf");
                        oplot.Delete();
                        oplot = null;
                        return;
                    }
                }
            }
            catch (System.Exception es)
            {
                WriteLog("tryPlotToFile出错"+es.StackTrace,false);
            }
            finally
            {
                activeDoc.Close(false);
                
            }
        }
        public void WriteLog(string logContent, bool isOverwrite)
        {
            try
            {
                logContent = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + logContent;
                string logDirectory = @"D:\ProgramLog";
                string logFileName = logDirectory + @"\PlotToPDF.log";
                if (!Directory.Exists(logDirectory)) Directory.CreateDirectory(logDirectory);
                FileStream logFileStream = new FileStream(logFileName, isOverwrite ? FileMode.Create : FileMode.Append);
                StreamWriter streamWriter = new StreamWriter(logFileStream);
                streamWriter.WriteLine(logContent);
                streamWriter.Close();
            }
            catch (System.Exception ex)
            { }

        }
    }
}
