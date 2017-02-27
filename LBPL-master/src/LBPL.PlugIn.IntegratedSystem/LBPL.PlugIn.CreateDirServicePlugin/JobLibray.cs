
using LBPL.PlugIn.CreateDirServicePlugin;
using LBPL.PlugIn.Integration.Interface;
using LBPL.PlugIn.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
//   服务资源池
// 
//   author：林滨
//------------------------------------------------
namespace LBPL.PlugIn.CreateDirServicePlugin
{
   public class JobLibray: IJobLibray
    {
       public  List<QuartzJobsCollection> GetJobList()
       {

           try
           {
               List<QuartzJobsCollection> jobList = new List<QuartzJobsCollection>();

               JobsConfig jobsConfig = new JobsConfig();
            
               Type t = jobsConfig.GetType();

               System.Reflection.PropertyInfo[] properties = t.GetProperties();

               foreach (System.Reflection.PropertyInfo s in t.GetProperties())
               {
                   jobList.Add((QuartzJobsCollection)jobsConfig.GetType().GetProperty(s.Name).GetValue(jobsConfig, null));

               } 

               return jobList;
           }
           catch (Exception ex)
           {
               
               throw;
           }
          
       }
    }
}
