using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwareapplication
{
    internal class SHAPE
    {
        private int shapeid;
        private string shapetype;
        private string shapecolr;
        // properties
public int idshape
        {
            get { return shapeid; }
            set { shapeid = value; }
        }
        public string typeshape
        {


            get { return shapetype; }
            set { shapetype = value; }
        }
        public string clrshape
        {
            get { return shapecolr; }
            set { shapecolr = value; }
        }
        public SHAPE(int shapeid, string shapetype, string shapecolr)
        {
            this.shapeid = shapeid;
            this.shapetype = shapetype;
            this.shapecolr = shapecolr;
            
        }
        //constructor overloading for deep copy
        public SHAPE(SHAPE other)
        {
            this.shapeid = other.shapeid;
            this.shapetype = other.shapetype;
            this.shapecolr = other.shapecolr;
        }
        public void draw()
        {
            Console.WriteLine($"shape id is {shapeid},shape type is {shapetype}, shape colour is {shapecolr}");
        }
        // distructoer
        ~SHAPE()
        {
            Console.WriteLine("shape is ended");
        }
    }
}
