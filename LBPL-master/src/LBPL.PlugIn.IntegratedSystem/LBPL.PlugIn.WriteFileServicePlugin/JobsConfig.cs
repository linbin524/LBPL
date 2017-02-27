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
using LBPL.PlugIn.WriteFileServicePlugin;
using LBPL.PlugIn.Integration.Interface;


//------------------------------------------------
//   服务配置
// 
//   author：林滨
//------------------------------------------------
namespace LBPL.PlugIn.WriteFileServicePlugin
{

    public class JobsConfig: IJobsConfig
    {
       
        Dictionary<string, string> cronDic = new Dictionary<string, string>();

        public JobsConfig() {
          
            string temp1 = CronConfig.WriteFileServiceJobTriggerCron;

            cronDic.Add("WriteFileServiceJobTriggerCron", temp1);

        }


        /// <summary>
        /// 文件操作写入文件定时服务
        /// </summary>
        public QuartzJobsCollection WriteFileJob
        {

            get
            {

                IJobDetail writeFileJob = JobBuilder.Create<FileServiceJob>()  //创建一个作业
                    .WithIdentity("WriteFileServiceJob_Key", "WriteFileServiceJob_Group")//自定义
                    .Build();


                ITrigger writeFileTrigger = TriggerBuilder.Create()
                                            .WithIdentity("WriteFileTrigger_key", "WriteFileTrigger_Group").StartNow()
                                            //现在开始
                                            .WithCronSchedule(cronDic["WriteFileServiceJobTriggerCron"])// 
                                            .Build();
           

                Quartz.Collection.HashSet<ITrigger> triggerList = new Quartz.Collection.HashSet<ITrigger>();
                triggerList.Add(writeFileTrigger);
                return new QuartzJobsCollection() { JobDetail = writeFileJob, Trigger = triggerList };
            }
        }


    }
}
