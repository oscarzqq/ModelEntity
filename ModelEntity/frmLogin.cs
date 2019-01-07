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
    public partial class frmLogin : Form
    {
        IniFile ini;
        public frmLogin()
        {
            InitializeComponent();
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Parent = pictureBox1;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string file = string.Format("{0}\\sys.ini", System.Environment.CurrentDirectory);
            ini = new IniFile(file);
            txtUserID.Text = ini.IniReadValue("Login", "UserID");
            if (!string.IsNullOrEmpty(txtUserID.Text.Trim()))
            {
                BaseInfo.Focus(txtUsePwd);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text.Trim()))
            {
                MsgBox.Warning("用户名不能为空！");
                return;
            }
            DataTable dt = SqlHelper.ExecuteDataTable(string.Format("select * from UserInfo where UserID='{0}' and UserPwd ='{1}'",txtUserID.Text.Trim().Replace("'",""),txtUsePwd.Text.Trim().Replace("'", "")));
            if(dt==null)
            {
                MsgBox.Warning("连接数据库失败，请联系管理员！");
                return;
            }
            if(dt.Rows.Count>0)
            {
                SystemInfo.UserID = txtUserID.Text.Trim();
                SystemInfo.UserName = BaseInfo.CVTStr(dt.Rows[0]["UserName"]);
                ini.IniWriteValue("Login", "UserID", SystemInfo.UserID);
                
                frmMain frm = new frmMain(this, lbTitle.Text);
                frm.ShowDialog();
            }
            else
            {
                MsgBox.Warning("用户名或密码错误！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
