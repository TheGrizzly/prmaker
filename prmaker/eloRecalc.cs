using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace prmaker
{
    class eloRecalc
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";

        public static void RecalculateEloForUpdate(int idt, int idm, int idlm, int Kvalue, bool firstIt)
        {
            List<int> idpWithMatches = new List<int>();
            List<int> idpAtTourney = new List<int>();
            List<int> aRatings = new List<int>();
            

            List<int> sIdSets = new List<int>();
            List<int> sIdPlayer1 = new List<int>();
            List<int> sIdPlayer2 = new List<int>();
            List<int> sScoreP1 = new List<int>();
            List<int> sScoreP2 = new List<int>();
            List<int> sRatingP1 = new List<int>();
            List<int> sRatingP2 = new List<int>();
            
            List<int> uIdp = new List<int>();
            List<int> uRatings = new List<int>();

            try
            {
                string query = "Call AllMatches(" + idt + ");";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sIdSets.Add(reader.GetInt32(0));
                        sIdPlayer1.Add(reader.GetInt32(1));
                        sIdPlayer2.Add(reader.GetInt32(2));
                        sScoreP1.Add(reader.GetInt32(3));
                        sScoreP2.Add(reader.GetInt32(4));
                        sRatingP1.Add(reader.GetInt32(5));
                        sRatingP2.Add(reader.GetInt32(6));
                    }
                }

                databaseConnection.Close();

                int indx = sIdSets.IndexOf(idm);

                string queryIdPlayers1 = "CALL GetIdpFromT(" + idt + ");";

                commandDatabase.CommandText = queryIdPlayers1;

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                   while (reader.Read())
                    {
                        idpAtTourney.Add(reader.GetInt32(0));
                    }
                }

                databaseConnection.Close();

                string queryIdPlayers2 = "CALL GetIdpFromM(" + idt + ");";

                commandDatabase.CommandText = queryIdPlayers2;

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idpWithMatches.Add(reader.GetInt32(0));
                    }
                }

                databaseConnection.Close();

                

                if (firstIt)
                {
                    int index = sIdSets.IndexOf(idm);
                    for(int i = index; i < sIdSets.Count; i++)
                    {
                        if (!uIdp.Contains(sIdPlayer1[i])){
                            uIdp.Add(sIdPlayer1[i]);
                            uRatings.Add(sRatingP1[i]);
                        }
                        if (!uIdp.Contains(sIdPlayer2[i])){
                            uIdp.Add(sIdPlayer2[i]);
                            uRatings.Add(sRatingP2[i]);
                        }
                    }

                    for(int i = 0; i < uIdp.Count; i++)
                    {
                        string queryReturn = "CALL ReturnElo(" + uIdp[i] + ", " + uRatings[i] + ");";

                        commandDatabase.CommandText = queryIdPlayers1;

                        databaseConnection.Open();
                        reader = commandDatabase.ExecuteReader();

                        
                        
                        databaseConnection.Close();

                    }
                }

                for (int i = 0; i < idpAtTourney.Count; i++)
                {
                    string queryGetRatings = "CALL GetRating(" + idpAtTourney[i] + ");";

                    commandDatabase.CommandText = queryGetRatings;

                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            aRatings.Add(reader.GetInt32(0));
                        }
                    }

                    databaseConnection.Close();
                }            

                int idp1 = sIdPlayer1[indx];
                int idp2 = sIdPlayer2[indx];
                int sc1 = sScoreP1[indx];
                int sc2 = sScoreP2[indx];  

                int rp1 = aRatings[idpAtTourney.IndexOf(idp1)];
                int rp2 = aRatings[idpAtTourney.IndexOf(idp2)];

                string queryUpdateMatch = "CALL UpdateMatch(" + idm + ", " + rp1 + ", " + rp2 + ");";

                commandDatabase.CommandText = queryUpdateMatch;

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();

                double Qa = Math.Pow(10, rp1 / 400);
                double Qb = Math.Pow(10, rp2 / 400);
                double Ea = Qa / (Qa + Qb);
                double Eb = Qb / (Qa + Qb);
                double Sa;
                double Sb;
                double Raa;
                double Rab;

                if ((sc1 == -1 && sc2 == 0) || (sc1 == 0 && sc2 == -1))
                {
                    Sa = Convert.ToDouble(sc1 / 1);
                    Sb = Convert.ToDouble(sc2 / 1);
                    if (sc1 == -1 && sc2 == 0)
                    {
                        Raa = Kvalue * (Sa - Ea);
                        Rab = 0;
                    }
                    else if (sc1 == 0 && sc2 == -1)
                    {
                        Raa = 0;
                        Rab = Kvalue * (Sa - Ea);
                    }
                }
                else
                {
                    Sa = Convert.ToDouble(sc1 / (sc1+sc2));
                    Sb = Convert.ToDouble(sc2 / (sc1 + sc2));
                    Raa = Kvalue * (Sa - Ea);
                    Rab = Kvalue * (Sb - Eb);
                }

                Raa = Kvalue * (Sa - Ea);
                Rab = Kvalue * (Sb - Eb);

                int NRa = Convert.ToInt32(rp1 + Math.Ceiling(Raa));
                int NRb = Convert.ToInt32(rp2 + Math.Ceiling(Rab));

                string query2 = "CALL RecalcElo(" + NRa + ", " + NRb + ", " + idp1 + ", " + idp2 + ");";

                commandDatabase.CommandText = query2;

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();

                if (idm != idlm)
                {
                    int idnm = sIdSets[sIdSets.IndexOf(idm) + 1];
                    RecalculateEloForUpdate(idt, idnm, idlm, Kvalue, false);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }

        }

        public static void RecalculateEloForDelete(int idt, int idm, int idlm, int nrp1, int nrp2)
        {

        }
    }
}
