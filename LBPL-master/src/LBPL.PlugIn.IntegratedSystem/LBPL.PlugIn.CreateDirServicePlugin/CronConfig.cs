using LBPL.PlugIn.Integration.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
//   演示任务 定时创建 文件夹 获取任务执行时间表达式
// 
//   author：林滨
//------------------------------------------------

namespace LBPL.PlugIn.CreateDirServicePlugin
{
   public class CronConfig:ICronConfig
    {
       /// <summary>
       /// 
       /// </summary>
       public static string CreateDirFolderServiceJobTriggerCron
        {

           get {

               return ConfigurationManager.AppSettings["CreateDirFolderServiceJobTriggerCron"];
           }
      }


    }
}
