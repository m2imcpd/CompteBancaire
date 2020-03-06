using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GestionBancaire.Classes
{
    public class ComptePayant : Compte
    {
        private decimal coutOperation;

        public decimal CoutOperation { get => coutOperation; set => coutOperation = value; }

        public ComptePayant(int id, string n, int ci, decimal s, decimal coperation) : base(id, n, ci, s)
        {
            CoutOperation = coperation;
        }
        public override bool AjouterOperation(Operation operation)
        {
            if(base.AjouterOperation(operation))
            {
                Operation o = new Operation
                {
                    CompteId = Id,
                    Montant = CoutOperation * -1,
                    DateOperation = DateTime.Now
                };
               return base.AjouterOperation(o);
            }
            else
            {
                return false;
            }
        }
        public override bool Save()
        {
            if (base.Save())
            {
                bool res;
                string request = "INSERT INTO comptePayant (compteId, coutOperation) " +
                    " values (@compteId, @coutOperation)";
                command = new SqlCommand(request, Configuration.connection);
                command.Parameters.Add(new SqlParameter("@compteId", Id));
                command.Parameters.Add(new SqlParameter("@coutOperation", CoutOperation));
                Configuration.connection.Open();
                res = command.ExecuteNonQuery() > 0;
                Configuration.connection.Close();
                return res;
            }
            else
            {
                return false;
            }
        }

        public static ComptePayant GetCompteByNumero(string numeroCompte)
        {
            ComptePayant c = null;
            string request = "SELECT c.Id , c.numero, c.clientId, c.solde, cp.coutOperation FROM compte as c inner join comptePayant as  cp on cp.compteId = c.id  where c.numero = @numero";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@numero", numeroCompte));
            Configuration.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                c = new ComptePayant(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDecimal(3), reader.GetDecimal(4));
            }
            reader.Close();
            command.Dispose();
            Configuration.connection.Close();
            //chercher les opérations du compte
            c.Operations = Operation.GetOperationsByCompte(c.Id);
            return c;
        }
    }
}
