﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        //pttmanegerın bağımlı olduğu sınıf yerine o sınıfın interface ini yazarız
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)//Constructor new yapıldığında çalışır
        {
            _applicantService = applicantService;
        }


        public void GiveMask(Person person)
        {

            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}
