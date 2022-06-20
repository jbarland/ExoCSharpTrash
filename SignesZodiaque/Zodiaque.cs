using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignesZodiaque
{
    internal class Zodiaque
    {
        public enum Signes
        {
            Bélier, Balance, Taureau, Scorpion, Gémeaux, Sagittaire, Cancer, Capricorne, Lion, Verseau, Vierge, Poisson
        }
        public static void DatePourSigne(Signes chosenSigne, out DateTime startDate, out DateTime endDate)
        {

            if (chosenSigne == Signes.Bélier)
            {
                startDate = new DateTime(1900,03,21);
                endDate = new DateTime(1900, 04, 20);
            }
            else if (chosenSigne == Signes.Balance)
            {
                startDate = new DateTime(1900, 09, 23);
                endDate = new DateTime(1900, 10, 20);
            }
            else if (chosenSigne == Signes.Taureau)
            {
                startDate = new DateTime(1900, 04, 21);
                endDate = new DateTime(1900, 05, 21);
            }
            else if (chosenSigne == Signes.Scorpion)
            {
                startDate = new DateTime(1900, 10, 21);
                endDate = new DateTime(1900, 11, 22);
            }
            else if (chosenSigne == Signes.Gémeaux)
            {
                startDate = new DateTime(1900, 05, 22);
                endDate = new DateTime(1900, 06, 21);
            }
            else if (chosenSigne == Signes.Sagittaire)
            {
                startDate = new DateTime(1900, 11, 23);
                endDate = new DateTime(1900, 12, 21);
            }
            else if (chosenSigne == Signes.Cancer)
            {
                startDate = new DateTime(1900, 06, 22);
                endDate = new DateTime(1900, 07, 21);
            }
            else if (chosenSigne == Signes.Capricorne)
            {
                startDate = new DateTime(1900, 12, 22);
                endDate = new DateTime(1900, 01, 20);
            }
            else if (chosenSigne == Signes.Lion)
            {
                startDate = new DateTime(1900, 07, 22);
                endDate = new DateTime(1900, 08, 22);
            }
            else if (chosenSigne == Signes.Verseau)
            {
                startDate = new DateTime(1900, 01, 21);
                endDate = new DateTime(1900, 02, 19);
            }
            else if (chosenSigne == Signes.Vierge)
            {
                startDate = new DateTime(1900, 08, 23);
                endDate = new DateTime(1900, 09, 22);
            }
            else
            {
                startDate = new DateTime(1900, 02, 20);
                endDate = new DateTime(1900, 03, 20);
            }
        }

        public static Signes SignePourDate(DateTime birthdate)
        {
            DateTime theDate = new DateTime (1900, birthdate.Month, birthdate.Day);

            if (theDate >= new DateTime(1900, 03, 21) && theDate <= new DateTime(1900, 04, 20))
            {
                return Signes.Bélier;
            }
            else if (theDate >= new DateTime(1900, 09, 23) && theDate <= new DateTime(1900, 10, 20))
            {
                return Signes.Balance;
            }
            else if (theDate >= new DateTime(1900, 04, 21) && theDate <= new DateTime(1900, 05, 21))
            {
                return Signes.Taureau;
            }
            else if (theDate >= new DateTime(1900, 10, 21) && theDate <= new DateTime(1900, 11, 22))
            {
                return Signes.Scorpion;
            }
            else if (theDate >= new DateTime(1900, 05, 22) && theDate <= new DateTime(1900, 06, 21))
            {
                return Signes.Gémeaux;
            }
            else if (theDate >= new DateTime(1900, 11, 23) && theDate <= new DateTime(1900, 12, 21))
            {
                return Signes.Sagittaire;
            }
            else if (theDate >= new DateTime(1900, 06, 22) && theDate <= new DateTime(1900, 07, 21))
            {
                return Signes.Cancer;
            }
            else if (theDate >= new DateTime(1900, 07, 22) && theDate <= new DateTime(1900, 08, 22))
            {
                return Signes.Lion;
            }
            else if (theDate >= new DateTime(1900, 01, 21) && theDate <= new DateTime(1900, 02, 19))
            {
                return Signes.Verseau;
            }
            else if (theDate >= new DateTime(1900, 08, 23) && theDate <= new DateTime(1900, 09, 22))
            {
                return Signes.Vierge;
            }
            else if (theDate >= new DateTime(1900, 02, 20) && theDate <= new DateTime(1900, 03, 20))
            {
                return Signes.Poisson;
            }
            else
            {
                return Signes.Capricorne;
            }
        }
    }
}

