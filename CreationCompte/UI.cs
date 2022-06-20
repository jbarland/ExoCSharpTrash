using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationCompte
{
    public class UI
    {
        public static string Login { get; private set; }
        public static string Pwd { get; private set; }
        public static string EnterLogin()
        {
            bool isLoginOk = false;
            Login = string.Empty;

            while (!isLoginOk)
            {
                try
                {
                    Console.WriteLine("Veuillez entrer votre nom d'utilisateur");
                    Login = Console.ReadLine();
                    Account.CheckLoginFormat(Login);
                    Account.CheckLoginUniqueness(Login);
                    isLoginOk = true;

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (LoginAlreadyExistsException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return Login;
        }

        public static string EnterPwd()
        {
            bool isPwdOk = false;
            string Pwd = string.Empty;

            while (!isPwdOk)
            {
                try
                {
                    Console.WriteLine("Veuillez entrer votre mot de passe");
                    Pwd = Console.ReadLine();
                    Account.CheckPassword(Pwd);
                    ConfirmSignin();
                    isPwdOk = true;

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return Pwd;
        }

        public static void ConfirmSignin()
        {
            Console.WriteLine($"Votre compte a bien été créé avec le login {Login}");
        }
    }
}
