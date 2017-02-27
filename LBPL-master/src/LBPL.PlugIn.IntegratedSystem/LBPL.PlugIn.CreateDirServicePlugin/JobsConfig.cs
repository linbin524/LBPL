using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz.Collection;

using Quartz.Util;
using System.Configuration;
using LBPL.PlugIn.Model;
using LBPL.PlugIn.Integration.Interface;



//------------------------------------------------
//   服务配置
// 
//   author：林滨
//------------------------------------------------
namespace LBPL.PlugIn.CreateDirServicePlugin
{

    public class JobsConfig: IJobsConfig
    {
       
        Dictionary<string, string> cronDic = new Dictionary<string, string>();

        public JobsConfig() {
          
            string temp1 = CronConfig.CreateDirFolderServiceJobTriggerCron;

            cronDic.Add("CreateDirFolderServiceJobTriggerCron", temp1);

        }


        /// <summary>
        /// 创建文件夹定时服务
        /// </summary>
        public QuartzJobsCollection CreateDirFolderJob
        {

            get
            {

                IJobDetail createDirFolderJob = JobBuilder.Create<CreateDirFolderJob>()  //创建一个作业
                    .WithIdentity("CreateDirFolderJob_Key", "CreateDirFolderJob_Group")//自定义
                    . UsingJobData("CreateFloderName", DateTime.Now.ToString("yyyy-MM-dd") + new Random().Next(999))//这个事件因为只调用一次，所以传过去的值就只是为一个一个
                    .Build();


                ITrigger createDirFolderTrigger = TriggerBuilder.Create()
                                            .WithIdentity("CreateDirFolderTrigger_key", "CreateDirFolderTrigger_Group").StartNow()
                                            //现在开始
                                            .WithCronSchedule(cronDic["CreateDirFolderServiceJobTriggerCron"])// 
                                            .Build();
           

                Quartz.Collection.HashSet<ITrigger> triggerList = new Quartz.Collection.HashSet<ITrigger>();
                triggerList.Add(createDirFolderTrigger);
                return new QuartzJobsCollection() { JobDetail = createDirFolderJob, Trigger = triggerList };
            }
        }


    }
}
