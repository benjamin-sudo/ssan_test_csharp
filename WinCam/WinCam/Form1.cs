using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;

namespace WinCam
{
    public partial class Form1 : Form
    {

        private string Path = @"C:\Users\LENOVO\source\repos\WinCam\WinCam";
        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCamp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender,EventArgs e){
            CargaDispositivos();
        }

        public void CargaDispositivos() {
            CerrarWebCam();
            MisDispositivos             =   new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0) {
                HayDispositivos         =   true;
                for (int i = 0; i < MisDispositivos.Count; i++) {
                    comboBox1.Items.Add(MisDispositivos[i].Name.ToString());
                    comboBox1.Text      =   MisDispositivos[0].Name.ToString();
                }
            } else {
                HayDispositivos     =   false;
            }
        }

        private void button1_Click(object sender, EventArgs e){
            int i                   =   comboBox1.SelectedIndex;
            string NombreVideo      =   MisDispositivos[i].MonikerString;
            MiWebCamp               =   new VideoCaptureDevice(NombreVideo);
            MiWebCamp.NewFrame      +=  new NewFrameEventHandler(capturando);
            MiWebCamp.Start();
        }

        private void capturando(object sender , NewFrameEventArgs eventArgs){
            Bitmap Imagen           =   (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image       =   Imagen;
        }

        private void CerrarWebCam() {
            if (MiWebCamp           !=  null && MiWebCamp.IsRunning) {
                MiWebCamp.SignalToStop();
                MiWebCamp           =   null;
            }
        }

        private void button2_Click(object sender, EventArgs e){
            if (MiWebCamp != null && MiWebCamp.IsRunning){
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.Image.Save(Path + "mipc.jpg", ImageFormat.Jpeg);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e){
            CerrarWebCam();
        }
    }
}