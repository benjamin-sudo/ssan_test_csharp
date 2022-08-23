using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Data.SqlTypes;

namespace ServicioLoop
{
    public partial class Service1 : ServiceBase
    {

        public Timer tiempo;
        public string fecha;
        public string filename;

        public Service1()
        {
            InitializeComponent();
            tiempo = new Timer();
            tiempo.Interval = 10000; //10 Segundos
            tiempo.Elapsed += new ElapsedEventHandler(tiempo_Elapsed);
            fecha = DateTime.Now.ToShortDateString().Replace("/", "-");

        }

        protected override void OnStart(string[] args)
        {
            tiempo.Enabled = true;
        }

        protected override void OnStop()
        {

        }

        public void tiempo_Elapsed(object sender, EventArgs e) {
            
            //Si existe directorio dentro de la pc
            if (!Directory.Exists(@"c:\\ambis\\" + fecha)) {
                Directory.CreateDirectory(@"c:\\ambis\\" + fecha);
            }

            //recoge la matriz
            foreach (string files in Directory.GetFiles(@"c:\\ambis","*.*")){ 
                filename = Path.GetFileName(files);
                //mover los arcvhios
                File.Move(files, @"c:\\ambis\\" + fecha + "\\"+  filename);
                
            }

        }
    }
}
