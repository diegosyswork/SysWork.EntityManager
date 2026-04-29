using System;
using Test;

namespace TestSEMInstanciable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new Db("Data Source=.;Initial Catalog=SYSWORK2005;User ID=sa;Password=Dm58125812");
            foreach (var cuenta in db.MA_CUENTAS.GetAll())
                Console.WriteLine($"codigo: {cuenta.CODIGO} descripcion: {cuenta.DESCRIPCION}");
            
            Console.ReadLine();
        }
    }
}
