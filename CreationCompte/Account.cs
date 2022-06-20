using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationCompte
{
    public class Account
    {
        public static void CheckLoginFormat(string login)
        {
            if (login.Length < 3) { throw new ArgumentException("Le login doit faire au moins 3 caractères"); }
        }

        public static void CheckPassword(string pwd)
        {
            pwd = pwd.Trim();
            if (pwd.Length < 6) { throw new ArgumentException("Le login doit faire au moins 6 caractères"); }

            int countLetter = 0;
            int countNb = 0;
            foreach (char c in pwd)
            {
                if (c >= 48 && c <= 57)
                {
                    countNb++;
                }
                else if (c >= 65 && c <= 90 || c >= 97 && c <= 122)
                {
                    countLetter++;
                }
                else if (countLetter == 1 && countNb == 1)
                {
                    break;
                }

            }

            if (countLetter == 0 && countNb > 0)
            {
                throw new ArgumentException("le mot de passe doit comporter au moins 1 lettre");
            }
            if (countNb == 0 && countLetter > 0)
            {
                throw new ArgumentException("le mot de passe doit comporter au moins 1 chiffre");
            }
            if (countNb == 0 && countLetter == 0)
            {
                throw new ArgumentException("le mot de passe doit comporter au moins 1 chiffre et 1 lettre");
            }

        }

        public static void CheckLoginUniqueness(string login)
        {
            long count;
            using (SqliteConnection connect = new SqliteConnection(@"Data Source=Comptes.db"))
            {
                connect.Open();

                string req = @"select count(*) from Comptes where login = @login";
                SqliteCommand cmd = new SqliteCommand(req, connect);
                SqliteParameter param = new SqliteParameter
                {
                    SqliteType = SqliteType.Text,
                    ParameterName = "@login",
                    Value = login
                };

                cmd.Parameters.Add(param);
                count = (long)cmd.ExecuteScalar();

            }

            if (count > 0)
            {
                throw new LoginAlreadyExistsException("Ce login existe déjà");
            }
        }
    }
}
