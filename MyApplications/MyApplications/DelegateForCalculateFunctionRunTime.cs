using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyApplications
{
    class DelegateForCalculateFunctionRunTime
    {
        int functionRunTimeLogLineFlag=0;
        string functionRunTimeLog = System.Windows.Forms.Application.StartupPath + "\\functionRunTimeLog.txt";
        private string paramInfo;
        private bool paramInfoBool;
        public delegate void RuntimeHandler(string paramFunction,bool paramBool);
        public event RuntimeHandler RunTimeEvent;
        [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
        static extern bool QueryPerformanceCounter(ref long count);
        [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
        static extern bool QueryPerformanceFrequency(ref long count);
        public void FunctionRunTime(string paramFunction, bool paramBool)
        {
            paramInfo = paramFunction;
            paramInfoBool = paramBool;
            long count = 0;
            long count1 = 0;
            long freq = 0;
            double resunt = 0;
            QueryPerformanceFrequency(ref freq);
            QueryPerformanceCounter(ref count);

            if (RunTimeEvent != null)//如果有对象注册
            {
                RunTimeEvent(paramInfo, paramInfoBool);
            }

            QueryPerformanceCounter(ref count1);
            count = count1 - count;
            resunt = (double)(count) / (double)freq;          
            
            if (functionRunTimeLogLineFlag == 0)
            {
                StreamWriter streamWriter = new StreamWriter(functionRunTimeLog, false, System.Text.Encoding.Default);
                streamWriter.WriteLine(resunt);
                functionRunTimeLogLineFlag++;
                streamWriter.Close();
            }
            else
            {
                StreamWriter streamWriterContinue = new StreamWriter(functionRunTimeLog, true, System.Text.Encoding.Default);
                streamWriterContinue.WriteLine(resunt);
                streamWriterContinue.Close();
            }
        }
    }
}
