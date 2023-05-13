namespace StudentManagement
{
    partial class crteSubFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deptLst = new System.Windows.Forms.CheckedListBox();
            this.creditNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.theoryNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.practicalNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.codeTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.semBox = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.priotityTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.creditNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoryNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicalNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Name:";
            // 
            // subTxt
            // 
            this.subTxt.Location = new System.Drawing.Point(232, 113);
            this.subTxt.Name = "subTxt";
            this.subTxt.Size = new System.Drawing.Size(188, 30);
            this.subTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Credit:";
            // 
            // deptLst
            // 
            this.deptLst.FormattingEnabled = true;
            this.deptLst.Location = new System.Drawing.Point(73, 344);
            this.deptLst.Name = "deptLst";
            this.deptLst.Size = new System.Drawing.Size(627, 179);
            this.deptLst.TabIndex = 4;
            // 
            // creditNum
            // 
            this.creditNum.Location = new System.Drawing.Point(168, 181);
            this.creditNum.Name = "creditNum";
            this.creditNum.Size = new System.Drawing.Size(120, 30);
            this.creditNum.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Departments:";
            // 
            // theoryNum
            // 
            this.theoryNum.Location = new System.Drawing.Point(256, 237);
            this.theoryNum.Name = "theoryNum";
            this.theoryNum.Size = new System.Drawing.Size(120, 30);
            this.theoryNum.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Theory Weightage:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(198, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Subject";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // practicalNum
            // 
            this.practicalNum.Enabled = false;
            this.practicalNum.Location = new System.Drawing.Point(580, 240);
            this.practicalNum.Name = "practicalNum";
            this.practicalNum.Size = new System.Drawing.Size(120, 30);
            this.practicalNum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Practical Weightage:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(511, 182);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(201, 29);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Contains Practicals";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // codeTxt
            // 
            this.codeTxt.Location = new System.Drawing.Point(580, 113);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(120, 30);
            this.codeTxt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Subject Code:";
            // 
            // semBox
            // 
            this.semBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.semBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.semBox.FormattingEnabled = true;
            this.semBox.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.semBox.Location = new System.Drawing.Point(382, 180);
            this.semBox.Name = "semBox";
            this.semBox.Size = new System.Drawing.Size(96, 33);
            this.semBox.TabIndex = 17;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(322, 184);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 25);
            this.label25.TabIndex = 16;
            this.label25.Text = "Sem:";
            // 
            // priotityTxt
            // 
            this.priotityTxt.Location = new System.Drawing.Point(446, 295);
            this.priotityTxt.Name = "priotityTxt";
            this.priotityTxt.Size = new System.Drawing.Size(254, 30);
            this.priotityTxt.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Priority:";
            // 
            // crteSubFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(780, 622);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priotityTxt);
            this.Controls.Add(this.semBox);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.codeTxt);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.practicalNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.theoryNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.creditNum);
            this.Controls.Add(this.deptLst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "crteSubFrm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.crteSubFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creditNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoryNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicalNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox deptLst;
        private System.Windows.Forms.NumericUpDown creditNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown theoryNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown practicalNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox semBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox priotityTxt;
        private System.Windows.Forms.Label label8;
    }
}