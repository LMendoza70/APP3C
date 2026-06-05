namespace APP3C.Cafeteria
{
    partial class frmCafeteria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFria = new System.Windows.Forms.RadioButton();
            this.rdbCaliente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbtamaño = new System.Windows.Forms.ComboBox();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtExtra);
            this.groupBox1.Controls.Add(this.lblExtra);
            this.groupBox1.Controls.Add(this.cmbtamaño);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbCaliente);
            this.groupBox1.Controls.Add(this.rdbFria);
            this.groupBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 592);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captura de Bebidas";
            // 
            // rdbFria
            // 
            this.rdbFria.AutoSize = true;
            this.rdbFria.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFria.Location = new System.Drawing.Point(6, 68);
            this.rdbFria.Name = "rdbFria";
            this.rdbFria.Size = new System.Drawing.Size(73, 25);
            this.rdbFria.TabIndex = 0;
            this.rdbFria.TabStop = true;
            this.rdbFria.Text = "Fria";
            this.rdbFria.UseVisualStyleBackColor = true;
            // 
            // rdbCaliente
            // 
            this.rdbCaliente.AutoSize = true;
            this.rdbCaliente.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCaliente.Location = new System.Drawing.Point(228, 68);
            this.rdbCaliente.Name = "rdbCaliente";
            this.rdbCaliente.Size = new System.Drawing.Size(119, 25);
            this.rdbCaliente.TabIndex = 1;
            this.rdbCaliente.TabStop = true;
            this.rdbCaliente.Text = "Caliente";
            this.rdbCaliente.UseVisualStyleBackColor = true;
            this.rdbCaliente.CheckedChanged += new System.EventHandler(this.rdbCaliente_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la bebida";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(11, 148);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(297, 35);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(11, 238);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(297, 35);
            this.txtPrecio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tamaño";
            // 
            // cmbtamaño
            // 
            this.cmbtamaño.FormattingEnabled = true;
            this.cmbtamaño.Items.AddRange(new object[] {
            "Chico",
            "Mediano",
            "Grande"});
            this.cmbtamaño.Location = new System.Drawing.Point(13, 335);
            this.cmbtamaño.Name = "cmbtamaño";
            this.cmbtamaño.Size = new System.Drawing.Size(295, 36);
            this.cmbtamaño.TabIndex = 7;
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(11, 419);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(297, 35);
            this.txtExtra.TabIndex = 9;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(6, 388);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(269, 28);
            this.lblExtra.TabIndex = 8;
            this.lblExtra.Text = "Cantidad de Hielo";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(11, 485);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(297, 62);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Agregar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(823, 616);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCafeteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCafeteria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCaliente;
        private System.Windows.Forms.RadioButton rdbFria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbtamaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label lblExtra;
    }
}