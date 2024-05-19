namespace VSMSOOPProject
{
    partial class frmLoginAdmin
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
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.Label();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(323, 176);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(184, 20);
            this.txtbxUsername.TabIndex = 0;
            // 
            // UsernameBox
            // 
            this.UsernameBox.AutoSize = true;
            this.UsernameBox.Location = new System.Drawing.Point(262, 179);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(55, 13);
            this.UsernameBox.TabIndex = 1;
            this.UsernameBox.Text = "Username";
            // 
            // PasswordBox
            // 
            this.PasswordBox.AutoSize = true;
            this.PasswordBox.Location = new System.Drawing.Point(264, 220);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(53, 13);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.Text = "Password";
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(323, 217);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(184, 20);
            this.txtbxPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(352, 265);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.txtbxUsername);
            this.Name = "frmLoginAdmin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLoginAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.Label UsernameBox;
        private System.Windows.Forms.Label PasswordBox;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}