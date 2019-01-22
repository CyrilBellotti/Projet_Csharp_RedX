using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Couche_Middleware;
using System.Timers;
using System.IO;
using System.Globalization;


namespace ServicePerf
{
    public partial class Service1 : ServiceBase
    {
        protected Timer t;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            t = new Timer(10000); // Exécute le service toutes les 10 secondes
            t.Elapsed += new ElapsedEventHandler(serviceExec); // Demander a Bobin
            t.Start(); // Lance le timer
        }

        //Arret du timer lors de l'arret du service
        protected override void OnStop()
        {
            t.Stop(); // Arrete le timer
        }

        //permet de récupérer les informations et de les inserer en base de données
        protected void serviceExec(object sender, EventArgs e)
        {
            // Instancie les objets des différentes classes
            TrackPerformance trackPerformance = new TrackPerformance();
            MachineInformation machineInfo = new MachineInformation();
            Performance performance = new Performance();

            // machineInfo prend les valeurs de l'exécution de la méthode getAveragePerformance()
            machineInfo = trackPerformance.getAveragePerformance();

            //convertion des "," en "." pour l'insertion des doubles dans la base de données
            string stringCPU = machineInfo.infoCPU.ToString(CultureInfo.InvariantCulture.NumberFormat);
            string stringRAM = machineInfo.infoRAM.ToString(CultureInfo.InvariantCulture.NumberFormat);
            string stringDisk = machineInfo.infoDisk.ToString(CultureInfo.InvariantCulture.NumberFormat);

            //insertion dans la base de données
            performance.insert(stringCPU, stringRAM, stringDisk);
        }
    }
}