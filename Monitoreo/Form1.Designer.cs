﻿namespace Monitoreo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtHRelativa = new System.Windows.Forms.TextBox();
            this.txtHumedad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPTanque = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnRegar = new System.Windows.Forms.Button();
            this.btnEnfriar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(44, 262);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(99, 31);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Humedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Humedad Relativa";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.BackColor = System.Drawing.SystemColors.Info;
            this.txtTemperatura.Location = new System.Drawing.Point(219, 54);
            this.txtTemperatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(102, 20);
            this.txtTemperatura.TabIndex = 4;
            // 
            // txtHRelativa
            // 
            this.txtHRelativa.BackColor = System.Drawing.SystemColors.Info;
            this.txtHRelativa.Location = new System.Drawing.Point(260, 147);
            this.txtHRelativa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHRelativa.Name = "txtHRelativa";
            this.txtHRelativa.Size = new System.Drawing.Size(102, 20);
            this.txtHRelativa.TabIndex = 5;
            // 
            // txtHumedad
            // 
            this.txtHumedad.BackColor = System.Drawing.SystemColors.Info;
            this.txtHumedad.Location = new System.Drawing.Point(260, 99);
            this.txtHumedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHumedad.Name = "txtHumedad";
            this.txtHumedad.Size = new System.Drawing.Size(102, 20);
            this.txtHumedad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Porcentaje del Tanque";
            // 
            // txtPTanque
            // 
            this.txtPTanque.BackColor = System.Drawing.SystemColors.Info;
            this.txtPTanque.Location = new System.Drawing.Point(260, 204);
            this.txtPTanque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPTanque.Name = "txtPTanque";
            this.txtPTanque.Size = new System.Drawing.Size(102, 20);
            this.txtPTanque.TabIndex = 8;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // btnRegar
            // 
            this.btnRegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegar.Location = new System.Drawing.Point(186, 262);
            this.btnRegar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegar.Name = "btnRegar";
            this.btnRegar.Size = new System.Drawing.Size(99, 31);
            this.btnRegar.TabIndex = 9;
            this.btnRegar.Text = "Regar";
            this.btnRegar.UseVisualStyleBackColor = true;
            this.btnRegar.Click += new System.EventHandler(this.btnRegar_Click);
            // 
            // btnEnfriar
            // 
            this.btnEnfriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnfriar.Location = new System.Drawing.Point(319, 262);
            this.btnEnfriar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnfriar.Name = "btnEnfriar";
            this.btnEnfriar.Size = new System.Drawing.Size(99, 31);
            this.btnEnfriar.TabIndex = 10;
            this.btnEnfriar.Text = "Enfriar";
            this.btnEnfriar.UseVisualStyleBackColor = true;
            this.btnEnfriar.Click += new System.EventHandler(this.btnEnfriar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(470, 336);
            this.Controls.Add(this.btnEnfriar);
            this.Controls.Add(this.btnRegar);
            this.Controls.Add(this.txtPTanque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHumedad);
            this.Controls.Add(this.txtHRelativa);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.TextBox txtHRelativa;
        private System.Windows.Forms.TextBox txtHumedad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPTanque;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnRegar;
        private System.Windows.Forms.Button btnEnfriar;
    }
}

