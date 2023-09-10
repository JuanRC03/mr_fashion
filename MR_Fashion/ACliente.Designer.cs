namespace MR_Fashion
{
    partial class ACliente
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
            this.guardar = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbdeuda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbdireccion = new System.Windows.Forms.TextBox();
            this.txbfechanacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txbnumero = new System.Windows.Forms.MaskedTextBox();
            this.cbxestadocivil = new System.Windows.Forms.ComboBox();
            this.cbxgenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbcedula = new System.Windows.Forms.MaskedTextBox();
            this.txbapellido = new System.Windows.Forms.MaskedTextBox();
            this.txbnombre = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet11 = new MR_Fashion.DataSet1();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Registro de datos";
            // 
            // lcontrol
            // 
            this.lcontrol.AutoSize = true;
            this.lcontrol.Location = new System.Drawing.Point(144, 388);
            this.lcontrol.Name = "lcontrol";
            this.lcontrol.Size = new System.Drawing.Size(0, 13);
            this.lcontrol.TabIndex = 28;
            this.lcontrol.Visible = false;
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
            this.guardar.Location = new System.Drawing.Point(248, 465);
            this.guardar.Name = "guardar";
            this.guardar.Rotation = 0D;
            this.guardar.Size = new System.Drawing.Size(229, 39);
            this.guardar.TabIndex = 27;
            this.guardar.Text = "Guardar";
            this.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbdeuda);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbdireccion);
            this.groupBox2.Controls.Add(this.txbfechanacimiento);
            this.groupBox2.Controls.Add(this.txbnumero);
            this.groupBox2.Controls.Add(this.cbxestadocivil);
            this.groupBox2.Controls.Add(this.cbxgenero);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(137, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 196);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Personales";
            // 
            // txbdeuda
            // 
            this.txbdeuda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbdeuda.Location = new System.Drawing.Point(209, 154);
            this.txbdeuda.Name = "txbdeuda";
            this.txbdeuda.Size = new System.Drawing.Size(122, 26);
            this.txbdeuda.TabIndex = 46;
            this.txbdeuda.TextChanged += new System.EventHandler(this.txbdeuda_TextChanged);
            this.txbdeuda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbdeuda_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Deuda:";
            // 
            // txbdireccion
            // 
            this.txbdireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbdireccion.Location = new System.Drawing.Point(219, 115);
            this.txbdireccion.Name = "txbdireccion";
            this.txbdireccion.Size = new System.Drawing.Size(323, 26);
            this.txbdireccion.TabIndex = 44;
            this.txbdireccion.TextChanged += new System.EventHandler(this.txbdireccion_TextChanged);
            this.txbdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbdireccion_KeyPress);
            // 
            // txbfechanacimiento
            // 
            this.txbfechanacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbfechanacimiento.Location = new System.Drawing.Point(278, 67);
            this.txbfechanacimiento.Mask = "00/00/0000";
            this.txbfechanacimiento.Name = "txbfechanacimiento";
            this.txbfechanacimiento.Size = new System.Drawing.Size(87, 26);
            this.txbfechanacimiento.TabIndex = 42;
            this.txbfechanacimiento.ValidatingType = typeof(System.DateTime);
            this.txbfechanacimiento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txbfechanacimiento_MaskInputRejected);
            this.txbfechanacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbfechanacimiento_KeyPress);
            // 
            // txbnumero
            // 
            this.txbnumero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnumero.Location = new System.Drawing.Point(444, 67);
            this.txbnumero.Mask = "000-000-0000";
            this.txbnumero.Name = "txbnumero";
            this.txbnumero.Size = new System.Drawing.Size(98, 26);
            this.txbnumero.TabIndex = 41;
            this.txbnumero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txbnumero_MaskInputRejected);
            this.txbnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbnumero_KeyPress);
            // 
            // cbxestadocivil
            // 
            this.cbxestadocivil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxestadocivil.FormattingEnabled = true;
            this.cbxestadocivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Viudo"});
            this.cbxestadocivil.Location = new System.Drawing.Point(423, 20);
            this.cbxestadocivil.Name = "cbxestadocivil";
            this.cbxestadocivil.Size = new System.Drawing.Size(119, 28);
            this.cbxestadocivil.TabIndex = 40;
            this.cbxestadocivil.SelectedIndexChanged += new System.EventHandler(this.cbxestadocivil_SelectedIndexChanged);
            this.cbxestadocivil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxestadocivil_KeyPress);
            // 
            // cbxgenero
            // 
            this.cbxgenero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxgenero.FormattingEnabled = true;
            this.cbxgenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbxgenero.Location = new System.Drawing.Point(209, 20);
            this.cbxgenero.Name = "cbxgenero";
            this.cbxgenero.Size = new System.Drawing.Size(99, 28);
            this.cbxgenero.TabIndex = 39;
            this.cbxgenero.SelectedIndexChanged += new System.EventHandler(this.cbxgenero_SelectedIndexChanged);
            this.cbxgenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxgenero_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Teléfono:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(133, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Fecha nacimiento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(326, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Estado civil:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(133, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Género:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbcedula);
            this.groupBox1.Controls.Add(this.txbapellido);
            this.groupBox1.Controls.Add(this.txbnombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(137, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 153);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // txbcedula
            // 
            this.txbcedula.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txbcedula.Location = new System.Drawing.Point(232, 107);
            this.txbcedula.Mask = "000000000-0";
            this.txbcedula.Name = "txbcedula";
            this.txbcedula.Size = new System.Drawing.Size(99, 26);
            this.txbcedula.TabIndex = 35;
            this.txbcedula.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txbcedula_MaskInputRejected);
            this.txbcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcedula_KeyPress);
            // 
            // txbapellido
            // 
            this.txbapellido.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txbapellido.Location = new System.Drawing.Point(209, 75);
            this.txbapellido.Mask = "???????????????????????????????????????";
            this.txbapellido.Name = "txbapellido";
            this.txbapellido.Size = new System.Drawing.Size(333, 26);
            this.txbapellido.TabIndex = 34;
            this.txbapellido.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txbapellido_MaskInputRejected);
            this.txbapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbapellido_KeyPress);
            // 
            // txbnombre
            // 
            this.txbnombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txbnombre.Location = new System.Drawing.Point(209, 34);
            this.txbnombre.Mask = "???????????????????????????????????????";
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(333, 26);
            this.txbnombre.TabIndex = 33;
            this.txbnombre.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txbnombre_MaskInputRejected);
            this.txbnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbnombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nº Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre:";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(157)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(483, 465);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(229, 39);
            this.iconButton1.TabIndex = 30;
            this.iconButton1.Text = "Cancelar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ACliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lcontrol);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ACliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACliente";
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
        public System.Windows.Forms.Label lcontrol;
        private FontAwesome.Sharp.IconButton guardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbdireccion;
        private System.Windows.Forms.MaskedTextBox txbfechanacimiento;
        private System.Windows.Forms.MaskedTextBox txbnumero;
        private System.Windows.Forms.ComboBox cbxestadocivil;
        private System.Windows.Forms.ComboBox cbxgenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txbcedula;
        private System.Windows.Forms.MaskedTextBox txbapellido;
        private System.Windows.Forms.MaskedTextBox txbnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.TextBox txbdeuda;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}