using DPFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDP4501
{
    public partial class frmRegistrar : Form
    {

        private DPFP.Template Template;
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate () {

                Template = template;
                btnAgregar.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("La plantilla de huellas dactilares está lista para la verificación de huellas dactilares.","Inscripción de huellas dactilares");
                    txtHuella.Text = "Huella capturada correctamente";
                }  else  {
                    MessageBox.Show("La plantilla de huella digital no es válida. Repita el registro de huellas dactilares", "Inscripción de huellas dactilares");
                }
            }));
        }
    }
}
