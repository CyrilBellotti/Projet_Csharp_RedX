using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couche_Middleware
{
    /// <summary>
    /// Cette classe permet de faire des calculs 
    /// </summary>
    public class Calculate
    {
        //retourne la moyenne de la liste de double
        public double calculMoyenne(List<double> list)
        {
            double total = 0;

            // Calculer la moyenne entre toutes les valeurs stockées dans les listes
            for (int i = 0; i < list.Count; i++)
            {
                total += list[i];
            }

            return total / list.Count;
        }
    }
}
