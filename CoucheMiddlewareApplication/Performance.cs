using Donnee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMiddlewareApplication
{
    public class Performance
    {
        private CADClass cad;
        private DataSet data;
        private Mappage mapPerformance;

        public Performance()
        {
            cad = new CADClass();
            data = new DataSet();
            mapPerformance = new Mappage();
        }

        /// <summary>
        /// permet l'execution de la requete select et retourne la derniere valeur
        /// </summary>
        /// <returns></returns>
        public DataSet selectLast()
        {
            this.data = cad.getRows(mapPerformance.selectLast());
            return data;
        }
    }
}
