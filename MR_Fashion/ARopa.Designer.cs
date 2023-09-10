namespace MR_Fashion
{
    partial class ARopa
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
            this.label4 = new System.Windows.Forms.Label();
            this.guardar = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cp = new System.Windows.Forms.MaskedTextBox();
            this.cbxorigen = new System.Windows.Forms.ComboBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.MaskedTextBox();
            this.p = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxgenero = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataSet11 = new MR_Fashion.DataSet1();
            this.talla = new System.Windows.Forms.ComboBox();
            this.color = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "Registro de datos de productos";
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(157)))), ((int)(((byte)(0)))));
            this.guardar.FlatAppearance.BorderSize = 0;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.guardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guardar.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.guardar.IconColor = System.Drawing.Color.White;
            this.guardar.IconSize = 30;
            this.guardar.Location = new System.Drawing.Point(390, 410);
            this.guardar.Name = "guardar";
            this.guardar.Rotation = 0D;
            this.guardar.Size = new System.Drawing.Size(229, 39);
            this.guardar.TabIndex = 32;
            this.guardar.Text = "Guardar";
            this.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.color);
            this.groupBox2.Controls.Add(this.talla);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(172, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 85);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos extras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Talla:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Color:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cp);
            this.groupBox1.Controls.Add(this.cbxorigen);
            this.groupBox1.Controls.Add(this.precio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.p);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxgenero);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(172, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 198);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // cp
            // 
            this.cp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cp.Location = new System.Drawing.Point(296, 88);
            this.cp.Mask = "00000";
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(49, 26);
            this.cp.TabIndex = 49;
            this.cp.ValidatingType = typeof(int);
            this.cp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cp_KeyPress);
            // 
            // cbxorigen
            // 
            this.cbxorigen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxorigen.FormattingEnabled = true;
            this.cbxorigen.Items.AddRange(new object[] {
            "Nacional",
            "Extranjero"});
            this.cbxorigen.Location = new System.Drawing.Point(378, 152);
            this.cbxorigen.Name = "cbxorigen";
            this.cbxorigen.Size = new System.Drawing.Size(99, 28);
            this.cbxorigen.TabIndex = 48;
            this.cbxorigen.SelectedIndexChanged += new System.EventHandler(this.cbxorigen_SelectedIndexChanged);
            this.cbxorigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxorigen_KeyPress);
            // 
            // precio
            // 
            this.precio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(247, 120);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(52, 26);
            this.precio.TabIndex = 44;
            this.precio.TextChanged += new System.EventHandler(this.precio_TextChanged);
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Cantidad de productos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Precio por unidad:";
            // 
            // c
            // 
            this.c.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.c.Location = new System.Drawing.Point(279, 52);
            this.c.Mask = "0000-????";
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(93, 26);
            this.c.TabIndex = 34;
            this.c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.c_KeyPress);
            // 
            // p
            // 
            this.p.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.p.Location = new System.Drawing.Point(259, 20);
            this.p.Mask = "???????????????????????????????????????";
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(218, 26);
            this.p.TabIndex = 1;
            this.p.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Código del producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre producto:";
            // 
            // cbxgenero
            // 
            this.cbxgenero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxgenero.FormattingEnabled = true;
            this.cbxgenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbxgenero.Location = new System.Drawing.Point(174, 152);
            this.cbxgenero.Name = "cbxgenero";
            this.cbxgenero.Size = new System.Drawing.Size(99, 28);
            this.cbxgenero.TabIndex = 39;
            this.cbxgenero.SelectedIndexChanged += new System.EventHandler(this.cbxgenero_SelectedIndexChanged);
            this.cbxgenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxgenero_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(105, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Género:";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(157)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(390, 471);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(229, 39);
            this.iconButton1.TabIndex = 34;
            this.iconButton1.Text = "Cancelar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // talla
            // 
            this.talla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talla.FormattingEnabled = true;
            this.talla.Items.AddRange(new object[] {
            "XXS",
            "XS",
            "M",
            "L",
            "XL",
            "XXL"});
            this.talla.Location = new System.Drawing.Point(158, 20);
            this.talla.Name = "talla";
            this.talla.Size = new System.Drawing.Size(99, 28);
            this.talla.TabIndex = 64;
            this.talla.SelectedIndexChanged += new System.EventHandler(this.talla_SelectedIndexChanged);
            this.talla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.talla_KeyPress);
            // 
            // color
            // 
            this.color.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Celeste",
            "Blanco",
            "Verde",
            "Violeta",
            "Azul",
            "Rosa",
            "Negro"});
            this.color.Location = new System.Drawing.Point(378, 18);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(99, 28);
            this.color.TabIndex = 65;
            this.color.SelectedIndexChanged += new System.EventHandler(this.color_SelectedIndexChanged);
            this.color.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.color_KeyPress);
            // 
            // ARopa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ARopa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARopa";
            this.Load += new System.EventHandler(this.ARopa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton guardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox cp;
        private System.Windows.Forms.ComboBox cbxorigen;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox c;
        private System.Windows.Forms.MaskedTextBox p;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxgenero;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.ComboBox talla;
    }
}