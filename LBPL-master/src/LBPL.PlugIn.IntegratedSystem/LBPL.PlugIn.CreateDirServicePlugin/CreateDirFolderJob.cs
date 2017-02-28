
using Quartz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
//------------------------------------------------
//   演示任务 定时创建 文件夹 传参数方式
// 
//   author：林滨
//------------------------------------------------

namespace LBPL.PlugIn.CreateDirServicePlugin
{
  public  class CreateDirFolderJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {

            JobDataMap dataMap = context.JobDetail.JobDataMap;

            string floderName = dataMap.GetString("CreateFloderName");//定时服务那边传过来的参数

            CreateFolderName(floderName);
        }


        public void CreateFolderName(string folderName) {

            string path = System.Environment.CurrentDirectory+"\\" + folderName + new Random().Next(954);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
