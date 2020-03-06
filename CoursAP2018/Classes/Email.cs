using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Email
    {
        private int id;
        private string mail;
        private int contactId;
        private static SqlCommand command;

        public int Id { get => id; set => id = value; }
        public string Mail { get => mail; set => mail = value; }
        public int ContactId { get => contactId; set => contactId = value; }

        public bool Save()
        {
            string request = "INSERT INTO email (mail, contactId) OUTPUT INSERTED.ID " +
                "values (@mail, @contactId)";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@mail", Mail));
            command.Parameters.Add(new SqlParameter("@contactId", ContactId));
            Configuration.connection.Open();
            Id = (int) command.ExecuteScalar();
            Configuration.connection.Close();
            return Id > 0;
        }

        public override string ToString()
        {
            return $" Email : {Mail}";
        }
    }
}
