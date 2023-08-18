namespace Segundo_Parcial_programacion.Forms
{
    partial class FormEliminar
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
            this.Panel_Datagried_delete = new System.Windows.Forms.Panel();
            this.dataGridView_delete = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modo_claro_btn_delete = new System.Windows.Forms.Button();
            this.modo_oscuro_btn_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_ID_delete = new System.Windows.Forms.Panel();
            this.Digita_ID_Label_delete = new System.Windows.Forms.Label();
            this.Buscar_label_mod = new System.Windows.Forms.Label();
            this.buscar_box_mod = new System.Windows.Forms.TextBox();
            this.panel_confirma_delete = new System.Windows.Forms.Panel();
            this.Text_Confirma_label_delete = new System.Windows.Forms.Label();
            this.Direccion_label_search_delete = new System.Windows.Forms.Label();
            this.FechNac_label_search_delete = new System.Windows.Forms.Label();
            this.Celular_label_search_delete = new System.Windows.Forms.Label();
            this.Apellido_label_search_delete = new System.Windows.Forms.Label();
            this.Nombre_label_search_delete = new System.Windows.Forms.Label();
            this.Direccion_Label_delete = new System.Windows.Forms.Label();
            this.FechNac_Label_delete = new System.Windows.Forms.Label();
            this.Celular_Label_delete = new System.Windows.Forms.Label();
            this.Apellido_Label_delete = new System.Windows.Forms.Label();
            this.Nombre_Label_delete = new System.Windows.Forms.Label();
            this.Find_btn_Delete = new FontAwesome.Sharp.IconButton();
            this.Eliminar_btn = new FontAwesome.Sharp.IconButton();
            this.Panel_Datagried_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_delete)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_ID_delete.SuspendLayout();
            this.panel_confirma_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Datagried_delete
            // 
            this.Panel_Datagried_delete.Controls.Add(this.dataGridView_delete);
            this.Panel_Datagried_delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Datagried_delete.Location = new System.Drawing.Point(0, 0);
            this.Panel_Datagried_delete.Name = "Panel_Datagried_delete";
            this.Panel_Datagried_delete.Size = new System.Drawing.Size(917, 214);
            this.Panel_Datagried_delete.TabIndex = 0;
            // 
            // dataGridView_delete
            // 
            this.dataGridView_delete.AllowUserToAddRows = false;
            this.dataGridView_delete.AllowUserToDeleteRows = false;
            this.dataGridView_delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_delete.Location = new System.Drawing.Point(20, 19);
            this.dataGridView_delete.Name = "dataGridView_delete";
            this.dataGridView_delete.ReadOnly = true;
            this.dataGridView_delete.Size = new System.Drawing.Size(776, 189);
            this.dataGridView_delete.TabIndex = 0;
            this.dataGridView_delete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.modo_claro_btn_delete);
            this.panel2.Controls.Add(this.modo_oscuro_btn_delete);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(752, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 314);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Modo oscuro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modo oscuro";
            // 
            // modo_claro_btn_delete
            // 
            this.modo_claro_btn_delete.BackColor = System.Drawing.Color.White;
            this.modo_claro_btn_delete.FlatAppearance.BorderSize = 0;
            this.modo_claro_btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modo_claro_btn_delete.Location = new System.Drawing.Point(50, 147);
            this.modo_claro_btn_delete.Name = "modo_claro_btn_delete";
            this.modo_claro_btn_delete.Size = new System.Drawing.Size(67, 23);
            this.modo_claro_btn_delete.TabIndex = 3;
            this.modo_claro_btn_delete.UseVisualStyleBackColor = false;
            this.modo_claro_btn_delete.Click += new System.EventHandler(this.modo_claro_btn_delete_Click);
            // 
            // modo_oscuro_btn_delete
            // 
            this.modo_oscuro_btn_delete.BackColor = System.Drawing.Color.Black;
            this.modo_oscuro_btn_delete.FlatAppearance.BorderSize = 0;
            this.modo_oscuro_btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modo_oscuro_btn_delete.Location = new System.Drawing.Point(49, 94);
            this.modo_oscuro_btn_delete.Name = "modo_oscuro_btn_delete";
            this.modo_oscuro_btn_delete.Size = new System.Drawing.Size(67, 23);
            this.modo_oscuro_btn_delete.TabIndex = 1;
            this.modo_oscuro_btn_delete.UseVisualStyleBackColor = false;
            this.modo_oscuro_btn_delete.Click += new System.EventHandler(this.modo_oscuro_btn_delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personalizar";
            // 
            // panel_ID_delete
            // 
            this.panel_ID_delete.Controls.Add(this.Digita_ID_Label_delete);
            this.panel_ID_delete.Controls.Add(this.Buscar_label_mod);
            this.panel_ID_delete.Controls.Add(this.buscar_box_mod);
            this.panel_ID_delete.Controls.Add(this.Find_btn_Delete);
            this.panel_ID_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ID_delete.Location = new System.Drawing.Point(0, 214);
            this.panel_ID_delete.Name = "panel_ID_delete";
            this.panel_ID_delete.Size = new System.Drawing.Size(140, 314);
            this.panel_ID_delete.TabIndex = 2;
            // 
            // Digita_ID_Label_delete
            // 
            this.Digita_ID_Label_delete.AutoSize = true;
            this.Digita_ID_Label_delete.Location = new System.Drawing.Point(17, 17);
            this.Digita_ID_Label_delete.Name = "Digita_ID_Label_delete";
            this.Digita_ID_Label_delete.Size = new System.Drawing.Size(103, 26);
            this.Digita_ID_Label_delete.TabIndex = 25;
            this.Digita_ID_Label_delete.Text = "Digita el ID \r\nque deseas eliminar.";
            // 
            // Buscar_label_mod
            // 
            this.Buscar_label_mod.AutoSize = true;
            this.Buscar_label_mod.Location = new System.Drawing.Point(53, 58);
            this.Buscar_label_mod.Name = "Buscar_label_mod";
            this.Buscar_label_mod.Size = new System.Drawing.Size(40, 13);
            this.Buscar_label_mod.TabIndex = 24;
            this.Buscar_label_mod.Text = "Buscar";
            // 
            // buscar_box_mod
            // 
            this.buscar_box_mod.Location = new System.Drawing.Point(56, 84);
            this.buscar_box_mod.Multiline = true;
            this.buscar_box_mod.Name = "buscar_box_mod";
            this.buscar_box_mod.Size = new System.Drawing.Size(37, 33);
            this.buscar_box_mod.TabIndex = 23;
            this.buscar_box_mod.TextChanged += new System.EventHandler(this.buscar_box_mod_TextChanged);
            // 
            // panel_confirma_delete
            // 
            this.panel_confirma_delete.Controls.Add(this.Text_Confirma_label_delete);
            this.panel_confirma_delete.Controls.Add(this.Eliminar_btn);
            this.panel_confirma_delete.Controls.Add(this.Direccion_label_search_delete);
            this.panel_confirma_delete.Controls.Add(this.FechNac_label_search_delete);
            this.panel_confirma_delete.Controls.Add(this.Celular_label_search_delete);
            this.panel_confirma_delete.Controls.Add(this.Apellido_label_search_delete);
            this.panel_confirma_delete.Controls.Add(this.Nombre_label_search_delete);
            this.panel_confirma_delete.Controls.Add(this.Direccion_Label_delete);
            this.panel_confirma_delete.Controls.Add(this.FechNac_Label_delete);
            this.panel_confirma_delete.Controls.Add(this.Celular_Label_delete);
            this.panel_confirma_delete.Controls.Add(this.Apellido_Label_delete);
            this.panel_confirma_delete.Controls.Add(this.Nombre_Label_delete);
            this.panel_confirma_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_confirma_delete.Location = new System.Drawing.Point(140, 214);
            this.panel_confirma_delete.Name = "panel_confirma_delete";
            this.panel_confirma_delete.Size = new System.Drawing.Size(612, 314);
            this.panel_confirma_delete.TabIndex = 3;
            this.panel_confirma_delete.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_confirma_delete_Paint);
            // 
            // Text_Confirma_label_delete
            // 
            this.Text_Confirma_label_delete.AutoSize = true;
            this.Text_Confirma_label_delete.Location = new System.Drawing.Point(14, 17);
            this.Text_Confirma_label_delete.Name = "Text_Confirma_label_delete";
            this.Text_Confirma_label_delete.Size = new System.Drawing.Size(222, 13);
            this.Text_Confirma_label_delete.TabIndex = 26;
            this.Text_Confirma_label_delete.Text = "Confirma que esto sea lo que deseas eliminar.";
            this.Text_Confirma_label_delete.Click += new System.EventHandler(this.Text_Confirma_label_delete_Click);
            // 
            // Direccion_label_search_delete
            // 
            this.Direccion_label_search_delete.AutoSize = true;
            this.Direccion_label_search_delete.Location = new System.Drawing.Point(65, 214);
            this.Direccion_label_search_delete.Name = "Direccion_label_search_delete";
            this.Direccion_label_search_delete.Size = new System.Drawing.Size(13, 13);
            this.Direccion_label_search_delete.TabIndex = 40;
            this.Direccion_label_search_delete.Text = "_";
            // 
            // FechNac_label_search_delete
            // 
            this.FechNac_label_search_delete.AutoSize = true;
            this.FechNac_label_search_delete.Location = new System.Drawing.Point(120, 176);
            this.FechNac_label_search_delete.Name = "FechNac_label_search_delete";
            this.FechNac_label_search_delete.Size = new System.Drawing.Size(13, 13);
            this.FechNac_label_search_delete.TabIndex = 39;
            this.FechNac_label_search_delete.Text = "_";
            this.FechNac_label_search_delete.Click += new System.EventHandler(this.FechNac_label_search_delete_Click);
            // 
            // Celular_label_search_delete
            // 
            this.Celular_label_search_delete.AutoSize = true;
            this.Celular_label_search_delete.Location = new System.Drawing.Point(62, 147);
            this.Celular_label_search_delete.Name = "Celular_label_search_delete";
            this.Celular_label_search_delete.Size = new System.Drawing.Size(13, 13);
            this.Celular_label_search_delete.TabIndex = 38;
            this.Celular_label_search_delete.Text = "_";
            // 
            // Apellido_label_search_delete
            // 
            this.Apellido_label_search_delete.AutoSize = true;
            this.Apellido_label_search_delete.Location = new System.Drawing.Point(62, 104);
            this.Apellido_label_search_delete.Name = "Apellido_label_search_delete";
            this.Apellido_label_search_delete.Size = new System.Drawing.Size(13, 13);
            this.Apellido_label_search_delete.TabIndex = 37;
            this.Apellido_label_search_delete.Text = "_";
            // 
            // Nombre_label_search_delete
            // 
            this.Nombre_label_search_delete.AutoSize = true;
            this.Nombre_label_search_delete.Location = new System.Drawing.Point(62, 58);
            this.Nombre_label_search_delete.Name = "Nombre_label_search_delete";
            this.Nombre_label_search_delete.Size = new System.Drawing.Size(13, 13);
            this.Nombre_label_search_delete.TabIndex = 36;
            this.Nombre_label_search_delete.Text = "_";
            // 
            // Direccion_Label_delete
            // 
            this.Direccion_Label_delete.AutoSize = true;
            this.Direccion_Label_delete.Location = new System.Drawing.Point(14, 214);
            this.Direccion_Label_delete.Name = "Direccion_Label_delete";
            this.Direccion_Label_delete.Size = new System.Drawing.Size(55, 13);
            this.Direccion_Label_delete.TabIndex = 35;
            this.Direccion_Label_delete.Text = "Direccion:";
            // 
            // FechNac_Label_delete
            // 
            this.FechNac_Label_delete.AutoSize = true;
            this.FechNac_Label_delete.Location = new System.Drawing.Point(14, 176);
            this.FechNac_Label_delete.Name = "FechNac_Label_delete";
            this.FechNac_Label_delete.Size = new System.Drawing.Size(109, 13);
            this.FechNac_Label_delete.TabIndex = 34;
            this.FechNac_Label_delete.Text = "Fecha de nacimiento:";
            // 
            // Celular_Label_delete
            // 
            this.Celular_Label_delete.AutoSize = true;
            this.Celular_Label_delete.Location = new System.Drawing.Point(14, 147);
            this.Celular_Label_delete.Name = "Celular_Label_delete";
            this.Celular_Label_delete.Size = new System.Drawing.Size(42, 13);
            this.Celular_Label_delete.TabIndex = 33;
            this.Celular_Label_delete.Text = "Celular:";
            // 
            // Apellido_Label_delete
            // 
            this.Apellido_Label_delete.AutoSize = true;
            this.Apellido_Label_delete.Location = new System.Drawing.Point(14, 104);
            this.Apellido_Label_delete.Name = "Apellido_Label_delete";
            this.Apellido_Label_delete.Size = new System.Drawing.Size(47, 13);
            this.Apellido_Label_delete.TabIndex = 32;
            this.Apellido_Label_delete.Text = "Apellido:";
            // 
            // Nombre_Label_delete
            // 
            this.Nombre_Label_delete.AutoSize = true;
            this.Nombre_Label_delete.Location = new System.Drawing.Point(14, 58);
            this.Nombre_Label_delete.Name = "Nombre_Label_delete";
            this.Nombre_Label_delete.Size = new System.Drawing.Size(47, 13);
            this.Nombre_Label_delete.TabIndex = 31;
            this.Nombre_Label_delete.Text = "Nombre:";
            // 
            // Find_btn_Delete
            // 
            this.Find_btn_Delete.BackColor = System.Drawing.Color.LightGreen;
            this.Find_btn_Delete.FlatAppearance.BorderSize = 0;
            this.Find_btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Find_btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.Find_btn_Delete.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.Find_btn_Delete.IconColor = System.Drawing.Color.Black;
            this.Find_btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Find_btn_Delete.IconSize = 20;
            this.Find_btn_Delete.Location = new System.Drawing.Point(37, 123);
            this.Find_btn_Delete.Name = "Find_btn_Delete";
            this.Find_btn_Delete.Size = new System.Drawing.Size(83, 26);
            this.Find_btn_Delete.TabIndex = 22;
            this.Find_btn_Delete.Text = "Buscar";
            this.Find_btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Find_btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Find_btn_Delete.UseVisualStyleBackColor = false;
            this.Find_btn_Delete.Click += new System.EventHandler(this.Find_btn_Delete_Click);
            // 
            // Eliminar_btn
            // 
            this.Eliminar_btn.BackColor = System.Drawing.Color.Red;
            this.Eliminar_btn.FlatAppearance.BorderSize = 0;
            this.Eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar_btn.ForeColor = System.Drawing.Color.White;
            this.Eliminar_btn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.Eliminar_btn.IconColor = System.Drawing.Color.White;
            this.Eliminar_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Eliminar_btn.IconSize = 20;
            this.Eliminar_btn.Location = new System.Drawing.Point(324, 129);
            this.Eliminar_btn.Name = "Eliminar_btn";
            this.Eliminar_btn.Size = new System.Drawing.Size(91, 31);
            this.Eliminar_btn.TabIndex = 25;
            this.Eliminar_btn.Text = "Eliminar";
            this.Eliminar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminar_btn.UseVisualStyleBackColor = false;
            this.Eliminar_btn.Click += new System.EventHandler(this.Eliminar_btn_Click);
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 528);
            this.Controls.Add(this.panel_confirma_delete);
            this.Controls.Add(this.panel_ID_delete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Datagried_delete);
            this.Name = "FormEliminar";
            this.Text = "FormEliminar";
            this.Load += new System.EventHandler(this.FormEliminar_Load);
            this.Panel_Datagried_delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_delete)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_ID_delete.ResumeLayout(false);
            this.panel_ID_delete.PerformLayout();
            this.panel_confirma_delete.ResumeLayout(false);
            this.panel_confirma_delete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Datagried_delete;
        private System.Windows.Forms.DataGridView dataGridView_delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_ID_delete;
        private System.Windows.Forms.Label Buscar_label_mod;
        private System.Windows.Forms.TextBox buscar_box_mod;
        private FontAwesome.Sharp.IconButton Find_btn_Delete;
        private System.Windows.Forms.Panel panel_confirma_delete;
        private System.Windows.Forms.Label Apellido_label_search_delete;
        private System.Windows.Forms.Label Nombre_label_search_delete;
        private System.Windows.Forms.Label Direccion_Label_delete;
        private System.Windows.Forms.Label FechNac_Label_delete;
        private System.Windows.Forms.Label Celular_Label_delete;
        private System.Windows.Forms.Label Apellido_Label_delete;
        private System.Windows.Forms.Label Nombre_Label_delete;
        private System.Windows.Forms.Label Direccion_label_search_delete;
        private System.Windows.Forms.Label FechNac_label_search_delete;
        private System.Windows.Forms.Label Celular_label_search_delete;
        private System.Windows.Forms.Label Digita_ID_Label_delete;
        private System.Windows.Forms.Label Text_Confirma_label_delete;
        private System.Windows.Forms.Button modo_oscuro_btn_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button modo_claro_btn_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton Eliminar_btn;
    }
}