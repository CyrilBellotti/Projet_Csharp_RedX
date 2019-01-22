using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couche_CAD
{
    public class CADClass
    {
        private string cnx;
        private string SQLRequest;
        private SqlDataAdapter dataAdaptater;
        private SqlConnection connection;
        private SqlCommand command;
        private DataSet data;

        public CADClass()
        {
            //   this.cnx = @"Data Source=ALIENWARE-11R6H\EXIABDDSERVER;Initial Catalog=REDXBDD;Integrated Security=True";
            this.cnx = @"Data Source=DESKTOP-KA3MQL1\SQLEXPRESS;Initial Catalog=RedX;Integrated Security=True";
            this.SQLRequest = null;
            this.connection = new SqlConnection(this.cnx);
            this.dataAdaptater = null;
            this.command = null;
            this.data = new DataSet();
        }

        //fonction pour requetes d'actions
        public void ActionRows(string SQLRequest)
        {
            this.data = new DataSet();
            this.SQLRequest = SQLRequest;
            this.command = new SqlCommand(this.SQLRequest, this.connection);
            this.dataAdaptater = new SqlDataAdapter(this.command);
            this.dataAdaptater.Fill(this.data, "rows");
        }

        //fonction pour requetes de récupération de données
        public DataSet getRows(string SQLRequest)
        {
            this.data.Clear();
            this.SQLRequest = SQLRequest;
            this.command = new SqlCommand(this.SQLRequest, this.connection);
            this.connection.Open();
            this.dataAdaptater = new SqlDataAdapter(this.command);
            this.dataAdaptater.Fill(this.data, "rows");
            connection.Close();
            return this.data;
        }
    }
}