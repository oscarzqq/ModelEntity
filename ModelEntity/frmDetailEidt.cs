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
    public partial class frmDetailEidt : Form
    {
        private string _ClassID;
        public frmDetailEidt()
        {
            InitializeComponent();
        }

        public frmDetailEidt(string classid)
        {
            InitializeComponent();
            _ClassID = classid;
            cbColType.SelectedIndex = 0;
        }

        private void frmDetailEidt_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = string.Format(@"insert into ModelDetailed(ClassID,ColID,ColName,ColType,ColLenth,ColIsPrimarykey,ColIsNull,Creater,CreateTime,Updater,UpdateTime)
values('{0}','{1}','{2}','{3}',{4},{5},{6},'{7}',getdate(),'{7}',getdate())", _ClassID,BaseInfo.CVTStr(txtColID.Text), BaseInfo.CVTStr(txtColName.Text), BaseInfo.CVTStr(cbColType.Text), BaseInfo.CVTInt(txtColID.Text),ckColIsPrimarykey.CheckState,ckColIsNull.CheckState,SystemInfo.UserName);
                if (SqlHelper.ExecuteNonQuery(sqlStr) > 0)
                    MsgBox.Information("保存成功。");
                else
                    MsgBox.Warning("保存失败！。");
            }
            catch (Exception ex)
            {

                MsgBox.Error(string.Format("发生错误：{0}", ex.Message));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
