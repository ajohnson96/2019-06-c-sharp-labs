using System;

namespace lab_14_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "Bob";
            p.SetNINO("ABC123", "");
            //Console.WriteLine()
        }
    }

    class Person
    {
        private string NINO;
        private string password;
        public string Name { get; set; }

        public void SetNINO(string newNINO, string password)
        {
            if(this.password == password)
            {
                this.NINO = newNINO;
            }

        }
    }
}
