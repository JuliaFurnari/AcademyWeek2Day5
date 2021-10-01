using AcademyWeek2Day5.Entity;
using AcademyWeek2Day5.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2Day5.ADO
{
    public class UtenteRepository:IUtenteRepository
    {
        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                      "Initial Catalog = MostriVsEroi;" +
                                      "Integrated Security = true;";
        public bool Add(Utente utente)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;


                    command.CommandText = "insert into Utenti values (@nick, @pass, @admin)";
                    command.Parameters.AddWithValue("@nick", utente.Nickname);
                    command.Parameters.AddWithValue("@pass", utente.Password);
                    command.Parameters.AddWithValue("@admin", false);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool Delete(Utente utente)
        {
            throw new NotImplementedException();
        }

        public List<Utente> Fetch()
        {
            throw new NotImplementedException();
        }

       
        public Utente GetByNickname(string nickname)
        {
            Utente utente = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from Utenti where Nickname = @nick";
                command.Parameters.AddWithValue("@nick", nickname);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var nick = (string)reader["Nickname"];
                    var pass = (string)reader["Password"];
                    var admin = (bool)reader["Admin"];
                    var id = (int)reader["Id"];

                    utente = new Utente { Nickname = nick, Password = pass, Id = id, Admin = admin};
                }

            }
            return utente;
        }
        public Utente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Utente utente)
        {
            throw new NotImplementedException();
        }
    }
}
