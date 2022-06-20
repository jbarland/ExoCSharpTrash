using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteo
{
    public class Stats
    {
        private List<MonthlyStatements> _statements;
        public Stats(List<MonthlyStatements> statements)
        {
            _statements = statements;
        }

        public MonthlyStatements? StatementTempMax
        {
            get
            {
                //MonthlyStatements statementWithMaxTemp = _statements[0];

                //foreach (MonthlyStatements statement in _statements)
                //{
                //    if (statement.MaxTemp > statementWithMaxTemp.MaxTemp)
                //    {
                //        statementWithMaxTemp = statement;
                //    }
                //}
                //return statementWithMaxTemp;

                MonthlyStatements? statementWithMaxTemp = _statements.MaxBy(s => s.MaxTemp);

                return statementWithMaxTemp;
            }
        }

        public double GetPrecipitationsYear(int year)
        {
            //double precipitationsYear = 0;
            //foreach (MonthlyStatements statement in _statements)
            //{
            //    if (statement.Month.Year == year)
            //    {
            //        precipitationsYear += statement.Precipitations;
            //    }

            //}
            //return precipitationsYear;

            double precipitationsYear = _statements.Where(s => s.Month.Year == year).Sum(s => s.Precipitations);

            return precipitationsYear;

        }

        public double? GetAverageSunshineForJuly()
        {
            double? averageSunshineForJuly = _statements.Where(s => s.Month.Month == 7).Average(s => s.Sunshine);
            return averageSunshineForJuly;
        }

        public int GetNbHotMonths()
        {
            double averageMaxTemp = _statements.Average(s => s.MaxTemp);
            int nbHotMonths = _statements.Where(s => s.MaxTemp > averageMaxTemp).Count();
            return nbHotMonths;
        }

        public IEnumerable<object> GetAveragePrecByYear()
        {
            var groups =
                _statements.GroupBy(s => s.Month.Year)
                .Select(group => new { Year = group.Key, AveragePrec = group.Average(s => s.Sunshine) }).ToList();

            return groups;
        }
    }
}
