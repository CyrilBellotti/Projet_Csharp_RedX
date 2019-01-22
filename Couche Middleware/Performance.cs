using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Donnee;

namespace Couche_Middleware
{
    public class Performance
    {
        /// <summary>
        /// Cette classe permet la gestion dans la base de donnée de la table Performance
        /// </summary>

            private CADClass cad;
            private DataSet data;
            private Mappage mapPerformance;

            public Performance()
            {
                cad = new CADClass();
                data = new DataSet();
                mapPerformance = new Mappage();
            }

            //permet l'execution de la requete d'insert
            public void insert(string CPU, string RAM, string Disk)
            {
                string SQLRequest = mapPerformance.insert(CPU, RAM, Disk); // Va chercher la requête
                cad.ActionRows(SQLRequest); // Exécute
            }
        }
    }