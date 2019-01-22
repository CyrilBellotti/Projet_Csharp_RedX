using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoucheMiddlewareApplication;

namespace CoucheClientGestion
{
    public partial class Form1 : Form
    {
        private PerfData perfData;
        private Thread t;
   //     private ProcessStartInfo processDiffusion;
   //     private Process myProcess;

        public Form1()
        {
            InitializeComponent();

            perfData = new PerfData();
            perfData.SomethingHappened += UpdateScreen;

            t = new Thread(new ThreadStart(perfData.checkPerformance));
            t.Start();
        }

        /// <summary>
        /// Cette Methode permet de mettre a jour le Form de facon Safe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateScreen(object sender, EventArgs e)
        {
            if (this.textBoxRAM.InvokeRequired)
            {
                SetTextBoxRAMCallback d = new SetTextBoxRAMCallback(SetTextBoxRAM);
                this.Invoke(d, new object[] { perfData.getAllStates()[1] });
            }
            else
            {
                this.textBoxRAM.Text = "(No Invoke)";
            }

            if (this.textBoxCPU.InvokeRequired)
            {
                SetTextBoxCPUCallback d = new SetTextBoxCPUCallback(SetTextBoxCPU);
                this.Invoke(d, new object[] { perfData.getAllStates()[0] });
            }
            else
            {
                this.textBoxCPU.Text = "(No Invoke)";
            }

            if (this.textBoxDisk.InvokeRequired)
            {
                SetTextBoxDiskCallback d = new SetTextBoxDiskCallback(SetTextBoxDisk);
                this.Invoke(d, new object[] { perfData.getAllStates()[2] });
            }
            else
            {
                this.textBoxDisk.Text = "(No Invoke)";
            }
        }

        /// <summary>
        /// Permet de générer une alerte en cas de performances insufisantes
        /// et de lancer ou non l'application de diffusion
        /// </summary>
        private void Alert()
        {
            string textAlert = "Vous avez des problèmes de : \n";
            bool erreur = false;

            if (Convert.ToDouble(textBoxCPU.Text) >= 90)
            {
                textAlert += "  - CPU \n";
                erreur = true;
            }
            if (Convert.ToDouble(textBoxDisk.Text) >= 90)
            {
                textAlert += "  - Disque \n";
                erreur = true;
            }
            if (Convert.ToDouble(textBoxRAM.Text) <= 50)
            {
                textAlert += "  - RAM \n";
                erreur = true;
            }

            //s'il y a une erreur, ne pas lancer l'application et afficher une Popup
            if (erreur)
            {
                MessageBox.Show(textAlert);
            }
            else
            {
                // Exécuté le Form2
                CoucheClientDiffusion.Form2 frm = new CoucheClientDiffusion.Form2();
                frm.Show();
              
              /*  processDiffusion = new ProcessStartInfo();
                Process[] processlist = Process.GetProcesses();
                bool processExist = false;

                foreach (Process theprocess in processlist)
                {
                    if (theprocess.ProcessName == "Service1")
                        processExist = true;
                }

                if (!processExist)
                {
                    processDiffusion.FileName = "ServicePerf.exe";
                    processDiffusion.WorkingDirectory = @"C:\Users\Cyril\Desktop\ProjetRedX\PROJET REDX\ServicePerf\bin\Debug\";
                    myProcess = Process.Start(processDiffusion);
                }*/

            }
        }

        /// <summary>
        /// Permet d'arreter le thread lors de la fermeture de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
  //          myProcess.Kill();
            t.Abort();
            t.Join();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Alert();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}