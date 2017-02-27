using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LBPL.PlugIn.WriteFileServicePlugin
{
   public class LogHelper
    {
       public static void WriteLog(string LogContent) {

           string filePath = System.Environment.CurrentDirectory + "\\File";//文件夹路径
           string path = System.Environment.CurrentDirectory + @"\File\log.txt";
           if (!Directory.Exists(filePath))//判断文件夹是否存在
           {
               Directory.CreateDirectory(filePath);//不存在则创建文件夹
           }

           if (!System.IO.File.Exists(path))
           {
               System.IO.File.Create(path).Close();//创建后要关闭，否则后面的操作无法实现

           }

           FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
           StreamWriter sw = new StreamWriter(fs, System.Text.ASCIIEncoding.UTF8);
           string textContent = LogContent;
           sw.WriteLine(textContent);
           sw.Flush();
           sw.Close();
       
       }
    }
}
