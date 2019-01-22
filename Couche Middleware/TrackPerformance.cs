using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Couche_Middleware
{
    public class TrackPerformance
    {
        // Variable de performance
        private PerformanceCounter counterDisk;
        private PerformanceCounter counterCPU;
        private PerformanceCounter counterRAM;

        public PerformanceCounter CounterDisk => this.counterDisk;
        public PerformanceCounter CounterCpu => this.counterCPU;
        public PerformanceCounter CounterRAM => this.counterRAM;

        private MachineInformation machineInfo;
        private Calculate calculate;

        private List<double> listInfoDisk;
        private List<double> listInfoRAM;
        private List<double> listInfoCPU;
        private int count;

        public TrackPerformance()
        {
            // Méthode calcul moyenne 
            calculate = new Calculate();

            // Initialisation de listes
            listInfoCPU = new List<double>();
            listInfoDisk = new List<double>();
            listInfoRAM = new List<double>();

            machineInfo.infoCPU = 0;
            machineInfo.infoDisk = 0;
            machineInfo.infoRAM = 0;
            count = 0;

            // On leur dit ce à quoi ils correspondent
            counterDisk = new PerformanceCounter("PhysicalDisk", @"% Disk Time", @"_Total");   
            counterCPU = new PerformanceCounter("Processor", @"% Processor Time", @"_Total");   
            counterRAM = new PerformanceCounter("Memory", "Available MBytes");                 
        }

        //retourne la moyenne des performances de la machine des 30 dernieres secondes 
        public MachineInformation getAveragePerformance()
        {
            while (count <= 10)
            {
                // Appel de la méthode qui recherche les infos de la machine
                machineInfo = getMachineInformation();

                //mise en place des informations dans des listes
                listInfoCPU.Add(machineInfo.infoCPU);
                listInfoDisk.Add(machineInfo.infoDisk);
                listInfoRAM.Add(machineInfo.infoRAM);

                count++;
                Thread.Sleep(1000); // Attend 10 seconde
            }

            //Calcul des moyennes
            machineInfo.infoCPU = calculate.calculMoyenne(listInfoCPU);
            machineInfo.infoRAM = calculate.calculMoyenne(listInfoRAM);
            machineInfo.infoDisk = calculate.calculMoyenne(listInfoDisk);

            return machineInfo;
        }

        //retourne les informations de la machine (RAM, CPU, Disque)
        public MachineInformation getMachineInformation()
        {
            //On récupère les infos et on les met dans les variables "infoXXX"
            machineInfo.infoDisk = counterDisk.NextValue();
            machineInfo.infoCPU = counterCPU.NextValue();
            machineInfo.infoRAM = counterRAM.NextValue();

            return machineInfo;
        }
    }
}