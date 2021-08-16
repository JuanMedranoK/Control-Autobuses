namespace CapaPresentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.buttonAUT = new System.Windows.Forms.Button();
            this.buttonRT = new System.Windows.Forms.Button();
            this.buttonCH = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelf = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(25, 12);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(205, 319);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // buttonAUT
            // 
            this.buttonAUT.BackColor = System.Drawing.Color.LightGray;
            this.buttonAUT.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAUT.Location = new System.Drawing.Point(11, 432);
            this.buttonAUT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAUT.Name = "buttonAUT";
            this.buttonAUT.Size = new System.Drawing.Size(230, 42);
            this.buttonAUT.TabIndex = 4;
            this.buttonAUT.Text = "Registrar Autobus";
            this.buttonAUT.UseVisualStyleBackColor = false;
            this.buttonAUT.Click += new System.EventHandler(this.buttonAUT_Click);
            // 
            // buttonRT
            // 
            this.buttonRT.BackColor = System.Drawing.Color.LightGray;
            this.buttonRT.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRT.Location = new System.Drawing.Point(11, 494);
            this.buttonRT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRT.Name = "buttonRT";
            this.buttonRT.Size = new System.Drawing.Size(230, 42);
            this.buttonRT.TabIndex = 5;
            this.buttonRT.Text = "Registrar Ruta";
            this.buttonRT.UseVisualStyleBackColor = false;
            this.buttonRT.Click += new System.EventHandler(this.buttonRT_Click);
            // 
            // buttonCH
            // 
            this.buttonCH.BackColor = System.Drawing.Color.LightGray;
            this.buttonCH.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCH.Location = new System.Drawing.Point(11, 371);
            this.buttonCH.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCH.Name = "buttonCH";
            this.buttonCH.Size = new System.Drawing.Size(230, 42);
            this.buttonCH.TabIndex = 3;
            this.buttonCH.Text = "Registrar Chofer";
            this.buttonCH.UseVisualStyleBackColor = false;
            this.buttonCH.Click += new System.EventHandler(this.buttonCH_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1151, 668);
            this.panelContenedor.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(93)))), ((int)(((byte)(166)))));
            this.panel4.Controls.Add(this.labelf);
            this.panel4.Controls.Add(this.labelHora);
            this.panel4.Controls.Add(this.buttonRT);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.buttonAUT);
            this.panel4.Controls.Add(this.buttonCH);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 668);
            this.panel4.TabIndex = 2;
            // 
            // labelf
            // 
            this.labelf.AutoSize = true;
            this.labelf.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelf.Location = new System.Drawing.Point(73, 583);
            this.labelf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelf.Name = "labelf";
            this.labelf.Size = new System.Drawing.Size(55, 21);
            this.labelf.TabIndex = 6;
            this.labelf.Text = "label1";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(76, 554);
            this.labelHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(55, 21);
            this.labelHora.TabIndex = 0;
            this.labelHora.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(93)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1151, 668);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de trasporte";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAUT;
        private System.Windows.Forms.Button buttonRT;
        private System.Windows.Forms.Button buttonCH;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelf;
    }
}