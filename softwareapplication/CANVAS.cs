using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwareapplication
{
    internal class CANVAS
    {
        private int cancsid;
            private SHAPE[]sHAPEs;
        private int spc;
        public int idcancas
        {
            get { return cancsid; }
            set { cancsid = value; }
        }
        public CANVAS(int cancsid)
        {
            this.cancsid = cancsid;
            sHAPEs = new SHAPE[10];
            spc = 0;
        }
        // constructor for deep copy
        public CANVAS(CANVAS obj)
        {
            this.cancsid = obj.cancsid;
            this.spc = obj.spc;
            sHAPEs = new SHAPE[10];
            for (int i = 0; i < spc; i++)
            {
                this.sHAPEs[i] = obj.sHAPEs[i];
            }
        }
        public void addshapes(SHAPE shape)
        {
            if (spc < sHAPEs.Length)
            {
                sHAPEs[spc] = shape;
                spc++;
            }
            else {
                Console.WriteLine("shapes can not be added");
            }

        }
        public void dsipalayshapes()
        {
            Console.WriteLine($"shape are avialbale in canvas {cancsid} are ");
            for (int i = 0; i < spc; i++)
            {
                sHAPEs[i].draw();
            }
        }
    ~ CANVAS()
        {
            Console.WriteLine("canvas is destroyes");
        }


    }
}
