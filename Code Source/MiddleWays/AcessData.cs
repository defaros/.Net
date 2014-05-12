using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParamsBDD;
using System.Data.SqlClient;
using System.Data;

namespace AcessData
{
    public class AccessDataDB
    {
        static Connection connect = new Connection();
        static SqlConnection myConnection = connect.getConnection();

        public SqlDataReader Query_RETOUR(string query)
        {
            
            SqlDataReader myReader = null;

            try {
                    Console.WriteLine("\nQuery : Connetion etablie"); // On l'annonce

                    SqlCommand myCommand = new SqlCommand(query, myConnection); // On prepare la requete

                    myReader = myCommand.ExecuteReader(); // On l'execute et on le stock dans l'objet SqlDataReader

                    Console.WriteLine("Query executer"); // Tout est OK au niveau de l'execution
                }
            catch (Exception e) {
                    Console.WriteLine(e.ToString());
                }

            return myReader;
            
        }

        public SqlCommand Query_StoredProcedure(string query)
        {

            SqlCommand myCommand = null;

            try
            {
                Console.WriteLine("\nQuery : Connetion etablie"); // On l'annonce

                myCommand = new SqlCommand(query, myConnection); // On prepare la requete

                myCommand.CommandType = CommandType.StoredProcedure;

                Console.WriteLine("Query executer"); // Tout est OK au niveau de l'execution
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return myCommand;

        }

       

        public void Query_NONRETOUR(string query)
        {

            try
            {
                myConnection.Open();

                Console.WriteLine("\nQuery : Connetion etablie");
                SqlCommand myCommand = new SqlCommand(query, myConnection);

                myCommand.ExecuteNonQuery();
                Console.WriteLine("Query executer");

                myConnection.Close();
                Console.WriteLine("Connection close");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Close_Query() {

            try
            {
            myConnection.Close(); // On ferme la connection
            Console.WriteLine("Connection close"); // On dit que la connection est bien ferme
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        
        }

        public void Open_Query()
        {

            try
            {
                myConnection.Open(); // On ouvre la connection
                Console.WriteLine("Connection close"); // On dit que la connection est bien ferme
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
