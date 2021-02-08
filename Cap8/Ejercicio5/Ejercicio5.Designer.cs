
namespace ProyectoEjerciciosCap8Y9.Cap8.Ejercicio5
{
    partial class Ejercicio5
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
            this.Cadena1TextBox = new System.Windows.Forms.TextBox();
            this.Cadena2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CadenaList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hacer un programa que le solicite al usuario dos cadenas y luego las muestre\r\nen " +
    "orden alfabético.";
            // 
            // Cadena1TextBox
            // 
            this.Cadena1TextBox.Location = new System.Drawing.Point(26, 93);
            this.Cadena1TextBox.Name = "Cadena1TextBox";
            this.Cadena1TextBox.Size = new System.Drawing.Size(173, 27);
            this.Cadena1TextBox.TabIndex = 1;
            // 
            // Cadena2TextBox
            // 
            this.Cadena2TextBox.Location = new System.Drawing.Point(285, 93);
            this.Cadena2TextBox.Name = "Cadena2TextBox";
            this.Cadena2TextBox.Size = new System.Drawing.Size(172, 27);
            this.Cadena2TextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadena 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cadena 2:";
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(259, 144);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(113, 29);
            this.AceptarButton.TabIndex = 5;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CadenaList
            // 
            this.CadenaList.FormattingEnabled = true;
            this.CadenaList.ItemHeight = 20;
            this.CadenaList.Location = new System.Drawing.Point(36, 48);
            this.CadenaList.Name = "CadenaList";
            this.CadenaList.Size = new System.Drawing.Size(150, 84);
            this.CadenaList.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NuevoButton);
            this.groupBox1.Controls.Add(this.Cadena1TextBox);
            this.groupBox1.Controls.Add(this.Cadena2TextBox);
            this.groupBox1.Controls.Add(this.AceptarButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(43, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de las Cadenas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CadenaList);
            this.groupBox2.Location = new System.Drawing.Point(43, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 149);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadenas ordenadas";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(110, 144);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(113, 29);
            this.NuevoButton.TabIndex = 6;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cadena1TextBox;
        private System.Windows.Forms.TextBox Cadena2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.ListBox CadenaList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button NuevoButton;
    }
}