namespace TrabalhoCalendario
{
    partial class FormFeriados
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelAno = new System.Windows.Forms.Label();
            this.maskedTextBoxAno = new System.Windows.Forms.MaskedTextBox();
            this.buttonCalcaular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 105);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(510, 394);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.ForeColor = System.Drawing.Color.White;
            this.labelAno.Location = new System.Drawing.Point(18, 15);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(97, 41);
            this.labelAno.TabIndex = 1;
            this.labelAno.Text = "Ano:";
            // 
            // maskedTextBoxAno
            // 
            this.maskedTextBoxAno.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxAno.Location = new System.Drawing.Point(121, 23);
            this.maskedTextBoxAno.Mask = "0000";
            this.maskedTextBoxAno.Name = "maskedTextBoxAno";
            this.maskedTextBoxAno.Size = new System.Drawing.Size(153, 33);
            this.maskedTextBoxAno.TabIndex = 2;
            this.maskedTextBoxAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBoxAno.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBoxAno.ValidatingType = typeof(int);
            // 
            // buttonCalcaular
            // 
            this.buttonCalcaular.AutoSize = true;
            this.buttonCalcaular.BackColor = System.Drawing.Color.White;
            this.buttonCalcaular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalcaular.Location = new System.Drawing.Point(281, 23);
            this.buttonCalcaular.Name = "buttonCalcaular";
            this.buttonCalcaular.Size = new System.Drawing.Size(107, 33);
            this.buttonCalcaular.TabIndex = 3;
            this.buttonCalcaular.Text = "Calcular Feriados";
            this.buttonCalcaular.UseVisualStyleBackColor = false;
            this.buttonCalcaular.Click += new System.EventHandler(this.buttonCalcaular_Click);
            // 
            // FormFeriados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(540, 514);
            this.Controls.Add(this.buttonCalcaular);
            this.Controls.Add(this.maskedTextBoxAno);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FormFeriados";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feriados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAno;
        private System.Windows.Forms.Button buttonCalcaular;
    }
}

