namespace Segundo_Parcial_programacion.Forms
{
    partial class FormAgregar
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
            this.Paneladd = new System.Windows.Forms.Panel();
            this.Aceptar_add_btn = new FontAwesome.Sharp.IconButton();
            this.FechaNac_Label = new System.Windows.Forms.Label();
            this.Telefono_label = new System.Windows.Forms.Label();
            this.Direccion_label = new System.Windows.Forms.Label();
            this.Apellido_label = new System.Windows.Forms.Label();
            this.Nombre_Label = new System.Windows.Forms.Label();
            this.dateTimePicker1_Textbox = new System.Windows.Forms.DateTimePicker();
            this.Celular_TextBox = new System.Windows.Forms.TextBox();
            this.Direccion_TextBox = new System.Windows.Forms.TextBox();
            this.Apellido_TextBox = new System.Windows.Forms.TextBox();
            this.Nombre_TextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Personalizar_add_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Introduccion_Label = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Paneladd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Paneladd
            // 
            this.Paneladd.BackColor = System.Drawing.Color.Black;
            this.Paneladd.Controls.Add(this.Aceptar_add_btn);
            this.Paneladd.Controls.Add(this.FechaNac_Label);
            this.Paneladd.Controls.Add(this.Telefono_label);
            this.Paneladd.Controls.Add(this.Direccion_label);
            this.Paneladd.Controls.Add(this.Apellido_label);
            this.Paneladd.Controls.Add(this.Nombre_Label);
            this.Paneladd.Controls.Add(this.dateTimePicker1_Textbox);
            this.Paneladd.Controls.Add(this.Celular_TextBox);
            this.Paneladd.Controls.Add(this.Direccion_TextBox);
            this.Paneladd.Controls.Add(this.Apellido_TextBox);
            this.Paneladd.Controls.Add(this.Nombre_TextBox);
            this.Paneladd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Paneladd.Location = new System.Drawing.Point(0, 0);
            this.Paneladd.Name = "Paneladd";
            this.Paneladd.Size = new System.Drawing.Size(798, 476);
            this.Paneladd.TabIndex = 11;
            // 
            // Aceptar_add_btn
            // 
            this.Aceptar_add_btn.BackColor = System.Drawing.Color.Green;
            this.Aceptar_add_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aceptar_add_btn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.Aceptar_add_btn.IconColor = System.Drawing.Color.Black;
            this.Aceptar_add_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Aceptar_add_btn.IconSize = 20;
            this.Aceptar_add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aceptar_add_btn.Location = new System.Drawing.Point(31, 359);
            this.Aceptar_add_btn.Name = "Aceptar_add_btn";
            this.Aceptar_add_btn.Size = new System.Drawing.Size(75, 32);
            this.Aceptar_add_btn.TabIndex = 20;
            this.Aceptar_add_btn.Text = "Aceptar";
            this.Aceptar_add_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Aceptar_add_btn.UseVisualStyleBackColor = false;
            this.Aceptar_add_btn.Click += new System.EventHandler(this.Aceptar_add_btn_Click);
            // 
            // FechaNac_Label
            // 
            this.FechaNac_Label.AutoSize = true;
            this.FechaNac_Label.ForeColor = System.Drawing.Color.White;
            this.FechaNac_Label.Location = new System.Drawing.Point(20, 265);
            this.FechaNac_Label.Name = "FechaNac_Label";
            this.FechaNac_Label.Size = new System.Drawing.Size(109, 13);
            this.FechaNac_Label.TabIndex = 21;
            this.FechaNac_Label.Text = "Fecha de nacimiento:";
            // 
            // Telefono_label
            // 
            this.Telefono_label.AutoSize = true;
            this.Telefono_label.BackColor = System.Drawing.Color.Transparent;
            this.Telefono_label.ForeColor = System.Drawing.Color.White;
            this.Telefono_label.Location = new System.Drawing.Point(318, 139);
            this.Telefono_label.Name = "Telefono_label";
            this.Telefono_label.Size = new System.Drawing.Size(52, 13);
            this.Telefono_label.TabIndex = 19;
            this.Telefono_label.Text = "Telefono:";
            // 
            // Direccion_label
            // 
            this.Direccion_label.AutoSize = true;
            this.Direccion_label.BackColor = System.Drawing.Color.Transparent;
            this.Direccion_label.ForeColor = System.Drawing.Color.White;
            this.Direccion_label.Location = new System.Drawing.Point(20, 139);
            this.Direccion_label.Name = "Direccion_label";
            this.Direccion_label.Size = new System.Drawing.Size(55, 13);
            this.Direccion_label.TabIndex = 18;
            this.Direccion_label.Text = "Direccion:";
            // 
            // Apellido_label
            // 
            this.Apellido_label.AutoSize = true;
            this.Apellido_label.BackColor = System.Drawing.Color.Transparent;
            this.Apellido_label.ForeColor = System.Drawing.Color.White;
            this.Apellido_label.Location = new System.Drawing.Point(323, 44);
            this.Apellido_label.Name = "Apellido_label";
            this.Apellido_label.Size = new System.Drawing.Size(47, 13);
            this.Apellido_label.TabIndex = 17;
            this.Apellido_label.Text = "Apellido:";
            // 
            // Nombre_Label
            // 
            this.Nombre_Label.AutoSize = true;
            this.Nombre_Label.BackColor = System.Drawing.Color.Transparent;
            this.Nombre_Label.ForeColor = System.Drawing.Color.White;
            this.Nombre_Label.Location = new System.Drawing.Point(20, 38);
            this.Nombre_Label.Name = "Nombre_Label";
            this.Nombre_Label.Size = new System.Drawing.Size(47, 13);
            this.Nombre_Label.TabIndex = 16;
            this.Nombre_Label.Text = "Nombre:";
            // 
            // dateTimePicker1_Textbox
            // 
            this.dateTimePicker1_Textbox.Location = new System.Drawing.Point(23, 296);
            this.dateTimePicker1_Textbox.Name = "dateTimePicker1_Textbox";
            this.dateTimePicker1_Textbox.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker1_Textbox.TabIndex = 15;
            // 
            // Celular_TextBox
            // 
            this.Celular_TextBox.Location = new System.Drawing.Point(321, 168);
            this.Celular_TextBox.Multiline = true;
            this.Celular_TextBox.Name = "Celular_TextBox";
            this.Celular_TextBox.Size = new System.Drawing.Size(238, 22);
            this.Celular_TextBox.TabIndex = 14;
            // 
            // Direccion_TextBox
            // 
            this.Direccion_TextBox.Location = new System.Drawing.Point(23, 168);
            this.Direccion_TextBox.Multiline = true;
            this.Direccion_TextBox.Name = "Direccion_TextBox";
            this.Direccion_TextBox.Size = new System.Drawing.Size(238, 66);
            this.Direccion_TextBox.TabIndex = 13;
            // 
            // Apellido_TextBox
            // 
            this.Apellido_TextBox.Location = new System.Drawing.Point(321, 60);
            this.Apellido_TextBox.Multiline = true;
            this.Apellido_TextBox.Name = "Apellido_TextBox";
            this.Apellido_TextBox.Size = new System.Drawing.Size(238, 21);
            this.Apellido_TextBox.TabIndex = 12;
            // 
            // Nombre_TextBox
            // 
            this.Nombre_TextBox.Location = new System.Drawing.Point(23, 60);
            this.Nombre_TextBox.Multiline = true;
            this.Nombre_TextBox.Name = "Nombre_TextBox";
            this.Nombre_TextBox.Size = new System.Drawing.Size(238, 21);
            this.Nombre_TextBox.TabIndex = 11;
            this.Nombre_TextBox.TextChanged += new System.EventHandler(this.Nombre_TextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(584, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 476);
            this.panel2.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 139);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 337);
            this.panel5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modo Oscuro.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modo claro.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(28, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(128, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.Personalizar_add_label);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 39);
            this.panel4.TabIndex = 7;
            // 
            // Personalizar_add_label
            // 
            this.Personalizar_add_label.AutoSize = true;
            this.Personalizar_add_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Personalizar_add_label.Location = new System.Drawing.Point(72, 14);
            this.Personalizar_add_label.Name = "Personalizar_add_label";
            this.Personalizar_add_label.Size = new System.Drawing.Size(73, 13);
            this.Personalizar_add_label.TabIndex = 2;
            this.Personalizar_add_label.Text = "Personalizar...";
            this.Personalizar_add_label.Click += new System.EventHandler(this.Personalizar_add_label_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.Introduccion_Label);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 100);
            this.panel3.TabIndex = 1;
            // 
            // Introduccion_Label
            // 
            this.Introduccion_Label.AutoSize = true;
            this.Introduccion_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Introduccion_Label.Location = new System.Drawing.Point(54, 31);
            this.Introduccion_Label.Name = "Introduccion_Label";
            this.Introduccion_Label.Size = new System.Drawing.Size(124, 26);
            this.Introduccion_Label.TabIndex = 1;
            this.Introduccion_Label.Text = "Agrega tus datos\r\n a la agenda electronica.";
            this.Introduccion_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Paneladd);
            this.Name = "FormAgregar";
            this.Text = "FormAgregar";
            this.Paneladd.ResumeLayout(false);
            this.Paneladd.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Paneladd;
        private FontAwesome.Sharp.IconButton Aceptar_add_btn;
        private System.Windows.Forms.Label FechaNac_Label;
        private System.Windows.Forms.Label Telefono_label;
        private System.Windows.Forms.Label Direccion_label;
        private System.Windows.Forms.Label Apellido_label;
        private System.Windows.Forms.Label Nombre_Label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_Textbox;
        private System.Windows.Forms.TextBox Celular_TextBox;
        private System.Windows.Forms.TextBox Direccion_TextBox;
        private System.Windows.Forms.TextBox Apellido_TextBox;
        private System.Windows.Forms.TextBox Nombre_TextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Personalizar_add_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Introduccion_Label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}