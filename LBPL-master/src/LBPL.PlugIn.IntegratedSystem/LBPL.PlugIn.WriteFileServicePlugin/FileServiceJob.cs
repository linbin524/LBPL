using Quartz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace LBPL.PlugIn.WriteFileServicePlugin
{
   public class FileServiceJob:IJob
    {

        public void Execute(IJobExecutionContext context)
        {

            FileWrite();
        }

        public void FileWrite()
        {

            string filePath = System.Environment.CurrentDirectory + "\\File";//文件夹路径
            string path = System.Environment.CurrentDirectory + @"\File\text.txt";
            if (!Directory.Exists(filePath))//判断文件夹是否存在
            {
                Directory.CreateDirectory(filePath);//不存在则创建文件夹
            }

            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path).Close();//创建后要关闭，否则后面的操作无法实现

            }
            //FileMode.Append 在文件末尾加入，那么FileAccess 只能是写入，不能使有包括读取操作



            try
            {
                for (int t = 0; t < 100; t++)
                {
                    //文件流和 流操作都是要一起的，否则就是缺少部件，会失败报错
                    FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs, System.Text.ASCIIEncoding.UTF8);
                    string textContent = "我是定时任务1 写入文件操作" + t + "  定时任务";
                    sw.WriteLine(textContent);
                    sw.Flush();
                    sw.Close();
                    if (t == 2)
                    {

                        throw new Exception("异常");
                    }
                }
            }
            catch (Exception ex)
            {

                LogHelper.WriteLog(ex.ToString());
            }
            //文件写入好了记得回收，关闭，要不然进程一直占用，其他进程无法访问

        }
    }
}
