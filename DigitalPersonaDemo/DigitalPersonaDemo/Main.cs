namespace DigitalPersonaDemo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_Registrar formulario_registrar = new form_Registrar();
            formulario_registrar.ShowDialog();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            form_Verificar formulario_verificar = new form_Verificar();
            formulario_verificar.ShowDialog();
        }
    }
}