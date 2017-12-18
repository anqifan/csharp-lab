using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace connectoracle
{
    class Program
    {
       
        public static string ConnectOracle()
    {
        try
        {
            string connString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.137.250)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));Persist Security Info=True;User ID=hr;Password=hr;";
            OracleConnection con = new OracleConnection(connString);

            con.Open();
            Console.WriteLine("yes");
            return string.Empty;
        }
        catch (Exception ex)
        {
                Console.WriteLine("no");
                return ex.ToString();
        }
    }
    static void Main(string[] args)
        {
            Console.WriteLine(ConnectOracle());
            Console.ReadLine();
        }
    }
}
