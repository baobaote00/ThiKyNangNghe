﻿
namespace ThiKyNangNghe
{
    partial class LoginForm
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
            this._OK = new System.Windows.Forms.Button();
            this.calcel = new System.Windows.Forms.Button();
            this.labelSignin = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _OK
            // 
            this._OK.Location = new System.Drawing.Point(243, 287);
            this._OK.Name = "_OK";
            this._OK.Size = new System.Drawing.Size(115, 35);
            this._OK.TabIndex = 0;
            this._OK.Text = "OK";
            this._OK.UseVisualStyleBackColor = true;
            // 
            // calcel
            // 
            this.calcel.Location = new System.Drawing.Point(391, 287);
            this.calcel.Name = "calcel";
            this.calcel.Size = new System.Drawing.Size(115, 35);
            this.calcel.TabIndex = 1;
            this.calcel.Text = "CANCEL";
            this.calcel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.labelSignin.AutoSize = true;
            this.labelSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelSignin.Location = new System.Drawing.Point(126, 58);
            this.labelSignin.Name = "Signin";
            this.labelSignin.Size = new System.Drawing.Size(301, 29);
            this.labelSignin.TabIndex = 0;
            this.labelSignin.Text = "Sign in to EM management";
            this.labelSignin.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelUsername.Location = new System.Drawing.Point(127, 127);
            this.labelUsername.Name = "Username";
            this.labelUsername.Size = new System.Drawing.Size(92, 22);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username:";
            // 
            // label3
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelPassword.Location = new System.Drawing.Point(129, 194);
            this.labelPassword.Name = "Password";
            this.labelPassword.Size = new System.Drawing.Size(88, 22);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(233, 131);
            this.textBoxUsername.Name = "username";
            this.textBoxUsername.Size = new System.Drawing.Size(243, 34);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(233, 197);
            this.textBoxPassword.Name = "password";
            this.textBoxPassword.Size = new System.Drawing.Size(241, 36);
            this.textBoxPassword.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelSignin);
            this.Controls.Add(this.calcel);
            this.Controls.Add(this._OK);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _OK;
        private System.Windows.Forms.Button calcel;
        private System.Windows.Forms.Label labelSignin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}

