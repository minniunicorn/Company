using System;

namespace Company
{
    class MyCompany
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстариция работы класса");
            Company MyCompany = new Company() { name = "Computerr", //Создание объекта класса
                                                persons = 10,
                                                money = 300000};
            Console.WriteLine(MyCompany.name + " " + MyCompany.persons + " " + MyCompany.money); //Вывод объекта класса
            Console.ReadKey();
        }
    }   
}
