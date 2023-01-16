namespace C_Presentacion.FormulariosProyecto.Cliente
{
    partial class ConsultarCliente
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
            this.label13 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.DTRegO = new System.Windows.Forms.DataGridView();
            this.btnMostrarTodo = new FontAwesome.Sharp.IconButton();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.BtnConsul = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DTRegO)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Apellido(Obligatorio):";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(294, 32);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(95, 13);
            this.apellido.TabIndex = 42;
            this.apellido.Text = "Nombre(Opcional):";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(392, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 41;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(132, 29);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(128, 20);
            this.txtApellido.TabIndex = 40;
            // 
            // DTRegO
            // 
            this.DTRegO.BackgroundColor = System.Drawing.Color.White;
            this.DTRegO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTRegO.Location = new System.Drawing.Point(12, 77);
            this.DTRegO.Name = "DTRegO";
            this.DTRegO.Size = new System.Drawing.Size(543, 163);
            this.DTRegO.TabIndex = 39;
            this.DTRegO.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DTRegO_MouseDoubleClick);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.btnMostrarTodo.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarTodo.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodo.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTodo.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            this.btnMostrarTodo.IconColor = System.Drawing.Color.White;
            this.btnMostrarTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrarTodo.IconSize = 35;
            this.btnMostrarTodo.Location = new System.Drawing.Point(200, 262);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(166, 43);
            this.btnMostrarTodo.TabIndex = 46;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarTodo.UseVisualStyleBackColor = false;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnRegresar.IconColor = System.Drawing.Color.White;
            this.btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRegresar.IconSize = 35;
            this.btnRegresar.Location = new System.Drawing.Point(388, 262);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(157, 43);
            this.btnRegresar.TabIndex = 45;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
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
            this.BtnConsul.Location = new System.Drawing.Point(25, 262);
            this.BtnConsul.Name = "BtnConsul";
            this.BtnConsul.Size = new System.Drawing.Size(152, 43);
            this.BtnConsul.TabIndex = 44;
            this.BtnConsul.Text = "Consultar";
            this.BtnConsul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsul.UseVisualStyleBackColor = false;
            this.BtnConsul.Click += new System.EventHandler(this.BtnConsul_Click);
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(570, 317);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.BtnConsul);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.DTRegO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTRegO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DataGridView DTRegO;
        private FontAwesome.Sharp.IconButton btnMostrarTodo;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private FontAwesome.Sharp.IconButton BtnConsul;
    }
}