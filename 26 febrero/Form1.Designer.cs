namespace _JUEGO_NAVE
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.TMR_1 = new System.Windows.Forms.Timer(this.components);
            this.OVNI = new System.Windows.Forms.PictureBox();
            this.BTN_DESPLAZAR = new System.Windows.Forms.Button();
            this.NAVE = new System.Windows.Forms.PictureBox();
            this.TMR_2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OVNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAVE)).BeginInit();
            this.SuspendLayout();
            // 
            // TMR_1
            // 
            this.TMR_1.Interval = 1;
            this.TMR_1.Tick += new System.EventHandler(this.TMR_1_Tick);
            // 
            // OVNI
            // 
            this.OVNI.BackColor = System.Drawing.SystemColors.Desktop;
            this.OVNI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OVNI.BackgroundImage")));
            this.OVNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OVNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OVNI.Image = ((System.Drawing.Image)(resources.GetObject("OVNI.Image")));
            this.OVNI.Location = new System.Drawing.Point(400, 120);
            this.OVNI.Name = "OVNI";
            this.OVNI.Size = new System.Drawing.Size(218, 139);
            this.OVNI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OVNI.TabIndex = 0;
            this.OVNI.TabStop = false;
            this.OVNI.Click += new System.EventHandler(this.IMG_1_Click);
            // 
            // BTN_DESPLAZAR
            // 
            this.BTN_DESPLAZAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_DESPLAZAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_DESPLAZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DESPLAZAR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_DESPLAZAR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DESPLAZAR.Image")));
            this.BTN_DESPLAZAR.Location = new System.Drawing.Point(850, 359);
            this.BTN_DESPLAZAR.Name = "BTN_DESPLAZAR";
            this.BTN_DESPLAZAR.Size = new System.Drawing.Size(130, 43);
            this.BTN_DESPLAZAR.TabIndex = 1;
            this.BTN_DESPLAZAR.Text = "INICIAR";
            this.BTN_DESPLAZAR.UseVisualStyleBackColor = false;
            this.BTN_DESPLAZAR.Click += new System.EventHandler(this.BTN_DESPLAZAR_Click);
            // 
            // NAVE
            // 
            this.NAVE.BackColor = System.Drawing.Color.Black;
            this.NAVE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NAVE.BackgroundImage")));
            this.NAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVE.Image = ((System.Drawing.Image)(resources.GetObject("NAVE.Image")));
            this.NAVE.Location = new System.Drawing.Point(400, 466);
            this.NAVE.Name = "NAVE";
            this.NAVE.Size = new System.Drawing.Size(218, 154);
            this.NAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NAVE.TabIndex = 2;
            this.NAVE.TabStop = false;
            this.NAVE.Click += new System.EventHandler(this.TMR_1_Tick);
            // 
            // TMR_2
            // 
            this.TMR_2.Tick += new System.EventHandler(this.NAVE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1003, 670);
            this.Controls.Add(this.NAVE);
            this.Controls.Add(this.BTN_DESPLAZAR);
            this.Controls.Add(this.OVNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NAVE_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.OVNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAVE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TMR_1;
        private System.Windows.Forms.PictureBox OVNI;
        private System.Windows.Forms.Button BTN_DESPLAZAR;
        private System.Windows.Forms.PictureBox NAVE;
        private System.Windows.Forms.Timer TMR_2;
    }
}

