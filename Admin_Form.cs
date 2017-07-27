using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_UserControls;
using System.Windows.Forms.Integration;
namespace Hospital_Management_System
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
             
        }

      

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            UControl_User uc_user = new UControl_User();
            eh_admin.Child = uc_user;
        }
        private void btn_patient_Click(object sender, EventArgs e)
        {
            UControl_VPatient viewpatient = new UControl_VPatient();
            eh_admin.Child = viewpatient;
        }

        private void lbl_enterpassword_Click(object sender, EventArgs e)
        {

        }

        private void eh_admin_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }
    }
}
