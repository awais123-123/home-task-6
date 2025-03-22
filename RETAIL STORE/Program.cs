using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETAIL_STORE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PRODUCT p1 = new PRODUCT(); //all default values
            PRODUCT p2 = new PRODUCT(1,"pc",123.56m,11);
            PRODUCT p3 = new PRODUCT(2, "key borad", 100.2m);
            PRODUCT p4 = new PRODUCT(3, "mouse");
            PRODUCT P5 = new PRODUCT(4, "", 0, 11);//NO NAME AND PRICE
            //store
            STORE mystore=new STORE("my kingdom","jaranwala");
            mystore.addpr(p1);
            mystore.addpr(p2);
            mystore.addpr(p3);
            mystore.addpr(p4);
            mystore.addpr(P5);
            mystore.displayallproducts();
            
            Console.WriteLine("here we usind distructor");
            mystore=null;
            p1=null;
            p2=null;
                
            p3=null;
            p4=null;
            P5=null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.ReadLine() ;

        }
    }
}
