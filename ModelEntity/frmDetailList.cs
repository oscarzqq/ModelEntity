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
    public partial class frmDetailList : Form
    {
        private string _ClassID;
        public frmDetailList()
        {
            InitializeComponent();
        }

        public frmDetailList(string classid)
        {
            InitializeComponent();
            _ClassID = classid;
        }

        private void frmDetailList_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            DataTable dt = SqlHelper.ExecuteDataTable(string.Format("select * from ModelDetailed where ClassID = '{0}' ", _ClassID));
            dataGridView1.DataSource = dt;
        }

        private void cmsNew_Click(object sender, EventArgs e)
        {
            frmDetailEidt frm = new frmDetailEidt(_ClassID);
            frm.ShowDialog();
            BindGrid();
        }

        private void cmsEidt_Click(object sender, EventArgs e)
        {

        }

        private void cmsDel_Click(object sender, EventArgs e)
        {

        }
    }
}
