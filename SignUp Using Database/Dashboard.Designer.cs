
namespace SignUp_Using_Database
{
    partial class Dashboard
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
            this.lblconpass = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.txtCountryDash = new System.Windows.Forms.ComboBox();
            this.txtPasswordDash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailDash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameDash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttopnamelbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "You\'re In, Welcome,";
            // 
            // lblconpass
            // 
            this.lblconpass.AutoSize = true;
            this.lblconpass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconpass.ForeColor = System.Drawing.Color.Red;
            this.lblconpass.Location = new System.Drawing.Point(165, 233);
            this.lblconpass.Name = "lblconpass";
            this.lblconpass.Size = new System.Drawing.Size(0, 15);
            this.lblconpass.TabIndex = 38;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.Red;
            this.lblpass.Location = new System.Drawing.Point(165, 235);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(0, 15);
            this.lblpass.TabIndex = 37;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Red;
            this.lblemail.Location = new System.Drawing.Point(165, 172);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(0, 15);
            this.lblemail.TabIndex = 36;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Red;
            this.lblusername.Location = new System.Drawing.Point(165, 111);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(0, 15);
            this.lblusername.TabIndex = 35;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdateInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(165, 343);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(427, 53);
            this.btnUpdateInfo.TabIndex = 34;
            this.btnUpdateInfo.Text = "Update Acc Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // txtCountryDash
            // 
            this.txtCountryDash.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryDash.FormattingEnabled = true;
            this.txtCountryDash.Items.AddRange(new object[] {
            "India",
            "USA",
            "UK",
            "Canada",
            "France",
            "Germany",
            "Australia",
            "Others"});
            this.txtCountryDash.Location = new System.Drawing.Point(165, 268);
            this.txtCountryDash.Name = "txtCountryDash";
            this.txtCountryDash.Size = new System.Drawing.Size(427, 32);
            this.txtCountryDash.TabIndex = 33;
            // 
            // txtPasswordDash
            // 
            this.txtPasswordDash.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordDash.Location = new System.Drawing.Point(165, 203);
            this.txtPasswordDash.Name = "txtPasswordDash";
            this.txtPasswordDash.Size = new System.Drawing.Size(427, 29);
            this.txtPasswordDash.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Country:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Password* :";
            // 
            // txtEmailDash
            // 
            this.txtEmailDash.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailDash.Location = new System.Drawing.Point(165, 140);
            this.txtEmailDash.Name = "txtEmailDash";
            this.txtEmailDash.Size = new System.Drawing.Size(427, 29);
            this.txtEmailDash.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Email* :";
            // 
            // txtNameDash
            // 
            this.txtNameDash.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameDash.Location = new System.Drawing.Point(165, 79);
            this.txtNameDash.Name = "txtNameDash";
            this.txtNameDash.Size = new System.Drawing.Size(427, 29);
            this.txtNameDash.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name* : ";
            // 
            // txttopnamelbl
            // 
            this.txttopnamelbl.AutoSize = true;
            this.txttopnamelbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttopnamelbl.Location = new System.Drawing.Point(517, 9);
            this.txttopnamelbl.Name = "txttopnamelbl";
            this.txttopnamelbl.Size = new System.Drawing.Size(0, 31);
            this.txttopnamelbl.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(650, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 285);
            this.button1.TabIndex = 40;
            this.button1.Text = "Erase My Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttopnamelbl);
            this.Controls.Add(this.lblconpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.txtCountryDash);
            this.Controls.Add(this.txtPasswordDash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailDash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameDash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblconpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.ComboBox txtCountryDash;
        private System.Windows.Forms.TextBox txtPasswordDash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailDash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameDash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txttopnamelbl;
        private System.Windows.Forms.Button button1;
    }
}