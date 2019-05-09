using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dictionary
{
    public class dataBase
    {

        public SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-P99380I\SQLEXPRESS;Initial Catalog=odev;Integrated Security=True;MultipleActiveResultSets=True");
    }
}