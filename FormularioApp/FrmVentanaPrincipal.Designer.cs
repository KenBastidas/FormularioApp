namespace FormularioApp
{
    partial class FrmVentanaPrincipal
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
            this.btnCalcularsueldo = new System.Windows.Forms.Button();
            this.btnEnteenBina = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBinaEnNum = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNumberPrimo = new System.Windows.Forms.Button();
            this.btnNameAge = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularsueldo
            // 
            this.btnCalcularsueldo.Location = new System.Drawing.Point(128, 53);
            this.btnCalcularsueldo.Name = "btnCalcularsueldo";
            this.btnCalcularsueldo.Size = new System.Drawing.Size(144, 64);
            this.btnCalcularsueldo.TabIndex = 0;
            this.btnCalcularsueldo.Text = "Calular sueldo";
            this.btnCalcularsueldo.UseVisualStyleBackColor = true;
            this.btnCalcularsueldo.Click += new System.EventHandler(this.btnCalcularsueldo_Click);
            // 
            // btnEnteenBina
            // 
            this.btnEnteenBina.Location = new System.Drawing.Point(132, 123);
            this.btnEnteenBina.Name = "btnEnteenBina";
            this.btnEnteenBina.Size = new System.Drawing.Size(140, 52);
            this.btnEnteenBina.TabIndex = 1;
            this.btnEnteenBina.Text = "Entero Binario";
            this.btnEnteenBina.UseVisualStyleBackColor = true;
            this.btnEnteenBina.Click += new System.EventHandler(this.btnEnteenBina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu principal";
            // 
            // btnBinaEnNum
            // 
            this.btnBinaEnNum.Location = new System.Drawing.Point(132, 194);
            this.btnBinaEnNum.Name = "btnBinaEnNum";
            this.btnBinaEnNum.Size = new System.Drawing.Size(140, 54);
            this.btnBinaEnNum.TabIndex = 3;
            this.btnBinaEnNum.Text = "Binario en numero";
            this.btnBinaEnNum.UseVisualStyleBackColor = true;
            this.btnBinaEnNum.Click += new System.EventHandler(this.btnBinaEnNum_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(132, 266);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(329, 48);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNumberPrimo
            // 
            this.btnNumberPrimo.Location = new System.Drawing.Point(301, 53);
            this.btnNumberPrimo.Name = "btnNumberPrimo";
            this.btnNumberPrimo.Size = new System.Drawing.Size(160, 60);
            this.btnNumberPrimo.TabIndex = 5;
            this.btnNumberPrimo.Text = "NumberPrimo";
            this.btnNumberPrimo.UseVisualStyleBackColor = true;
            this.btnNumberPrimo.Click += new System.EventHandler(this.btnNumberPrimo_Click);
            // 
            // btnNameAge
            // 
            this.btnNameAge.Location = new System.Drawing.Point(301, 125);
            this.btnNameAge.Name = "btnNameAge";
            this.btnNameAge.Size = new System.Drawing.Size(160, 48);
            this.btnNameAge.TabIndex = 6;
            this.btnNameAge.Text = "NameAge";
            this.btnNameAge.UseVisualStyleBackColor = true;
            this.btnNameAge.Click += new System.EventHandler(this.btnNameAge_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(303, 194);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(158, 49);
            this.btnDateTime.TabIndex = 7;
            this.btnDateTime.Text = "DateTime";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // FrmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.btnNameAge);
            this.Controls.Add(this.btnNumberPrimo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBinaEnNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnteenBina);
            this.Controls.Add(this.btnCalcularsueldo);
            this.Name = "FrmVentanaPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularsueldo;
        private System.Windows.Forms.Button btnEnteenBina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBinaEnNum;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNumberPrimo;
        private System.Windows.Forms.Button btnNameAge;
        private System.Windows.Forms.Button btnDateTime;
    }
}