/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Couche_CAD
{
    public class initialisation
    {
        /*private String cnx;                       //Contient la chaine de connexion à la BDD
        private String rq_sql;                    //Contient la requête SQL
        private SqlDataAdapter dataAdaptater;     //Lien entre l'application et la BDD
        private SqlConnection connection;         //Assure la connexion
        private SqlCommand command;               //Execute les requêtes 
        private DataSet data;                     //Stock les données de la BDD en local

        public initialisation()
            {
                this.rq_sql = null;
                this.cnx = @"Data Source = ALIENWARE - 11R6H\EXIABDDSERVER; Initial Catalog = REDXBDD; Integrated Security = True";                                 //Information de location de la BDD
                this.connection = new SqlConnection(this.cnx); //Instanciation objet connection qui va s'appuyer sur cette chaine de caractère
                this.command = null;
                this.dataAdaptater = null;
                this.data = new DataSet();
            }

        //fonction pour requetes d'actions
        public void ActionRows(string SQLRequest)
            {
                this.data = new DataSet();
                this.rq_sql = rq_sql;
                this.command = new SqlCommand(this.rq_sql, this.connection);
                this.dataAdaptater = new SqlDataAdapter(this.command);
                this.dataAdaptater.Fill(this.data, "rows");
            }

        //fonction pour requetes de récupération de données
        public DataSet getRows(string rq_sql)
            {
                this.data.Clear();
                this.SQLRequest = rq_sql;
                this.command = new SqlCommand(this.rq_sql, this.connection);
                this.connection.Open();
                this.dataAdaptater = new SqlDataAdapter(this.command);
                this.dataAdaptater.Fill(this.data, "rows");
                connection.Close();
                return this.data;
            }

    }

}*/
