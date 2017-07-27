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
namespace Hospital_Management_System
{
    public partial class Clerk_Form : Form
    {
        public Clerk_Form()
        {
            InitializeComponent();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {

        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            UControl_CPatient editpatient = new UControl_CPatient();
            eh_clerk.Child = editpatient;
        }

        private void eh_clerk_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_medicine_Click(object sender, EventArgs e)
        {
            UControl_AllMedicines allmedicines = new UControl_AllMedicines();
            eh_clerk.Child = allmedicines; 
        }

        private void btn_instrument_Click(object sender, EventArgs e)
        {

            UControl_AllInstruments allinstruments = new UControl_AllInstruments();
            eh_clerk.Child = allinstruments; 
        }
    }
}
