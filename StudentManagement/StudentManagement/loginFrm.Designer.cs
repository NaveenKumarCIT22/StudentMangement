namespace StudentManagement
{
    partial class loginFrm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.pswdBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.usrBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitBtn.Location = new System.Drawing.Point(242, 366);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(128, 38);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginBtn.Location = new System.Drawing.Point(564, 366);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(128, 38);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "Enter";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(237, 228);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 29);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Password";
            // 
            // pswdBox
            // 
            this.pswdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pswdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswdBox.Location = new System.Drawing.Point(242, 270);
            this.pswdBox.Name = "pswdBox";
            this.pswdBox.ShortcutsEnabled = false;
            this.pswdBox.Size = new System.Drawing.Size(450, 27);
            this.pswdBox.TabIndex = 10;
            this.pswdBox.UseSystemPasswordChar = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(237, 121);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(124, 29);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Username";
            // 
            // usrBox
            // 
            this.usrBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrBox.Location = new System.Drawing.Point(242, 163);
            this.usrBox.Name = "usrBox";
            this.usrBox.Size = new System.Drawing.Size(450, 27);
            this.usrBox.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(412, 27);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(124, 38);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "LOGIN";
            // 
            // loginFrm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(977, 446);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.pswdBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.usrBox);
            this.Controls.Add(this.Label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gateway";
            this.Load += new System.EventHandler(this.loginFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button exitBtn;
        internal System.Windows.Forms.Button loginBtn;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox pswdBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox usrBox;
        internal System.Windows.Forms.Label Label1;
    }
}

