using LBPL.PlugIn.Integration;
using LBPL.PlugIn.Integration.Interface;
using LBPL.PlugIn.Model;
using Quartz;
using Quartz.Impl.Matchers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LBPL.PlugIn.IntegratedSystem
{
    public partial class Form1 : Form
    {
        Dictionary<string, JobKey> jobKeyDic = new Dictionary<string, JobKey>();

      public static JobKey temp;
        public QuartzFactory QF;
        public Form1()
        {
            InitializeComponent();
            QF=new QuartzFactory();
            QF.QuartzService();
            string error = "";
           var list= QF.QZServiceRpository.DefaultRunningQZServer(System.Environment.CurrentDirectory + "\\ServicePlugins\\",out error);
            string temp = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //JobsConfig jobsConfig = new JobsConfig();

            //Type t = jobsConfig.GetType();
            //QuartzJobsCollection temp = new QuartzJobsCollection();
            //foreach (var p in t.GetProperties())
            //{

            //    if (p.Name == tb_AddService.Text)
            //    {
            //        temp = (QuartzJobsCollection)jobsConfig.GetType().GetProperty(p.Name).GetValue(jobsConfig, null);
            //        QuartzFactory.AddQuartzServer(temp.JobDetail, temp.Trigger);
            //    }

            //}


        }

        private void btn_GetRunningService_Click(object sender, EventArgs e)
        {
            // List<IJobExecutionContext> list = QuartzFactory.GetALLQuartzServer();
          
            //List<string> jobList = new List<string>();
            //foreach (var i in list)
            //{

            //    if (jobKeyDic.Where(x => x.Key == i.JobDetail.JobType.Name).Count() == 0)
            //    {
            //        jobKeyDic.Add(i.JobDetail.JobType.Name, i.JobDetail.Key);
            //        jobList.Add(i.JobDetail.JobType.Name);
            //    }
                
            //}
            //cbb_ServiceList.DataSource = jobList;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            //string temp = cbb_ServiceList.SelectedValue.ToString();
            //QuartzFactory.PauseQuartzServer(jobKeyDic[temp]);
        }

        private void btn_ReStart_Click(object sender, EventArgs e)
        {
            //string temp = cbb_ServiceList.SelectedValue.ToString();
            //QuartzFactory.PauseQuartzServer(jobKeyDic[temp]);
            //QuartzFactory.Resume(jobKeyDic[temp]);
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            //string temp = cbb_ServiceList.SelectedValue.ToString();
            //QuartzFactory.PauseQuartzServer(jobKeyDic[temp]);
            //QuartzFactory.Resume(jobKeyDic[temp]);
        }

        private void btn_RunningDefaultService_Click(object sender, EventArgs e)
        {
            string path = System.Environment.CurrentDirectory + "\\ServicePlugins\\LBPL.PlugIn.CreateDirServicePlugin.dll";
            Assembly ass = Assembly.LoadFile(path);

            Type[] allType = ass.GetTypes();  //获取程序集中的所有类型列表
            Dictionary<string, Type> dic = new Dictionary<string, Type>();
            foreach (Type temp in allType)
            {

                if (temp.GetInterface("ICronConfig") != null)
                {
                    dic.Add("CronConfig", temp);
                }
                if (temp.GetInterface("IJobsConfig") != null)
                {
                    dic.Add("JobsConfig", temp);
                }

                if (temp.GetInterface("IJobLibray") != null)
                {
                    dic.Add("JobLibray", temp);
                }

            }
            var jobsConfig = Activator.CreateInstance(dic["JobsConfig"]);
            IJobLibray jobLibrary = (IJobLibray)Activator.CreateInstance(dic["JobLibray"]);
            Type t = jobsConfig.GetType();
            string error = "";
            foreach (var c in jobLibrary.GetJobList())
            {
                QF.QZServiceRpository.AddQuartzServer(c.JobDetail, c.Trigger,out error);
                temp = c.JobDetail.Key;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            QF.QZServiceRpository.IsExistsJob(temp);
        }
    }
}
