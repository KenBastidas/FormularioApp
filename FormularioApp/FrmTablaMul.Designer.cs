namespace FormularioApp
{
    partial class FrmTablaMul
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTabla = new System.Windows.Forms.Button();
            this.txtNumTabla = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero";
            // 
            // btnTabla
            // 
            this.btnTabla.Location = new System.Drawing.Point(40, 81);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(88, 23);
            this.btnTabla.TabIndex = 1;
            this.btnTabla.Text = "Calcular tabla";
            this.btnTabla.UseVisualStyleBackColor = true;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // txtNumTabla
            // 
            this.txtNumTabla.Location = new System.Drawing.Point(142, 34);
            this.txtNumTabla.Name = "txtNumTabla";
            this.txtNumTabla.Size = new System.Drawing.Size(117, 20);
            this.txtNumTabla.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(142, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 355);
            this.listBox1.TabIndex = 4;
            // 
            // FrmTablaMul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtNumTabla);
            this.Controls.Add(this.btnTabla);
            this.Controls.Add(this.label1);
            this.Name = "FrmTablaMul";
            this.Text = "FrmTablaMul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTabla;
        private System.Windows.Forms.TextBox txtNumTabla;
        private System.Windows.Forms.ListBox listBox1;
    }
}