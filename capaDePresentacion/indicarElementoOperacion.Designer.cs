namespace capaDePresentacion
{
    partial class indicarElementoOperacion
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
            this.selectorOperaciones = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectorOperaciones
            // 
            this.selectorOperaciones.FormattingEnabled = true;
            this.selectorOperaciones.Items.AddRange(new object[] {
            "Ruta",
            "Chofer",
            "Guagua"});
            this.selectorOperaciones.Location = new System.Drawing.Point(60, 99);
            this.selectorOperaciones.Name = "selectorOperaciones";
            this.selectorOperaciones.Size = new System.Drawing.Size(276, 21);
            this.selectorOperaciones.TabIndex = 5;
            this.selectorOperaciones.SelectedIndexChanged += new System.EventHandler(this.selectorOperaciones_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Idicar el elemento de la operacion";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(60, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "selecionar ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // indicarElementoOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectorOperaciones);
            this.Name = "indicarElementoOperacion";
            this.Text = "indicar elemento operacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectorOperaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}