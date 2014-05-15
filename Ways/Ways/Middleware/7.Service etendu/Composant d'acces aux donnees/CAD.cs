using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ways.Middleware.Service_etendu.Composant_d_acces_aux_donnees
{
    class CAD
    {

        private string rq_sql;
        private string rows;
        private SqlCommand oCmd;
        private DbDataAdapter oDA;
        private DataSet oDS;
        private SqlConnection oConn;
        private Hashtable oParameters;

        public CAD()
        {
            this.rq_sql = null;
            this.rows = null;
            this.oCmd = null;
            this.oDA = null;
        }

        public void openConnection(MSG oMsg)
        {
            try
            {
                XML oXml = new XML();
                oXml.ReadConfigDecrypted(oMsg);
                oConn = new SqlConnection();

                oConn.ConnectionString =
                    @"Data Source=WIN-" + oMsg.GetData("source") + @";Initial Catalog=" + oMsg.GetData("database") + @";Persist Security Info=True;User ID=" + oMsg.GetData("login") + @";Password=" + oMsg.GetData("pwd") + "1";
                oConn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERREUR:\n" + e.Message);
            }
        }

        public void closeConnection()
        {
            try
            {
                oConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERREUR:\n" + e.Message);
            }
        }

        // Fonction qui gère les requêtes SELECT
        public MSG GetRows(MSG oMsg)
        {
            openConnection(oMsg);
            this.rq_sql = (string)oMsg.GetData("sql");
            //this.rows = (string)oMsg.GetData("rows");
            this.oCmd = new SqlCommand(rq_sql, oConn);
            this.oDS = new DataSet();
            //this.oCmd = oConn.CreateCommand();

            if ((Boolean)oMsg.GetData("boolParam"))
            {
                oParameters = (Hashtable)oMsg.GetData("parameters");

                foreach (string param in oParameters.Keys)
                {
                    oCmd.Parameters.AddWithValue(param, oParameters[param]);
                }
            }
            this.oDA = new SqlDataAdapter(this.oCmd);
            this.oDA.Fill(this.oDS);
            oMsg.SetData("dataset", this.oDS);
            return oMsg;
        }

        // Fonction qui gère les requêtes INSERT UPDATE ET DELETE
        public MSG ActionRows(MSG oMsg)
        {
            openConnection(oMsg);
            this.rq_sql = (string)oMsg.GetData("sql");
            this.oCmd = new SqlCommand(rq_sql, oConn);

            if ((Boolean)oMsg.GetData("boolParam"))
            {
                oParameters = (Hashtable)oMsg.GetData("parameters");

                foreach (string param in oParameters.Keys)
                {
                    oCmd.Parameters.AddWithValue(param, oParameters[param]);
                }
            }
            if (this.oCmd.ExecuteScalar() != null)
            {
                oMsg.Statut = true;
            }
            oConn.Close();
            return oMsg;
        }


    }
}
