namespace ModelEntity
{
    partial class frmDetailEidt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckColIsNull = new System.Windows.Forms.CheckBox();
            this.ckColIsPrimarykey = new System.Windows.Forms.CheckBox();
            this.cbColType = new System.Windows.Forms.ComboBox();
            this.txtColLenth = new System.Windows.Forms.TextBox();
            this.txtColName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckColIsNull);
            this.groupBox1.Controls.Add(this.ckColIsPrimarykey);
            this.groupBox1.Controls.Add(this.cbColType);
            this.groupBox1.Controls.Add(this.txtColLenth);
            this.groupBox1.Controls.Add(this.txtColName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtColID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ckColIsNull
            // 
            this.ckColIsNull.AutoSize = true;
            this.ckColIsNull.Location = new System.Drawing.Point(251, 132);
            this.ckColIsNull.Name = "ckColIsNull";
            this.ckColIsNull.Size = new System.Drawing.Size(72, 16);
            this.ckColIsNull.TabIndex = 11;
            this.ckColIsNull.Text = "可否为空";
            this.ckColIsNull.UseVisualStyleBackColor = true;
            // 
            // ckColIsPrimarykey
            // 
            this.ckColIsPrimarykey.AutoSize = true;
            this.ckColIsPrimarykey.Location = new System.Drawing.Point(48, 132);
            this.ckColIsPrimarykey.Name = "ckColIsPrimarykey";
            this.ckColIsPrimarykey.Size = new System.Drawing.Size(72, 16);
            this.ckColIsPrimarykey.TabIndex = 10;
            this.ckColIsPrimarykey.Text = "是否主键";
            this.ckColIsPrimarykey.UseVisualStyleBackColor = true;
            // 
            // cbColType
            // 
            this.cbColType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColType.FormattingEnabled = true;
            this.cbColType.Items.AddRange(new object[] {
            "String",
            "Int32",
            "Int64",
            "Bool",
            "Float",
            "Double",
            "Date",
            "DateTime"});
            this.cbColType.Location = new System.Drawing.Point(117, 94);
            this.cbColType.Name = "cbColType";
            this.cbColType.Size = new System.Drawing.Size(82, 20);
            this.cbColType.TabIndex = 7;
            // 
            // txtColLenth
            // 
            this.txtColLenth.Location = new System.Drawing.Point(272, 94);
            this.txtColLenth.Name = "txtColLenth";
            this.txtColLenth.Size = new System.Drawing.Size(51, 21);
            this.txtColLenth.TabIndex = 9;
            // 
            // txtColName
            // 
            this.txtColName.Location = new System.Drawing.Point(117, 57);
            this.txtColName.Name = "txtColName";
            this.txtColName.Size = new System.Drawing.Size(206, 21);
            this.txtColName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(329, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "*";
            // 
            // txtColID
            // 
            this.txtColID.Location = new System.Drawing.Point(117, 20);
            this.txtColID.Name = "txtColID";
            this.txtColID.Size = new System.Drawing.Size(206, 21);
            this.txtColID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "长度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "列 类 型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "列中文名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(329, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "列    名：";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(329, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取  消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保  存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmDetailEidt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 224);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailEidt";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "列信息编辑";
            this.Load += new System.EventHandler(this.frmDetailEidt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ckColIsNull;
        private System.Windows.Forms.CheckBox ckColIsPrimarykey;
        private System.Windows.Forms.ComboBox cbColType;
        private System.Windows.Forms.TextBox txtColLenth;
        private System.Windows.Forms.TextBox txtColName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}