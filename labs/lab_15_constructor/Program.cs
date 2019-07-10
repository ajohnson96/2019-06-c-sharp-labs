using System;

namespace lab_15_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var Peter = new Person("PZ 89 56 42", "Password", "Peter");
            Peter.SetNINO("DEF456", "ihavenoidea");
            Peter.GetNINO("Password");
            Console.WriteLine(Peter.SetNINO("DEF456", "Password"));
            Console.WriteLine(Peter.GetNINO("Password"));
        }
    }

    class Person
    {
        private string NINO;
        private string password;

        public string Name;

        // constructor : (public + name of class)
        public Person(string NINO, string password, string Name)
        {
            this.NINO = NINO;
            this.password = password;
            this.Name = Name;
        }

        // Setter
        public bool SetNINO(string NewNINO, string password)
        {
            bool itWorked = false;

           if(this.password == password)
            {
                this.NINO = NewNINO;
                itWorked = true;
            }

            return itWorked;
        }

        // Getter
        public string GetNINO(string password)
        {
            string GiveNINO = "Incorrect Password - Try Again";

            if (this.password == password)
            {
                GiveNINO = this.NINO;
            }

            return this.NINO;
        }
    }
}
