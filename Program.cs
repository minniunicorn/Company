using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстариция работы класса");
            Company MyCompany = new Company() { name = "Computerr",
                                                persons = 10,
                                                money = 300000};
            Console.WriteLine(MyCompany.name + " " + MyCompany.persons + " " + MyCompany.money);
            Console.ReadKey();
        }
    }   
}
