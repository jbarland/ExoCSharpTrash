using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteo
{
    public static class DAL
    {
        const string file = "DonneesMeteoParis.txt";

        public static List<MonthlyStatements> GetMonthlyStatements()
        {
            var list = new List<MonthlyStatements>();

            string[] statements = File.ReadAllLines(file);

            for (int i = 1; i < statements.Length; i++)
            {
                list.Add(new MonthlyStatements(statements[i]));
            }

            return list;
        }
    }
}
