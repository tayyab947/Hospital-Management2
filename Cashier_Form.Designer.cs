namespace Hospital_Management_System
{
    partial class Cashier_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier_Form));
            this.btn_bed = new System.Windows.Forms.Button();
            this.rdbutton_patient = new System.Windows.Forms.RadioButton();
            this.lnl_enterid = new System.Windows.Forms.Label();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.llbl_hospitalinfo = new System.Windows.Forms.LinkLabel();
            this.btn_patient = new System.Windows.Forms.Button();
            this.rdbutton_instrument = new System.Windows.Forms.RadioButton();
            this.rdbutton_medicine = new System.Windows.Forms.RadioButton();
            this.lbl_cashierportal = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.llbl_personalinfo = new System.Windows.Forms.LinkLabel();
            this.rdbutton_bed = new System.Windows.Forms.RadioButton();
            this.btn_instrument = new System.Windows.Forms.Button();
            this.btn_medicine = new System.Windows.Forms.Button();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.eh_cashier = new System.Windows.Forms.Integration.ElementHost();
            this.btn_entercharges = new System.Windows.Forms.Button();
            this.btn_enterinstrument = new System.Windows.Forms.Button();
            this.pnl_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_bed
            // 
            this.btn_bed.BackColor = System.Drawing.Color.Transparent;
            this.btn_bed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_bed.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_bed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bed.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_bed.Location = new System.Drawing.Point(12, 437);
            this.btn_bed.Name = "btn_bed";
            this.btn_bed.Size = new System.Drawing.Size(109, 45);
            this.btn_bed.TabIndex = 58;
            this.btn_bed.Text = "Bed";
            this.btn_bed.UseVisualStyleBackColor = false;
            this.btn_bed.Click += new System.EventHandler(this.btn_bed_Click);
            // 
            // rdbutton_patient
            // 
            this.rdbutton_patient.AutoSize = true;
            this.rdbutton_patient.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbutton_patient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbutton_patient.Location = new System.Drawing.Point(441, 61);
            this.rdbutton_patient.Name = "rdbutton_patient";
            this.rdbutton_patient.Size = new System.Drawing.Size(78, 20);
            this.rdbutton_patient.TabIndex = 22;
            this.rdbutton_patient.TabStop = true;
            this.rdbutton_patient.Text = "Patient";
            this.rdbutton_patient.UseVisualStyleBackColor = true;
            // 
            // lnl_enterid
            // 
            this.lnl_enterid.AutoSize = true;
            this.lnl_enterid.BackColor = System.Drawing.Color.Transparent;
            this.lnl_enterid.Font = new System.Drawing.Font("Footlight MT Light", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnl_enterid.ForeColor = System.Drawing.SystemColors.Menu;
            this.lnl_enterid.Location = new System.Drawing.Point(12, 15);
            this.lnl_enterid.Name = "lnl_enterid";
            this.lnl_enterid.Size = new System.Drawing.Size(84, 20);
            this.lnl_enterid.TabIndex = 15;
            this.lnl_enterid.Text = "Enter Id :";
            // 
            // txtbox_search
            // 
            this.txtbox_search.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_search.Location = new System.Drawing.Point(132, 14);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(342, 24);
            this.txtbox_search.TabIndex = 14;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.Location = new System.Drawing.Point(490, 9);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(89, 31);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // llbl_hospitalinfo
            // 
            this.llbl_hospitalinfo.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.llbl_hospitalinfo.AutoSize = true;
            this.llbl_hospitalinfo.BackColor = System.Drawing.Color.Transparent;
            this.llbl_hospitalinfo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_hospitalinfo.LinkColor = System.Drawing.Color.White;
            this.llbl_hospitalinfo.Location = new System.Drawing.Point(283, 51);
            this.llbl_hospitalinfo.Name = "llbl_hospitalinfo";
            this.llbl_hospitalinfo.Size = new System.Drawing.Size(116, 21);
            this.llbl_hospitalinfo.TabIndex = 54;
            this.llbl_hospitalinfo.TabStop = true;
            this.llbl_hospitalinfo.Text = "Hospital Info";
            // 
            // btn_patient
            // 
            this.btn_patient.BackColor = System.Drawing.Color.Transparent;
            this.btn_patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_patient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_patient.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_patient.Location = new System.Drawing.Point(12, 239);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(109, 45);
            this.btn_patient.TabIndex = 51;
            this.btn_patient.Text = "Patient";
            this.btn_patient.UseVisualStyleBackColor = false;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
            // 
            // rdbutton_instrument
            // 
            this.rdbutton_instrument.AutoSize = true;
            this.rdbutton_instrument.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbutton_instrument.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbutton_instrument.Location = new System.Drawing.Point(229, 61);
            this.rdbutton_instrument.Name = "rdbutton_instrument";
            this.rdbutton_instrument.Size = new System.Drawing.Size(112, 20);
            this.rdbutton_instrument.TabIndex = 20;
            this.rdbutton_instrument.TabStop = true;
            this.rdbutton_instrument.Text = "Instrument";
            this.rdbutton_instrument.UseVisualStyleBackColor = true;
            // 
            // rdbutton_medicine
            // 
            this.rdbutton_medicine.AutoSize = true;
            this.rdbutton_medicine.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbutton_medicine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbutton_medicine.Location = new System.Drawing.Point(122, 61);
            this.rdbutton_medicine.Name = "rdbutton_medicine";
            this.rdbutton_medicine.Size = new System.Drawing.Size(93, 20);
            this.rdbutton_medicine.TabIndex = 19;
            this.rdbutton_medicine.TabStop = true;
            this.rdbutton_medicine.Text = "Medicine";
            this.rdbutton_medicine.UseVisualStyleBackColor = true;
            // 
            // lbl_cashierportal
            // 
            this.lbl_cashierportal.AutoSize = true;
            this.lbl_cashierportal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cashierportal.Font = new System.Drawing.Font("Modern No. 20", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cashierportal.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_cashierportal.Location = new System.Drawing.Point(507, 23);
            this.lbl_cashierportal.Name = "lbl_cashierportal";
            this.lbl_cashierportal.Size = new System.Drawing.Size(178, 30);
            this.lbl_cashierportal.TabIndex = 49;
            this.lbl_cashierportal.Text = "Cashier Portal";
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Modern No. 20", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(1100, 12);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(41, 28);
            this.btn_minimize.TabIndex = 48;
            this.btn_minimize.Text = "-";
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimize.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1147, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(41, 28);
            this.btn_close.TabIndex = 47;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // llbl_personalinfo
            // 
            this.llbl_personalinfo.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.llbl_personalinfo.AutoSize = true;
            this.llbl_personalinfo.BackColor = System.Drawing.Color.Transparent;
            this.llbl_personalinfo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_personalinfo.LinkColor = System.Drawing.Color.White;
            this.llbl_personalinfo.Location = new System.Drawing.Point(781, 51);
            this.llbl_personalinfo.Name = "llbl_personalinfo";
            this.llbl_personalinfo.Size = new System.Drawing.Size(117, 21);
            this.llbl_personalinfo.TabIndex = 55;
            this.llbl_personalinfo.TabStop = true;
            this.llbl_personalinfo.Text = "Personal Info";
            // 
            // rdbutton_bed
            // 
            this.rdbutton_bed.AutoSize = true;
            this.rdbutton_bed.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbutton_bed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbutton_bed.Location = new System.Drawing.Point(357, 61);
            this.rdbutton_bed.Name = "rdbutton_bed";
            this.rdbutton_bed.Size = new System.Drawing.Size(53, 20);
            this.rdbutton_bed.TabIndex = 21;
            this.rdbutton_bed.TabStop = true;
            this.rdbutton_bed.Text = "Bed";
            this.rdbutton_bed.UseVisualStyleBackColor = true;
            // 
            // btn_instrument
            // 
            this.btn_instrument.BackColor = System.Drawing.Color.Transparent;
            this.btn_instrument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_instrument.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_instrument.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_instrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_instrument.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instrument.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_instrument.Location = new System.Drawing.Point(12, 371);
            this.btn_instrument.Name = "btn_instrument";
            this.btn_instrument.Size = new System.Drawing.Size(109, 45);
            this.btn_instrument.TabIndex = 53;
            this.btn_instrument.Text = "Instrument";
            this.btn_instrument.UseVisualStyleBackColor = false;
            this.btn_instrument.Click += new System.EventHandler(this.btn_instrument_Click);
            // 
            // btn_medicine
            // 
            this.btn_medicine.BackColor = System.Drawing.Color.Transparent;
            this.btn_medicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_medicine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_medicine.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_medicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medicine.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medicine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_medicine.Location = new System.Drawing.Point(12, 305);
            this.btn_medicine.Name = "btn_medicine";
            this.btn_medicine.Size = new System.Drawing.Size(109, 45);
            this.btn_medicine.TabIndex = 52;
            this.btn_medicine.Text = "Medicine";
            this.btn_medicine.UseVisualStyleBackColor = false;
            this.btn_medicine.Click += new System.EventHandler(this.btn_medicine_Click);
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_filter.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filter.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_filter.Location = new System.Drawing.Point(13, 63);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(59, 18);
            this.lbl_filter.TabIndex = 17;
            this.lbl_filter.Text = "Filters  :";
            // 
            // pnl_search
            // 
            this.pnl_search.BackColor = System.Drawing.Color.Transparent;
            this.pnl_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_search.Controls.Add(this.rdbutton_patient);
            this.pnl_search.Controls.Add(this.rdbutton_bed);
            this.pnl_search.Controls.Add(this.rdbutton_instrument);
            this.pnl_search.Controls.Add(this.rdbutton_medicine);
            this.pnl_search.Controls.Add(this.lbl_filter);
            this.pnl_search.Controls.Add(this.btn_search);
            this.pnl_search.Controls.Add(this.lnl_enterid);
            this.pnl_search.Controls.Add(this.txtbox_search);
            this.pnl_search.Location = new System.Drawing.Point(287, 75);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(611, 102);
            this.pnl_search.TabIndex = 50;
            // 
            // eh_cashier
            // 
            this.eh_cashier.BackColor = System.Drawing.Color.Transparent;
            this.eh_cashier.BackColorTransparent = true;
            this.eh_cashier.Location = new System.Drawing.Point(152, 204);
            this.eh_cashier.Name = "eh_cashier";
            this.eh_cashier.Size = new System.Drawing.Size(894, 381);
            this.eh_cashier.TabIndex = 59;
            this.eh_cashier.Text = "elementHost1";
            this.eh_cashier.Child = null;
            // 
            // btn_entercharges
            // 
            this.btn_entercharges.BackColor = System.Drawing.Color.Transparent;
            this.btn_entercharges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_entercharges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_entercharges.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_entercharges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entercharges.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entercharges.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_entercharges.Location = new System.Drawing.Point(1070, 323);
            this.btn_entercharges.Name = "btn_entercharges";
            this.btn_entercharges.Size = new System.Drawing.Size(118, 60);
            this.btn_entercharges.TabIndex = 61;
            this.btn_entercharges.Text = "Enter Charges";
            this.btn_entercharges.UseVisualStyleBackColor = false;
            // 
            // btn_enterinstrument
            // 
            this.btn_enterinstrument.BackColor = System.Drawing.Color.Transparent;
            this.btn_enterinstrument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enterinstrument.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_enterinstrument.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_enterinstrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enterinstrument.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enterinstrument.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_enterinstrument.Location = new System.Drawing.Point(1070, 410);
            this.btn_enterinstrument.Name = "btn_enterinstrument";
            this.btn_enterinstrument.Size = new System.Drawing.Size(118, 60);
            this.btn_enterinstrument.TabIndex = 60;
            this.btn_enterinstrument.Text = "Update Patient Bill";
            this.btn_enterinstrument.UseVisualStyleBackColor = false;
            this.btn_enterinstrument.Click += new System.EventHandler(this.btn_enterinstrument_Click);
            // 
            // Cashier_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 592);
            this.Controls.Add(this.btn_entercharges);
            this.Controls.Add(this.btn_enterinstrument);
            this.Controls.Add(this.eh_cashier);
            this.Controls.Add(this.btn_bed);
            this.Controls.Add(this.llbl_hospitalinfo);
            this.Controls.Add(this.btn_patient);
            this.Controls.Add(this.lbl_cashierportal);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.llbl_personalinfo);
            this.Controls.Add(this.btn_instrument);
            this.Controls.Add(this.btn_medicine);
            this.Controls.Add(this.pnl_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Form_Load);
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bed;
        private System.Windows.Forms.RadioButton rdbutton_patient;
        private System.Windows.Forms.Label lnl_enterid;
        private System.Windows.Forms.TextBox txtbox_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.LinkLabel llbl_hospitalinfo;
        private System.Windows.Forms.Button btn_patient;
        private System.Windows.Forms.RadioButton rdbutton_instrument;
        private System.Windows.Forms.RadioButton rdbutton_medicine;
        private System.Windows.Forms.Label lbl_cashierportal;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.LinkLabel llbl_personalinfo;
        private System.Windows.Forms.RadioButton rdbutton_bed;
        private System.Windows.Forms.Button btn_instrument;
        private System.Windows.Forms.Button btn_medicine;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.Integration.ElementHost eh_cashier;
        private System.Windows.Forms.Button btn_entercharges;
        private System.Windows.Forms.Button btn_enterinstrument;
    }
}