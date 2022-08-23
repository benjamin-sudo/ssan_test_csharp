using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace WebCam
{
    public partial class Form1 : Form
    {
        //main star
        public Form1(){
            InitializeComponent();
        }

        int contador                    =   0;
        DateTime localDate              =   DateTime.Now;

        private void btncapturar_Click(object sender, EventArgs e){
            contador                    =   0;
            timer1.Start();
            this.Visible                =   false;
        }

        private void timer1_Tick(object sender, EventArgs e){
            if (contador == 1) {
                Rectangle limites       =   Screen.GetBounds(Point.Empty);
                Bitmap imgb             =   new Bitmap(limites.Width,limites.Height);
                Graphics graf           =   Graphics.FromImage(imgb);
                graf.CopyFromScreen(Point.Empty,Point.Empty,limites.Size);
                pictureBoximg.Image     =   imgb;
                this.Visible            =   true;
                timer1.Stop();
            }
            contador++;
        }

        private void btnguardar_Click(object sender, EventArgs e){
            SaveFileDialog df           =   new SaveFileDialog();
            df.Filter                   =   "Imagen | .png";
            df.FileName                 =   DateTimeOffset.Now.ToUnixTimeSeconds() + "_.png";
            if (df.ShowDialog()         ==  System.Windows.Forms.DialogResult.OK) { 
                ImageFormat formato     =   ImageFormat.Png;
                pictureBoximg.Image.Save(df.FileName,formato);
            }
        }
    }
}