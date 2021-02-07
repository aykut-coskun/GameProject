using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManagement : ISaleService
    {
        public void Buy(Gamer gamer, Campaign campaign, Games games)
        {
            Console.WriteLine("Adı : " + gamer.FirstName + " olan oyuncu "  + campaign.CampaignName + " kampanyası ile " +  games.GameName + " oyununu aldı "); 
        }
    }
}
