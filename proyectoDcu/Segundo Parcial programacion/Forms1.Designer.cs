namespace Segundo_Parcial_programacion
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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.Eliminar_btn = new FontAwesome.Sharp.IconButton();
            this.Buscar_btn = new FontAwesome.Sharp.IconButton();
            this.Editar_btn = new FontAwesome.Sharp.IconButton();
            this.Agregar_btn = new FontAwesome.Sharp.IconButton();
            this.paneLogo = new System.Windows.Forms.Panel();
            this.Home_btn = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.MInimize_btn = new FontAwesome.Sharp.IconButton();
            this.maximizar_btn = new FontAwesome.Sharp.IconButton();
            this.Exit_btn = new FontAwesome.Sharp.IconButton();
            this.titulochildrenform = new System.Windows.Forms.Label();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelshadow = new System.Windows.Forms.Panel();
            this.paneldesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelmenu.SuspendLayout();
            this.paneLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home_btn)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.paneldesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelmenu.Controls.Add(this.Eliminar_btn);
            this.panelmenu.Controls.Add(this.Buscar_btn);
            this.panelmenu.Controls.Add(this.Editar_btn);
            this.panelmenu.Controls.Add(this.Agregar_btn);
            this.panelmenu.Controls.Add(this.paneLogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(220, 671);
            this.panelmenu.TabIndex = 0;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmenu_Paint);
            // 
            // Eliminar_btn
            // 
            this.Eliminar_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Eliminar_btn.FlatAppearance.BorderSize = 0;
            this.Eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Eliminar_btn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.Eliminar_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.Eliminar_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Eliminar_btn.IconSize = 32;
            this.Eliminar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar_btn.Location = new System.Drawing.Point(0, 320);
            this.Eliminar_btn.Name = "Eliminar_btn";
            this.Eliminar_btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Eliminar_btn.Size = new System.Drawing.Size(220, 60);
            this.Eliminar_btn.TabIndex = 5;
            this.Eliminar_btn.Text = "Eliminar";
            this.Eliminar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminar_btn.UseVisualStyleBackColor = true;
            this.Eliminar_btn.Click += new System.EventHandler(this.Eliminar_btn_Click);
            // 
            // Buscar_btn
            // 
            this.Buscar_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Buscar_btn.FlatAppearance.BorderSize = 0;
            this.Buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Buscar_btn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.Buscar_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.Buscar_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Buscar_btn.IconSize = 32;
            this.Buscar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar_btn.Location = new System.Drawing.Point(0, 260);
            this.Buscar_btn.Name = "Buscar_btn";
            this.Buscar_btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Buscar_btn.Size = new System.Drawing.Size(220, 60);
            this.Buscar_btn.TabIndex = 4;
            this.Buscar_btn.Text = "Buscar";
            this.Buscar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscar_btn.UseVisualStyleBackColor = true;
            this.Buscar_btn.Click += new System.EventHandler(this.Buscar_btn_Click);
            // 
            // Editar_btn
            // 
            this.Editar_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Editar_btn.FlatAppearance.BorderSize = 0;
            this.Editar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Editar_btn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.Editar_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.Editar_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Editar_btn.IconSize = 32;
            this.Editar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editar_btn.Location = new System.Drawing.Point(0, 200);
            this.Editar_btn.Name = "Editar_btn";
            this.Editar_btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Editar_btn.Size = new System.Drawing.Size(220, 60);
            this.Editar_btn.TabIndex = 3;
            this.Editar_btn.Text = "Editar";
            this.Editar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Editar_btn.UseVisualStyleBackColor = true;
            this.Editar_btn.Click += new System.EventHandler(this.Editar_btn_Click);
            // 
            // Agregar_btn
            // 
            this.Agregar_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Agregar_btn.FlatAppearance.BorderSize = 0;
            this.Agregar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Agregar_btn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.Agregar_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.Agregar_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Agregar_btn.IconSize = 32;
            this.Agregar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregar_btn.Location = new System.Drawing.Point(0, 140);
            this.Agregar_btn.Name = "Agregar_btn";
            this.Agregar_btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Agregar_btn.Size = new System.Drawing.Size(220, 60);
            this.Agregar_btn.TabIndex = 2;
            this.Agregar_btn.Text = "Agregar";
            this.Agregar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Agregar_btn.UseVisualStyleBackColor = true;
            this.Agregar_btn.Click += new System.EventHandler(this.Agregar_btn_Click);
            // 
            // paneLogo
            // 
            this.paneLogo.Controls.Add(this.Home_btn);
            this.paneLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneLogo.Location = new System.Drawing.Point(0, 0);
            this.paneLogo.Name = "paneLogo";
            this.paneLogo.Size = new System.Drawing.Size(220, 140);
            this.paneLogo.TabIndex = 1;
            this.paneLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.paneLogo_Paint);
            // 
            // Home_btn
            // 
            this.Home_btn.Image = global::Segundo_Parcial_programacion.Properties.Resources.png_clipart_calendar_date_computer_icons_agenda_others_text_calendar;
            this.Home_btn.Location = new System.Drawing.Point(12, 12);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(187, 104);
            this.Home_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home_btn.TabIndex = 0;
            this.Home_btn.TabStop = false;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.MInimize_btn);
            this.panelTitleBar.Controls.Add(this.maximizar_btn);
            this.panelTitleBar.Controls.Add(this.Exit_btn);
            this.panelTitleBar.Controls.Add(this.titulochildrenform);
            this.panelTitleBar.Controls.Add(this.IconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(935, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // MInimize_btn
            // 
            this.MInimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MInimize_btn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MInimize_btn.IconColor = System.Drawing.Color.Black;
            this.MInimize_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MInimize_btn.IconSize = 20;
            this.MInimize_btn.Location = new System.Drawing.Point(833, 3);
            this.MInimize_btn.Name = "MInimize_btn";
            this.MInimize_btn.Size = new System.Drawing.Size(29, 23);
            this.MInimize_btn.TabIndex = 4;
            this.MInimize_btn.UseVisualStyleBackColor = true;
            this.MInimize_btn.Click += new System.EventHandler(this.MInimize_btn_Click);
            // 
            // maximizar_btn
            // 
            this.maximizar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar_btn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximizar_btn.IconColor = System.Drawing.SystemColors.InfoText;
            this.maximizar_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizar_btn.IconSize = 20;
            this.maximizar_btn.Location = new System.Drawing.Point(868, 4);
            this.maximizar_btn.Name = "maximizar_btn";
            this.maximizar_btn.Size = new System.Drawing.Size(29, 23);
            this.maximizar_btn.TabIndex = 3;
            this.maximizar_btn.UseVisualStyleBackColor = true;
            this.maximizar_btn.Click += new System.EventHandler(this.maximizar_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.ForeColor = System.Drawing.Color.Red;
            this.Exit_btn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Exit_btn.IconColor = System.Drawing.Color.Red;
            this.Exit_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exit_btn.IconSize = 20;
            this.Exit_btn.Location = new System.Drawing.Point(903, 4);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(29, 22);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // titulochildrenform
            // 
            this.titulochildrenform.AutoSize = true;
            this.titulochildrenform.ForeColor = System.Drawing.Color.Gainsboro;
            this.titulochildrenform.Location = new System.Drawing.Point(54, 28);
            this.titulochildrenform.Name = "titulochildrenform";
            this.titulochildrenform.Size = new System.Drawing.Size(35, 13);
            this.titulochildrenform.TabIndex = 1;
            this.titulochildrenform.Text = "Home";
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildForm.IconSize = 42;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(5, 11);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(42, 47);
            this.IconCurrentChildForm.TabIndex = 0;
            this.IconCurrentChildForm.TabStop = false;
            // 
            // panelshadow
            // 
            this.panelshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelshadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelshadow.Location = new System.Drawing.Point(220, 75);
            this.panelshadow.Name = "panelshadow";
            this.panelshadow.Size = new System.Drawing.Size(935, 9);
            this.panelshadow.TabIndex = 2;
            this.panelshadow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelshadow_Paint);
            // 
            // paneldesktop
            // 
            this.paneldesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(74)))));
            this.paneldesktop.Controls.Add(this.pictureBox1);
            this.paneldesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesktop.Location = new System.Drawing.Point(220, 84);
            this.paneldesktop.Name = "paneldesktop";
            this.paneldesktop.Size = new System.Drawing.Size(935, 587);
            this.paneldesktop.TabIndex = 3;
            this.paneldesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldesktop_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Segundo_Parcial_programacion.Properties.Resources.png_clipart_calendar_date_computer_icons_agenda_others_text_calendar;
            this.pictureBox1.Location = new System.Drawing.Point(380, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 671);
            this.Controls.Add(this.paneldesktop);
            this.Controls.Add(this.panelshadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelmenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelmenu.ResumeLayout(false);
            this.paneLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Home_btn)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.paneldesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private FontAwesome.Sharp.IconButton Agregar_btn;
        private System.Windows.Forms.Panel paneLogo;
        private FontAwesome.Sharp.IconButton Eliminar_btn;
        private FontAwesome.Sharp.IconButton Buscar_btn;
        private FontAwesome.Sharp.IconButton Editar_btn;
        private System.Windows.Forms.PictureBox Home_btn;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private System.Windows.Forms.Label titulochildrenform;
        private System.Windows.Forms.Panel panelshadow;
        private System.Windows.Forms.Panel paneldesktop;
        private FontAwesome.Sharp.IconButton MInimize_btn;
        private FontAwesome.Sharp.IconButton maximizar_btn;
        private FontAwesome.Sharp.IconButton Exit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

