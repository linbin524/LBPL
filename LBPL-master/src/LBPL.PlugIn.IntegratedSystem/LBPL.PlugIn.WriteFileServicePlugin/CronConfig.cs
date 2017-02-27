using LBPL.PlugIn.Integration.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBPL.PlugIn.WriteFileServicePlugin
{
   public class CronConfig: ICronConfig
    {
       /// <summary>
       /// 
       /// </summary>
       public static string WriteFileServiceJobTriggerCron
        {

           get {

               return ConfigurationManager.AppSettings["WriteFileServiceJobTriggerCron"];
           }
      }


    }
}
