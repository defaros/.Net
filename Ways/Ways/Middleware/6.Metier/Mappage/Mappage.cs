using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Ways.Client.Composant_utilisateur_de_communication;

namespace Ways.Middleware.Metier.Mappage
{
    class Mappage
    {
        //Redirige les requetes faites à la BDD aux procédures stockées correspondantes




        public static string[] getAllNames()
        {
            string[] allNames = null;

            return allNames;
        }




        /****************************************Questions****************************************/
        public static void addQuestion (string enonce)
        {
            /*using (SqlCommand cmd = new SqlCommand("AddQuest", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@enonce_question", enonce));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }*/
        }

        public static void modifQuestion(int IDQuestion, string enonce)
        {
            /*
            using (SqlCommand cmd = new SqlCommand("MajQuest", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_question", IDQuestion));
                cmd.Parameters.Add(new SqlParameter("@enonce_question", enonce));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }*/
        }

        public static void supprQuestion(int IDQuestion)
        {

        }

        public static int getIDQuestionbyEnonce(string enonce)
        {
            int IDQuestion = 0;

            return IDQuestion;
        }


        public static Question getAllQuestionsOfType(string type)
        {
            return null;
        }






        /****************************************Reponses****************************************/
        public static void addReponse(int IDQuestion, string enonce, int points)
        {
            /*using (SqlCommand cmd = new SqlCommand("AddReponse", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idQuest", IDQuestion));
                cmd.Parameters.Add(new SqlParameter("@txtRep", enonce));
                cmd.Parameters.Add(new SqlParameter("@pointsRep", points));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }*/
        }

        public static void modifReponse(int IDReponse, string newEnonce, int newPoints)
        {

        }

        public static void supprReponse(int IDReponse)
        {

        }

        public static List<int> getIDsReponseByIdQuestion(int IDQuestion)
        {
            List<int> ids = new List<int>();

            //Recupère les ID reponses en fonction de l'Id de la question

            return ids;
        }

        /****************************************Metier****************************************/

        public static Question getAllMetier()
        {
            return null;
        }

    }
}
