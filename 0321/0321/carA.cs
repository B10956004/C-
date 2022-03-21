using System;
using System.Collections.Generic;
using System.Text;

namespace _0321
{
    class CarA:Car//繼承Car類別
    {
        public override void OpenDoor()
        {
            //base.OpenDoor();
            Console.WriteLine("上開");
        }
    }
}
