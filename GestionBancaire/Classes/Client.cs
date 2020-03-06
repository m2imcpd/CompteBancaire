using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;

namespace GestionBancaire.Classes
{
    public class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private static SqlCommand command;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set {
                Regex r = new Regex(@"^0[1-9]{1}[.-\s]?([0-9]{2}){4}$");
                if(r.IsMatch(value))
                {
                    telephone = value;
                }
                else
                {
                    throw new Exception("Téléphone incorrect");
                }
            } 
        }

        public bool Save()
        {
            string request = "INSERT INTO client (nom, prenom, telephone)" +
                " OUTPUT INSERTED.ID values " +
                "(@nom, @prenom, @telephone)";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@nom", Nom));
            command.Parameters.Add(new SqlParameter("@prenom", Prenom));
            command.Parameters.Add(new SqlParameter("@telephone", Telephone));
            Configuration.connection.Open();
            Id = (int)command.ExecuteScalar();
            Configuration.connection.Close();
            return Id > 0;
        }

        public static Client GetClientByTelephone(string phone)
        {
            Client c = null;
            string request = "SELECT * FROM client where telephone = @telephone";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@telephone", phone));
            Configuration.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                c = new Client
                {
                    Id = reader.GetInt32(0),
                    Nom = reader.GetString(1),
                    Prenom = reader.GetString(2),
                    Telephone = reader.GetString(3)
                };
            }
            reader.Close();
            command.Dispose();
            Configuration.connection.Close();
            return c;
        }
    }
}
