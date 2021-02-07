using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Hiçbir sınıfı çıplak bırakmıyoruz. 
    //Bir class inheritance veya implementasyon almıyorsa ileride skıntı yaraatabilir.
    //GamerManager'ın içerisine kayıt olurken IUserValidationService kullanmak istiyoruz.
    //Eğer bir manager sınfının içinde başka bir manager sınıfını kullanacaksak asla onu new'leme.
    //Onun yerine userValidationService adında bir constructor oluştururuz ve bunu generate constructor yaparız
    //ve bunun anlamı GamerManager'ın içerisinde bir doğrulama servisi kullanacağız.
    //Bu doğrulama servisi asla kimlik paylaşım sisteminin kendisi değil onun soyutu.
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
