using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GestionBancaire.Classes
{
    public class Compte
    {
        private int id;
        private decimal solde;
        private int clientId;
        private string numero;
        private List<Operation> operations;
        protected static SqlCommand command; 

        public int Id { get => id; set => id = value; }
        public decimal Solde { get => solde; }
        public int ClientId { get => clientId; set => clientId = value; }
        public string Numero { get => numero; }
        public List<Operation> Operations { get => operations; set => operations = value; }

        public Compte()
        {
            Operations = new List<Operation>();
        }

        public Compte(int id, string n, int ci, decimal s)
        {
            Id = id;
            numero = n;
            ClientId = ci;
            solde = s;
        }

        public virtual bool Save()
        {
            numero = Guid.NewGuid().ToString();
            solde = 0;
            string request = "INSERT INTO compte (numero, clientId, solde) " +
                "OUTPUT INSERTED.ID values " +
                "(@numero, @clientId, @solde)";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@numero", Numero));
            command.Parameters.Add(new SqlParameter("@clientId", ClientId));
            command.Parameters.Add(new SqlParameter("@solde", Solde));
            Configuration.connection.Open();
            Id = (int)command.ExecuteScalar();
            Configuration.connection.Close();
            return Id > 0;
        }

        public virtual bool Update()
        {
            bool result;
            string request = "UPDATE compte set solde = @solde";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@solde", Solde));
            Configuration.connection.Open();
            result = command.ExecuteNonQuery() > 0;
            Configuration.connection.Close();
            return result;
        }

        public virtual bool  AjouterOperation(Operation operation)
        {
            Operations.Add(operation);
            solde += operation.Montant;
            return Update();
        }

        public static Compte GetCompteByNumero(string numeroCompte)
        {
            Compte c = null;
            string request = "SELECT * FROM compte where numero = @numero";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@numero", numeroCompte));
            Configuration.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                c = new Compte(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDecimal(3));
            }
            reader.Close();
            command.Dispose();
            Configuration.connection.Close();
            //chercher les opérations du compte
            c.Operations = Operation.GetOperationsByCompte(c.Id);
            return c;
        }

        public override string ToString()
        {
            return $"Numéro de compte : {Numero}, Solde : {Solde}";
        }
    }
}
