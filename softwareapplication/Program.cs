using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwareapplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SHAPE s1=new SHAPE(1,"circle","red");
            SHAPE s2 = new SHAPE(2, "squre", "blue");
            SHAPE original_shape =new SHAPE (3,"trinagel","orange");
            //shalow copy 
            SHAPE shallow=original_shape;
            //deep copy
            SHAPE deep = new SHAPE(original_shape);
            //before changing 
            Console.WriteLine("shapes befor chages");
            original_shape.draw();
            Console.WriteLine("shhalow copy of shape ");
                shallow.draw(); 
            Console.WriteLine("deep copy of sh[pe ");
            deep.draw();
            // after changes shape 
            original_shape.idshape = 5;
            original_shape.typeshape = "cube";
            original_shape.clrshape = "pink";
            //after changing 
            Console.WriteLine("shapes agter chages-------------------------");
            original_shape.draw();
            Console.WriteLine("shhalow copy of shape ");
            shallow.draw();
            Console.WriteLine("deep copy of sh[pe ");
            deep.draw();
            Console.ReadLine();
            Console.Clear();
            // for canvas 

            CANVAS c1 = new CANVAS(1);
            CANVAS original=new CANVAS(2);  
            original.addshapes(s1);
            original.addshapes(s2);
            //shalow canvas
            CANVAS shallow_original=original;
            CANVAS deep_original = new CANVAS(original);
            //beore changing 
            Console.WriteLine("canvas before changing");
            original.dsipalayshapes();
            Console.WriteLine("shallow copy before changes");
            shallow_original.dsipalayshapes();
            Console.WriteLine("deep copy before changes");
            deep_original.dsipalayshapes();
            original.idcancas = 9;
            original.addshapes(original_shape);
            //after changing 
            Console.WriteLine("canvas after changing");
            original.dsipalayshapes();
            Console.WriteLine("shallow copy after changes");
            shallow_original.dsipalayshapes();
            Console.WriteLine("deep copy after changes");
            deep_original.dsipalayshapes();

        }
    }
}
