using System;
using SysWork.Data.Common.ValueObjects;
using SysWork.SWCG.Test;

namespace TestSEMSingletonPublicProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Db.ConnectionString = "Data Source=.;Initial Catalog=SYSWORK2005;User ID=sa;Password=Dm58125812";
            Db.DatabaseEngine = EDatabaseEngine.MSSqlServer;
            var repo = Db.MA_CUENTAS;

            foreach (var cuenta in repo.GetAll())

                Console.WriteLine($"codigo: {cuenta.CODIGO} descripcion:{cuenta.DESCRIPCION}");


            Console.ReadLine();
        }
    }
}
