using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelSYS
{
    public partial class frmUpdRoomType : Form
    {
        public frmUpdRoomType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdRoomType_Load(object sender, EventArgs e)
        {

        }

        private void cboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoomType.SelectedIndex == -1)
                return;

            txtTypeCode.Text = "DB";
            txtDescription.Text = "Double Room";
            txtRate.Text = "85.00";
            grpRoomType.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details updated", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);

            cboRoomType.SelectedIndex = -1;
            grpRoomType.Visible = false; 
        }
    }
}
