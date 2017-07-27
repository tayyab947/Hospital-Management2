namespace Hospital_Management_System
{
    partial class Add_User_Form
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
            this.lbl_adduser = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.lbl_enterpassword = new System.Windows.Forms.Label();
            this.txtbox_contactno = new System.Windows.Forms.TextBox();
            this.lbl_entercontactno = new System.Windows.Forms.Label();
            this.txtbox_address = new System.Windows.Forms.TextBox();
            this.lbl_enteraddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_adduser
            // 
            this.lbl_adduser.AutoSize = true;
            this.lbl_adduser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adduser.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adduser.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_adduser.Location = new System.Drawing.Point(140, 23);
            this.lbl_adduser.Name = "lbl_adduser";
            this.lbl_adduser.Size = new System.Drawing.Size(154, 25);
            this.lbl_adduser.TabIndex = 14;
            this.lbl_adduser.Text = "Add New User";
            // 
            // txtbox_password
            // 
            this.txtbox_password.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password.Location = new System.Drawing.Point(197, 229);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(229, 24);
            this.txtbox_password.TabIndex = 22;
            // 
            // lbl_enterpassword
            // 
            this.lbl_enterpassword.AutoSize = true;
            this.lbl_enterpassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_enterpassword.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterpassword.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_enterpassword.Location = new System.Drawing.Point(25, 229);
            this.lbl_enterpassword.Name = "lbl_enterpassword";
            this.lbl_enterpassword.Size = new System.Drawing.Size(132, 21);
            this.lbl_enterpassword.TabIndex = 21;
            this.lbl_enterpassword.Text = "Enter Password :";
            // 
            // txtbox_contactno
            // 
            this.txtbox_contactno.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_contactno.Location = new System.Drawing.Point(197, 274);
            this.txtbox_contactno.Name = "txtbox_contactno";
            this.txtbox_contactno.Size = new System.Drawing.Size(229, 24);
            this.txtbox_contactno.TabIndex = 24;
            // 
            // lbl_entercontactno
            // 
            this.lbl_entercontactno.AutoSize = true;
            this.lbl_entercontactno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_entercontactno.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entercontactno.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_entercontactno.Location = new System.Drawing.Point(25, 274);
            this.lbl_entercontactno.Name = "lbl_entercontactno";
            this.lbl_entercontactno.Size = new System.Drawing.Size(144, 21);
            this.lbl_entercontactno.TabIndex = 23;
            this.lbl_entercontactno.Text = "Enter Contact No :";
            // 
            // txtbox_address
            // 
            this.txtbox_address.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_address.Location = new System.Drawing.Point(197, 319);
            this.txtbox_address.Name = "txtbox_address";
            this.txtbox_address.Size = new System.Drawing.Size(229, 24);
            this.txtbox_address.TabIndex = 26;
            // 
            // lbl_enteraddress
            // 
            this.lbl_enteraddress.AutoSize = true;
            this.lbl_enteraddress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_enteraddress.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enteraddress.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_enteraddress.Location = new System.Drawing.Point(25, 319);
            this.lbl_enteraddress.Name = "lbl_enteraddress";
            this.lbl_enteraddress.Size = new System.Drawing.Size(120, 21);
            this.lbl_enteraddress.TabIndex = 25;
            this.lbl_enteraddress.Text = "Enter Address :";
            // 
            // Add_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(656, 492);
            this.Controls.Add(this.txtbox_address);
            this.Controls.Add(this.lbl_enteraddress);
            this.Controls.Add(this.txtbox_contactno);
            this.Controls.Add(this.lbl_entercontactno);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.lbl_enterpassword);
            this.Controls.Add(this.lbl_adduser);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_User_Form";
            this.Opacity = 0.4D;
            this.Text = "Add User_Form";
            this.TransparencyKey = System.Drawing.SystemColors.WindowText;
            this.Load += new System.EventHandler(this.Add_User_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_adduser;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label lbl_enterpassword;
        private System.Windows.Forms.TextBox txtbox_contactno;
        private System.Windows.Forms.Label lbl_entercontactno;
        private System.Windows.Forms.TextBox txtbox_address;
        private System.Windows.Forms.Label lbl_enteraddress;

    }
}