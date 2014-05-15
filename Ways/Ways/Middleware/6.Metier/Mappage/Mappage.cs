using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Ways.Client.Composant_utilisateur_de_communication;
using Ways.Middleware.Service_etendu.Composant_d_acces_aux_donnees;

namespace Ways.Middleware.Metier.Mappage
{
    class Mappage
    {
        //Redirige les requetes faites à la BDD aux procédures stockées correspondantes




        public static User[] getAllUsers()
        {
            User[] allNames = null;

            return allNames;
        }




        /****************************************Questions****************************************/
        public static void addQuestion (string enonce ,string type)
        {
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("AjoutQuest", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@enoncQuest", enonce));
                cmd.Parameters.Add(new SqlParameter("@typeQuest", type));

                cmd.ExecuteNonQuery();
            }
            cad.closeConnection();
        }

        public static void modifQuestion(int IDQuestion, string enonce)
        {
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("MajQuest", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_question", IDQuestion));
                cmd.Parameters.Add(new SqlParameter("@enonce_question", enonce));

                cmd.ExecuteNonQuery();
            }

            cad.closeConnection();
        }

        public static void supprQuestion(int IDQuestion)
        {
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("DelQuest", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idQuest", IDQuestion));

                cmd.ExecuteNonQuery();
            }

            cad.closeConnection();
        }

        public static int getIDQuestionbyEnonce(string enonce)
        {
            int IDQuestion = 0;

            return IDQuestion;
        }


        public static List<Question> getAllQuestionsOfType(string type)
        {
            return null;
        }






        /****************************************Reponses****************************************/
        public static void addReponse(int IDQuestion, string enonce, int points)
        {
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("AddReponse", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idQuest", IDQuestion));
                cmd.Parameters.Add(new SqlParameter("@txtRep", enonce));
                cmd.Parameters.Add(new SqlParameter("@pointsRep", points));

                cmd.ExecuteNonQuery();
            }
            cad.closeConnection();
        }

        public static void modifReponse(int IDReponse, string newEnonce, int newPoints)
        {
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("MajRep", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idRep", IDReponse));
                cmd.Parameters.Add(new SqlParameter("@txtRep", newEnonce));
                cmd.Parameters.Add(new SqlParameter("@pointRep", newPoints));

                cmd.ExecuteNonQuery();
            }

        }

        public static void supprReponse(int IDReponse)
        {
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("DelRep", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idRep", IDReponse));

                cmd.ExecuteNonQuery();
            }
            cad.closeConnection();
        }


        public static List<int> getIDsReponseByIdQuestion(int IDQuestion)
        {
            List<int> ids = new List<int>();

            //Recupère les ID reponses en fonction de l'Id de la question

            return ids;
        }

        /****************************************Filiere****************************************/

        public static List<Filiere> getAllMetier()
        {
            List<Filiere> filiere = new List<Filiere>();
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            SqlDataReader reader;
            using (SqlCommand cmd = new SqlCommand("AffichMetier", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();
            }
            cad.closeConnection();



            return filiere;
        }






        /****************************************Admin****************************************/


        //Controle les accès aux fonctions administrateurs
        public static bool verifLogin(string identifiant, string psw)
        {
            //Verifie la connexion Admin
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("ConAdmin", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@loginAdmin", identifiant));
                cmd.Parameters.Add(new SqlParameter("@mdpAdmin", psw));

                cmd.ExecuteNonQuery();
            }
            cad.closeConnection();

            return true;
        }


    }
}
