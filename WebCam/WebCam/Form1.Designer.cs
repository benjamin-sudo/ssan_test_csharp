namespace WebCam
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoximg = new System.Windows.Forms.PictureBox();
            this.btncapturar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoximg
            // 
            this.pictureBoximg.Location = new System.Drawing.Point(12, 12);
            this.pictureBoximg.Name = "pictureBoximg";
            this.pictureBoximg.Size = new System.Drawing.Size(776, 388);
            this.pictureBoximg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoximg.TabIndex = 0;
            this.pictureBoximg.TabStop = false;
            // 
            // btncapturar
            // 
            this.btncapturar.Location = new System.Drawing.Point(293, 406);
            this.btncapturar.Name = "btncapturar";
            this.btncapturar.Size = new System.Drawing.Size(75, 23);
            this.btncapturar.TabIndex = 1;
            this.btncapturar.Text = "Capturar";
            this.btncapturar.UseVisualStyleBackColor = true;
            this.btncapturar.Click += new System.EventHandler(this.btncapturar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(374, 406);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 472);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncapturar);
            this.Controls.Add(this.pictureBoximg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoximg;
        private Button btncapturar;
        private Button btnguardar;
        private System.Windows.Forms.Timer timer1;
    }
}