using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelSYS
{
    public partial class frmRoomMenu : Form
    {
        public frmRoomMenu()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtTypeCode.Text.Equals("")) {

                MessageBox.Show("Type Code must be entered",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTypeCode.Focus();
                return;
            }
            else if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Description must be entered",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }
            else if (txtRate.Text.Equals(""))
            {
                MessageBox.Show("Rate must be entered",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                return;
            }
            else
            {
                MessageBox.Show("New data were added to DataBase",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTypeCode.Clear();
                txtDescription.Clear();
                txtRate.Clear();
            }
        }
    }
}
