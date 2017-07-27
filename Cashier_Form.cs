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
    public partial class Cashier_Form : Form
    {
        public Cashier_Form()
        {
            InitializeComponent();
        }

        private void Cashier_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_enterinstrument_Click(object sender, EventArgs e)
        {

        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            UControl_VPatient viewpatient = new UControl_VPatient();
            eh_cashier.Child = viewpatient;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_medicine_Click(object sender, EventArgs e)
        {
            UControl_AllMedicines allmedicines = new UControl_AllMedicines();
            eh_cashier.Child = allmedicines;
        }

        private void btn_instrument_Click(object sender, EventArgs e)
        {
            UControl_AllInstruments allinstruments = new UControl_AllInstruments();
            eh_cashier.Child = allinstruments;
        }

        private void btn_bed_Click(object sender, EventArgs e)
        {
            UControl_AllBed allbed = new UControl_AllBed();
            eh_cashier.Child = allbed;
        }
    }
}
