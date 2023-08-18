namespace Segundo_Parcial_programacion.Forms
{
    partial class FormBuscar
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
            this.panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelconfirmadelete = new System.Windows.Forms.Panel();
            this.Text_Confirma_label_delete = new System.Windows.Forms.Label();
            this.Direccion_label_search_delete = new System.Windows.Forms.Label();
            this.FechNac_label_search_delete = new System.Windows.Forms.Label();
            this.Celular_label_search_delete = new System.Windows.Forms.Label();
            this.Apellido_label_search_delete = new System.Windows.Forms.Label();
            this.Nombre_label_search_delete = new System.Windows.Forms.Label();
            this.Direccion_Label_delete = new System.Windows.Forms.Label();
            this.FechNac_Label_delete = new System.Windows.Forms.Label();
            this.Apellido_Label_delete = new System.Windows.Forms.Label();
            this.Nombre_Label_delete = new System.Windows.Forms.Label();
            this.Digita_ID_Label_delete = new System.Windows.Forms.Label();
            this.Buscar_label_mod = new System.Windows.Forms.Label();
            this.buscar_box_mod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Modo_claro_btn_mod = new System.Windows.Forms.Button();
            this.Modo_oscuro_btn_mod = new System.Windows.Forms.Button();
            this.Find_btn_Delete = new FontAwesome.Sharp.IconButton();
            this.dataGridView_delete = new System.Windows.Forms.DataGridView();
            this.agenda_electronicaDataSet = new Segundo_Parcial_programacion.agenda_electronicaDataSet();
            this.agendaelectronicatableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agenda_electronicatableTableAdapter = new Segundo_Parcial_programacion.agenda_electronicaDataSetTableAdapters.agenda_electronicatableTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelconfirmadelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenda_electronicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaelectronicatableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dataGridView_delete);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 199);
            this.panel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Modo_claro_btn_mod);
            this.panel2.Controls.Add(this.Modo_oscuro_btn_mod);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(600, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 251);
            this.panel2.TabIndex = 1;
            // 
            // panelconfirmadelete
            // 
            this.panelconfirmadelete.Controls.Add(this.Text_Confirma_label_delete);
            this.panelconfirmadelete.Controls.Add(this.Direccion_label_search_delete);
            this.panelconfirmadelete.Controls.Add(this.FechNac_label_search_delete);
            this.panelconfirmadelete.Controls.Add(this.Celular_label_search_delete);
            this.panelconfirmadelete.Controls.Add(this.Apellido_label_search_delete);
            this.panelconfirmadelete.Controls.Add(this.Nombre_label_search_delete);
            this.panelconfirmadelete.Controls.Add(this.Direccion_Label_delete);
            this.panelconfirmadelete.Controls.Add(this.FechNac_Label_delete);
            this.panelconfirmadelete.Controls.Add(this.label1);
            this.panelconfirmadelete.Controls.Add(this.Apellido_Label_delete);
            this.panelconfirmadelete.Controls.Add(this.Nombre_Label_delete);
            this.panelconfirmadelete.Controls.Add(this.Digita_ID_Label_delete);
            this.panelconfirmadelete.Controls.Add(this.Buscar_label_mod);
            this.panelconfirmadelete.Controls.Add(this.buscar_box_mod);
            this.panelconfirmadelete.Controls.Add(this.Find_btn_Delete);
            this.panelconfirmadelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelconfirmadelete.Location = new System.Drawing.Point(0, 199);
            this.panelconfirmadelete.Name = "panelconfirmadelete";
            this.panelconfirmadelete.Size = new System.Drawing.Size(600, 251);
            this.panelconfirmadelete.TabIndex = 2;
            this.panelconfirmadelete.Paint += new System.Windows.Forms.PaintEventHandler(this.panelconfirmadelete_Paint);
            // 
            // Text_Confirma_label_delete
            // 
            this.Text_Confirma_label_delete.AutoSize = true;
            this.Text_Confirma_label_delete.Location = new System.Drawing.Point(172, 32);
            this.Text_Confirma_label_delete.Name = "Text_Confirma_label_delete";
            this.Text_Confirma_label_delete.Size = new System.Drawing.Size(156, 13);
            this.Text_Confirma_label_delete.TabIndex = 45;
            this.Text_Confirma_label_delete.Text = "Para que se vea mas detallado.";
            // 
            // Direccion_label_search_delete
            // 
            this.Direccion_label_search_delete.AutoSize = true;
            this.Direccion_label_search_delete.Location = new System.Drawing.Point(234, 208);
            this.Direccion_label_search_delete.Name = "Direccion_label_search_delete";
            this.Direccion_label_search_delete.Size = new System.Drawing.Size(13, 13);
            this.Direccion_label_search_delete.TabIndex = 55;
            this.Direccion_label_search_delete.Text = "_";
            // 
            // FechNac_label_search_delete
            // 
            this.FechNac_label_search_delete.AutoSize = true;
            this.FechNac_label_search_delete.Location = new System.Drawing.Point(283, 166);
            this.FechNac_label_search_delete.Name = "FechNac_label_search_delete";
            this.FechNac_label_search_delete.Size = new System.Drawing.Size(13, 13);
            this.FechNac_label_search_delete.TabIndex = 54;
            this.FechNac_label_search_delete.Text = "_";
            // 
            // Celular_label_search_delete
            // 
            this.Celular_label_search_delete.AutoSize = true;
            this.Celular_label_search_delete.Location = new System.Drawing.Point(225, 131);
            this.Celular_label_search_delete.Name = "Celular_label_search_delete";
            this.Celular_label_search_delete.Size = new System.Drawing.Size(13, 13);
            this.Celular_label_search_delete.TabIndex = 53;
            this.Celular_label_search_delete.Text = "_";
            // 
            // Apellido_label_search_delete
            // 
            this.Apellido_label_search_delete.AutoSize = true;
            this.Apellido_label_search_delete.Location = new System.Drawing.Point(220, 96);
            this.Apellido_label_search_delete.Name = "Apellido_label_search_delete";
            this.Apellido_label_search_delete.Size = new System.Drawing.Size(13, 13);
            this.Apellido_label_search_delete.TabIndex = 52;
            this.Apellido_label_search_delete.Text = "_";
            // 
            // Nombre_label_search_delete
            // 
            this.Nombre_label_search_delete.AutoSize = true;
            this.Nombre_label_search_delete.Location = new System.Drawing.Point(219, 71);
            this.Nombre_label_search_delete.Name = "Nombre_label_search_delete";
            this.Nombre_label_search_delete.Size = new System.Drawing.Size(13, 13);
            this.Nombre_label_search_delete.TabIndex = 51;
            this.Nombre_label_search_delete.Text = "_";
            // 
            // Direccion_Label_delete
            // 
            this.Direccion_Label_delete.AutoSize = true;
            this.Direccion_Label_delete.Location = new System.Drawing.Point(177, 208);
            this.Direccion_Label_delete.Name = "Direccion_Label_delete";
            this.Direccion_Label_delete.Size = new System.Drawing.Size(55, 13);
            this.Direccion_Label_delete.TabIndex = 50;
            this.Direccion_Label_delete.Text = "Direccion:";
            // 
            // FechNac_Label_delete
            // 
            this.FechNac_Label_delete.AutoSize = true;
            this.FechNac_Label_delete.Location = new System.Drawing.Point(177, 166);
            this.FechNac_Label_delete.Name = "FechNac_Label_delete";
            this.FechNac_Label_delete.Size = new System.Drawing.Size(109, 13);
            this.FechNac_Label_delete.TabIndex = 49;
            this.FechNac_Label_delete.Text = "Fecha de nacimiento:";
            // 
            // Apellido_Label_delete
            // 
            this.Apellido_Label_delete.AutoSize = true;
            this.Apellido_Label_delete.Location = new System.Drawing.Point(172, 96);
            this.Apellido_Label_delete.Name = "Apellido_Label_delete";
            this.Apellido_Label_delete.Size = new System.Drawing.Size(47, 13);
            this.Apellido_Label_delete.TabIndex = 47;
            this.Apellido_Label_delete.Text = "Apellido:";
            // 
            // Nombre_Label_delete
            // 
            this.Nombre_Label_delete.AutoSize = true;
            this.Nombre_Label_delete.Location = new System.Drawing.Point(172, 71);
            this.Nombre_Label_delete.Name = "Nombre_Label_delete";
            this.Nombre_Label_delete.Size = new System.Drawing.Size(47, 13);
            this.Nombre_Label_delete.TabIndex = 46;
            this.Nombre_Label_delete.Text = "Nombre:";
            // 
            // Digita_ID_Label_delete
            // 
            this.Digita_ID_Label_delete.AutoSize = true;
            this.Digita_ID_Label_delete.Location = new System.Drawing.Point(39, 58);
            this.Digita_ID_Label_delete.Name = "Digita_ID_Label_delete";
            this.Digita_ID_Label_delete.Size = new System.Drawing.Size(65, 26);
            this.Digita_ID_Label_delete.TabIndex = 44;
            this.Digita_ID_Label_delete.Text = "Digita el ID \r\nque deseas:";
            // 
            // Buscar_label_mod
            // 
            this.Buscar_label_mod.AutoSize = true;
            this.Buscar_label_mod.Location = new System.Drawing.Point(39, 25);
            this.Buscar_label_mod.Name = "Buscar_label_mod";
            this.Buscar_label_mod.Size = new System.Drawing.Size(40, 13);
            this.Buscar_label_mod.TabIndex = 43;
            this.Buscar_label_mod.Text = "Buscar";
            this.Buscar_label_mod.Click += new System.EventHandler(this.Buscar_label_mod_Click);
            // 
            // buscar_box_mod
            // 
            this.buscar_box_mod.Location = new System.Drawing.Point(53, 109);
            this.buscar_box_mod.Multiline = true;
            this.buscar_box_mod.Name = "buscar_box_mod";
            this.buscar_box_mod.Size = new System.Drawing.Size(37, 33);
            this.buscar_box_mod.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Modo oscuro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Modo claro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Personalizar";
            // 
            // Modo_claro_btn_mod
            // 
            this.Modo_claro_btn_mod.BackColor = System.Drawing.Color.White;
            this.Modo_claro_btn_mod.FlatAppearance.BorderSize = 0;
            this.Modo_claro_btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modo_claro_btn_mod.Location = new System.Drawing.Point(113, 136);
            this.Modo_claro_btn_mod.Name = "Modo_claro_btn_mod";
            this.Modo_claro_btn_mod.Size = new System.Drawing.Size(75, 23);
            this.Modo_claro_btn_mod.TabIndex = 7;
            this.Modo_claro_btn_mod.UseVisualStyleBackColor = false;
            this.Modo_claro_btn_mod.Click += new System.EventHandler(this.Modo_claro_btn_mod_Click);
            // 
            // Modo_oscuro_btn_mod
            // 
            this.Modo_oscuro_btn_mod.BackColor = System.Drawing.Color.Black;
            this.Modo_oscuro_btn_mod.FlatAppearance.BorderSize = 0;
            this.Modo_oscuro_btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modo_oscuro_btn_mod.Location = new System.Drawing.Point(17, 136);
            this.Modo_oscuro_btn_mod.Name = "Modo_oscuro_btn_mod";
            this.Modo_oscuro_btn_mod.Size = new System.Drawing.Size(75, 23);
            this.Modo_oscuro_btn_mod.TabIndex = 6;
            this.Modo_oscuro_btn_mod.UseVisualStyleBackColor = false;
            this.Modo_oscuro_btn_mod.Click += new System.EventHandler(this.Modo_oscuro_btn_mod_Click);
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
            this.Find_btn_Delete.Location = new System.Drawing.Point(32, 166);
            this.Find_btn_Delete.Name = "Find_btn_Delete";
            this.Find_btn_Delete.Size = new System.Drawing.Size(83, 26);
            this.Find_btn_Delete.TabIndex = 41;
            this.Find_btn_Delete.Text = "Buscar";
            this.Find_btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Find_btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Find_btn_Delete.UseVisualStyleBackColor = false;
            this.Find_btn_Delete.Click += new System.EventHandler(this.Find_btn_Delete_Click);
            // 
            // dataGridView_delete
            // 
            this.dataGridView_delete.AllowUserToAddRows = false;
            this.dataGridView_delete.AllowUserToDeleteRows = false;
            this.dataGridView_delete.AutoGenerateColumns = false;
            this.dataGridView_delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_delete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView_delete.DataSource = this.agendaelectronicatableBindingSource;
            this.dataGridView_delete.Location = new System.Drawing.Point(275, 5);
            this.dataGridView_delete.Name = "dataGridView_delete";
            this.dataGridView_delete.ReadOnly = true;
            this.dataGridView_delete.Size = new System.Drawing.Size(250, 189);
            this.dataGridView_delete.TabIndex = 1;
            this.dataGridView_delete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_delete_CellContentClick);
            // 
            // agenda_electronicaDataSet
            // 
            this.agenda_electronicaDataSet.DataSetName = "agenda_electronicaDataSet";
            this.agenda_electronicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaelectronicatableBindingSource
            // 
            this.agendaelectronicatableBindingSource.DataMember = "agenda_electronicatable";
            this.agendaelectronicatableBindingSource.DataSource = this.agenda_electronicaDataSet;
            // 
            // agenda_electronicatableTableAdapter
            // 
            this.agenda_electronicatableTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelconfirmadelete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.Name = "FormBuscar";
            this.Text = "FormBuscar";
            this.Load += new System.EventHandler(this.FormBuscar_Load);
            this.panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelconfirmadelete.ResumeLayout(false);
            this.panelconfirmadelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenda_electronicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaelectronicatableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelconfirmadelete;
        private System.Windows.Forms.Label Text_Confirma_label_delete;
        private System.Windows.Forms.Label Direccion_label_search_delete;
        private System.Windows.Forms.Label FechNac_label_search_delete;
        private System.Windows.Forms.Label Celular_label_search_delete;
        private System.Windows.Forms.Label Apellido_label_search_delete;
        private System.Windows.Forms.Label Nombre_label_search_delete;
        private System.Windows.Forms.Label Direccion_Label_delete;
        private System.Windows.Forms.Label FechNac_Label_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Apellido_Label_delete;
        private System.Windows.Forms.Label Nombre_Label_delete;
        private System.Windows.Forms.Label Digita_ID_Label_delete;
        private System.Windows.Forms.Label Buscar_label_mod;
        private System.Windows.Forms.TextBox buscar_box_mod;
        private FontAwesome.Sharp.IconButton Find_btn_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Modo_claro_btn_mod;
        private System.Windows.Forms.Button Modo_oscuro_btn_mod;
        private System.Windows.Forms.DataGridView dataGridView_delete;
        private agenda_electronicaDataSet agenda_electronicaDataSet;
        private System.Windows.Forms.BindingSource agendaelectronicatableBindingSource;
        private agenda_electronicaDataSetTableAdapters.agenda_electronicatableTableAdapter agenda_electronicatableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}