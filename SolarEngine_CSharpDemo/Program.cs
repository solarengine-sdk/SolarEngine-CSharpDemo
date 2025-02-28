using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json.Converters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApplication2
{


    static class Program
    {



        [STAThread]
        static void Main()
        {

//#if CONSOLE_APP
//            MessageBox.Show($"CONSOLE_APP ");
//#elif WPF_APP
// MessageBox.Show($"WPF_APP ");
// // 如果是WPF应用，还需要订阅DispatcherUnhandledException等
//#endif
           // Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {

                MessageBox.Show($"UnhandledException22222 ");
                if (e.ExceptionObject is Exception exception)
                {
                    // 将异常信息和调用堆栈转换为字符串
                    string exceptionStr = exception.ToString();
                    // string stackTraceStr = exception.StackTrace ?? "";

                    MessageBox.Show($"UnhandledException11111: {exceptionStr} ");


                    // 仅当异常信息或调用堆栈中包含"SolarEngineWindow"时记录日志
                    if (exceptionStr.Contains("SolarEngineWindow"))
                    {
                        // 记录错误信息和调用堆栈
                        MessageBox.Show($"UnhandledException: {exceptionStr} ");
                        // LogTool.Error($"Call Stack: {stackTraceStr}");

                      
                    }
                }
                else
                {
                    // 如果 ExceptionObject 不是 Exception 类型，则直接检查其字符串表示形式是否包含"SolarEngineWindow"
                    string exceptionObjectStr = e.ExceptionObject.ToString();

                    // 仅当异常对象的字符串表示形式中包含"SolarEngineWindow"时记录日志
                    if (exceptionObjectStr.Contains("SolarEngineWindow"))
                    {
                        // 记录错误信息
                        MessageBox.Show($"UnhandledException: {exceptionObjectStr}");

                     
                    }
                }

            };



            MessageBox.Show(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // 这里是你的回调逻辑，例如记录日志或通知用户
            MessageBox.Show($"应用程序遇到了一个错误: {e.Exception.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // 根据实际情况决定是否退出程序
            // Environment.Exit(1); // 使用此行可以在处理完异常后强制退出程序
        }



    }
}
