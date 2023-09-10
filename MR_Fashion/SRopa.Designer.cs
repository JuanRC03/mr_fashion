namespace MR_Fashion
{
    partial class SRopa
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.canp = new System.Windows.Forms.Label();
            this.cp = new System.Windows.Forms.Label();
            this.np = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guardar = new FontAwesome.Sharp.IconButton();
            this.cproducto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prep = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataSet11 = new MR_Fashion.DataSet1();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 30);
            this.label4.TabIndex = 39;
            this.label4.Text = "Productos agotados o en Stock";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prep);
            this.groupBox2.Controls.Add(this.canp);
            this.groupBox2.Controls.Add(this.cp);
            this.groupBox2.Controls.Add(this.np);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 155);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de producto";
            // 
            // canp
            // 
            this.canp.AutoSize = true;
            this.canp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canp.Location = new System.Drawing.Point(378, 85);
            this.canp.Name = "canp";
            this.canp.Size = new System.Drawing.Size(0, 20);
            this.canp.TabIndex = 72;
            // 
            // cp
            // 
            this.cp.AutoSize = true;
            this.cp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp.Location = new System.Drawing.Point(361, 49);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(0, 20);
            this.cp.TabIndex = 71;
            // 
            // np
            // 
            this.np.AutoSize = true;
            this.np.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np.Location = new System.Drawing.Point(335, 17);
            this.np.Name = "np";
            this.np.Size = new System.Drawing.Size(0, 20);
            this.np.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(193, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "Cantidad de productos:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(190, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 20);
            this.label12.TabIndex = 66;
            this.label12.Text = "Código del producto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(190, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 20);
            this.label14.TabIndex = 65;
            this.label14.Text = "Nombre producto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guardar);
            this.groupBox1.Controls.Add(this.cproducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 105);
            this.groupBox1.TabIndex = 37;
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
            this.guardar.Location = new System.Drawing.Point(197, 52);
            this.guardar.Name = "guardar";
            this.guardar.Rotation = 0D;
            this.guardar.Size = new System.Drawing.Size(229, 39);
            this.guardar.TabIndex = 35;
            this.guardar.Text = "Busacar";
            this.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // cproducto
            // 
            this.cproducto.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cproducto.Location = new System.Drawing.Point(349, 20);
            this.cproducto.Mask = "0000-????";
            this.cproducto.Name = "cproducto";
            this.cproducto.Size = new System.Drawing.Size(103, 26);
            this.cproducto.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Código del producto:";
            // 
            // prep
            // 
            this.prep.AutoSize = true;
            this.prep.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prep.Location = new System.Drawing.Point(335, 114);
            this.prep.Name = "prep";
            this.prep.Size = new System.Drawing.Size(0, 20);
            this.prep.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(193, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 68;
            this.label11.Text = "Precio por unidad:";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SRopa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SRopa";
            this.Size = new System.Drawing.Size(732, 420);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label prep;
        private System.Windows.Forms.Label canp;
        private System.Windows.Forms.Label cp;
        private System.Windows.Forms.Label np;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton guardar;
        private System.Windows.Forms.MaskedTextBox cproducto;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet11;
    }
}
