using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Burada e-devlet sistemini simüle ediyoruz. 
    //Burada implementasyon yaptık ve UserValidationManager aşağıdaki doğrulamayı yapmakla yükümlü.
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        { //Burada eğer doğruysa true yanlışsa false döndüreceğiz. 
          //O yüzden IUserValidationService'teki imzayı 'bool' olarak değiştiriyoruz.
            
            if (gamer.BirthYear == 1991 && gamer.FirstName == "AYKUT" && gamer.LastName == "COŞKUN" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
