namespace EjemploPROG
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
            this.gbTiposTV = new System.Windows.Forms.GroupBox();
            this.txtCuotaMensual = new System.Windows.Forms.TextBox();
            this.txtCuotaInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTiposTV = new System.Windows.Forms.ComboBox();
            this.gbOperacion = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.mtbDNI = new System.Windows.Forms.MaskedTextBox();
            this.txtClienteCuotaInicial = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtMensualidad = new System.Windows.Forms.TextBox();
            this.txtTiposTV = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.lvwClientes = new System.Windows.Forms.ListView();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.lvwControl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTiposTV.SuspendLayout();
            this.gbOperacion.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbClientes.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTiposTV
            // 
            this.gbTiposTV.Controls.Add(this.txtCuotaMensual);
            this.gbTiposTV.Controls.Add(this.txtCuotaInicial);
            this.gbTiposTV.Controls.Add(this.label2);
            this.gbTiposTV.Controls.Add(this.label1);
            this.gbTiposTV.Controls.Add(this.cbTiposTV);
            this.gbTiposTV.Location = new System.Drawing.Point(13, 13);
            this.gbTiposTV.Name = "gbTiposTV";
            this.gbTiposTV.Size = new System.Drawing.Size(199, 119);
            this.gbTiposTV.TabIndex = 0;
            this.gbTiposTV.TabStop = false;
            this.gbTiposTV.Text = "Tipos de TV";
            // 
            // txtCuotaMensual
            // 
            this.txtCuotaMensual.Enabled = false;
            this.txtCuotaMensual.Location = new System.Drawing.Point(88, 88);
            this.txtCuotaMensual.Name = "txtCuotaMensual";
            this.txtCuotaMensual.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaMensual.TabIndex = 4;
            // 
            // txtCuotaInicial
            // 
            this.txtCuotaInicial.Enabled = false;
            this.txtCuotaInicial.Location = new System.Drawing.Point(88, 50);
            this.txtCuotaInicial.Name = "txtCuotaInicial";
            this.txtCuotaInicial.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaInicial.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuota Mensual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuota Inicial";
            // 
            // cbTiposTV
            // 
            this.cbTiposTV.FormattingEnabled = true;
            this.cbTiposTV.Items.AddRange(new object[] {
            "LG",
            "Sony",
            "Toshiba",
            "Samsung"});
            this.cbTiposTV.Location = new System.Drawing.Point(7, 20);
            this.cbTiposTV.Name = "cbTiposTV";
            this.cbTiposTV.Size = new System.Drawing.Size(181, 21);
            this.cbTiposTV.TabIndex = 0;
            this.cbTiposTV.SelectedIndexChanged += new System.EventHandler(this.cbTiposTV_SelectedIndexChanged);
            // 
            // gbOperacion
            // 
            this.gbOperacion.Controls.Add(this.btnCancelar);
            this.gbOperacion.Controls.Add(this.btnGuardar);
            this.gbOperacion.Controls.Add(this.btnAdd);
            this.gbOperacion.Location = new System.Drawing.Point(13, 138);
            this.gbOperacion.Name = "gbOperacion";
            this.gbOperacion.Size = new System.Drawing.Size(200, 107);
            this.gbOperacion.TabIndex = 1;
            this.gbOperacion.TabStop = false;
            this.gbOperacion.Text = "Operacion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(118, 56);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 36);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(7, 56);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 36);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.mtbDNI);
            this.gbCliente.Controls.Add(this.txtClienteCuotaInicial);
            this.gbCliente.Controls.Add(this.txtEdad);
            this.gbCliente.Controls.Add(this.txtObservacion);
            this.gbCliente.Controls.Add(this.txtMensualidad);
            this.gbCliente.Controls.Add(this.txtTiposTV);
            this.gbCliente.Controls.Add(this.txtApellidos);
            this.gbCliente.Controls.Add(this.txtNombres);
            this.gbCliente.Controls.Add(this.label10);
            this.gbCliente.Controls.Add(this.label9);
            this.gbCliente.Controls.Add(this.label8);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Location = new System.Drawing.Point(218, 13);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(362, 175);
            this.gbCliente.TabIndex = 2;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // mtbDNI
            // 
            this.mtbDNI.Enabled = false;
            this.mtbDNI.Location = new System.Drawing.Point(256, 20);
            this.mtbDNI.Name = "mtbDNI";
            this.mtbDNI.Size = new System.Drawing.Size(100, 20);
            this.mtbDNI.TabIndex = 18;
            // 
            // txtClienteCuotaInicial
            // 
            this.txtClienteCuotaInicial.Enabled = false;
            this.txtClienteCuotaInicial.Location = new System.Drawing.Point(202, 104);
            this.txtClienteCuotaInicial.Name = "txtClienteCuotaInicial";
            this.txtClienteCuotaInicial.Size = new System.Drawing.Size(154, 20);
            this.txtClienteCuotaInicial.TabIndex = 17;
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(256, 50);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 16;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Enabled = false;
            this.txtObservacion.Location = new System.Drawing.Point(93, 150);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(100, 20);
            this.txtObservacion.TabIndex = 14;
            // 
            // txtMensualidad
            // 
            this.txtMensualidad.Enabled = false;
            this.txtMensualidad.Location = new System.Drawing.Point(93, 122);
            this.txtMensualidad.Name = "txtMensualidad";
            this.txtMensualidad.Size = new System.Drawing.Size(100, 20);
            this.txtMensualidad.TabIndex = 13;
            // 
            // txtTiposTV
            // 
            this.txtTiposTV.Enabled = false;
            this.txtTiposTV.Location = new System.Drawing.Point(93, 85);
            this.txtTiposTV.Name = "txtTiposTV";
            this.txtTiposTV.Size = new System.Drawing.Size(100, 20);
            this.txtTiposTV.TabIndex = 12;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(93, 50);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 11;
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(93, 20);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Edad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cuota Inicial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mensualidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Observacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de TV";

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.lvwClientes);
            this.gbClientes.Location = new System.Drawing.Point(13, 252);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(567, 222);
            this.gbClientes.TabIndex = 3;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Clientes";
            // 
            // lvwClientes
            // 
            this.lvwClientes.Location = new System.Drawing.Point(7, 20);
            this.lvwClientes.Name = "lvwClientes";
            this.lvwClientes.Size = new System.Drawing.Size(554, 202);
            this.lvwClientes.TabIndex = 0;
            this.lvwClientes.UseCompatibleStateImageBehavior = false;
            this.lvwClientes.View = System.Windows.Forms.View.Details;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.lvwControl);
            this.gbControl.Location = new System.Drawing.Point(13, 481);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(567, 197);
            this.gbControl.TabIndex = 4;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // lvwControl
            // 
            this.lvwControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwControl.Location = new System.Drawing.Point(7, 20);
            this.lvwControl.Name = "lvwControl";
            this.lvwControl.Size = new System.Drawing.Size(554, 171);
            this.lvwControl.TabIndex = 0;
            this.lvwControl.UseCompatibleStateImageBehavior = false;
            this.lvwControl.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tipos TV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 693);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbOperacion);
            this.Controls.Add(this.gbTiposTV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTiposTV.ResumeLayout(false);
            this.gbTiposTV.PerformLayout();
            this.gbOperacion.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbClientes.ResumeLayout(false);
            this.gbControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTiposTV;
        private System.Windows.Forms.TextBox txtCuotaMensual;
        private System.Windows.Forms.TextBox txtCuotaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTiposTV;
        private System.Windows.Forms.GroupBox gbOperacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbDNI;
        private System.Windows.Forms.TextBox txtClienteCuotaInicial;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtMensualidad;
        private System.Windows.Forms.TextBox txtTiposTV;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.ListView lvwClientes;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.ListView lvwControl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

