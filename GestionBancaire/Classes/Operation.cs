using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GestionBancaire.Classes
{
    public class Operation
    {
        private int id;
        private decimal montant;
        private DateTime dateOperation;
        private int compteId;
        private static SqlCommand command; 

        public int Id { get => id; set => id = value; }
        public decimal Montant { get => montant; set => montant = value; }
        public DateTime DateOperation { get => dateOperation; set => dateOperation = value; }
        public int CompteId { get => compteId; set => compteId = value; }

        public bool Save()
        {
            string request = "INSERT INTO operation (compteId, dateOperation, montant) " +
                " OUTPUT INSERTED.ID values(@compteId, @dateOperation, @montant)";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@compteId", CompteId));
            command.Parameters.Add(new SqlParameter("@dateOperation", DateOperation));
            command.Parameters.Add(new SqlParameter("@montant", Montant));
            Configuration.connection.Open();
            Id = (int)command.ExecuteScalar();
            Configuration.connection.Close();
            return Id > 0;
        }

        public static List<Operation> GetOperationsByCompte(int id)
        {
            List<Operation> liste = new List<Operation>();
            string request = "SELECT * FROM operation where compteId = @compteId";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@compteId", id));
            Configuration.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Operation o = new Operation()
                {
                    Id = reader.GetInt32(0),
                    CompteId = reader.GetInt32(1),
                    DateOperation = reader.GetDateTime(2),
                    Montant = reader.GetDecimal(3)
                };
                liste.Add(o);
            }
            reader.Close();
            Configuration.connection.Close();
            return liste;
        }
    }
}
