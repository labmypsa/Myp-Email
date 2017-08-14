namespace Myp_Email
{
    partial class Form3
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
            this.dataGridView_logs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_logs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_logs
            // 
            this.dataGridView_logs.AllowUserToAddRows = false;
            this.dataGridView_logs.AllowUserToDeleteRows = false;
            this.dataGridView_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_logs.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_logs.Name = "dataGridView_logs";
            this.dataGridView_logs.ReadOnly = true;
            this.dataGridView_logs.Size = new System.Drawing.Size(720, 474);
            this.dataGridView_logs.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 474);
            this.Controls.Add(this.dataGridView_logs);
            this.Name = "Form3";
            this.Text = "Reporte Logs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_logs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_logs;
    }
}