
namespace SignUp_Using_Database
{
    partial class CommandBuildForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PerformOperationBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // PerformOperationBtn
            // 
            this.PerformOperationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PerformOperationBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerformOperationBtn.Location = new System.Drawing.Point(36, 399);
            this.PerformOperationBtn.Name = "PerformOperationBtn";
            this.PerformOperationBtn.Size = new System.Drawing.Size(725, 39);
            this.PerformOperationBtn.TabIndex = 1;
            this.PerformOperationBtn.Text = "Perform Operation";
            this.PerformOperationBtn.UseVisualStyleBackColor = false;
            this.PerformOperationBtn.Click += new System.EventHandler(this.PerformOperationBtn_Click);
            // 
            // CommandBuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PerformOperationBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CommandBuildForm";
            this.Text = "CommandBuildForm";
            this.Load += new System.EventHandler(this.CommandBuildForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PerformOperationBtn;
    }
}