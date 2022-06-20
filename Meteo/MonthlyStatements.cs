using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteo
{
    public class MonthlyStatements
    {
        public DateTime Month { get; private set; }
        public double MinTemp { get; private set; }
        public double MaxTemp { get; private set; }
        public double Precipitations { get; private set; }
        public double? Sunshine { get; private set; }

        public const string _headingArray = "| Mois      | T°min(°C) | T°max(°C) | Précip(mm) | Ensol(h)  |\n" +
                                            "-------------------------------------------------------------";

        public MonthlyStatements(string s)
        {
            string[] array = s.Split('\t');

            

            Month = DateTime.Parse(array[0]);
            MinTemp = Double.Parse(array[1]);
            MaxTemp = Double.Parse(array[2]);
            Precipitations = Double.Parse(array[3]);
            Sunshine = (array[4] == String.Empty)? null : Double.Parse(array[4]);
            Sunshine = (Double.TryParse(array[4], out Double sunshine))? sunshine: null;
        }


        public override string ToString()
        {
            return String.Format($"| {Month,-10:MM/yyyy}| {MinTemp,-10:F1}| {MaxTemp,-10:F1}| {Precipitations,-11:F1}| {Sunshine,-10:F1}|");
        }


    }
}
