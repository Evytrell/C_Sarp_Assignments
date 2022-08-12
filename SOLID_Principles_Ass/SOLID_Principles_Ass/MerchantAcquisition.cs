using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Ass
{
    internal class MerchantAcquisition
    {

        public string CreateAccount()
        {
            string name = "firstname , lastname";
            string merchantId = "aw1224444";

            return name + merchantId;

        }

        public string StoreRegistration()
        {
            string businessName = "name of business";
            string businessLocation = "business location";

            return businessName + businessLocation;
        }
        

    }        

    public class MerchantSupport
    {

        /// <summary>
        /// merchants can ask for support like helping them with logistics and managing their stores
        /// </summary>
        void Logistics()
        {
            
        }

        public string StoreManagement()
        {
            var storeMgt = new MerchantAcquisition();
            storeMgt.StoreRegistration();   

            return "your store has been created";

        }
    }
}

