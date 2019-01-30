using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0727466_WEEK_04
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Village
    {
        //Node is an ADT
        //What KIND of DATA do we need in a nood?
        public Village nextVillage;
        public Village previousVillage;
        public string VillageName;
        public bool isAstrildeHere = false;
    }
    class Countryside
    {
        Village Maple = new Village();
        Village Toronto = new Village();
        Village Ajax = new  Village();
        Village First;
        Village Last;

        public void  launch()
        {
            Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.previousVillage = Maple;
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.nextVillage = Toronto;


        }


    }
}
