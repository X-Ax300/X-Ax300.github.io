namespace Segundo_Parcial_programacion.Forms
{
    partial class FormModificar
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
            this.Panel_Mod_info = new System.Windows.Forms.Panel();
            this.Buscar_label_mod = new System.Windows.Forms.Label();
            this.buscar_box_mod = new System.Windows.Forms.TextBox();
            this.Direccion_Box_mod = new System.Windows.Forms.TextBox();
            this.dateTimePicker_box_mod = new System.Windows.Forms.DateTimePicker();
            this.Celular_Box_mod = new System.Windows.Forms.TextBox();
            this.Apellido_Box_mod = new System.Windows.Forms.TextBox();
            this.Nombre_Box_mod = new System.Windows.Forms.TextBox();
            this.Direccion_Label_Mod = new System.Windows.Forms.Label();
            this.Telefono_Label_mod = new System.Windows.Forms.Label();
            this.Fecha_Nac_Label_Mod = new System.Windows.Forms.Label();
            this.Apellido_Label_Mod = new System.Windows.Forms.Label();
            this.Nombre_Label_mod = new System.Windows.Forms.Label();
            this.Panel_mod_datagridview = new System.Windows.Forms.Panel();
            this.dataGridViewModificar = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Modo_claro_btn_mod = new System.Windows.Forms.Button();
            this.Modo_oscuro_btn_mod = new System.Windows.Forms.Button();
            this.Refrescar_btn_mod = new FontAwesome.Sharp.IconButton();
            this.Aceptar_btn_mod = new FontAwesome.Sharp.IconButton();
            this.Panel_Mod_info.SuspendLayout();
            this.Panel_mod_datagridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificar)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Mod_info
            // 
            this.Panel_Mod_info.AutoScroll = true;
            this.Panel_Mod_info.Controls.Add(this.Buscar_label_mod);
            this.Panel_Mod_info.Controls.Add(this.buscar_box_mod);
            this.Panel_Mod_info.Controls.Add(this.Refrescar_btn_mod);
            this.Panel_Mod_info.Controls.Add(this.Aceptar_btn_mod);
            this.Panel_Mod_info.Controls.Add(this.Direccion_Box_mod);
            this.Panel_Mod_info.Controls.Add(this.dateTimePicker_box_mod);
            this.Panel_Mod_info.Controls.Add(this.Celular_Box_mod);
            this.Panel_Mod_info.Controls.Add(this.Apellido_Box_mod);
            this.Panel_Mod_info.Controls.Add(this.Nombre_Box_mod);
            this.Panel_Mod_info.Controls.Add(this.Direccion_Label_Mod);
            this.Panel_Mod_info.Controls.Add(this.Telefono_Label_mod);
            this.Panel_Mod_info.Controls.Add(this.Fecha_Nac_Label_Mod);
            this.Panel_Mod_info.Controls.Add(this.Apellido_Label_Mod);
            this.Panel_Mod_info.Controls.Add(this.Nombre_Label_mod);
            this.Panel_Mod_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Mod_info.Location = new System.Drawing.Point(0, 246);
            this.Panel_Mod_info.Name = "Panel_Mod_info";
            this.Panel_Mod_info.Size = new System.Drawing.Size(919, 302);
            this.Panel_Mod_info.TabIndex = 0;
            // 
            // Buscar_label_mod
            // 
            this.Buscar_label_mod.AutoSize = true;
            this.Buscar_label_mod.Location = new System.Drawing.Point(29, 62);
            this.Buscar_label_mod.Name = "Buscar_label_mod";
            this.Buscar_label_mod.Size = new System.Drawing.Size(40, 13);
            this.Buscar_label_mod.TabIndex = 21;
            this.Buscar_label_mod.Text = "Buscar";
            this.Buscar_label_mod.Click += new System.EventHandler(this.Buscar_label_mod_Click);
            // 
            // buscar_box_mod
            // 
            this.buscar_box_mod.Location = new System.Drawing.Point(32, 80);
            this.buscar_box_mod.Multiline = true;
            this.buscar_box_mod.Name = "buscar_box_mod";
            this.buscar_box_mod.Size = new System.Drawing.Size(37, 33);
            this.buscar_box_mod.TabIndex = 20;
            // 
            // Direccion_Box_mod
            // 
            this.Direccion_Box_mod.Location = new System.Drawing.Point(477, 188);
            this.Direccion_Box_mod.Multiline = true;
            this.Direccion_Box_mod.Name = "Direccion_Box_mod";
            this.Direccion_Box_mod.Size = new System.Drawing.Size(238, 66);
            this.Direccion_Box_mod.TabIndex = 17;
            this.Direccion_Box_mod.TextChanged += new System.EventHandler(this.Direccion_Box_mod_TextChanged);
            // 
            // dateTimePicker_box_mod
            // 
            this.dateTimePicker_box_mod.Location = new System.Drawing.Point(249, 234);
            this.dateTimePicker_box_mod.Name = "dateTimePicker_box_mod";
            this.dateTimePicker_box_mod.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_box_mod.TabIndex = 16;
            this.dateTimePicker_box_mod.ValueChanged += new System.EventHandler(this.dateTimePicker_box_mod_ValueChanged);
            // 
            // Celular_Box_mod
            // 
            this.Celular_Box_mod.Location = new System.Drawing.Point(182, 172);
            this.Celular_Box_mod.Multiline = true;
            this.Celular_Box_mod.Name = "Celular_Box_mod";
            this.Celular_Box_mod.Size = new System.Drawing.Size(238, 21);
            this.Celular_Box_mod.TabIndex = 15;
            this.Celular_Box_mod.TextChanged += new System.EventHandler(this.Celular_Box_mod_TextChanged);
            // 
            // Apellido_Box_mod
            // 
            this.Apellido_Box_mod.Location = new System.Drawing.Point(182, 129);
            this.Apellido_Box_mod.Multiline = true;
            this.Apellido_Box_mod.Name = "Apellido_Box_mod";
            this.Apellido_Box_mod.Size = new System.Drawing.Size(238, 21);
            this.Apellido_Box_mod.TabIndex = 14;
            this.Apellido_Box_mod.TextChanged += new System.EventHandler(this.Apellido_Box_mod_TextChanged);
            // 
            // Nombre_Box_mod
            // 
            this.Nombre_Box_mod.Location = new System.Drawing.Point(182, 88);
            this.Nombre_Box_mod.Multiline = true;
            this.Nombre_Box_mod.Name = "Nombre_Box_mod";
            this.Nombre_Box_mod.Size = new System.Drawing.Size(238, 21);
            this.Nombre_Box_mod.TabIndex = 13;
            this.Nombre_Box_mod.TextChanged += new System.EventHandler(this.Nombre_Box_mod_TextChanged);
            // 
            // Direccion_Label_Mod
            // 
            this.Direccion_Label_Mod.AutoSize = true;
            this.Direccion_Label_Mod.Location = new System.Drawing.Point(474, 172);
            this.Direccion_Label_Mod.Name = "Direccion_Label_Mod";
            this.Direccion_Label_Mod.Size = new System.Drawing.Size(55, 13);
            this.Direccion_Label_Mod.TabIndex = 5;
            this.Direccion_Label_Mod.Text = "Direccion:";
            this.Direccion_Label_Mod.Click += new System.EventHandler(this.Direccion_Label_Mod_Click);
            // 
            // Telefono_Label_mod
            // 
            this.Telefono_Label_mod.AutoSize = true;
            this.Telefono_Label_mod.Location = new System.Drawing.Point(134, 177);
            this.Telefono_Label_mod.Name = "Telefono_Label_mod";
            this.Telefono_Label_mod.Size = new System.Drawing.Size(42, 13);
            this.Telefono_Label_mod.TabIndex = 4;
            this.Telefono_Label_mod.Text = "Celular:";
            this.Telefono_Label_mod.Click += new System.EventHandler(this.Telefono_Label_mod_Click);
            // 
            // Fecha_Nac_Label_Mod
            // 
            this.Fecha_Nac_Label_Mod.AutoSize = true;
            this.Fecha_Nac_Label_Mod.Location = new System.Drawing.Point(134, 234);
            this.Fecha_Nac_Label_Mod.Name = "Fecha_Nac_Label_Mod";
            this.Fecha_Nac_Label_Mod.Size = new System.Drawing.Size(109, 13);
            this.Fecha_Nac_Label_Mod.TabIndex = 3;
            this.Fecha_Nac_Label_Mod.Text = "Fecha de nacimiento:";
            this.Fecha_Nac_Label_Mod.Click += new System.EventHandler(this.Fecha_Nac_Label_Mod_Click);
            // 
            // Apellido_Label_Mod
            // 
            this.Apellido_Label_Mod.AutoSize = true;
            this.Apellido_Label_Mod.Location = new System.Drawing.Point(134, 132);
            this.Apellido_Label_Mod.Name = "Apellido_Label_Mod";
            this.Apellido_Label_Mod.Size = new System.Drawing.Size(47, 13);
            this.Apellido_Label_Mod.TabIndex = 2;
            this.Apellido_Label_Mod.Text = "Apellido:";
            this.Apellido_Label_Mod.Click += new System.EventHandler(this.Apellido_Label_Mod_Click);
            // 
            // Nombre_Label_mod
            // 
            this.Nombre_Label_mod.AutoSize = true;
            this.Nombre_Label_mod.Location = new System.Drawing.Point(134, 91);
            this.Nombre_Label_mod.Name = "Nombre_Label_mod";
            this.Nombre_Label_mod.Size = new System.Drawing.Size(47, 13);
            this.Nombre_Label_mod.TabIndex = 1;
            this.Nombre_Label_mod.Text = "Nombre:";
            this.Nombre_Label_mod.Click += new System.EventHandler(this.Nombre_Label_mod_Click);
            // 
            // Panel_mod_datagridview
            // 
            this.Panel_mod_datagridview.AutoScroll = true;
            this.Panel_mod_datagridview.Controls.Add(this.dataGridViewModificar);
            this.Panel_mod_datagridview.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_mod_datagridview.Location = new System.Drawing.Point(0, 0);
            this.Panel_mod_datagridview.Name = "Panel_mod_datagridview";
            this.Panel_mod_datagridview.Size = new System.Drawing.Size(919, 246);
            this.Panel_mod_datagridview.TabIndex = 1;
            this.Panel_mod_datagridview.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_mod_datagridview_Paint);
            // 
            // dataGridViewModificar
            // 
            this.dataGridViewModificar.AllowUserToAddRows = false;
            this.dataGridViewModificar.AllowUserToDeleteRows = false;
            this.dataGridViewModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModificar.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewModificar.Name = "dataGridViewModificar";
            this.dataGridViewModificar.ReadOnly = true;
            this.dataGridViewModificar.Size = new System.Drawing.Size(716, 216);
            this.dataGridViewModificar.TabIndex = 0;
            this.dataGridViewModificar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModificar_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.Modo_claro_btn_mod);
            this.panel4.Controls.Add(this.Modo_oscuro_btn_mod);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(731, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 302);
            this.panel4.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modo oscuro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modo claro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personalizar";
            // 
            // Modo_claro_btn_mod
            // 
            this.Modo_claro_btn_mod.BackColor = System.Drawing.Color.White;
            this.Modo_claro_btn_mod.FlatAppearance.BorderSize = 0;
            this.Modo_claro_btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modo_claro_btn_mod.Location = new System.Drawing.Point(110, 109);
            this.Modo_claro_btn_mod.Name = "Modo_claro_btn_mod";
            this.Modo_claro_btn_mod.Size = new System.Drawing.Size(75, 23);
            this.Modo_claro_btn_mod.TabIndex = 2;
            this.Modo_claro_btn_mod.UseVisualStyleBackColor = false;
            this.Modo_claro_btn_mod.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modo_oscuro_btn_mod
            // 
            this.Modo_oscuro_btn_mod.BackColor = System.Drawing.Color.Black;
            this.Modo_oscuro_btn_mod.FlatAppearance.BorderSize = 0;
            this.Modo_oscuro_btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modo_oscuro_btn_mod.Location = new System.Drawing.Point(14, 109);
            this.Modo_oscuro_btn_mod.Name = "Modo_oscuro_btn_mod";
            this.Modo_oscuro_btn_mod.Size = new System.Drawing.Size(75, 23);
            this.Modo_oscuro_btn_mod.TabIndex = 1;
            this.Modo_oscuro_btn_mod.UseVisualStyleBackColor = false;
            this.Modo_oscuro_btn_mod.Click += new System.EventHandler(this.button1_Click);
            // 
            // Refrescar_btn_mod
            // 
            this.Refrescar_btn_mod.BackColor = System.Drawing.Color.LightGreen;
            this.Refrescar_btn_mod.FlatAppearance.BorderSize = 0;
            this.Refrescar_btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refrescar_btn_mod.ForeColor = System.Drawing.Color.Black;
            this.Refrescar_btn_mod.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.Refrescar_btn_mod.IconColor = System.Drawing.Color.Black;
            this.Refrescar_btn_mod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Refrescar_btn_mod.IconSize = 20;
            this.Refrescar_btn_mod.Location = new System.Drawing.Point(13, 119);
            this.Refrescar_btn_mod.Name = "Refrescar_btn_mod";
            this.Refrescar_btn_mod.Size = new System.Drawing.Size(83, 26);
            this.Refrescar_btn_mod.TabIndex = 19;
            this.Refrescar_btn_mod.Text = "Refrescar";
            this.Refrescar_btn_mod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Refrescar_btn_mod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Refrescar_btn_mod.UseVisualStyleBackColor = false;
            this.Refrescar_btn_mod.Click += new System.EventHandler(this.Refrescar_btn_mod_Click);
            // 
            // Aceptar_btn_mod
            // 
            this.Aceptar_btn_mod.BackColor = System.Drawing.Color.LightGreen;
            this.Aceptar_btn_mod.FlatAppearance.BorderSize = 0;
            this.Aceptar_btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptar_btn_mod.ForeColor = System.Drawing.Color.Black;
            this.Aceptar_btn_mod.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.Aceptar_btn_mod.IconColor = System.Drawing.Color.Black;
            this.Aceptar_btn_mod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Aceptar_btn_mod.IconSize = 20;
            this.Aceptar_btn_mod.Location = new System.Drawing.Point(137, 264);
            this.Aceptar_btn_mod.Name = "Aceptar_btn_mod";
            this.Aceptar_btn_mod.Size = new System.Drawing.Size(75, 26);
            this.Aceptar_btn_mod.TabIndex = 18;
            this.Aceptar_btn_mod.Text = "Aceptar";
            this.Aceptar_btn_mod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aceptar_btn_mod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Aceptar_btn_mod.UseVisualStyleBackColor = false;
            this.Aceptar_btn_mod.Click += new System.EventHandler(this.Aceptar_btn_mod_Click);
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 548);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Panel_Mod_info);
            this.Controls.Add(this.Panel_mod_datagridview);
            this.Name = "FormModificar";
            this.Text = "FormModificar";
            this.Load += new System.EventHandler(this.FormModificar_Load);
            this.Panel_Mod_info.ResumeLayout(false);
            this.Panel_Mod_info.PerformLayout();
            this.Panel_mod_datagridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Mod_info;
        private System.Windows.Forms.Panel Panel_mod_datagridview;
        private System.Windows.Forms.DataGridView dataGridViewModificar;
        private System.Windows.Forms.Label Nombre_Label_mod;
        private System.Windows.Forms.Label Fecha_Nac_Label_Mod;
        private System.Windows.Forms.Label Apellido_Label_Mod;
        private System.Windows.Forms.Label Direccion_Label_Mod;
        private System.Windows.Forms.Label Telefono_Label_mod;
        private System.Windows.Forms.DateTimePicker dateTimePicker_box_mod;
        private System.Windows.Forms.TextBox Celular_Box_mod;
        private System.Windows.Forms.TextBox Apellido_Box_mod;
        private System.Windows.Forms.TextBox Nombre_Box_mod;
        private System.Windows.Forms.TextBox Direccion_Box_mod;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Modo_claro_btn_mod;
        private System.Windows.Forms.Button Modo_oscuro_btn_mod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Aceptar_btn_mod;
        private FontAwesome.Sharp.IconButton Refrescar_btn_mod;
        private System.Windows.Forms.Label Buscar_label_mod;
        private System.Windows.Forms.TextBox buscar_box_mod;
    }
}