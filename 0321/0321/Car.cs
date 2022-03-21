using System;
using System.Collections.Generic;
using System.Text;

namespace _0321
{
    class Car
    {
        string color = "red";
        int cc = 1500;
        string brand = "BMW";
        //private
        public  void StartEngine()
        {
            Console.WriteLine("Engine發動");
        }
        public void ShowInfo()
        {
            Console.WriteLine("顏色" + color);
            Console.WriteLine("CC數" + cc);
            Console.WriteLine("廠牌" + brand);
        }
        public void changeColor(string changeCol)
        {
            color = changeCol;
        }
        public virtual void OpenDoor()
        {
            Console.WriteLine("側開");
        }
    }
}
