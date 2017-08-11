namespace Myp_Email
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox_sucursal = new System.Windows.Forms.ComboBox();
            this.id_sucursal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_correo = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_name = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_editar);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.tabla);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 479);
            this.panel1.TabIndex = 0;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(327, 141);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "Eliminar";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(246, 141);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 23);
            this.button_editar.TabIndex = 5;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(165, 141);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "+ Agregar ";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(-2, 172);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(423, 304);
            this.tabla.TabIndex = 3;
            this.tabla.DoubleClick += new System.EventHandler(this.tabla_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox_sucursal);
            this.panel4.Controls.Add(this.id_sucursal);
            this.panel4.Location = new System.Drawing.Point(12, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(393, 40);
            this.panel4.TabIndex = 2;
            // 
            // comboBox_sucursal
            // 
            this.comboBox_sucursal.FormattingEnabled = true;
            this.comboBox_sucursal.Location = new System.Drawing.Point(75, 10);
            this.comboBox_sucursal.Name = "comboBox_sucursal";
            this.comboBox_sucursal.Size = new System.Drawing.Size(315, 21);
            this.comboBox_sucursal.TabIndex = 3;
            // 
            // id_sucursal
            // 
            this.id_sucursal.AutoSize = true;
            this.id_sucursal.Location = new System.Drawing.Point(5, 13);
            this.id_sucursal.Name = "id_sucursal";
            this.id_sucursal.Size = new System.Drawing.Size(54, 13);
            this.id_sucursal.TabIndex = 0;
            this.id_sucursal.Text = "Sucursal :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.text_correo);
            this.panel3.Controls.Add(this.correo);
            this.panel3.Location = new System.Drawing.Point(12, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 40);
            this.panel3.TabIndex = 1;
            // 
            // text_correo
            // 
            this.text_correo.Location = new System.Drawing.Point(75, 10);
            this.text_correo.Name = "text_correo";
            this.text_correo.Size = new System.Drawing.Size(315, 20);
            this.text_correo.TabIndex = 2;
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Location = new System.Drawing.Point(5, 13);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(47, 13);
            this.correo.TabIndex = 0;
            this.correo.Text = "Correo  :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.text_name);
            this.panel2.Controls.Add(this.nombre);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 40);
            this.panel2.TabIndex = 0;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(75, 10);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(315, 20);
            this.text_name.TabIndex = 1;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(5, 13);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(50, 13);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 479);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Modulo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox_sucursal;
        private System.Windows.Forms.Label id_sucursal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_correo;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_editar;
    }
}