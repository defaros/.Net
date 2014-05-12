using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ParamsBDD
{
    class Connection
    {
        static string username = "ExiaProjet";
        static string password = "lc6550";
        static string serveur = "25.55.136.25";
        static string database = "ProjetBdd";

        SqlConnection myConnection = new SqlConnection("user id="+username+";" +
                                                            "password="+password+";server="+serveur+";" +
                                                            "Trusted_Connection=no;" +
                                                            "database="+database+"; " +
                                                            "connection timeout=30");

        public SqlConnection getConnection()
        {
            return myConnection;
        }

    }
}
