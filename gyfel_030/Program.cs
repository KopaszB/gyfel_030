using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//B.30.feladat: Készítsünk  programot,  amely bekéri  a  víz  hőmérsékletét, majd  eldönti, hogy  az  milyen halmazállapotú. A halmazállapot lehet folyékony, gőz, vagy jég.

namespace gyfel_030
{
    class Program
    {
        static void Main()
        {
            int ertek = int.Parse(Console.ReadLine());
            VizHalmazallapota(ertek);
            Console.ReadLine();
        }

        static void VizHalmazallapota(int szam)
        {
            if (szam >= 100)
                Console.WriteLine($"A {szam} fokos vizet gőznek hívjuk!");
            else if (szam < 0)
                Console.WriteLine($"A {szam} fokos vizet jégnek hívjuk!");
            else
                Console.WriteLine($"A {szam} fokos víz folyékony halmazállapotú.");


        }
    }
}
