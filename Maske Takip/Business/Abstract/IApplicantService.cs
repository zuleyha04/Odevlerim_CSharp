using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
        //sadece method imzazı bulundurabilirsin
        //birbirinin alternatifi olan sistemlerin farklı implementasyon yapmasını sağlar.(Yabancı uyruklu/Tc vatandaşı)
    {
        void ApplyForMask(Person person);


        List<Person> GetList();

        bool CheckPerson(Person person);
       
    }
}
