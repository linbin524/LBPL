namespace LBPL.PlugIn.IntegratedSystem
{
    partial class WinFormServiceDemo
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.cbb_ServiceList = new System.Windows.Forms.ComboBox();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_ReStart = new System.Windows.Forms.Button();
            this.btn_GetRunningService = new System.Windows.Forms.Button();
            this.Btn_InputPlugin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.Btn_ChooseFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dgv_ServiceList = new System.Windows.Forms.DataGridView();
            this.JobKeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriggerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_StopAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ServiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(1109, 103);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // cbb_ServiceList
            // 
            this.cbb_ServiceList.FormattingEnabled = true;
            this.cbb_ServiceList.Location = new System.Drawing.Point(809, 12);
            this.cbb_ServiceList.Name = "cbb_ServiceList";
            this.cbb_ServiceList.Size = new System.Drawing.Size(257, 20);
            this.cbb_ServiceList.TabIndex = 3;
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(913, 102);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "暂停";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_ReStart
            // 
            this.btn_ReStart.Location = new System.Drawing.Point(1014, 103);
            this.btn_ReStart.Name = "btn_ReStart";
            this.btn_ReStart.Size = new System.Drawing.Size(75, 23);
            this.btn_ReStart.TabIndex = 5;
            this.btn_ReStart.Text = "恢复";
            this.btn_ReStart.UseVisualStyleBackColor = true;
            this.btn_ReStart.Click += new System.EventHandler(this.btn_ReStart_Click);
            // 
            // btn_GetRunningService
            // 
            this.btn_GetRunningService.Location = new System.Drawing.Point(1083, 12);
            this.btn_GetRunningService.Name = "btn_GetRunningService";
            this.btn_GetRunningService.Size = new System.Drawing.Size(137, 23);
            this.btn_GetRunningService.TabIndex = 6;
            this.btn_GetRunningService.Text = "获取定时服务列表";
            this.btn_GetRunningService.UseVisualStyleBackColor = true;
            this.btn_GetRunningService.Click += new System.EventHandler(this.btn_GetRunningService_Click);
            // 
            // Btn_InputPlugin
            // 
            this.Btn_InputPlugin.Location = new System.Drawing.Point(569, 15);
            this.Btn_InputPlugin.Name = "Btn_InputPlugin";
            this.Btn_InputPlugin.Size = new System.Drawing.Size(135, 29);
            this.Btn_InputPlugin.TabIndex = 12;
            this.Btn_InputPlugin.Text = "导入";
            this.Btn_InputPlugin.UseVisualStyleBackColor = true;
            this.Btn_InputPlugin.Click += new System.EventHandler(this.Btn_InputPlugin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "导入服务插件：";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(116, 20);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(301, 21);
            this.tb_path.TabIndex = 10;
            // 
            // Btn_ChooseFile
            // 
            this.Btn_ChooseFile.Location = new System.Drawing.Point(436, 15);
            this.Btn_ChooseFile.Name = "Btn_ChooseFile";
            this.Btn_ChooseFile.Size = new System.Drawing.Size(116, 29);
            this.Btn_ChooseFile.TabIndex = 9;
            this.Btn_ChooseFile.Text = "选择文件.....";
            this.Btn_ChooseFile.UseVisualStyleBackColor = true;
            this.Btn_ChooseFile.Click += new System.EventHandler(this.Btn_ChooseFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // dgv_ServiceList
            // 
            this.dgv_ServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ServiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobKeyName,
            this.TriggerName,
            this.State});
            this.dgv_ServiceList.Location = new System.Drawing.Point(671, 153);
            this.dgv_ServiceList.Name = "dgv_ServiceList";
            this.dgv_ServiceList.RowTemplate.Height = 23;
            this.dgv_ServiceList.Size = new System.Drawing.Size(560, 338);
            this.dgv_ServiceList.TabIndex = 13;
            // 
            // JobKeyName
            // 
            this.JobKeyName.DataPropertyName = "JobKeyName";
            this.JobKeyName.HeaderText = "任务名";
            this.JobKeyName.Name = "JobKeyName";
            this.JobKeyName.Width = 200;
            // 
            // TriggerName
            // 
            this.TriggerName.DataPropertyName = "TriggerName";
            this.TriggerName.HeaderText = "触发器名称";
            this.TriggerName.Name = "TriggerName";
            this.TriggerName.Width = 200;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "状态";
            this.State.Name = "State";
            this.State.Width = 200;
            // 
            // btn_StopAll
            // 
            this.btn_StopAll.Location = new System.Drawing.Point(796, 102);
            this.btn_StopAll.Name = "btn_StopAll";
            this.btn_StopAll.Size = new System.Drawing.Size(98, 23);
            this.btn_StopAll.TabIndex = 14;
            this.btn_StopAll.Text = "停止所有服务";
            this.btn_StopAll.UseVisualStyleBackColor = true;
            this.btn_StopAll.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // WinFormServiceDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 599);
            this.Controls.Add(this.btn_StopAll);
            this.Controls.Add(this.dgv_ServiceList);
            this.Controls.Add(this.Btn_InputPlugin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.Btn_ChooseFile);
            this.Controls.Add(this.btn_GetRunningService);
            this.Controls.Add(this.btn_ReStart);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.cbb_ServiceList);
            this.Controls.Add(this.btn_Delete);
            this.Name = "WinFormServiceDemo";
            this.Text = "WinForm定时服务Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ServiceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ComboBox cbb_ServiceList;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_ReStart;
        private System.Windows.Forms.Button btn_GetRunningService;
        private System.Windows.Forms.Button Btn_InputPlugin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button Btn_ChooseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dgv_ServiceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobKeyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriggerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Button btn_StopAll;
    }
}

