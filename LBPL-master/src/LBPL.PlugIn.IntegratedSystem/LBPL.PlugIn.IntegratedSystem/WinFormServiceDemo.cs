using AOP.Common.WinForm;
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
    public partial class WinFormServiceDemo : Form
    {
        Dictionary<string, JobKey> jobKeyDic = new Dictionary<string, JobKey>();
        public List<ShowModel> CacheList = new List<ShowModel>();
        public static JobKey temp;
        public QuartzFactory QF;
        public WinFormServiceDemo()
        {
            InitializeComponent();
            QF = new QuartzFactory();
            QF.QuartzService();
            string error = "";
            var list = QF.QZServiceRpository.DefaultRunningQZServer(System.Environment.CurrentDirectory + "\\ServicePlugins\\", out error);
            BingCbb_List();
            BingDGV_List();
            string temp = "";
        }


        private void btn_GetRunningService_Click(object sender, EventArgs e)
        {
            BingCbb_List();
            BingDGV_List();

        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            string temp = cbb_ServiceList.SelectedValue.ToString();
            ShowModel showModel = CacheList.Where(x => x.JobKeyName == temp).FirstOrDefault();
            string error = "";
            bool result = QF.QZServiceRpository.PauseQuartzServer(showModel.JobsTrigger.JobKey, out error);
            if (result)
            {

                AttrMessage.RightMsg("服务" + temp + "暂停成功！");
            }
            else
            {

                AttrMessage.ErrorMsg("服务" + temp + "暂停失败！");
            }
            BingCbb_List();
            BingDGV_List();
        }

        private void btn_ReStart_Click(object sender, EventArgs e)
        {
            string temp = cbb_ServiceList.SelectedValue.ToString();
            ShowModel showModel = CacheList.Where(x => x.JobKeyName == temp).FirstOrDefault();
            bool result = QF.QZServiceRpository.ResumeQuartzServer(showModel.JobsTrigger.JobKey);
            if (result)
            {

                AttrMessage.RightMsg("服务" + temp + "恢复成功！");
            }
            else
            {

                AttrMessage.ErrorMsg("服务" + temp + "恢复失败！");
            }
            BingCbb_List();
            BingDGV_List();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            string error = "";
            bool result = QF.QZServiceRpository.StopAllQuartzServer(out error);
            if (result)
            {

                AttrMessage.RightMsg("所有服务停止成功！");
            }
            else
            {

                AttrMessage.ErrorMsg("所有服务停止失败！");
            }
            BingCbb_List();
            BingDGV_List();
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string temp = cbb_ServiceList.SelectedValue.ToString();
            ShowModel showModel = CacheList.Where(x => x.JobKeyName == temp).FirstOrDefault();
            string error = "";
            bool result = QF.QZServiceRpository.DeleteQuartzServer(showModel.JobsTrigger.JobKey);
            if (result)
            {

                AttrMessage.RightMsg("服务" + temp + "删除成功！");
            }
            else
            {

                AttrMessage.ErrorMsg("服务" + temp + "删除失败！");
            }
            BingCbb_List();
            BingDGV_List();
        }

        private void Btn_ChooseFile_Click(object sender, EventArgs e)
        {
            string filePath = DialogHelper.OpenDialog(this.openFileDialog, @"D:\Develop\开源项目\自己的开源项目\LBPL.PlugIn.IntegratedSystem\LBPL.PlugIn.IntegratedSystem\PluginLibrary", "插件|*.dll");
            tb_path.Text = filePath;

        }

        private void Btn_InputPlugin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_path.Text))
            {
                AttrMessage.ErrorMsg("请选择要导入的插件文件!");
                return;
            }
            string error = "";
            bool result = QF.QZServiceRpository.AddQZServerDLL(tb_path.Text.ToString(), out error);

            if (result)
            {
                BingCbb_List();
                BingDGV_List();
                AttrMessage.RightMsg("服务加载成功！");
            }
            else
            {
                AttrMessage.ErrorMsg("插件加载失败");
            }

        }


        public void BingCbb_List()
        {

            List<JobsTrigger> list = QF.QZServiceRpository.GetALLQuartzServer();

            List<string> jobList = new List<string>();

            CacheList = new List<ShowModel>();
            foreach (var i in list)
            {
                ShowModel temp = new ShowModel();
                temp.JobKeyName = i.JobKey.Name;
                temp.TriggerName = i.TriggerKey.Name;
                temp.State = i.TriggerState.ToString();
                temp.JobsTrigger = i;
                CacheList.Add(temp);
                jobList.Add(i.JobKey.Name);

            }
            cbb_ServiceList.DataSource = null;
            cbb_ServiceList.DataSource = jobList;

        }

        public void BingDGV_List()
        {

            List<JobsTrigger> list = QF.QZServiceRpository.GetALLQuartzServer();

            List<ShowModel> serviceStateList = new List<ShowModel>();
            foreach (var i in list)
            {
                ShowModel temp = new ShowModel();
                temp.JobKeyName = i.JobKey.Name;
                temp.TriggerName = i.TriggerKey.Name;
                temp.State = i.TriggerState.ToString();
                temp.JobsTrigger = i;
                serviceStateList.Add(temp);

            }
            dgv_ServiceList.DataSource = new BindingList<ShowModel>(serviceStateList);

        }



    }

    /// <summary>
    /// 演示Demo
    /// </summary>
    public class ShowModel
    {

        public string JobKeyName { get; set; }
        public string TriggerName { get; set; }
        public string State { get; set; }

        public JobsTrigger JobsTrigger { get; set; }

    }
}
