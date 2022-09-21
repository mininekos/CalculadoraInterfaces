namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lbl_ = new System.Windows.Forms.Label();
            this.rd_btn_Basicas = new System.Windows.Forms.RadioButton();
            this.rd_btn_Avanzada = new System.Windows.Forms.RadioButton();
            this.listaAvanzada = new System.Windows.Forms.ListBox();
            this.cmBoxBasica = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(96, 78);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(83, 23);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(96, 118);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(83, 23);
            this.txtNum2.TabIndex = 3;
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Location = new System.Drawing.Point(27, 121);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(63, 15);
            this.lbl_.TabIndex = 2;
            this.lbl_.Text = "Numero 2:";
            // 
            // rd_btn_Basicas
            // 
            this.rd_btn_Basicas.AutoSize = true;
            this.rd_btn_Basicas.Location = new System.Drawing.Point(218, 37);
            this.rd_btn_Basicas.Name = "rd_btn_Basicas";
            this.rd_btn_Basicas.Size = new System.Drawing.Size(58, 19);
            this.rd_btn_Basicas.TabIndex = 4;
            this.rd_btn_Basicas.TabStop = true;
            this.rd_btn_Basicas.Text = "Basica";
            this.rd_btn_Basicas.UseVisualStyleBackColor = true;
            this.rd_btn_Basicas.CheckedChanged += new System.EventHandler(this.rd_btn_Basicas_CheckedChanged);
            // 
            // rd_btn_Avanzada
            // 
            this.rd_btn_Avanzada.AutoSize = true;
            this.rd_btn_Avanzada.Location = new System.Drawing.Point(355, 37);
            this.rd_btn_Avanzada.Name = "rd_btn_Avanzada";
            this.rd_btn_Avanzada.Size = new System.Drawing.Size(76, 19);
            this.rd_btn_Avanzada.TabIndex = 5;
            this.rd_btn_Avanzada.TabStop = true;
            this.rd_btn_Avanzada.Text = "Avanzada";
            this.rd_btn_Avanzada.UseVisualStyleBackColor = true;
            this.rd_btn_Avanzada.CheckedChanged += new System.EventHandler(this.rd_btn_Avanzada_CheckedChanged);
            // 
            // listaAvanzada
            // 
            this.listaAvanzada.Enabled = false;
            this.listaAvanzada.FormattingEnabled = true;
            this.listaAvanzada.ItemHeight = 15;
            this.listaAvanzada.Location = new System.Drawing.Point(334, 62);
            this.listaAvanzada.Name = "listaAvanzada";
            this.listaAvanzada.Size = new System.Drawing.Size(120, 94);
            this.listaAvanzada.TabIndex = 6;
            // 
            // cmBoxBasica
            // 
            this.cmBoxBasica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxBasica.Enabled = false;
            this.cmBoxBasica.FormattingEnabled = true;
            this.cmBoxBasica.Location = new System.Drawing.Point(194, 62);
            this.cmBoxBasica.Name = "cmBoxBasica";
            this.cmBoxBasica.Size = new System.Drawing.Size(121, 23);
            this.cmBoxBasica.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(183, 197);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 270);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmBoxBasica);
            this.Controls.Add(this.listaAvanzada);
            this.Controls.Add(this.rd_btn_Avanzada);
            this.Controls.Add(this.rd_btn_Basicas);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label lbl_;
        private RadioButton rd_btn_Basicas;
        private RadioButton rd_btn_Avanzada;
        private ListBox listaAvanzada;
        private ComboBox cmBoxBasica;
        private Button btnCalcular;
    }
}