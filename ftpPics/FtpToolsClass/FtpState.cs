using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;

namespace ftpPics.FtpToolsClass
{
    class FtpState
    {
        private ManualResetEvent wait;                      //等待事件
        private FtpWebRequest request;                      //客户端
        private string fileName;                            //文件名
        private Exception operationException = null;        // 在应用程序执行期间发生的错误
        string status;                                      //FTP状态
        private string fullLocalPath;                       //本地路径

        public string FullLocalPath
        {
            get { return fullLocalPath; }
            set { fullLocalPath = value; }
        }

        public FtpState()                                    //构造函数
        {
            wait = new ManualResetEvent(false);
        }

        public ManualResetEvent OperationComplete
        {
            get { return wait; }
        }

        public FtpWebRequest Request
        {
            get { return request; }
            set { request = value; }
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public Exception OperationException
        {
            get { return operationException; }
            set { operationException = value; }
        }

        public string StatusDescription
        {
            get { return status; }
            set { status = value; }
        }
    }
}
