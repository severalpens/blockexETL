using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockex.Context
{
    //Rename class as 'ConnectionStrings' and fill in the variables
    public static class ConnectionStringExamples
    {
        public static readonly string LocalPostgreSQL = "Server = 127.0.0.1; Port = 5432; Database = postgres; User Id = postgres; Password = <password>";

        //render.com
        public static readonly string RenderPostgreSQL = "Host = oregon-postgres.render.com; Database = <database>; Username = <username>; Password = <password>; SSL Mode = Require;";

        public static readonly string LocalSqlServer = "Data Source=localhost;Initial Catalog=<database>;Persist Security Info=True;User ID=<username>;Password=<password>";
    }
}
