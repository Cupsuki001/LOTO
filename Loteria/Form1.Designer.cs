namespace Loteria
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
            this.BTNjugar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MASKEDnum = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTNingresar = new System.Windows.Forms.Button();
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.TXB1 = new System.Windows.Forms.TextBox();
            this.TXB2 = new System.Windows.Forms.TextBox();
            this.TXB3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOTERIA UNI";
            // 
            // BTNjugar
            // 
            this.BTNjugar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNjugar.Location = new System.Drawing.Point(29, 200);
            this.BTNjugar.Name = "BTNjugar";
            this.BTNjugar.Size = new System.Drawing.Size(75, 23);
            this.BTNjugar.TabIndex = 1;
            this.BTNjugar.Text = "Jugar";
            this.BTNjugar.UseVisualStyleBackColor = false;
            this.BTNjugar.Click += new System.EventHandler(this.BTNjugar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.TXB3);
            this.groupBox1.Controls.Add(this.TXB2);
            this.groupBox1.Controls.Add(this.TXB1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NUMEROS INGRESADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero 1 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero 2 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Numero 3 =";
            // 
            // MASKEDnum
            // 
            this.MASKEDnum.Location = new System.Drawing.Point(352, 81);
            this.MASKEDnum.Mask = "99";
            this.MASKEDnum.Name = "MASKEDnum";
            this.MASKEDnum.Size = new System.Drawing.Size(100, 23);
            this.MASKEDnum.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(275, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 27);
            this.label6.TabIndex = 4;
            // 
            // BTNingresar
            // 
            this.BTNingresar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNingresar.Location = new System.Drawing.Point(368, 136);
            this.BTNingresar.Name = "BTNingresar";
            this.BTNingresar.Size = new System.Drawing.Size(75, 23);
            this.BTNingresar.TabIndex = 5;
            this.BTNingresar.Text = "Ingresar";
            this.BTNingresar.UseVisualStyleBackColor = false;
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNlimpiar.Location = new System.Drawing.Point(119, 200);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNlimpiar.TabIndex = 6;
            this.BTNlimpiar.Text = "Limpiar";
            this.BTNlimpiar.UseVisualStyleBackColor = false;
            // 
            // TXB1
            // 
            this.TXB1.Location = new System.Drawing.Point(139, 27);
            this.TXB1.Name = "TXB1";
            this.TXB1.Size = new System.Drawing.Size(40, 23);
            this.TXB1.TabIndex = 7;
            // 
            // TXB2
            // 
            this.TXB2.Location = new System.Drawing.Point(139, 56);
            this.TXB2.Name = "TXB2";
            this.TXB2.Size = new System.Drawing.Size(40, 23);
            this.TXB2.TabIndex = 8;
            // 
            // TXB3
            // 
            this.TXB3.Location = new System.Drawing.Point(139, 85);
            this.TXB3.Name = "TXB3";
            this.TXB3.Size = new System.Drawing.Size(40, 23);
            this.TXB3.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(323, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 52);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COMENTARIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "NADA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(291, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 27);
            this.label8.TabIndex = 8;
            this.label8.Text = "INGRESE EL NUMERO";
            // 
            // BTNsalir
            // 
            this.BTNsalir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNsalir.Location = new System.Drawing.Point(200, 200);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 9;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(534, 255);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTNlimpiar);
            this.Controls.Add(this.BTNingresar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MASKEDnum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNjugar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BTNjugar;
        private GroupBox groupBox1;
        private TextBox TXB3;
        private TextBox TXB2;
        private TextBox TXB1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox MASKEDnum;
        private Label label6;
        private Button BTNingresar;
        private Button BTNlimpiar;
        private GroupBox groupBox2;
        private Label label7;
        private Label label8;
        private Button BTNsalir;
    }
}