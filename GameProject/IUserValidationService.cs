using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Validate: Doğrulamak
    interface IUserValidationService
    {
        bool Validate(Gamer gamer); 
    }
}
