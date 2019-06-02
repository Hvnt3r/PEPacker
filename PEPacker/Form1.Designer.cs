namespace PEPacker
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输入注册码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.制作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.PEHeaderTab = new System.Windows.Forms.TabPage();
            this.FileHeaderListView = new System.Windows.Forms.ListView();
            this.PEHeader_Key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PEHeader_Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataListTab = new System.Windows.Forms.TabPage();
            this.DataListView = new System.Windows.Forms.ListView();
            this.Data_key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_RVA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Section_tableTab = new System.Windows.Forms.TabPage();
            this.SectionTableLIstView = new System.Windows.Forms.ListView();
            this.Section_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Section_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Section_RVA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Section_xxx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImportTableTab = new System.Windows.Forms.TabPage();
            this.ImportTableListView = new System.Windows.Forms.ListView();
            this.ExportTableTab = new System.Windows.Forms.TabPage();
            this.ExportTableListView = new System.Windows.Forms.ListView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.BeginPackBtn = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.Encryption_CheckBox = new System.Windows.Forms.CheckBox();
            this.ProcessPEInfo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.PEHeaderTab.SuspendLayout();
            this.DataListTab.SuspendLayout();
            this.Section_tableTab.SuspendLayout();
            this.ImportTableTab.SuspendLayout();
            this.ExportTableTab.SuspendLayout();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.注册ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 注册ToolStripMenuItem
            // 
            this.注册ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.输入注册码ToolStripMenuItem});
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            this.注册ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.注册ToolStripMenuItem.Text = "注册";
            this.注册ToolStripMenuItem.Click += new System.EventHandler(this.注册ToolStripMenuItem_Click);
            // 
            // 输入注册码ToolStripMenuItem
            // 
            this.输入注册码ToolStripMenuItem.Name = "输入注册码ToolStripMenuItem";
            this.输入注册码ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.输入注册码ToolStripMenuItem.Text = "输入注册码";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.制作者ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 制作者ToolStripMenuItem
            // 
            this.制作者ToolStripMenuItem.Name = "制作者ToolStripMenuItem";
            this.制作者ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.制作者ToolStripMenuItem.Text = "制作者";
            this.制作者ToolStripMenuItem.Click += new System.EventHandler(this.制作者ToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.PEHeaderTab);
            this.tabControl.Controls.Add(this.DataListTab);
            this.tabControl.Controls.Add(this.Section_tableTab);
            this.tabControl.Controls.Add(this.ImportTableTab);
            this.tabControl.Controls.Add(this.ExportTableTab);
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl.Location = new System.Drawing.Point(12, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(720, 536);
            this.tabControl.TabIndex = 1;
            // 
            // PEHeaderTab
            // 
            this.PEHeaderTab.Controls.Add(this.FileHeaderListView);
            this.PEHeaderTab.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PEHeaderTab.Location = new System.Drawing.Point(4, 33);
            this.PEHeaderTab.Name = "PEHeaderTab";
            this.PEHeaderTab.Padding = new System.Windows.Forms.Padding(3);
            this.PEHeaderTab.Size = new System.Drawing.Size(712, 499);
            this.PEHeaderTab.TabIndex = 0;
            this.PEHeaderTab.Text = "文件头信息";
            this.PEHeaderTab.UseVisualStyleBackColor = true;
            // 
            // FileHeaderListView
            // 
            this.FileHeaderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PEHeader_Key,
            this.PEHeader_Value});
            this.FileHeaderListView.GridLines = true;
            this.FileHeaderListView.Location = new System.Drawing.Point(6, 6);
            this.FileHeaderListView.Name = "FileHeaderListView";
            this.FileHeaderListView.Size = new System.Drawing.Size(700, 487);
            this.FileHeaderListView.TabIndex = 0;
            this.FileHeaderListView.UseCompatibleStateImageBehavior = false;
            this.FileHeaderListView.View = System.Windows.Forms.View.Details;
            // 
            // PEHeader_Key
            // 
            this.PEHeader_Key.Text = "字段";
            this.PEHeader_Key.Width = 233;
            // 
            // PEHeader_Value
            // 
            this.PEHeader_Value.Text = "值";
            this.PEHeader_Value.Width = 181;
            // 
            // DataListTab
            // 
            this.DataListTab.Controls.Add(this.DataListView);
            this.DataListTab.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataListTab.Location = new System.Drawing.Point(4, 33);
            this.DataListTab.Name = "DataListTab";
            this.DataListTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataListTab.Size = new System.Drawing.Size(712, 499);
            this.DataListTab.TabIndex = 1;
            this.DataListTab.Text = "数据目录";
            this.DataListTab.UseVisualStyleBackColor = true;
            // 
            // DataListView
            // 
            this.DataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data_key,
            this.Data_RVA,
            this.Data_Size});
            this.DataListView.Location = new System.Drawing.Point(6, 6);
            this.DataListView.Name = "DataListView";
            this.DataListView.Size = new System.Drawing.Size(700, 487);
            this.DataListView.TabIndex = 0;
            this.DataListView.UseCompatibleStateImageBehavior = false;
            this.DataListView.View = System.Windows.Forms.View.Details;
            // 
            // Data_key
            // 
            this.Data_key.Text = "目录名称";
            this.Data_key.Width = 295;
            // 
            // Data_RVA
            // 
            this.Data_RVA.Text = "虚拟地址";
            this.Data_RVA.Width = 175;
            // 
            // Data_Size
            // 
            this.Data_Size.Text = "大小";
            this.Data_Size.Width = 174;
            // 
            // Section_tableTab
            // 
            this.Section_tableTab.BackColor = System.Drawing.Color.Transparent;
            this.Section_tableTab.Controls.Add(this.SectionTableLIstView);
            this.Section_tableTab.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Section_tableTab.Location = new System.Drawing.Point(4, 33);
            this.Section_tableTab.Name = "Section_tableTab";
            this.Section_tableTab.Size = new System.Drawing.Size(712, 499);
            this.Section_tableTab.TabIndex = 2;
            this.Section_tableTab.Text = "节表";
            this.Section_tableTab.UseVisualStyleBackColor = true;
            // 
            // SectionTableLIstView
            // 
            this.SectionTableLIstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Section_Name,
            this.Section_Size,
            this.Section_RVA,
            this.Section_xxx});
            this.SectionTableLIstView.Location = new System.Drawing.Point(6, 6);
            this.SectionTableLIstView.Name = "SectionTableLIstView";
            this.SectionTableLIstView.Size = new System.Drawing.Size(700, 487);
            this.SectionTableLIstView.TabIndex = 0;
            this.SectionTableLIstView.UseCompatibleStateImageBehavior = false;
            this.SectionTableLIstView.View = System.Windows.Forms.View.Details;
            // 
            // Section_Name
            // 
            this.Section_Name.Text = "节名称";
            this.Section_Name.Width = 73;
            // 
            // Section_Size
            // 
            this.Section_Size.Text = "虚拟大小";
            this.Section_Size.Width = 100;
            // 
            // Section_RVA
            // 
            this.Section_RVA.Text = "虚拟地址";
            this.Section_RVA.Width = 110;
            // 
            // Section_xxx
            // 
            this.Section_xxx.Width = 179;
            // 
            // ImportTableTab
            // 
            this.ImportTableTab.Controls.Add(this.ImportTableListView);
            this.ImportTableTab.Location = new System.Drawing.Point(4, 33);
            this.ImportTableTab.Name = "ImportTableTab";
            this.ImportTableTab.Size = new System.Drawing.Size(712, 499);
            this.ImportTableTab.TabIndex = 3;
            this.ImportTableTab.Text = "导入表";
            this.ImportTableTab.UseVisualStyleBackColor = true;
            // 
            // ImportTableListView
            // 
            this.ImportTableListView.Location = new System.Drawing.Point(6, 6);
            this.ImportTableListView.Name = "ImportTableListView";
            this.ImportTableListView.Size = new System.Drawing.Size(700, 487);
            this.ImportTableListView.TabIndex = 0;
            this.ImportTableListView.UseCompatibleStateImageBehavior = false;
            this.ImportTableListView.View = System.Windows.Forms.View.Details;
            // 
            // ExportTableTab
            // 
            this.ExportTableTab.Controls.Add(this.ExportTableListView);
            this.ExportTableTab.Location = new System.Drawing.Point(4, 33);
            this.ExportTableTab.Name = "ExportTableTab";
            this.ExportTableTab.Size = new System.Drawing.Size(712, 499);
            this.ExportTableTab.TabIndex = 4;
            this.ExportTableTab.Text = "导出表";
            this.ExportTableTab.UseVisualStyleBackColor = true;
            // 
            // ExportTableListView
            // 
            this.ExportTableListView.Location = new System.Drawing.Point(6, 6);
            this.ExportTableListView.Name = "ExportTableListView";
            this.ExportTableListView.Size = new System.Drawing.Size(700, 487);
            this.ExportTableListView.TabIndex = 0;
            this.ExportTableListView.UseCompatibleStateImageBehavior = false;
            this.ExportTableListView.View = System.Windows.Forms.View.Details;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(738, 477);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(318, 36);
            this.progressBar.TabIndex = 2;
            // 
            // BeginPackBtn
            // 
            this.BeginPackBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginPackBtn.Location = new System.Drawing.Point(738, 529);
            this.BeginPackBtn.Name = "BeginPackBtn";
            this.BeginPackBtn.Size = new System.Drawing.Size(318, 36);
            this.BeginPackBtn.TabIndex = 4;
            this.BeginPackBtn.Text = "开始加壳！";
            this.BeginPackBtn.UseVisualStyleBackColor = true;
            this.BeginPackBtn.Click += new System.EventHandler(this.BeginPackBtn_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.Color.Azure;
            this.GroupBox.Controls.Add(this.Encryption_CheckBox);
            this.GroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox.Location = new System.Drawing.Point(738, 104);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(318, 355);
            this.GroupBox.TabIndex = 6;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "加壳选项";
            // 
            // Encryption_CheckBox
            // 
            this.Encryption_CheckBox.AutoSize = true;
            this.Encryption_CheckBox.Location = new System.Drawing.Point(15, 26);
            this.Encryption_CheckBox.Name = "Encryption_CheckBox";
            this.Encryption_CheckBox.Size = new System.Drawing.Size(61, 24);
            this.Encryption_CheckBox.TabIndex = 0;
            this.Encryption_CheckBox.Text = "加密";
            this.Encryption_CheckBox.UseVisualStyleBackColor = true;
            // 
            // ProcessPEInfo
            // 
            this.ProcessPEInfo.BackColor = System.Drawing.Color.LightBlue;
            this.ProcessPEInfo.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProcessPEInfo.Location = new System.Drawing.Point(738, 64);
            this.ProcessPEInfo.Name = "ProcessPEInfo";
            this.ProcessPEInfo.Size = new System.Drawing.Size(318, 34);
            this.ProcessPEInfo.TabIndex = 8;
            this.ProcessPEInfo.Text = "打开文件并生成PE信息";
            this.ProcessPEInfo.UseVisualStyleBackColor = false;
            this.ProcessPEInfo.Click += new System.EventHandler(this.ProcessPEInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1068, 579);
            this.Controls.Add(this.ProcessPEInfo);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.BeginPackBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PEPacker v1.0 by Hvnt3r";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.PEHeaderTab.ResumeLayout(false);
            this.DataListTab.ResumeLayout(false);
            this.Section_tableTab.ResumeLayout(false);
            this.ImportTableTab.ResumeLayout(false);
            this.ExportTableTab.ResumeLayout(false);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 制作者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输入注册码ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage PEHeaderTab;
        private System.Windows.Forms.TabPage DataListTab;
        private System.Windows.Forms.TabPage Section_tableTab;
        private System.Windows.Forms.TabPage ImportTableTab;
        private System.Windows.Forms.TabPage ExportTableTab;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button BeginPackBtn;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.ListView FileHeaderListView;
        private System.Windows.Forms.ColumnHeader PEHeader_Value;
        private System.Windows.Forms.ColumnHeader PEHeader_Key;
        private System.Windows.Forms.ListView DataListView;
        private System.Windows.Forms.ListView SectionTableLIstView;
        private System.Windows.Forms.ListView ImportTableListView;
        private System.Windows.Forms.ListView ExportTableListView;
        private System.Windows.Forms.ColumnHeader Data_key;
        private System.Windows.Forms.ColumnHeader Data_RVA;
        private System.Windows.Forms.ColumnHeader Data_Size;
        private System.Windows.Forms.ColumnHeader Section_Name;
        private System.Windows.Forms.ColumnHeader Section_Size;
        private System.Windows.Forms.ColumnHeader Section_RVA;
        private System.Windows.Forms.ColumnHeader Section_xxx;
        private System.Windows.Forms.CheckBox Encryption_CheckBox;
        private System.Windows.Forms.Button ProcessPEInfo;
    }
}

