namespace ModelEntity
{
    partial class frmDetailList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEidt = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDel = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLenth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsPrimarykey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsNull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.ColID,
            this.ColName,
            this.ColType,
            this.ColLenth,
            this.ColIsPrimarykey,
            this.ColIsNull,
            this.Creater,
            this.CreateTime,
            this.Updater,
            this.UpdateTime});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(923, 384);
            this.dataGridView1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsNew,
            this.cmsEidt,
            this.cmsDel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 70);
            // 
            // cmsNew
            // 
            this.cmsNew.Name = "cmsNew";
            this.cmsNew.Size = new System.Drawing.Size(152, 22);
            this.cmsNew.Text = "新增(&N)";
            this.cmsNew.Click += new System.EventHandler(this.cmsNew_Click);
            // 
            // cmsEidt
            // 
            this.cmsEidt.Name = "cmsEidt";
            this.cmsEidt.Size = new System.Drawing.Size(152, 22);
            this.cmsEidt.Text = "修改(&E)";
            this.cmsEidt.Click += new System.EventHandler(this.cmsEidt_Click);
            // 
            // cmsDel
            // 
            this.cmsDel.Name = "cmsDel";
            this.cmsDel.Size = new System.Drawing.Size(152, 22);
            this.cmsDel.Text = "删除(&D)";
            this.cmsDel.Click += new System.EventHandler(this.cmsDel_Click);
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.HeaderText = "类名";
            this.ClassID.Name = "ClassID";
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ColID";
            this.ColID.HeaderText = "列名";
            this.ColID.Name = "ColID";
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "ColName";
            this.ColName.HeaderText = "列中文名";
            this.ColName.Name = "ColName";
            // 
            // ColType
            // 
            this.ColType.DataPropertyName = "ColType";
            this.ColType.HeaderText = "列类型";
            this.ColType.Name = "ColType";
            // 
            // ColLenth
            // 
            this.ColLenth.DataPropertyName = "ColLenth";
            this.ColLenth.HeaderText = "长度";
            this.ColLenth.Name = "ColLenth";
            // 
            // ColIsPrimarykey
            // 
            this.ColIsPrimarykey.DataPropertyName = "ColIsPrimarykey";
            this.ColIsPrimarykey.HeaderText = "是否主键";
            this.ColIsPrimarykey.Name = "ColIsPrimarykey";
            // 
            // ColIsNull
            // 
            this.ColIsNull.DataPropertyName = "ColIsNull";
            this.ColIsNull.HeaderText = "可否为空";
            this.ColIsNull.Name = "ColIsNull";
            // 
            // Creater
            // 
            this.Creater.DataPropertyName = "Creater";
            this.Creater.HeaderText = "创建者";
            this.Creater.Name = "Creater";
            this.Creater.Visible = false;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.Visible = false;
            // 
            // Updater
            // 
            this.Updater.DataPropertyName = "Updater";
            this.Updater.HeaderText = "修改者";
            this.Updater.Name = "Updater";
            // 
            // UpdateTime
            // 
            this.UpdateTime.DataPropertyName = "UpdateTime";
            this.UpdateTime.HeaderText = "修改时间";
            this.UpdateTime.Name = "UpdateTime";
            // 
            // frmDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 384);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "列信息";
            this.Load += new System.EventHandler(this.frmDetailList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsNew;
        private System.Windows.Forms.ToolStripMenuItem cmsEidt;
        private System.Windows.Forms.ToolStripMenuItem cmsDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLenth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIsPrimarykey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIsNull;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creater;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Updater;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
    }
}