namespace Hospital_Management_System
{
    partial class Clerk_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clerk_Form));
            this.llbl_hospitalinfo = new System.Windows.Forms.LinkLabel();
            this.btn_instrument = new System.Windows.Forms.Button();
            this.btn_medicine = new System.Windows.Forms.Button();
            this.rdbutton_block = new System.Windows.Forms.RadioButton();
            this.rdbutton_instrument = new System.Windows.Forms.RadioButton();
            this.rdbutton_medicine = new System.Windows.Forms.RadioButton();
            this.rdbutton_user = new System.Windows.Forms.RadioButton();
            this.btn_patient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.rdbutton_patient = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.lbl_clerkportal = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.llbl_personalinfo = new System.Windows.Forms.LinkLabel();
            this.eh_clerk = new System.Windows.Forms.Integration.ElementHost();
            this.btn_assignroom = new System.Windows.Forms.Button();
            this.btn_availablerooms = new System.Windows.Forms.Button();
            this.pnl_search.SuspendLayout();
            this.SuspendLayout();
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
            this.llbl_hospitalinfo.TabIndex = 41;
            this.llbl_hospitalinfo.TabStop = true;
            this.llbl_hospitalinfo.Text = "Hospital Info";
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
            this.btn_instrument.Location = new System.Drawing.Point(12, 415);
            this.btn_instrument.Name = "btn_instrument";
            this.btn_instrument.Size = new System.Drawing.Size(109, 45);
            this.btn_instrument.TabIndex = 36;
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
            this.btn_medicine.Location = new System.Drawing.Point(12, 358);
            this.btn_medicine.Name = "btn_medicine";
            this.btn_medicine.Size = new System.Drawing.Size(109, 45);
            this.btn_medicine.TabIndex = 35;
            this.btn_medicine.Text = "Medicine";
            this.btn_medicine.UseVisualStyleBackColor = false;
            this.btn_medicine.Click += new System.EventHandler(this.btn_medicine_Click);
            // 
            // rdbutton_block
            // 
            this.rdbutton_block.AutoSize = true;
            this.rdbutton_block.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbutton_block.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbutton_block.Location = new System.Drawing.Point(416, 61);
            this.rdbutton_block.Name = "rdbutton_block";
            this.rdbutton_block.Size = new System.Drawing.Size(67, 20);
            this.rdbutton_block.TabIndex = 21;
            this.rdbutton_block.TabStop = true;
            this.rdbutton_block.Text = "Block";
            this.rdbutton_block.UseVisualStyleBackColor = true;
            // 
            // rdbutton_instrument
            // 
            this.rdbutton_instrument.AutoSize = true;
            this.rdbutton_instrument.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbutton_instrument.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbutton_instrument.Location = new System.Drawing.Point(288, 61);
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
            this.rdbutton_medicine.Location = new System.Drawing.Point(181, 61);
            this.rdbutton_medicine.Name = "rdbutton_medicine";
            this.rdbutton_medicine.Size = new System.Drawing.Size(93, 20);
            this.rdbutton_medicine.TabIndex = 19;
            this.rdbutton_medicine.TabStop = true;
            this.rdbutton_medicine.Text = "Medicine";
            this.rdbutton_medicine.UseVisualStyleBackColor = true;
            // 
            // rdbutton_user
            // 
            this.rdbutton_user.AutoSize = true;
            this.rdbutton_user.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbutton_user.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbutton_user.Location = new System.Drawing.Point(107, 61);
            this.rdbutton_user.Name = "rdbutton_user";
            this.rdbutton_user.Size = new System.Drawing.Size(59, 20);
            this.rdbutton_user.TabIndex = 18;
            this.rdbutton_user.TabStop = true;
            this.rdbutton_user.Text = "User";
            this.rdbutton_user.UseVisualStyleBackColor = true;
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
            this.btn_patient.Location = new System.Drawing.Point(12, 301);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(109, 45);
            this.btn_patient.TabIndex = 34;
            this.btn_patient.Text = "Patient";
            this.btn_patient.UseVisualStyleBackColor = false;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filters  :";
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
            // pnl_search
            // 
            this.pnl_search.BackColor = System.Drawing.Color.Transparent;
            this.pnl_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_search.Controls.Add(this.rdbutton_patient);
            this.pnl_search.Controls.Add(this.rdbutton_block);
            this.pnl_search.Controls.Add(this.rdbutton_instrument);
            this.pnl_search.Controls.Add(this.rdbutton_medicine);
            this.pnl_search.Controls.Add(this.rdbutton_user);
            this.pnl_search.Controls.Add(this.label2);
            this.pnl_search.Controls.Add(this.btn_search);
            this.pnl_search.Controls.Add(this.label1);
            this.pnl_search.Controls.Add(this.txtbox_search);
            this.pnl_search.Location = new System.Drawing.Point(287, 75);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(611, 102);
            this.pnl_search.TabIndex = 32;
            // 
            // rdbutton_patient
            // 
            this.rdbutton_patient.AutoSize = true;
            this.rdbutton_patient.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbutton_patient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbutton_patient.Location = new System.Drawing.Point(500, 61);
            this.rdbutton_patient.Name = "rdbutton_patient";
            this.rdbutton_patient.Size = new System.Drawing.Size(78, 20);
            this.rdbutton_patient.TabIndex = 22;
            this.rdbutton_patient.TabStop = true;
            this.rdbutton_patient.Text = "Patient";
            this.rdbutton_patient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter Id :";
            // 
            // txtbox_search
            // 
            this.txtbox_search.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_search.Location = new System.Drawing.Point(132, 14);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(342, 24);
            this.txtbox_search.TabIndex = 14;
            // 
            // lbl_clerkportal
            // 
            this.lbl_clerkportal.AutoSize = true;
            this.lbl_clerkportal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clerkportal.Font = new System.Drawing.Font("Modern No. 20", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clerkportal.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_clerkportal.Location = new System.Drawing.Point(507, 23);
            this.lbl_clerkportal.Name = "lbl_clerkportal";
            this.lbl_clerkportal.Size = new System.Drawing.Size(154, 30);
            this.lbl_clerkportal.TabIndex = 31;
            this.lbl_clerkportal.Text = "Clerk Portal";
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
            this.btn_minimize.TabIndex = 30;
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
            this.btn_close.TabIndex = 29;
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
            this.llbl_personalinfo.TabIndex = 42;
            this.llbl_personalinfo.TabStop = true;
            this.llbl_personalinfo.Text = "Personal Info";
            // 
            // eh_clerk
            // 
            this.eh_clerk.BackColor = System.Drawing.Color.Transparent;
            this.eh_clerk.BackColorTransparent = true;
            this.eh_clerk.Location = new System.Drawing.Point(152, 204);
            this.eh_clerk.Name = "eh_clerk";
            this.eh_clerk.Size = new System.Drawing.Size(894, 381);
            this.eh_clerk.TabIndex = 48;
            this.eh_clerk.Text = "elementHost1";
            this.eh_clerk.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.eh_clerk_ChildChanged);
            this.eh_clerk.Child = null;
            // 
            // btn_assignroom
            // 
            this.btn_assignroom.BackColor = System.Drawing.Color.Transparent;
            this.btn_assignroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_assignroom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_assignroom.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_assignroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assignroom.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assignroom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_assignroom.Location = new System.Drawing.Point(1070, 293);
            this.btn_assignroom.Name = "btn_assignroom";
            this.btn_assignroom.Size = new System.Drawing.Size(118, 60);
            this.btn_assignroom.TabIndex = 60;
            this.btn_assignroom.Text = "Assign Room";
            this.btn_assignroom.UseVisualStyleBackColor = false;
            // 
            // btn_availablerooms
            // 
            this.btn_availablerooms.BackColor = System.Drawing.Color.Transparent;
            this.btn_availablerooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_availablerooms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_availablerooms.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_availablerooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_availablerooms.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_availablerooms.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_availablerooms.Location = new System.Drawing.Point(1070, 380);
            this.btn_availablerooms.Name = "btn_availablerooms";
            this.btn_availablerooms.Size = new System.Drawing.Size(118, 60);
            this.btn_availablerooms.TabIndex = 59;
            this.btn_availablerooms.Text = "Available Rooms";
            this.btn_availablerooms.UseVisualStyleBackColor = false;
            // 
            // Clerk_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 592);
            this.Controls.Add(this.btn_assignroom);
            this.Controls.Add(this.btn_availablerooms);
            this.Controls.Add(this.eh_clerk);
            this.Controls.Add(this.llbl_hospitalinfo);
            this.Controls.Add(this.btn_instrument);
            this.Controls.Add(this.btn_medicine);
            this.Controls.Add(this.btn_patient);
            this.Controls.Add(this.pnl_search);
            this.Controls.Add(this.lbl_clerkportal);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.llbl_personalinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clerk_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Form";
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbl_hospitalinfo;
        private System.Windows.Forms.Button btn_instrument;
        private System.Windows.Forms.Button btn_medicine;
        private System.Windows.Forms.RadioButton rdbutton_block;
        private System.Windows.Forms.RadioButton rdbutton_instrument;
        private System.Windows.Forms.RadioButton rdbutton_medicine;
        private System.Windows.Forms.RadioButton rdbutton_user;
        private System.Windows.Forms.Button btn_patient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_search;
        private System.Windows.Forms.Label lbl_clerkportal;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.LinkLabel llbl_personalinfo;
        private System.Windows.Forms.RadioButton rdbutton_patient;
        private System.Windows.Forms.Integration.ElementHost eh_clerk;
        private System.Windows.Forms.Button btn_assignroom;
        private System.Windows.Forms.Button btn_availablerooms;


    }
}