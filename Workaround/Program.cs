using Business.Concrete;
using Entities.Concrete;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            person.NationalIdentity = 12345678901;
            person.FirstName = "AHMET";
            person.LastName = "TURP";
            person.DateOfBirthYear = 2000;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);

            Console.ReadLine();
        }

    }
}