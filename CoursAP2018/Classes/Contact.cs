using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Contact
    {
        private int id;
        private string nom;
        private string prenom;
        private static SqlCommand command;
        private List<Email> emails;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public List<Email> Emails { get => emails; set => emails = value; }

        public Contact()
        {
            Emails = new List<Email>();
        }
        public bool Save()
        {
            string request = "INSERT INTO contact " +
                "(nom, prenom) OUTPUT INSERTED.ID values " +
                "(@nom, @prenom)";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@nom", Nom));
            command.Parameters.Add(new SqlParameter("@prenom", Prenom));
            Configuration.connection.Open();
            Id = (int)command.ExecuteScalar();
            Configuration.connection.Close();
            return Id > 0;
        }

        public bool Update()
        {
            bool res;
            string request = "UPDATE contact set nom = @nom, prenom = @prenom" +
                " where id = @id";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@nom", Nom));
            command.Parameters.Add(new SqlParameter("@prenom", Prenom));
            command.Parameters.Add(new SqlParameter("@id", Id));
            Configuration.connection.Open();
            res = command.ExecuteNonQuery() > 0;
            Configuration.connection.Close();
            return res;
        }

        public bool Delete()
        {
            bool res;
            string request = "DELETE FROM contact where id = @id";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@id", Id));
            Configuration.connection.Open();
            res = command.ExecuteNonQuery() > 0;
            Configuration.connection.Close();
            return res;
        }
        public static Contact GetContactById(int id)
        {
            Contact c = null;
            string request = "SELECT * FROM contact where id = @id";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@id", id));
            Configuration.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                c = new Contact
                {
                    Id = reader.GetInt32(0),
                    Nom = reader.GetString(1),
                    Prenom = reader.GetString(2)
                };
            }
            reader.Close();
            command.Dispose();
            if(c != null)
            {
                request = "SELECT * FROM email where contactId = @contactId";
                command = new SqlCommand(request, Configuration.connection);
                command.Parameters.Add(new SqlParameter("@contactId", c.Id));
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Email e = new Email
                    {
                        Id = reader.GetInt32(0),
                        Mail = reader.GetString(1),
                        ContactId = reader.GetInt32(2)
                    };
                    c.Emails.Add(e);
                }
                reader.Close();
                command.Dispose();
            }
            Configuration.connection.Close();
            return c;
        }

        public static List<Contact> GetContacts()
        {
            List<Contact> liste = new List<Contact>();
            string request = "SELECT * FROM contact";
            command = new SqlCommand(request, Configuration.connection);
            Configuration.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Contact c = new Contact
                {
                    Id = reader.GetInt32(0),
                    Nom = reader.GetString(1),
                    Prenom = reader.GetString(2)
                };
                liste.Add(c);
            }
            reader.Close();
            foreach(Contact c in liste)
            {
                request = "SELECT * FROM email where contactId = @contactId";
                command = new SqlCommand(request, Configuration.connection);
                command.Parameters.Add(new SqlParameter("@contactId", c.Id));
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Email e = new Email
                    {
                        Id = reader.GetInt32(0),
                        Mail = reader.GetString(1),
                        ContactId = reader.GetInt32(2)
                    };
                    c.Emails.Add(e);
                }
                reader.Close();
                command.Dispose();
            }
            Configuration.connection.Close();
            return liste;
        }

        public override string ToString()
        {
            return $"Id : {Id}, Prénom : {Prenom}, Nom : {Nom}";
        }
    }
}
