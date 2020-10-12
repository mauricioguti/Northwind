using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Northwind
{
    class varpublic
    {
        public static SqlConnection cadconex = new SqlConnection("Server=(local);database=northwind; Integrated Security = true");
    }
}
