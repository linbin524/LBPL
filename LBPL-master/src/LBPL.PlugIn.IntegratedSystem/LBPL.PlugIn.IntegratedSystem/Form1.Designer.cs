namespace LBPL.PlugIn.IntegratedSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tb_AddService = new System.Windows.Forms.TextBox();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.cbb_ServiceList = new System.Windows.Forms.ComboBox();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_ReStart = new System.Windows.Forms.Button();
            this.btn_GetRunningService = new System.Windows.Forms.Button();
            this.btn_RunningDefaultService = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加任务";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_AddService
            // 
            this.tb_AddService.Location = new System.Drawing.Point(23, 38);
            this.tb_AddService.Name = "tb_AddService";
            this.tb_AddService.Size = new System.Drawing.Size(256, 21);
            this.tb_AddService.TabIndex = 1;
            this.tb_AddService.Text = "UpdateTextJob";
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(549, 127);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "停止";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // cbb_ServiceList
            // 
            this.cbb_ServiceList.FormattingEnabled = true;
            this.cbb_ServiceList.Location = new System.Drawing.Point(538, 36);
            this.cbb_ServiceList.Name = "cbb_ServiceList";
            this.cbb_ServiceList.Size = new System.Drawing.Size(257, 20);
            this.cbb_ServiceList.TabIndex = 3;
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(651, 126);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "暂停";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_ReStart
            // 
            this.btn_ReStart.Location = new System.Drawing.Point(752, 127);
            this.btn_ReStart.Name = "btn_ReStart";
            this.btn_ReStart.Size = new System.Drawing.Size(75, 23);
            this.btn_ReStart.TabIndex = 5;
            this.btn_ReStart.Text = "恢复";
            this.btn_ReStart.UseVisualStyleBackColor = true;
            this.btn_ReStart.Click += new System.EventHandler(this.btn_ReStart_Click);
            // 
            // btn_GetRunningService
            // 
            this.btn_GetRunningService.Location = new System.Drawing.Point(812, 36);
            this.btn_GetRunningService.Name = "btn_GetRunningService";
            this.btn_GetRunningService.Size = new System.Drawing.Size(137, 23);
            this.btn_GetRunningService.TabIndex = 6;
            this.btn_GetRunningService.Text = "获取定时服务列表";
            this.btn_GetRunningService.UseVisualStyleBackColor = true;
            this.btn_GetRunningService.Click += new System.EventHandler(this.btn_GetRunningService_Click);
            // 
            // btn_RunningDefaultService
            // 
            this.btn_RunningDefaultService.Location = new System.Drawing.Point(23, 100);
            this.btn_RunningDefaultService.Name = "btn_RunningDefaultService";
            this.btn_RunningDefaultService.Size = new System.Drawing.Size(169, 23);
            this.btn_RunningDefaultService.TabIndex = 7;
            this.btn_RunningDefaultService.Text = "加载默认服务";
            this.btn_RunningDefaultService.UseVisualStyleBackColor = true;
            this.btn_RunningDefaultService.Click += new System.EventHandler(this.btn_RunningDefaultService_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "获取当前触发器状态";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_RunningDefaultService);
            this.Controls.Add(this.btn_GetRunningService);
            this.Controls.Add(this.btn_ReStart);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.cbb_ServiceList);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.tb_AddService);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_AddService;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.ComboBox cbb_ServiceList;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_ReStart;
        private System.Windows.Forms.Button btn_GetRunningService;
        private System.Windows.Forms.Button btn_RunningDefaultService;
        private System.Windows.Forms.Button button2;
    }
}

