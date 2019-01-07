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
    public partial class frmMain : Form
    {
        private frmLogin _frmlogin;
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(frmLogin frm,string title)
        {
            InitializeComponent();
            _frmlogin = frm;
            _frmlogin.Hide();
            this.Text = title;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("当前用户：{0}   日期：{1}", SystemInfo.UserName,DateTime.Now.ToShortDateString());
            BindGrid();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmlogin.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            DataTable dt = SqlHelper.ExecuteDataTable(string.Format("select ClassID,ClassName,TableName,Creater,CreateTime,Updater,UpdateTime from ModelMain where ClassID like '%{0}%' or ClassName like '%{0}%' or TableName like '%{0}%'", txtSearch.Text.Trim().Replace("'", "")));
            dataGridView1.DataSource = dt;
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            frmNew frm = new frmNew("","","");
            frm.ShowDialog();
            BindGrid();
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.ShowDialog();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            DataGridViewRow dgvr = dataGridView1.CurrentRow;
            string ClassID = dgvr.Cells["ClassID"].Value.ToString();
            string ClassName = dgvr.Cells["ClassName"].Value.ToString();
            string TableName = dgvr.Cells["TableName"].Value.ToString();

            frmNew frm = new frmNew(ClassID, ClassName, TableName);
            frm.ShowDialog();
            BindGrid();
        }

        private void cmsNew_Click(object sender, EventArgs e)
        {
            tsmAdd_Click(sender, null);
        }

        private void cmsEidt_Click(object sender, EventArgs e)
        {
            dataGridView1_MouseDoubleClick(sender, null);
        }

        private void cmsDel_Click(object sender, EventArgs e)
        {
            if(MsgBox.Question("确定要删除选中的信息吗？")==DialogResult.Yes)
            {
                string ClassIDs = string.Empty;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if(BaseInfo.CVTBool( item.Cells["ColCheck"].EditedFormattedValue))
                    {
                        ClassIDs += string.Format("'{0}',", item.Cells["ClassID"].Value);
                    }
                }
                if (!string.IsNullOrEmpty(ClassIDs))
                {
                    string sqlStr = string.Format("delete from ModelMain where ClassID in({0});delete from ModelDetailed where ClassID in({0})", ClassIDs.TrimEnd(','));
                    if (SqlHelper.ExecuteNonQuery(sqlStr) > 0)
                        MsgBox.Information("删除成功。");
                    else
                        MsgBox.Warning("删除失败！。");
                    BindGrid();
                }
                else
                    MsgBox.Warning("没有选择要删除的记录！");
            }
        }

        private void cmsSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells["ColCheck"].Value = true;
            }
        }

        private void cmsSelectNull_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells["ColCheck"].Value = false;
            }
        }

        private void cmsAddDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            DataGridViewRow dgvr = dataGridView1.CurrentRow;
            frmDetailList frm = new frmDetailList(dgvr.Cells["ClassID"].Value.ToString());
            frm.ShowDialog();
        }

        private void cmsBuildEntity_Click(object sender, EventArgs e)
        {

        }
    }
}
