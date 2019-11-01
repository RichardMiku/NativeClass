using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;

namespace Native.Config
{
    public class Config
    {
        /// <summary>
        /// WriteCfg
        /// </summary>
        /// <param name="FileName">文件名</param>
        /// <param name="section">项名称</param>
        /// <param name="term">节名称</param>
        /// <param name="value">欲写值</param>
        /// <returns></returns>
        [DllImport("NativeConfig.dll")]
        private static extern bool WriteCfg(string FileName, string section, string term, string value);
        /// <summary>
        /// ReadCfg
        /// </summary>
        /// <param name="FileName">文件名</param>
        /// <param name="section">项名称</param>
        /// <param name="term">节名称</param>
        /// <returns></returns>
        [DllImport("NativeConfig.dll")]
        private static extern string ReadCfg(string FileName, string section, string term);
        /// <summary>
        /// 写配置项
        /// </summary>
        /// <param name="FileName">文件名</param>
        /// <param name="section">项名称</param>
        /// <param name="term">节名称</param>
        /// <param name="value">欲写值</param>
        /// <returns></returns>
        public void WriteConfiguration(string FileName, string section, string term, string value)
        {
            bool W = WriteCfg(FileName, section, term, value);
            if (W == false)
            {
                MessageBox.Show("写入配置项失败！", "提示");
            }
        }
        /// <summary>
        /// 读配置项
        /// </summary>
        /// <param name="FileName">文件名</param>
        /// <param name="section">项名称</param>
        /// <param name="term">节名称</param>
        /// <returns></returns>
        public string ReadConfiguration(string FileName, string section, string term)
        {
            string Cfg;
            Cfg = ReadCfg(FileName, section, term);
            return Cfg;
        }
    }
}