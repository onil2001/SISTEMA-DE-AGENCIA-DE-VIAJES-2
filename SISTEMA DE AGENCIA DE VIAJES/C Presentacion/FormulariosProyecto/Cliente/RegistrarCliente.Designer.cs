namespace C_Presentacion.FormulariosProyecto.Cliente
{
    partial class RegistrarCliente
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.BtnConsul = new FontAwesome.Sharp.IconButton();
            this.txtCodigoBusqueda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 532);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dgvCliente);
            this.panel2.Controls.Add(this.BtnConsul);
            this.panel2.Controls.Add(this.txtCodigoBusqueda);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 532);
            this.panel2.TabIndex = 20;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCliente.Location = new System.Drawing.Point(46, 390);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 62;
            this.dgvCliente.RowTemplate.Height = 28;
            this.dgvCliente.ShowCellToolTips = false;
            this.dgvCliente.Size = new System.Drawing.Size(533, 132);
            this.dgvCliente.TabIndex = 38;
            this.dgvCliente.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellMouseEnter);
            this.dgvCliente.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellMouseLeave);
            this.dgvCliente.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCliente_CellMouseMove);
            this.dgvCliente.DoubleClick += new System.EventHandler(this.dgvCliente_DoubleClick);
            // 
            // BtnConsul
            // 
            this.BtnConsul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BtnConsul.FlatAppearance.BorderSize = 0;
            this.BtnConsul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsul.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsul.ForeColor = System.Drawing.Color.White;
            this.BtnConsul.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnConsul.IconColor = System.Drawing.Color.White;
            this.BtnConsul.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConsul.IconSize = 35;
            this.BtnConsul.Location = new System.Drawing.Point(203, 342);
            this.BtnConsul.Name = "BtnConsul";
            this.BtnConsul.Size = new System.Drawing.Size(219, 42);
            this.BtnConsul.TabIndex = 37;
            this.BtnConsul.Text = "Buscar cliente";
            this.BtnConsul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsul.UseVisualStyleBackColor = false;
            this.BtnConsul.Click += new System.EventHandler(this.BtnConsul_Click);
            // 
            // txtCodigoBusqueda
            // 
            this.txtCodigoBusqueda.Location = new System.Drawing.Point(111, 353);
            this.txtCodigoBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoBusqueda.Multiline = true;
            this.txtCodigoBusqueda.Name = "txtCodigoBusqueda";
            this.txtCodigoBusqueda.Size = new System.Drawing.Size(67, 22);
            this.txtCodigoBusqueda.TabIndex = 36;
            this.txtCodigoBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Código: ";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 35;
            this.btnActualizar.Location = new System.Drawing.Point(439, 342);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(148, 43);
            this.btnActualizar.TabIndex = 34;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCancelar.IconSize = 35;
            this.BtnCancelar.Location = new System.Drawing.Point(458, 184);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(148, 44);
            this.BtnCancelar.TabIndex = 22;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 35;
            this.BtnGuardar.Location = new System.Drawing.Point(458, 131);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(129, 45);
            this.BtnGuardar.TabIndex = 21;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(9, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 246);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.txtDireccion);
            this.tabPage1.Controls.Add(this.txtCorreo);
            this.tabPage1.Controls.Add(this.txtTelefono);
            this.tabPage1.Controls.Add(this.txtCedula);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(435, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Información personal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(83, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(31, 26);
            this.txtCodigo.TabIndex = 30;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(217, 50);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(164, 83);
            this.txtDireccion.TabIndex = 28;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(83, 167);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(121, 26);
            this.txtCorreo.TabIndex = 27;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(83, 138);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 26);
            this.txtTelefono.TabIndex = 26;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(83, 109);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(122, 26);
            this.txtCedula.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(122, 26);
            this.txtNombre.TabIndex = 24;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(83, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(122, 26);
            this.txtApellido.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 21);
            this.label12.TabIndex = 29;
            this.label12.Text = "Código:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cédula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(199, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Registrar cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 28);
            this.label9.TabIndex = 39;
            this.label9.Text = "Registrar Clientes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 311);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 28);
            this.label10.TabIndex = 40;
            this.label10.Text = "Actualizar Clientes";
            // 
            // RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(627, 532);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarCliente";
            this.Text = "RegistrarCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private System.Windows.Forms.TextBox txtCodigoBusqueda;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton BtnConsul;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}