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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 49);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}