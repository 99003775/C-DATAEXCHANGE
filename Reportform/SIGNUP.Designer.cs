
namespace Reportform
{
    partial class SIGNUP
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
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsms = new System.Windows.Forms.Label();
            this.lbltran = new System.Windows.Forms.Label();
            this.lblreport = new System.Windows.Forms.Label();
            this.chkreport = new System.Windows.Forms.CheckBox();
            this.chktran = new System.Windows.Forms.CheckBox();
            this.chksms = new System.Windows.Forms.CheckBox();
            this.signup1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "FIRST NAME";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(254, 91);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(275, 22);
            this.txtlname.TabIndex = 3;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(254, 36);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(275, 22);
            this.txtfname.TabIndex = 4;
            this.txtfname.Text = "pawan kumar";
            this.txtfname.TextChanged += new System.EventHandler(this.txtfname_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(254, 147);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(285, 22);
            this.txtemail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "LAST NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-MAIL";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.lblsms);
            this.groupBox1.Controls.Add(this.lbltran);
            this.groupBox1.Controls.Add(this.lblreport);
            this.groupBox1.Controls.Add(this.chkreport);
            this.groupBox1.Controls.Add(this.chktran);
            this.groupBox1.Controls.Add(this.chksms);
            this.groupBox1.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 122);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVIES";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblsms
            // 
            this.lblsms.AutoSize = true;
            this.lblsms.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsms.ForeColor = System.Drawing.Color.Gold;
            this.lblsms.Location = new System.Drawing.Point(338, 100);
            this.lblsms.Name = "lblsms";
            this.lblsms.Size = new System.Drawing.Size(27, 20);
            this.lblsms.TabIndex = 18;
            this.lblsms.Text = "......";
            // 
            // lbltran
            // 
            this.lbltran.AutoSize = true;
            this.lbltran.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltran.Location = new System.Drawing.Point(338, 67);
            this.lbltran.Name = "lbltran";
            this.lbltran.Size = new System.Drawing.Size(24, 20);
            this.lbltran.TabIndex = 17;
            this.lbltran.Text = ".....";
            // 
            // lblreport
            // 
            this.lblreport.AutoSize = true;
            this.lblreport.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreport.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblreport.Location = new System.Drawing.Point(338, 38);
            this.lblreport.Name = "lblreport";
            this.lblreport.Size = new System.Drawing.Size(24, 20);
            this.lblreport.TabIndex = 16;
            this.lblreport.Text = ".....";
            // 
            // chkreport
            // 
            this.chkreport.AutoSize = true;
            this.chkreport.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkreport.Location = new System.Drawing.Point(181, 37);
            this.chkreport.Name = "chkreport";
            this.chkreport.Size = new System.Drawing.Size(92, 22);
            this.chkreport.TabIndex = 11;
            this.chkreport.Text = "REPORT";
            this.chkreport.UseVisualStyleBackColor = true;
            this.chkreport.CheckedChanged += new System.EventHandler(this.chkreport_CheckedChanged);
            // 
            // chktran
            // 
            this.chktran.AutoSize = true;
            this.chktran.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chktran.Location = new System.Drawing.Point(181, 67);
            this.chktran.Name = "chktran";
            this.chktran.Size = new System.Drawing.Size(133, 22);
            this.chktran.TabIndex = 13;
            this.chktran.Text = "TRANSTION STATUS";
            this.chktran.UseVisualStyleBackColor = true;
            this.chktran.CheckedChanged += new System.EventHandler(this.chktran_CheckedChanged);
            // 
            // chksms
            // 
            this.chksms.AutoSize = true;
            this.chksms.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksms.Location = new System.Drawing.Point(182, 95);
            this.chksms.Name = "chksms";
            this.chksms.Size = new System.Drawing.Size(105, 23);
            this.chksms.TabIndex = 15;
            this.chksms.Text = "SMS STATUS";
            this.chksms.UseVisualStyleBackColor = true;
            this.chksms.CheckedChanged += new System.EventHandler(this.chksms_CheckedChanged);
            // 
            // signup1
            // 
            this.signup1.Location = new System.Drawing.Point(610, 388);
            this.signup1.Name = "signup1";
            this.signup1.Size = new System.Drawing.Size(126, 36);
            this.signup1.TabIndex = 20;
            this.signup1.Text = "SIGN UP";
            this.signup1.UseVisualStyleBackColor = true;
            this.signup1.Click += new System.EventHandler(this.signup1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(704, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SIGNUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.signup1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label1);
            this.Name = "SIGNUP";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SIGNUP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblsms;
        private System.Windows.Forms.Label lbltran;
        private System.Windows.Forms.Label lblreport;
        private System.Windows.Forms.CheckBox chkreport;
        private System.Windows.Forms.CheckBox chktran;
        private System.Windows.Forms.CheckBox chksms;
        private System.Windows.Forms.Button signup1;
        private System.Windows.Forms.Button button2;
    }
}

