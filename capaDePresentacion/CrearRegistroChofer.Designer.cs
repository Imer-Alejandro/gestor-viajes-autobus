namespace capaDePresentacion
{
    partial class CrearRegistroChofer
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
            this.telefonoRegistroChofer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreRegistroChofer = new System.Windows.Forms.TextBox();
            this.cedulaRegistroChofer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nacimientoRegistroChofer = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // telefonoRegistroChofer
            // 
            this.telefonoRegistroChofer.Location = new System.Drawing.Point(64, 174);
            this.telefonoRegistroChofer.Name = "telefonoRegistroChofer";
            this.telefonoRegistroChofer.Size = new System.Drawing.Size(265, 20);
            this.telefonoRegistroChofer.TabIndex = 17;
            this.telefonoRegistroChofer.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 47);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crear registro chofer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(64, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "registrar chofer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefono del chofer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre del chofer";
            // 
            // nombreRegistroChofer
            // 
            this.nombreRegistroChofer.Location = new System.Drawing.Point(67, 113);
            this.nombreRegistroChofer.Name = "nombreRegistroChofer";
            this.nombreRegistroChofer.Size = new System.Drawing.Size(265, 20);
            this.nombreRegistroChofer.TabIndex = 15;
            // 
            // cedulaRegistroChofer
            // 
            this.cedulaRegistroChofer.Location = new System.Drawing.Point(64, 237);
            this.cedulaRegistroChofer.Name = "cedulaRegistroChofer";
            this.cedulaRegistroChofer.Size = new System.Drawing.Size(265, 20);
            this.cedulaRegistroChofer.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cedula del chofer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // nacimientoRegistroChofer
            // 
            this.nacimientoRegistroChofer.Location = new System.Drawing.Point(67, 306);
            this.nacimientoRegistroChofer.Name = "nacimientoRegistroChofer";
            this.nacimientoRegistroChofer.Size = new System.Drawing.Size(262, 20);
            this.nacimientoRegistroChofer.TabIndex = 23;
            // 
            // CrearRegistroChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 443);
            this.Controls.Add(this.nacimientoRegistroChofer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cedulaRegistroChofer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefonoRegistroChofer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreRegistroChofer);
            this.Name = "CrearRegistroChofer";
            this.Text = "CrearRegistroChofer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox telefonoRegistroChofer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreRegistroChofer;
        private System.Windows.Forms.TextBox cedulaRegistroChofer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker nacimientoRegistroChofer;
    }
}