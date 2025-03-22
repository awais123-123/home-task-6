using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETAIL_STORE
{
    internal class PRODUCT
    {
        public int product_ID;
        public string product_name; 
        public decimal price;
        public int QuantintityInStock;
        public PRODUCT(int product_ID, string product_name, decimal price, int quantintityInStock)
        {
            this.product_ID = product_ID;
            this.product_name = product_name;
            this.price = price;
            //here concept of constructor channing
            if (quantintityInStock >= 0 && quantintityInStock<= 100)
            {


                QuantintityInStock = quantintityInStock;
            }
            else
            {
                Console.WriteLine("quntity it not according to condition");
                quantintityInStock = 0;
            }
        }
        //constructor chaning with 4 approch
        //public PRODUCT(int product_ID=1, string product_name="", decimal price=0, int quantintityInStock=0)
        //{
        //    this.product_ID = product_ID;
        //    this.product_name = product_name;
        //    this.price = price;
        //    //here concept of constructor channing
        //    if (quantintityInStock > 0 && quantintityInStock < 100)
        //    {


        //        QuantintityInStock = quantintityInStock;
        //    }
        //    else
        //    {
        //        Console.WriteLine("quntity it not according to condition");
        //        quantintityInStock = 0;
        //    }
        //}
        //constructor chaing with 3 rd apprach;
        public PRODUCT(int product_ID, string product_name, decimal price):this(product_ID,product_name,price,0) { 
            //no need to write any thing in the body
        }
        public PRODUCT(int product_ID,int quantintityInStock) : this(product_ID, "", 0, quantintityInStock)
        {
            //no need to write any thing in the body
        }
        public PRODUCT(): this(0,"",0,0)
        {

        }
        public PRODUCT(int product_ID, string product_name) : this(product_ID, product_name, 0, 0)
        {
            //no need to write any thing in the body
        }
        //*******************************************************************************
        public void displayproduct()
        {
            Console.WriteLine($"product id={product_ID},product name={product_name},product price={price},qunatity in stock ={QuantintityInStock}");
        }
        //destructor
     ~PRODUCT()
        {
            Console.WriteLine($"product having  produ id {product_ID} is killed ");
        }
    }
}
