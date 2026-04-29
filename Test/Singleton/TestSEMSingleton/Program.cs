using System;
using SysWork.Data.Common.ValueObjects;
using SysWork.SWCG.Test.Entities;

namespace TestSEMSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataManager.ConnectionString = "Data Source=.;Initial Catalog=SYSWORK2005;User ID=sa;Password=Dm58125812";
            DataManager.DatabaseEngine = EDatabaseEngine.MSSqlServer;
            var repo = DataManager.GetInstance().MA_CUENTASRepository;

            foreach (var cuenta in repo.GetAll())
            
                Console.WriteLine($"codigo: {cuenta.CODIGO} descripcion:{cuenta.DESCRIPCION}");
            

            Console.ReadLine();
        }
    }
}
