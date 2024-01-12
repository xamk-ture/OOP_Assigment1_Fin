using System.Globalization;

namespace OOP_Assigment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DateTime birthDate = new DateTime(1990, 1, 1);


            DateTime thisMoment = DateTime.Now;

            CultureInfo culture = new CultureInfo("fi-FI");

            TimeSpan timeSpan = thisMoment - birthDate;

        }

        enum GameMode { ReactionGame, SpedenPelit}

        public enum Role
        {
            Admin = 0,
            User = 1,
            Guest = 2
        }

        public const string AdminRole = "Administrator";
        public const string UserRole = "User";

        public bool EnumRoleCheck(Role role)
        {
            GameMode gameMode = GameMode.ReactionGame;
            if(gameMode == GameMode.SpedenPelit)
            {
                return true;
            }
            else
            {
                return false;
            }

            if(role == Role.Admin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveUser(Role role)
        {             
            
            if(role != Role.Admin)
            {
                return;
            }

            //Remove user
        }

        public bool RoleCheck(string role)
        {
            if (role == "Administrator")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveUser(string role)
        {
            if(role != "Admin")
            {
                return;
            }

            //Remove user
        }

    }
}