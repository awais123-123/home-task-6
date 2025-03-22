using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETAIL_STORE
{
    internal class STORE
    {
        public string storename;
        public string location;
        private PRODUCT[] produvts;
        private int p_c;
        public STORE(string storename, string location )
        {
            this.storename = storename;
            this.location = location;
            produvts = new PRODUCT[10];   
            p_c = 0;    

        }
        public void addpr(PRODUCT pRODUCT) {
            if (p_c < produvts.Length)
            {
                produvts[p_c++] = pRODUCT;
            }
            else
            {
                Console.WriteLine("product can not be added");
            }
        }
        public void displayallproducts()
        {
            Console.WriteLine($"alll inventry in the store {storename},at the loctaon {location} is here");
            foreach(PRODUCT pr in produvts)
            {
                if(pr != null)
                {
                    pr.displayproduct();
                }
                
            }
        }
        ~STORE()
        {
            Console.WriteLine("store is ended");
        }
    }
}
