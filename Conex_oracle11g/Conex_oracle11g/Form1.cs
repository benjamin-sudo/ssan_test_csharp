//using Oracle.DataAccess.Client;
using System;
using System.Data.OracleClient;



namespace Conex_oracle11g
{
    public partial class Form1 : Form
    {
        private OracleConnection con = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String @strconexion = "DATA SOURCE=10.5.183.212:1521/DSSAN;USER ID=USUARIO_SISTEMAS;PASSWORD=USU2014RIOSSAN";
            con = new OracleConnection(@strconexion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                label1.Text += "\n Conexion exitosa";
            } catch(Exception ex) {
                label1.Text += "\n error -> " + ex.Message;
            }  finally{ 
                con.Close();
                label1.Text += "\n Se desconecto";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}