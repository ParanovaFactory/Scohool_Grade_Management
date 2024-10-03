using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScohoolGradeManagement
{
    internal class SQLConnection
    {
        public SqlConnection conncetion()
        {
            SqlConnection conncet = new SqlConnection(@"Data Source=PREDATOR;Initial Catalog=""School Grade"";Integrated Security=True;TrustServerCertificate=True");
            conncet.Open();
            return conncet;
        }
    }
}
