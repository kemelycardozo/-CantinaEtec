namespace WindowsFormsApp1
{
    partial class Recarregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recarregar));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtRecarga = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBiometria = new System.Windows.Forms.TextBox();
            this.txtValorRecarga = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(28, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Biometria: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(123, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Recarregar";
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(205)))), ((int)(((byte)(69)))));
            this.btnRecarregar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecarregar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRecarregar.Location = new System.Drawing.Point(186, 349);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(161, 45);
            this.btnRecarregar.TabIndex = 42;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.UseVisualStyleBackColor = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dtRecarga);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBiometria);
            this.panel1.Controls.Add(this.btnVolta);
            this.panel1.Controls.Add(this.txtValorRecarga);
            this.panel1.Controls.Add(this.btnRecarregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(99, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 414);
            this.panel1.TabIndex = 43;
            // 
            // dtRecarga
            // 
            this.dtRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRecarga.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRecarga.Location = new System.Drawing.Point(129, 132);
            this.dtRecarga.Name = "dtRecarga";
            this.dtRecarga.Size = new System.Drawing.Size(121, 24);
            this.dtRecarga.TabIndex = 99;
            this.dtRecarga.UseWaitCursor = true;
            this.dtRecarga.Value = new System.DateTime(2017, 10, 10, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(55, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 98;
            this.label5.Text = "Data:";
            // 
            // txtBiometria
            // 
            this.txtBiometria.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBiometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiometria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBiometria.Location = new System.Drawing.Point(129, 170);
            this.txtBiometria.Multiline = true;
            this.txtBiometria.Name = "txtBiometria";
            this.txtBiometria.Size = new System.Drawing.Size(163, 133);
            this.txtBiometria.TabIndex = 97;
            // 
            // txtValorRecarga
            // 
            this.txtValorRecarga.BackColor = System.Drawing.Color.Gainsboro;
            this.txtValorRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorRecarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorRecarga.Location = new System.Drawing.Point(129, 95);
            this.txtValorRecarga.Name = "txtValorRecarga";
            this.txtValorRecarga.Size = new System.Drawing.Size(163, 26);
            this.txtValorRecarga.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.Botoes_5053_arrow_left_48;
            this.button1.Location = new System.Drawing.Point(29, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 34);
            this.button1.TabIndex = 100;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVolta
            // 
            this.btnVolta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnVolta.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.seta_esquerda;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnVolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolta.Location = new System.Drawing.Point(15, 258);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(93, 45);
            this.btnVolta.TabIndex = 96;
            this.btnVolta.UseVisualStyleBackColor = false;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(-22, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 15;
            // 
            // Recarregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(745, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recarregar";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.TextBox txtBiometria;
        private System.Windows.Forms.TextBox txtValorRecarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtRecarga;
        private System.Windows.Forms.Button button1;
    }
}