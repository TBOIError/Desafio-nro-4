namespace Inmuebles
{
    partial class Inmobiliaria
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPiso = new System.Windows.Forms.Button();
            this.labelDir = new System.Windows.Forms.Label();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.labelMetros = new System.Windows.Forms.Label();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.labelNuev = new System.Windows.Forms.Label();
            this.labelAños = new System.Windows.Forms.Label();
            this.labelVentanas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radiobtnventana1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnLocal = new System.Windows.Forms.Button();
            this.comboBoxUSADO = new System.Windows.Forms.ComboBox();
            this.comboBoxAÑOS = new System.Windows.Forms.ComboBox();
            this.comboBoxPISO = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPiso
            // 
            this.btnPiso.Location = new System.Drawing.Point(53, 270);
            this.btnPiso.Name = "btnPiso";
            this.btnPiso.Size = new System.Drawing.Size(156, 31);
            this.btnPiso.TabIndex = 0;
            this.btnPiso.Text = "Piso";
            this.btnPiso.UseVisualStyleBackColor = true;
            this.btnPiso.Click += new System.EventHandler(this.btnPiso_Click);
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Location = new System.Drawing.Point(50, 9);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(52, 13);
            this.labelDir.TabIndex = 1;
            this.labelDir.Text = "Dirección";
            // 
            // txtDirec
            // 
            this.txtDirec.Location = new System.Drawing.Point(53, 34);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(156, 20);
            this.txtDirec.TabIndex = 2;
            // 
            // labelMetros
            // 
            this.labelMetros.AutoSize = true;
            this.labelMetros.Location = new System.Drawing.Point(50, 71);
            this.labelMetros.Name = "labelMetros";
            this.labelMetros.Size = new System.Drawing.Size(93, 13);
            this.labelMetros.TabIndex = 3;
            this.labelMetros.Text = "Metros Cuadrados";
            this.labelMetros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(53, 98);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(156, 20);
            this.txtMetros.TabIndex = 4;
            // 
            // labelNuev
            // 
            this.labelNuev.AutoSize = true;
            this.labelNuev.Location = new System.Drawing.Point(50, 134);
            this.labelNuev.Name = "labelNuev";
            this.labelNuev.Size = new System.Drawing.Size(130, 13);
            this.labelNuev.TabIndex = 5;
            this.labelNuev.Text = "Nuevo o Segunda Mano?";
            this.labelNuev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAños
            // 
            this.labelAños.AutoSize = true;
            this.labelAños.Location = new System.Drawing.Point(355, 9);
            this.labelAños.Name = "labelAños";
            this.labelAños.Size = new System.Drawing.Size(102, 13);
            this.labelAños.TabIndex = 7;
            this.labelAños.Text = "Años de antiguedad";
            // 
            // labelVentanas
            // 
            this.labelVentanas.AutoSize = true;
            this.labelVentanas.Location = new System.Drawing.Point(355, 71);
            this.labelVentanas.Name = "labelVentanas";
            this.labelVentanas.Size = new System.Drawing.Size(111, 13);
            this.labelVentanas.TabIndex = 9;
            this.labelVentanas.Text = "Cantidad de ventanas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Piso de Altura";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(211, 224);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(156, 20);
            this.txtPrecio.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Precio de Inmueble";
            // 
            // radiobtnventana1
            // 
            this.radiobtnventana1.AutoSize = true;
            this.radiobtnventana1.Location = new System.Drawing.Point(324, 101);
            this.radiobtnventana1.Name = "radiobtnventana1";
            this.radiobtnventana1.Size = new System.Drawing.Size(74, 17);
            this.radiobtnventana1.TabIndex = 26;
            this.radiobtnventana1.TabStop = true;
            this.radiobtnventana1.Text = "1 o menos";
            this.radiobtnventana1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(400, 101);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "De 2 a 4";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(472, 101);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 17);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Más de 4";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(339, 270);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(185, 31);
            this.btnLocal.TabIndex = 32;
            this.btnLocal.Text = "Local";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // comboBoxUSADO
            // 
            this.comboBoxUSADO.FormattingEnabled = true;
            this.comboBoxUSADO.Items.AddRange(new object[] {
            "NUEVO",
            "SEGUNDA MANO"});
            this.comboBoxUSADO.Location = new System.Drawing.Point(53, 164);
            this.comboBoxUSADO.Name = "comboBoxUSADO";
            this.comboBoxUSADO.Size = new System.Drawing.Size(156, 21);
            this.comboBoxUSADO.TabIndex = 33;
            // 
            // comboBoxAÑOS
            // 
            this.comboBoxAÑOS.FormattingEnabled = true;
            this.comboBoxAÑOS.Items.AddRange(new object[] {
            "Menos de 15 años",
            "15 años o más"});
            this.comboBoxAÑOS.Location = new System.Drawing.Point(358, 34);
            this.comboBoxAÑOS.Name = "comboBoxAÑOS";
            this.comboBoxAÑOS.Size = new System.Drawing.Size(166, 21);
            this.comboBoxAÑOS.TabIndex = 34;
            // 
            // comboBoxPISO
            // 
            this.comboBoxPISO.FormattingEnabled = true;
            this.comboBoxPISO.Items.AddRange(new object[] {
            "1er o 2do Piso",
            "3er Piso o Superior"});
            this.comboBoxPISO.Location = new System.Drawing.Point(324, 164);
            this.comboBoxPISO.Name = "comboBoxPISO";
            this.comboBoxPISO.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPISO.TabIndex = 35;
            // 
            // Inmobiliaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(580, 325);
            this.Controls.Add(this.comboBoxPISO);
            this.Controls.Add(this.comboBoxAÑOS);
            this.Controls.Add(this.comboBoxUSADO);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radiobtnventana1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVentanas);
            this.Controls.Add(this.labelAños);
            this.Controls.Add(this.labelNuev);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.labelMetros);
            this.Controls.Add(this.txtDirec);
            this.Controls.Add(this.labelDir);
            this.Controls.Add(this.btnPiso);
            this.Name = "Inmobiliaria";
            this.Text = "Inmobiliaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPiso;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.Label labelMetros;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.Label labelNuev;
        private System.Windows.Forms.Label labelAños;
        private System.Windows.Forms.Label labelVentanas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiobtnventana1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.ComboBox comboBoxUSADO;
        private System.Windows.Forms.ComboBox comboBoxAÑOS;
        private System.Windows.Forms.ComboBox comboBoxPISO;
    }
}

