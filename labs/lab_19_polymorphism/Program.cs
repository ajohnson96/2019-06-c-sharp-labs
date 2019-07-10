using System;

namespace lab_19_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // these all call the same method, but due to polymorphism the results change

            var p = new Parent();
            p.ThrowAParty();

            var c01 = new Child01();
            c01.ThrowAParty();

            var c02 = new Child02();
            c02.ThrowAParty();
        }
    }

    class Parent
    {
        public virtual void ThrowAParty()
        {
            Console.WriteLine("Parent is throwing a dinner party, base classes only");
        }
    }

    class Child01:Parent
    {
        public override void ThrowAParty()
        {
            Console.WriteLine("Parent is throwing a dinner party, but child goes swimming!");
        }
    }

    class Child02:Parent
    {
        public override void ThrowAParty()
        {
            Console.WriteLine("GET OUT OF MY ROOM MOM");
        }

    }
}
