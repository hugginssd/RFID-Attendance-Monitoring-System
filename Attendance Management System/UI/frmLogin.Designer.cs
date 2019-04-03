namespace Attendance_Management_System
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.txtUsername = new Windows.Forms.HintTextBox(this.components);
            this.txtPassword = new Windows.Forms.HintTextBox(this.components);
            this.btnSignIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdmin = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.EnterToTab = false;
            this.txtUsername.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.HintColor = System.Drawing.Color.Gray;
            this.txtUsername.HintValue = "Username";
            this.txtUsername.Location = new System.Drawing.Point(52, 61);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(224, 25);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextForeColor = System.Drawing.Color.Black;
            this.txtUsername.Value = "";
            // 
            // txtPassword
            // 
            this.txtPassword.EnterToTab = false;
            this.txtPassword.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.HintColor = System.Drawing.Color.Gray;
            this.txtPassword.HintValue = "Password";
            this.txtPassword.Location = new System.Drawing.Point(52, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(224, 25);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextForeColor = System.Drawing.Color.Black;
            this.txtPassword.Value = "";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Depth = 0;
            this.btnSignIn.Location = new System.Drawing.Point(52, 156);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Primary = true;
            this.btnSignIn.Size = new System.Drawing.Size(110, 27);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(168, 156);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(108, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(104, 200);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 18);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 24);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(129, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            // 
            // lblAdmin
            // 
            this.lblAdmin.Depth = 0;
            this.lblAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAdmin.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAdmin.Location = new System.Drawing.Point(0, 237);
            this.lblAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(319, 13);
            this.lblAdmin.TabIndex = 6;
            this.lblAdmin.Text = "This function is only available to administrators?";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(319, 250);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.HintTextBox txtUsername;
        private Windows.Forms.HintTextBox txtPassword;
        private MaterialSkin.Controls.MaterialRaisedButton btnSignIn;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel lblAdmin;
    }
}