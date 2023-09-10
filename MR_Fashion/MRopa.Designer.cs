namespace MR_Fashion
{
    partial class MRopa
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
            this.lcontrol = new System.Windows.Forms.Label();
            this.gbxmodificar = new System.Windows.Forms.GroupBox();
            this.color = new System.Windows.Forms.ComboBox();
            this.talla = new System.Windows.Forms.ComboBox();
            this.btnactualizar = new FontAwesome.Sharp.IconButton();
            this.txbcodigo = new System.Windows.Forms.MaskedTextBox();
            this.txbcantidad = new System.Windows.Forms.MaskedTextBox();
            this.txborigen = new System.Windows.Forms.ComboBox();
            this.txbprecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbnombre = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbgenero = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guardar = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cproducto = new System.Windows.Forms.MaskedTextBox();
            this.dataSet11 = new MR_Fashion.DataSet1();
            this.gbxmodificar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 30);
            this.label4.TabIndex = 38;
            this.label4.Text = "Modificar datos de productos";
            // 
            // lcontrol
            // 
            this.lcontrol.AutoSize = true;
            this.lcontrol.Location = new System.Drawing.Point(155, 375);
            this.lcontrol.Name = "lcontrol";
            this.lcontrol.Size = new System.Drawing.Size(0, 13);
            this.lcontrol.TabIndex = 37;
            this.lcontrol.Visible = false;
            // 
            // gbxmodificar
            // 
            this.gbxmodificar.Controls.Add(this.color);
            this.gbxmodificar.Controls.Add(this.talla);
            this.gbxmodificar.Controls.Add(this.btnactualizar);
            this.gbxmodificar.Controls.Add(this.txbcodigo);
            this.gbxmodificar.Controls.Add(this.txbcantidad);
            this.gbxmodificar.Controls.Add(this.txborigen);
            this.gbxmodificar.Controls.Add(this.txbprecio);
            this.gbxmodificar.Controls.Add(this.label8);
            this.gbxmodificar.Controls.Add(this.label6);
            this.gbxmodificar.Controls.Add(this.txbnombre);
            this.gbxmodificar.Controls.Add(this.label5);
            this.gbxmodificar.Controls.Add(this.label2);
            this.gbxmodificar.Controls.Add(this.label1);
            this.gbxmodificar.Controls.Add(this.txbgenero);
            this.gbxmodificar.Controls.Add(this.label13);
            this.gbxmodificar.Controls.Add(this.label3);
            this.gbxmodificar.Controls.Add(this.label7);
            this.gbxmodificar.Enabled = false;
            this.gbxmodificar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxmodificar.Location = new System.Drawing.Point(147, 207);
            this.gbxmodificar.Name = "gbxmodificar";
            this.gbxmodificar.Size = new System.Drawing.Size(657, 262);
            this.gbxmodificar.TabIndex = 36;
            this.gbxmodificar.TabStop = false;
            this.gbxmodificar.Text = "Datos del producto";
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
            this.color.Location = new System.Drawing.Point(341, 125);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(99, 28);
            this.color.TabIndex = 67;
            this.color.SelectedIndexChanged += new System.EventHandler(this.color_SelectedIndexChanged);
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
            this.talla.Location = new System.Drawing.Point(107, 127);
            this.talla.Name = "talla";
            this.talla.Size = new System.Drawing.Size(99, 28);
            this.talla.TabIndex = 66;
            this.talla.SelectedIndexChanged += new System.EventHandler(this.talla_SelectedIndexChanged);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(157)))), ((int)(((byte)(0)))));
            this.btnactualizar.FlatAppearance.BorderSize = 0;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnactualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnactualizar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnactualizar.IconColor = System.Drawing.Color.White;
            this.btnactualizar.IconSize = 30;
            this.btnactualizar.Location = new System.Drawing.Point(217, 205);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Rotation = 0D;
            this.btnactualizar.Size = new System.Drawing.Size(220, 39);
            this.btnactualizar.TabIndex = 64;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txbcodigo
            // 
            this.txbcodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txbcodigo.Location = new System.Drawing.Point(217, 49);
            this.txbcodigo.Mask = "0000-????";
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(80, 26);
            this.txbcodigo.TabIndex = 35;
            // 
            // txbcantidad
            // 
            this.txbcantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txbcantidad.Location = new System.Drawing.Point(545, 52);
            this.txbcantidad.Mask = "99999";
            this.txbcantidad.Name = "txbcantidad";
            this.txbcantidad.Size = new System.Drawing.Size(45, 26);
            this.txbcantidad.TabIndex = 49;
            this.txbcantidad.ValidatingType = typeof(int);
            // 
            // txborigen
            // 
            this.txborigen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txborigen.FormattingEnabled = true;
            this.txborigen.Items.AddRange(new object[] {
            "Nacional",
            "Extranjero"});
            this.txborigen.Location = new System.Drawing.Point(493, 82);
            this.txborigen.Name = "txborigen";
            this.txborigen.Size = new System.Drawing.Size(97, 28);
            this.txborigen.TabIndex = 48;
            this.txborigen.SelectedIndexChanged += new System.EventHandler(this.txborigen_SelectedIndexChanged);
            // 
            // txbprecio
            // 
            this.txbprecio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbprecio.Location = new System.Drawing.Point(190, 84);
            this.txbprecio.Name = "txbprecio";
            this.txbprecio.Size = new System.Drawing.Size(52, 26);
            this.txbprecio.TabIndex = 44;
            this.txbprecio.TextChanged += new System.EventHandler(this.txbprecio_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Cantidad de productos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Precio por unidad:";
            // 
            // txbnombre
            // 
            this.txbnombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txbnombre.Location = new System.Drawing.Point(208, 20);
            this.txbnombre.Mask = "???????????????????????????????????????";
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(384, 26);
            this.txbnombre.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Código del producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre producto:";
            // 
            // txbgenero
            // 
            this.txbgenero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbgenero.FormattingEnabled = true;
            this.txbgenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.txbgenero.Location = new System.Drawing.Point(318, 84);
            this.txbgenero.Name = "txbgenero";
            this.txbgenero.Size = new System.Drawing.Size(99, 28);
            this.txbgenero.TabIndex = 39;
            this.txbgenero.SelectedIndexChanged += new System.EventHandler(this.txbgenero_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(249, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Género:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Talla:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Color:";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(157)))), ((int)(((byte)(0)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btncancelar.IconColor = System.Drawing.Color.White;
            this.btncancelar.IconSize = 30;
            this.btncancelar.Location = new System.Drawing.Point(364, 493);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Rotation = 0D;
            this.btncancelar.Size = new System.Drawing.Size(220, 39);
            this.btncancelar.TabIndex = 65;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guardar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cproducto);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(147, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 104);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(157)))), ((int)(((byte)(0)))));
            this.guardar.FlatAppearance.BorderSize = 0;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.guardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guardar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.guardar.IconColor = System.Drawing.Color.White;
            this.guardar.IconSize = 30;
            this.guardar.Location = new System.Drawing.Point(208, 52);
            this.guardar.Name = "guardar";
            this.guardar.Rotation = 0D;
            this.guardar.Size = new System.Drawing.Size(229, 39);
            this.guardar.TabIndex = 37;
            this.guardar.Text = "Busacar";
            this.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Código del producto:";
            // 
            // cproducto
            // 
            this.cproducto.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cproducto.Location = new System.Drawing.Point(364, 20);
            this.cproducto.Mask = "0000-????";
            this.cproducto.Name = "cproducto";
            this.cproducto.Size = new System.Drawing.Size(80, 26);
            this.cproducto.TabIndex = 34;
            this.cproducto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cproducto_MaskInputRejected);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MRopa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lcontrol);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gbxmodificar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MRopa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MRopa";
            this.gbxmodificar.ResumeLayout(false);
            this.gbxmodificar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lcontrol;
        private System.Windows.Forms.GroupBox gbxmodificar;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnactualizar;
        private System.Windows.Forms.MaskedTextBox txbcodigo;
        private System.Windows.Forms.MaskedTextBox txbcantidad;
        private System.Windows.Forms.ComboBox txborigen;
        private System.Windows.Forms.TextBox txbprecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txbnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txbgenero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton guardar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox cproducto;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.ComboBox talla;
        private DataSet1 dataSet11;
    }
}