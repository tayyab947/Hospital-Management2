namespace Hospital_Management_System
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.lbl_adminportal = new System.Windows.Forms.Label();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.panel_search = new System.Windows.Forms.Panel();
            this.rdbutton_patient = new System.Windows.Forms.RadioButton();
            this.rdbutton_room = new System.Windows.Forms.RadioButton();
            this.rdbutton_instrument = new System.Windows.Forms.RadioButton();
            this.rdbutton_medicine = new System.Windows.Forms.RadioButton();
            this.rdbutton_user = new System.Windows.Forms.RadioButton();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_enterid = new System.Windows.Forms.Label();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_patient = new System.Windows.Forms.Button();
            this.btn_medicine = new System.Windows.Forms.Button();
            this.btn_instrument = new System.Windows.Forms.Button();
            this.btn_bed = new System.Windows.Forms.Button();
            this.btn_Floor = new System.Windows.Forms.Button();
            this.btn_room = new System.Windows.Forms.Button();
            this.btn_block = new System.Windows.Forms.Button();
            this.lnklbl_hospitalinfo = new System.Windows.Forms.LinkLabel();
            this.lnkbl_personalinfo = new System.Windows.Forms.LinkLabel();
            this.eh_admin = new System.Windows.Forms.Integration.ElementHost();
            this.panel_search.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
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
            this.btn_minimize.TabIndex = 12;
            this.btn_minimize.Text = "-";
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // lbl_adminportal
            // 
            this.lbl_adminportal.AutoSize = true;
            this.lbl_adminportal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adminportal.Font = new System.Drawing.Font("Modern No. 20", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminportal.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_adminportal.Location = new System.Drawing.Point(507, 23);
            this.lbl_adminportal.Name = "lbl_adminportal";
            this.lbl_adminportal.Size = new System.Drawing.Size(171, 30);
            this.lbl_adminportal.TabIndex = 13;
            this.lbl_adminportal.Text = "Admin Portal";
            // 
            // txtbox_search
            // 
            this.txtbox_search.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_search.Location = new System.Drawing.Point(132, 14);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(342, 24);
            this.txtbox_search.TabIndex = 14;
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.Transparent;
            this.panel_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_search.Controls.Add(this.rdbutton_patient);
            this.panel_search.Controls.Add(this.rdbutton_room);
            this.panel_search.Controls.Add(this.rdbutton_instrument);
            this.panel_search.Controls.Add(this.rdbutton_medicine);
            this.panel_search.Controls.Add(this.rdbutton_user);
            this.panel_search.Controls.Add(this.lbl_filter);
            this.panel_search.Controls.Add(this.btn_search);
            this.panel_search.Controls.Add(this.lbl_enterid);
            this.panel_search.Controls.Add(this.txtbox_search);
            this.panel_search.Location = new System.Drawing.Point(287, 75);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(611, 102);
            this.panel_search.TabIndex = 15;
            // 
            // rdbutton_patient
            // 
            this.rdbutton_patient.AutoSize = true;
            this.rdbutton_patient.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbutton_patient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbutton_patient.Location = new System.Drawing.Point(490, 64);
            this.rdbutton_patient.Name = "rdbutton_patient";
            this.rdbutton_patient.Size = new System.Drawing.Size(78, 20);
            this.rdbutton_patient.TabIndex = 22;
            this.rdbutton_patient.TabStop = true;
            this.rdbutton_patient.Text = "Patient";
            this.rdbutton_patient.UseVisualStyleBackColor = true;
            // 
            // rdbutton_room
            // 
            this.rdbutton_room.AutoSize = true;
            this.rdbutton_room.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbutton_room.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbutton_room.Location = new System.Drawing.Point(406, 64);
            this.rdbutton_room.Name = "rdbutton_room";
            this.rdbutton_room.Size = new System.Drawing.Size(69, 20);
            this.rdbutton_room.TabIndex = 21;
            this.rdbutton_room.TabStop = true;
            this.rdbutton_room.Text = "Room";
            this.rdbutton_room.UseVisualStyleBackColor = true;
            // 
            // rdbutton_instrument
            // 
            this.rdbutton_instrument.AutoSize = true;
            this.rdbutton_instrument.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbutton_instrument.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbutton_instrument.Location = new System.Drawing.Point(278, 64);
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
            this.rdbutton_medicine.Location = new System.Drawing.Point(171, 64);
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
            this.rdbutton_user.Location = new System.Drawing.Point(97, 64);
            this.rdbutton_user.Name = "rdbutton_user";
            this.rdbutton_user.Size = new System.Drawing.Size(59, 20);
            this.rdbutton_user.TabIndex = 18;
            this.rdbutton_user.TabStop = true;
            this.rdbutton_user.Text = "User";
            this.rdbutton_user.UseVisualStyleBackColor = true;
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
            // lbl_enterid
            // 
            this.lbl_enterid.AutoSize = true;
            this.lbl_enterid.BackColor = System.Drawing.Color.Transparent;
            this.lbl_enterid.Font = new System.Drawing.Font("Footlight MT Light", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterid.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_enterid.Location = new System.Drawing.Point(12, 15);
            this.lbl_enterid.Name = "lbl_enterid";
            this.lbl_enterid.Size = new System.Drawing.Size(84, 20);
            this.lbl_enterid.TabIndex = 15;
            this.lbl_enterid.Text = "Enter Id :";
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.Transparent;
            this.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_user.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_user.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_user.Location = new System.Drawing.Point(12, 239);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(109, 45);
            this.btn_user.TabIndex = 17;
            this.btn_user.Text = "User";
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
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
            this.btn_patient.Location = new System.Drawing.Point(12, 309);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(109, 45);
            this.btn_patient.TabIndex = 18;
            this.btn_patient.Text = "Patient";
            this.btn_patient.UseVisualStyleBackColor = false;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
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
            this.btn_medicine.Location = new System.Drawing.Point(12, 379);
            this.btn_medicine.Name = "btn_medicine";
            this.btn_medicine.Size = new System.Drawing.Size(109, 45);
            this.btn_medicine.TabIndex = 19;
            this.btn_medicine.Text = "Medicine";
            this.btn_medicine.UseVisualStyleBackColor = false;
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
            this.btn_instrument.Location = new System.Drawing.Point(12, 449);
            this.btn_instrument.Name = "btn_instrument";
            this.btn_instrument.Size = new System.Drawing.Size(109, 45);
            this.btn_instrument.TabIndex = 20;
            this.btn_instrument.Text = "Instrument";
            this.btn_instrument.UseVisualStyleBackColor = false;
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
            this.btn_bed.Location = new System.Drawing.Point(1068, 459);
            this.btn_bed.Name = "btn_bed";
            this.btn_bed.Size = new System.Drawing.Size(109, 45);
            this.btn_bed.TabIndex = 24;
            this.btn_bed.Text = "Bed";
            this.btn_bed.UseVisualStyleBackColor = false;
            // 
            // btn_Floor
            // 
            this.btn_Floor.BackColor = System.Drawing.Color.Transparent;
            this.btn_Floor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Floor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Floor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Floor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Floor.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Floor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Floor.Location = new System.Drawing.Point(1068, 319);
            this.btn_Floor.Name = "btn_Floor";
            this.btn_Floor.Size = new System.Drawing.Size(109, 45);
            this.btn_Floor.TabIndex = 23;
            this.btn_Floor.Text = "Floor";
            this.btn_Floor.UseVisualStyleBackColor = false;
            // 
            // btn_room
            // 
            this.btn_room.BackColor = System.Drawing.Color.Transparent;
            this.btn_room.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_room.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_room.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_room.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_room.Location = new System.Drawing.Point(1068, 389);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(109, 45);
            this.btn_room.TabIndex = 22;
            this.btn_room.Text = "Room";
            this.btn_room.UseVisualStyleBackColor = false;
            // 
            // btn_block
            // 
            this.btn_block.BackColor = System.Drawing.Color.Transparent;
            this.btn_block.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_block.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_block.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_block.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_block.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_block.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_block.Location = new System.Drawing.Point(1068, 249);
            this.btn_block.Name = "btn_block";
            this.btn_block.Size = new System.Drawing.Size(109, 45);
            this.btn_block.TabIndex = 21;
            this.btn_block.Text = "Block";
            this.btn_block.UseVisualStyleBackColor = false;
            // 
            // lnklbl_hospitalinfo
            // 
            this.lnklbl_hospitalinfo.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.lnklbl_hospitalinfo.AutoSize = true;
            this.lnklbl_hospitalinfo.BackColor = System.Drawing.Color.Transparent;
            this.lnklbl_hospitalinfo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklbl_hospitalinfo.LinkColor = System.Drawing.Color.Tomato;
            this.lnklbl_hospitalinfo.Location = new System.Drawing.Point(283, 51);
            this.lnklbl_hospitalinfo.Name = "lnklbl_hospitalinfo";
            this.lnklbl_hospitalinfo.Size = new System.Drawing.Size(116, 21);
            this.lnklbl_hospitalinfo.TabIndex = 27;
            this.lnklbl_hospitalinfo.TabStop = true;
            this.lnklbl_hospitalinfo.Text = "Hospital Info";
            // 
            // lnkbl_personalinfo
            // 
            this.lnkbl_personalinfo.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.lnkbl_personalinfo.AutoSize = true;
            this.lnkbl_personalinfo.BackColor = System.Drawing.Color.Transparent;
            this.lnkbl_personalinfo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkbl_personalinfo.LinkColor = System.Drawing.Color.Tomato;
            this.lnkbl_personalinfo.Location = new System.Drawing.Point(781, 51);
            this.lnkbl_personalinfo.Name = "lnkbl_personalinfo";
            this.lnkbl_personalinfo.Size = new System.Drawing.Size(117, 21);
            this.lnkbl_personalinfo.TabIndex = 28;
            this.lnkbl_personalinfo.TabStop = true;
            this.lnkbl_personalinfo.Text = "Personal Info";
            // 
            // eh_admin
            // 
            this.eh_admin.BackColor = System.Drawing.Color.Transparent;
            this.eh_admin.BackColorTransparent = true;
            this.eh_admin.Location = new System.Drawing.Point(152, 204);
            this.eh_admin.Name = "eh_admin";
            this.eh_admin.Size = new System.Drawing.Size(894, 381);
            this.eh_admin.TabIndex = 29;
            this.eh_admin.Text = "elementHost1";
            this.eh_admin.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.eh_admin_ChildChanged);
            this.eh_admin.Child = null;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 592);
            this.Controls.Add(this.eh_admin);
            this.Controls.Add(this.lnkbl_personalinfo);
            this.Controls.Add(this.lnklbl_hospitalinfo);
            this.Controls.Add(this.btn_bed);
            this.Controls.Add(this.btn_Floor);
            this.Controls.Add(this.btn_room);
            this.Controls.Add(this.btn_block);
            this.Controls.Add(this.btn_instrument);
            this.Controls.Add(this.btn_medicine);
            this.Controls.Add(this.btn_patient);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.panel_search);
            this.Controls.Add(this.lbl_adminportal);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label lbl_adminportal;
        private System.Windows.Forms.TextBox txtbox_search;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.Label lbl_enterid;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.RadioButton rdbutton_room;
        private System.Windows.Forms.RadioButton rdbutton_instrument;
        private System.Windows.Forms.RadioButton rdbutton_medicine;
        private System.Windows.Forms.RadioButton rdbutton_user;
        private System.Windows.Forms.RadioButton rdbutton_patient;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_patient;
        private System.Windows.Forms.Button btn_medicine;
        private System.Windows.Forms.Button btn_instrument;
        private System.Windows.Forms.Button btn_bed;
        private System.Windows.Forms.Button btn_Floor;
        private System.Windows.Forms.Button btn_room;
        private System.Windows.Forms.Button btn_block;
        private System.Windows.Forms.LinkLabel lnklbl_hospitalinfo;
        private System.Windows.Forms.LinkLabel lnkbl_personalinfo;
        private System.Windows.Forms.Integration.ElementHost eh_admin;
    }
}