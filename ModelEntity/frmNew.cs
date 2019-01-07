using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModelEntity
{
    public partial class frmNew : Form
    {
        private string ClassID;
        private string ClassName;
        private string TableName;
        public frmNew()
        {
            InitializeComponent();
        }
        public frmNew(string _ClassID, string _ClassName, string _TableName)
        {
            InitializeComponent();
            ClassID = _ClassID;
            ClassName = _ClassName;
            TableName = _TableName;
        }
        private void frmNew_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ClassID.Trim()))
            {
                txtClassID.Text = ClassID;
                txtClassName.Text = ClassName;
                txtTableName.Text = TableName;
                txtClassID.Enabled = false; 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(BaseInfo.CVTStr(txtClassID.Text.Trim())))
                {
                    MsgBox.Warning("类名不能为空！");
                    BaseInfo.Focus(txtClassID);
                    return;
                }

                if (string.IsNullOrEmpty(BaseInfo.CVTStr(txtClassName.Text.Trim())))
                {
                    MsgBox.Warning("类中文名不能为空！");
                    BaseInfo.Focus(txtClassName);
                    return;
                }

                if (string.IsNullOrEmpty(BaseInfo.CVTStr(txtTableName.Text.Trim())))
                {
                    MsgBox.Warning("表名不能为空！");
                    BaseInfo.Focus(txtTableName);
                    return;
                }
                if (txtClassID.Enabled)
                {
                    string sqlStr = string.Format("insert into ModelMain(ClassID,ClassName,TableName,Creater,CreateTime,Updater,UpdateTime) values('{0}','{1}','{2}','{3}',getdate(),'{3}',getdate())",
                   BaseInfo.CVTStr(txtClassID.Text.Trim()),
                   BaseInfo.CVTStr(txtClassName.Text.Trim()),
                   BaseInfo.CVTStr(txtTableName.Text.Trim()),
                   SystemInfo.UserName);
                    if (SqlHelper.ExecuteNonQuery(sqlStr) > 0)
                        MsgBox.Information("保存成功。");
                    else
                        MsgBox.Warning("保存失败！。");
                }
                else
                {
                    string sqlStr = string.Format("update ModelMain set ClassName= '{1}',TableName = '{2}',Updater='{3}',UpdateTime=getdate() where ClassID='{0}'",
                   BaseInfo.CVTStr(txtClassID.Text.Trim()),
                   BaseInfo.CVTStr(txtClassName.Text.Trim()),
                   BaseInfo.CVTStr(txtTableName.Text.Trim()),
                  SystemInfo.UserName);
                    if (SqlHelper.ExecuteNonQuery(sqlStr) > 0)
                        MsgBox.Information("保存成功。");
                    else
                        MsgBox.Warning("保存失败！。");
                }
                if (ckSaveType.Checked)
                {
                    ClearTxt();
                }
                else
                    this.Close();
            }
            catch (Exception ex)
            {

                MsgBox.Error(string.Format("发生错误：{0}",ex.Message));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearTxt()
        {
            txtClassID.Text = "";
            txtClassName.Text = "";
            txtTableName.Text = "";
            BaseInfo.Focus(txtClassID);
        }
    }
}
