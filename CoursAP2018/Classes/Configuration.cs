using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Configuration
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\ap2018;Integrated Security=True");
    }
}
