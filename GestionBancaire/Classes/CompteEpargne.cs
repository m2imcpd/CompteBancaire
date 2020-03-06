using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GestionBancaire.Classes
{
    public class CompteEpargne : Compte
    {
        private double taux;
        
        public double Taux { get => taux; set => taux = value; }

        public CompteEpargne() : base()
        {
            
        }
        public CompteEpargne(int id, string n, int ci, decimal s, double t) : base(id, n, ci, s)
        {
            Taux = t;
        }
        public void UpdateInteret()
        {
            Operation o = new Operation
            {
                Montant = Solde * (decimal)Taux / 100,
                DateOperation = DateTime.Now,
                CompteId = Id
            };
            o.Save();
            AjouterOperation(o);
        }

        public override bool Save()
        {
            if(base.Save())
            {
                bool res;
                string request = "INSERT INTO CompteEpargne (compteId, taux) " +
                    " values (@compteId, @taux)";
                command = new SqlCommand(request, Configuration.connection);
                command.Parameters.Add(new SqlParameter("@compteId", Id));
                command.Parameters.Add(new SqlParameter("@taux", Taux));
                Configuration.connection.Open();
                res = command.ExecuteNonQuery() > 0;
                Configuration.connection.Close();
                return res;
            }
            else {
                return false;
            }
        }

        public static CompteEpargne GetCompteByNumero(string numeroCompte)
        {
            CompteEpargne c = null;
            string request = "SELECT c.Id , c.numero, c.clientId, c.solde, cp.taux FROM compte as c inner join compteEpargne as  cp on cp.compteId = c.id  where c.numero = @numero";
            command = new SqlCommand(request, Configuration.connection);
            command.Parameters.Add(new SqlParameter("@numero", numeroCompte));
            Configuration.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                c = new CompteEpargne(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDecimal(3), reader.GetDouble(4));
            }
            reader.Close();
            command.Dispose();
            Configuration.connection.Close();
            //chercher les opérations du compte
            if (c != null)
                c.Operations = Operation.GetOperationsByCompte(c.Id);
            return c;
        }
    }
}
