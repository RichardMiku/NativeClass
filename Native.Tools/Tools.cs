using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.InteropServices;
using System.IO;

namespace Native.Tools
{
    public class Tools
    {
        /// <summary>
        /// HTTPReadFile
        /// </summary>
        /// <param name="http">http地址</param>
        /// <returns></returns>
        [DllImport("NativeTools.dll")]
        private static extern byte HTTPReadFile(string http);
        /// <summary>
        /// HTTP读文件
        /// </summary>
        /// <param name="http">http地址</param>
        /// <returns></returns>
        public byte HttpReadFile(string http)
        {
            byte Value;
            Value = HTTPReadFile(http);
            return Value;
        }
        /// <summary>
        /// 取运行目录
        /// </summary>
        /// <returns></returns>
        public string GetRunningDirectory()
        {
            string dir;
            dir = AppDomain.CurrentDomain.BaseDirectory;
            return dir;
        }
        /// <summary>
        /// LoadBall
        /// </summary>
        /// <returns></returns>
        [DllImport("NativeBall.dll")]
        private static extern bool LoadBall();
        /// <summary>
        /// 加载悬浮球
        /// </summary>
        public void Loadball()
        {
            LoadBall();
        }
        /// <summary>
        /// 检查网络连接check
        /// </summary>
        /// <param name="Description"></param>
        /// <param name="ReservedValue"></param>
        /// <returns></returns>
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(int Description, int ReservedValue);
        /// <summary>
        /// 检查网络连接
        /// </summary>
        /// <returns></returns>
        public bool IsConnectInternet()
          {
              int Description = 0;
             return InternetGetConnectedState(Description, 0);
          }
}
}
