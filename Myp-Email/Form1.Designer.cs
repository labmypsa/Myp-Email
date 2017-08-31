namespace Myp_Email
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recordatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibracióntécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fecha = new System.Windows.Forms.Label();
            this.reloj = new System.Windows.Forms.Label();
            this.timer_reloj = new System.Windows.Forms.Timer(this.components);
            this.timer_checador = new System.Windows.Forms.Timer(this.components);
            this.panel_radio = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.check_g = new System.Windows.Forms.CheckBox();
            this.check_h = new System.Windows.Forms.CheckBox();
            this.check_n = new System.Windows.Forms.CheckBox();
            this.consola = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel_radio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordatoriosToolStripMenuItem,
            this.modulosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recordatoriosToolStripMenuItem
            // 
            this.recordatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.recordatoriosToolStripMenuItem.Name = "recordatoriosToolStripMenuItem";
            this.recordatoriosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.recordatoriosToolStripMenuItem.Text = "Recordatorios";
            // 
            // internosToolStripMenuItem
            // 
            this.internosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calibraciónToolStripMenuItem,
            this.salidaToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.calibracióntécnicoToolStripMenuItem});
            this.internosToolStripMenuItem.Name = "internosToolStripMenuItem";
            this.internosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.internosToolStripMenuItem.Text = "Internos";
            // 
            // calibraciónToolStripMenuItem
            // 
            this.calibraciónToolStripMenuItem.Name = "calibraciónToolStripMenuItem";
            this.calibraciónToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.calibraciónToolStripMenuItem.Text = "Calibración";
            this.calibraciónToolStripMenuItem.Click += new System.EventHandler(this.calibraciónToolStripMenuItem_Click);
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.salidaToolStripMenuItem.Text = "Salida";
            this.salidaToolStripMenuItem.Click += new System.EventHandler(this.salidaToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // calibracióntécnicoToolStripMenuItem
            // 
            this.calibracióntécnicoToolStripMenuItem.Name = "calibracióntécnicoToolStripMenuItem";
            this.calibracióntécnicoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.calibracióntécnicoToolStripMenuItem.Text = "Calibración_técnico";
            this.calibracióntécnicoToolStripMenuItem.Click += new System.EventHandler(this.calibracióntécnicoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calibracionToolStripMenuItem,
            this.salidaToolStripMenuItem1,
            this.facturaciónToolStripMenuItem,
            this.cotizaciónToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.modulosToolStripMenuItem.Text = "Modulos";
            // 
            // calibracionToolStripMenuItem
            // 
            this.calibracionToolStripMenuItem.Name = "calibracionToolStripMenuItem";
            this.calibracionToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.calibracionToolStripMenuItem.Text = "Correo_Calibración";
            this.calibracionToolStripMenuItem.Click += new System.EventHandler(this.calibracionToolStripMenuItem_Click);
            // 
            // salidaToolStripMenuItem1
            // 
            this.salidaToolStripMenuItem1.Name = "salidaToolStripMenuItem1";
            this.salidaToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.salidaToolStripMenuItem1.Text = "Correo_Salida";
            this.salidaToolStripMenuItem1.Click += new System.EventHandler(this.salidaToolStripMenuItem1_Click);
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.facturaciónToolStripMenuItem.Text = "Correo_Facturación";
            this.facturaciónToolStripMenuItem.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // cotizaciónToolStripMenuItem
            // 
            this.cotizaciónToolStripMenuItem.Name = "cotizaciónToolStripMenuItem";
            this.cotizaciónToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cotizaciónToolStripMenuItem.Text = "Correo_Cotización";
            this.cotizaciónToolStripMenuItem.Click += new System.EventHandler(this.cotizaciónToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(413, 5);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(76, 13);
            this.Fecha.TabIndex = 1;
            this.Fecha.Text = "dd/MMM/yyyy";
            // 
            // reloj
            // 
            this.reloj.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.reloj.AutoSize = true;
            this.reloj.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloj.ForeColor = System.Drawing.Color.LimeGreen;
            this.reloj.Location = new System.Drawing.Point(0, 17);
            this.reloj.Name = "reloj";
            this.reloj.Size = new System.Drawing.Size(72, 17);
            this.reloj.TabIndex = 0;
            this.reloj.Text = "00:00:00";
            // 
            // timer_reloj
            // 
            this.timer_reloj.Tick += new System.EventHandler(this.timer_reloj_Tick);
            // 
            // timer_checador
            // 
            this.timer_checador.Tick += new System.EventHandler(this.timer_checador_Tick);
            // 
            // panel_radio
            // 
            this.panel_radio.AccessibleDescription = "";
            this.panel_radio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_radio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_radio.Controls.Add(this.label1);
            this.panel_radio.Controls.Add(this.check_g);
            this.panel_radio.Controls.Add(this.check_h);
            this.panel_radio.Controls.Add(this.check_n);
            this.panel_radio.Location = new System.Drawing.Point(2, 25);
            this.panel_radio.Name = "panel_radio";
            this.panel_radio.Size = new System.Drawing.Size(374, 61);
            this.panel_radio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccionar las sucursales que desea que reciban recordatorios";
            // 
            // check_g
            // 
            this.check_g.AutoSize = true;
            this.check_g.Location = new System.Drawing.Point(270, 31);
            this.check_g.Name = "check_g";
            this.check_g.Size = new System.Drawing.Size(70, 17);
            this.check_g.TabIndex = 5;
            this.check_g.Text = "Guaymas";
            this.check_g.UseVisualStyleBackColor = true;
            // 
            // check_h
            // 
            this.check_h.AutoSize = true;
            this.check_h.Location = new System.Drawing.Point(139, 31);
            this.check_h.Name = "check_h";
            this.check_h.Size = new System.Drawing.Size(74, 17);
            this.check_h.TabIndex = 4;
            this.check_h.Text = "Hermosillo";
            this.check_h.UseVisualStyleBackColor = true;
            // 
            // check_n
            // 
            this.check_n.AllowDrop = true;
            this.check_n.AutoSize = true;
            this.check_n.Location = new System.Drawing.Point(23, 31);
            this.check_n.Name = "check_n";
            this.check_n.Size = new System.Drawing.Size(65, 17);
            this.check_n.TabIndex = 3;
            this.check_n.Text = "Nogales";
            this.check_n.UseVisualStyleBackColor = true;
            // 
            // consola
            // 
            this.consola.BackColor = System.Drawing.Color.Black;
            this.consola.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consola.ForeColor = System.Drawing.Color.YellowGreen;
            this.consola.Location = new System.Drawing.Point(2, 315);
            this.consola.Multiline = true;
            this.consola.Name = "consola";
            this.consola.ReadOnly = true;
            this.consola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consola.Size = new System.Drawing.Size(485, 170);
            this.consola.TabIndex = 3;
            this.consola.Text = ">";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.reloj);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(380, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 61);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(499, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consola);
            this.Controls.Add(this.panel_radio);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Email-Myp V-1.0.3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_radio.ResumeLayout(false);
            this.panel_radio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibracióntécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label reloj;
        private System.Windows.Forms.Timer timer_reloj;
        private System.Windows.Forms.Timer timer_checador;
        private System.Windows.Forms.Panel panel_radio;
        private System.Windows.Forms.CheckBox check_g;
        private System.Windows.Forms.CheckBox check_h;
        private System.Windows.Forms.CheckBox check_n;
        private System.Windows.Forms.TextBox consola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
    }
}

