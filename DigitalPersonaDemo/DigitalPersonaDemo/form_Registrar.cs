using DPFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPersonaDemo
{
    public partial class form_Registrar : Form
    {
        private DPFP.Template Template;
        public form_Registrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
        }


        private void OnTemplate(DPFP.Template template) { 
            this.Invoke(new Function(delegate () 
            {
                Template = template;
                btnAgregar.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification");
                    txtHuella.Text = "La huella fue capturada correctamente";
                }
                else 
                {
                    MessageBox.Show("The fingerprint templat is not valid. Reperi fingerprint entolamente");
                }
            }));
        }
    }
}
