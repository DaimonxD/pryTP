namespace pryTP
{
    partial class frmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboxLocales = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.txtFila1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFila2 = new System.Windows.Forms.TextBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxLocales
            // 
            this.cboxLocales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxLocales.FormattingEnabled = true;
            this.cboxLocales.Items.AddRange(new object[] {
            "Quenaken",
            "Onas",
            "Tobas"});
            this.cboxLocales.Location = new System.Drawing.Point(16, 77);
            this.cboxLocales.Name = "cboxLocales";
            this.cboxLocales.Size = new System.Drawing.Size(151, 21);
            this.cboxLocales.TabIndex = 0;
            this.cboxLocales.SelectedIndexChanged += new System.EventHandler(this.cboxLocales_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(433, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 28);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro de Reservas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Locales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Área Azul";
            // 
            // txtAzul
            // 
            this.txtAzul.Location = new System.Drawing.Point(88, 50);
            this.txtAzul.Multiline = true;
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.ReadOnly = true;
            this.txtAzul.Size = new System.Drawing.Size(95, 21);
            this.txtAzul.TabIndex = 7;
            // 
            // txtFila1
            // 
            this.txtFila1.Location = new System.Drawing.Point(285, 50);
            this.txtFila1.Multiline = true;
            this.txtFila1.Name = "txtFila1";
            this.txtFila1.ReadOnly = true;
            this.txtFila1.Size = new System.Drawing.Size(95, 21);
            this.txtFila1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVerde);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFila2);
            this.groupBox1.Controls.Add(this.txtAzul);
            this.groupBox1.Controls.Add(this.txtFila1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 147);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Asientos por Fila";
            // 
            // txtVerde
            // 
            this.txtVerde.Location = new System.Drawing.Point(88, 85);
            this.txtVerde.Multiline = true;
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.ReadOnly = true;
            this.txtVerde.Size = new System.Drawing.Size(95, 21);
            this.txtVerde.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Área Verde";
            // 
            // txtFila2
            // 
            this.txtFila2.Location = new System.Drawing.Point(285, 85);
            this.txtFila2.Multiline = true;
            this.txtFila2.Name = "txtFila2";
            this.txtFila2.ReadOnly = true;
            this.txtFila2.Size = new System.Drawing.Size(95, 21);
            this.txtFila2.TabIndex = 13;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(368, 280);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 12;
            this.btnReservar.Text = "&Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 315);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxLocales);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Reservas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxLocales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAzul;
        private System.Windows.Forms.TextBox txtFila1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVerde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFila2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReservar;
    }
}

