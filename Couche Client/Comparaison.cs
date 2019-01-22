using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoucheClientDiffusion;

/*Faire en sorte que si les valeur du CPU, RAM et/ou Disk
 * sont trop haute l'application ne ce lance pas
 *  et un message s'affiche.*/

namespace Couche_Client
{
    class Comparaison
    {
        public int CPUtest;
        public int Disktest;
        public int RAMtest;
        public void VerifTotal()
        {
            if (CPUtest < 85 && RAMtest > 50 && Disktest < 90)
            {
                CoucheClientDiffusion.Form2 frm = new CoucheClientDiffusion.Form2();
                frm.Show();
            }
            else
            {
                if (CPUtest > 85)
                {
                    MessageBox.Show("Votre CPU est trop utilisé, veuillez fermer les autres applications en cours d'exécution.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (RAMtest > 50)
                {
                    MessageBox.Show("Votre mémoire vive est trop sollicitée, veuillez fermer les autres applications en cours d'exécution.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Disktest > 90)
                {
                    MessageBox.Show("Vous n'avez presque plus d'espace disponible, veuillez libérer de l'espace.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
