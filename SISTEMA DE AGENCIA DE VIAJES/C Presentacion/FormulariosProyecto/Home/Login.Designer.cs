
namespace C_Presentacion.Home
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 206);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(109, 188);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidaste tu contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(111, 147);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(125, 34);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "Ingresar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(53)))), ((int)(((byte)(103)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 25;
            this.iconPictureBox2.Location = new System.Drawing.Point(11, 107);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox2.TabIndex = 8;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(53)))), ((int)(((byte)(103)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(11, 70);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 29);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "ESPIRITU VIAJERO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::C_Presentacion.Properties.Resources._22;
            this.pictureBox2.Location = new System.Drawing.Point(295, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_Presentacion.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(331, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(370, 242);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}