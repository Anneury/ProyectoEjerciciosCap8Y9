
namespace ProyectoEjerciciosCap8Y9.Cap8.Ejercicio3
{
    partial class Ejercicio3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.HoraLabel = new System.Windows.Forms.Label();
            this.TiempoFecha = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hacer un programa que muestre la hora del día en formato AM/FM seguida del\r\naño, " +
    "el día y el mes actual.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.FechaLabel);
            this.groupBox1.Controls.Add(this.HoraLabel);
            this.groupBox1.Location = new System.Drawing.Point(82, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Hora";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FechaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FechaLabel.Location = new System.Drawing.Point(131, 98);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(64, 25);
            this.FechaLabel.TabIndex = 4;
            this.FechaLabel.Text = "Fecha";
            // 
            // HoraLabel
            // 
            this.HoraLabel.AutoSize = true;
            this.HoraLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoraLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HoraLabel.Location = new System.Drawing.Point(131, 50);
            this.HoraLabel.Name = "HoraLabel";
            this.HoraLabel.Size = new System.Drawing.Size(85, 39);
            this.HoraLabel.TabIndex = 3;
            this.HoraLabel.Text = "Hora";
            // 
            // TiempoFecha
            // 
            this.TiempoFecha.Enabled = true;
            this.TiempoFecha.Tick += new System.EventHandler(this.TiempoFecha_Tick);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(664, 284);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label HoraLabel;
        private System.Windows.Forms.Timer TiempoFecha;
        private System.Windows.Forms.Label FechaLabel;
    }
}