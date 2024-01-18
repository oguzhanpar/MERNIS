using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //SONAR QUBE Software Code Quality Tool
    public class PttManager: ISupplierService 
    {
        private IApplicantService _applicantService;

        //Constructor
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            string fullName = person.FirstName + " " + person.LastName;

            Console.WriteLine(fullName + " için MERNIS SORGULAMA BAŞLATILDI...");

            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(fullName + " TCKN Doğrulandı");
            }
            else
            {
                Console.WriteLine(fullName + " TCKN Doğrulama BAŞARISIZ!");
            }
        }
    }
}
