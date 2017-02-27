using LBPL.PlugIn.Integration.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
