using System;

namespace GameProject
{
    class Program
    {
        //GamerManager'i kullanarak gamer'ı kayıt ettiğimizde çalışabilmek için
        //bir doğrulama servisine ihiyaç duyarız.Doğrulama sınıfının kim olduğunu belirtiriz(UserValidationManager)

        static void Main(string[] args)
        {
            GamerManager gamermanager = new GamerManager(new NewEStateUserValidationManager());
            gamermanager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1991,
                FirstName = "AYKUT",
                LastName = "COŞKUN",
                IdentityNumber = 123456
            });

            Console.WriteLine();

            Campaign campaign1 = new Campaign() { CampaignId = 1, CampaignName = "Üyelik indirimi", CampaignDetails = "Yeni üye olana bir ay indirim", RateofDiscount = 25 };
            Campaign campaign2 = new Campaign() { CampaignId = 2, CampaignName = "Kış fırsatı", CampaignDetails = "Kış ayları boyunca geçerlidir", RateofDiscount = 40 };

            CampaignManager campaignmanager = new CampaignManager();
            campaignmanager.Add(campaign1);
            campaignmanager.Add(campaign2);
            campaignmanager.Update(campaign2);

            Console.WriteLine();

            Gamer gamer1 = new Gamer() 
            { 
                Id = 1, 
                FirstName = "Engincan", 
                LastName = "Coşkun", 
                BirthYear = 2003, 
                IdentityNumber = 13579 
            };
            
            Gamer gamer2 = new Gamer() 
            { 
                Id = 2, 
                FirstName = "İlhan", 
                LastName = "Coşkun", 
                BirthYear = 1986, 
                IdentityNumber = 24680 
            };

            Console.WriteLine();


            Games game1 = new Games(){ GameId = 111, GameName = "Call of Duty",GamePrice = 150};
            
            Games game2 = new Games(){ GameId = 222, GameName = "NBA 2K21", GamePrice = 250};
            
            Games game3 = new Games() { GameId = 333, GameName = "FİFA 2021", GamePrice = 350 };


            SaleManagement salemanagement = new SaleManagement();
            salemanagement.Buy(gamer1, campaign1, game3); 
            salemanagement.Buy(gamer2, campaign2, game1); 
                     
        }
    }
}
