using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Ways.Client.Composant_utilisateur_de_communication;
using Ways.Middleware.Service_etendu.Composant_d_acces_aux_donnees;
using System.ComponentModel;

namespace Ways.Middleware.Metier.Mappage
{
    class Mappage
    {
        //Redirige les requetes faites à la BDD aux procédures stockées correspondantes


        /****************************************User****************************************/
        
        public static void storeScore(User user)
        {
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("storeScore", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@pseudoUser", user.Nom));
                cmd.Parameters.Add(new SqlParameter("@scoreUser", user.Score));
                cmd.ExecuteNonQuery();
            }
            cad.closeConnection();
        }

        public static Classement getClassement()
        {
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            SqlDataReader reader;
            using (SqlCommand cmd = new SqlCommand("getClassement", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
            }


            BindingList<User> users = new BindingList<User>();
            int placement = 0;

            while (reader.Read())
            {
                placement ++;
                int score = reader.GetInt32(reader.GetOrdinal("score_utilisateur"));
                string pseudo = reader.GetString(reader.GetOrdinal("pseudo_utilisateur"));
                User user = new User(pseudo, score, placement);
                users.Add(user);
            }

            Classement classement = new Classement(users);


            cad.closeConnection();
            return classement;

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

        public static void modifQuestion(int IDQuestion, string enonce, string type)
        {
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("MajQuest", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idQuest", IDQuestion));
                cmd.Parameters.Add(new SqlParameter("@enoncQuest", enonce));
                cmd.Parameters.Add(new SqlParameter("@typeQuest", type));

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

        public static int getlastIDQuestion(string enonce)
        {
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            int id;
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("lastIdQuestion", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                id = (int)cmd.ExecuteScalar();
            }
            cad.closeConnection();

            return id;
        }


        public static List<Question> getAllQuestionsOfType(string type)
        {
            List<Question> list = new List<Question>();
            SqlDataReader reader;
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("GetAllQuestOfType", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@typeQuest", type));

                reader = cmd.ExecuteReader();
            }

            while (reader.Read())
            {
                int id = reader.GetInt32(reader.GetOrdinal("id_question"));
                string enonce = reader.GetString(reader.GetOrdinal("enonce_question"));
                Question quest = new Question(id,enonce,type,null);
                list.Add(quest);
            }
            cad.closeConnection();

            return list;
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

        public static void supprReponses(int IDQuestion)
        {
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("DelRep", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idQuest", IDQuestion));

                cmd.ExecuteNonQuery();
            }
            cad.closeConnection();
        }


        public static List<int> getIDsReponseByIdQuestion(int IDQuestion)
        {
            List<int> ids = new List<int>();

            //Recupère les ID reponses en fonction de l'Id de la question
            SqlDataReader reader;
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("IdQuestIdRep", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idQuest", IDQuestion));

                reader = cmd.ExecuteReader();
            }

            while (reader.Read())
            {
                ids.Add(reader.GetInt32(reader.GetOrdinal("id_reponse")));
            }



            return ids;
        }

        public static Reponse[] getReponseByIdQuestion(int IDQuestion)
        {
            List<Reponse> reps = new List<Reponse>();
            SqlDataReader reader;
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            using (SqlCommand cmd = new SqlCommand("getReponseByIdQuestion", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IDQuestion", IDQuestion));

                reader = cmd.ExecuteReader();
            }

            while (reader.Read())
            {
                Reponse rep = new Reponse(null, 0,-1);

                rep.ID = reader.GetInt32(reader.GetOrdinal("id_reponse"));
                rep.reponse = reader.GetString(reader.GetOrdinal("texte_reponse"));
                rep.points = reader.GetInt32(reader.GetOrdinal("point_reponse"));

                reps.Add(rep);
            }
            cad.closeConnection();

            Reponse[] tableauRep = reps.ToArray();

            return tableauRep;
        }



        /****************************************Filiere****************************************/

        public static List<Filiere> getAllMetier()
        {
            List<Filiere> filieres = new List<Filiere>();
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            SqlDataReader reader;
            using (SqlCommand cmd = new SqlCommand("AffichMetier", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();
            }

            while (reader.Read())
            {
                Filiere filiere = new Filiere();
                filiere.name = reader.GetString(reader.GetOrdinal("nom_filiere"));
                filiere.description = reader.GetString(reader.GetOrdinal("description_filiere"));
                filiere.miniScore = reader.GetInt32(reader.GetOrdinal("minscore_filiere"));
                filiere.maxiScore = reader.GetInt32(reader.GetOrdinal("maxscore_filiere"));
                filieres.Add(filiere);
            }


            return filieres;
        }






        /****************************************Admin****************************************/


        //Controle les accès aux fonctions administrateurs
        public static bool verifLogin(string identifiant, string psw)
        {
            //Verifie la connexion Admin
            CAD cad = new CAD();
            cad.openConnection(new MSG());
            SqlConnection conn = cad.oConn;
            int count = 0;
            using (SqlCommand cmd = new SqlCommand("ConAdmin", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@loginAdmin", identifiant));
                cmd.Parameters.Add(new SqlParameter("@mdpAdmin", psw));

                count = (int)cmd.ExecuteScalar();
                cad.closeConnection();
            }

            if (count >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
