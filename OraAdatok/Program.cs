using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraAdatok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Alapok 801"); //ez a témakörünk
            int egeszTipusuValtozo1; //létrehoztunk egy egész típusú változót
            int egeszTipusuvaltozo2 = 1; //ez a másik változó is most jött létre, de neki rögtön kezdőértéket is adtunk
            egeszTipusuValtozo1 = 11; //muszáj kezdőértéket kapnia, mielőtt felhasználnánk
            Console.WriteLine("Ez az első változó kiíratása: " + egeszTipusuValtozo1);//így már fog futni Console.WriteLine("Ez a második változó kiíratása: "+egeszTipusuValtozo2);
            Console.WriteLine("\n\nTömbök használata");
            int[] egeszektombje1 = new int[] { 6, 12, 10, 18, 24, 28, 5, 5 };
            int[] egeszektombje2 = new int[7];
            int[] egeszektombje3 = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //minta minden elen kiíratására
            Console.Write("egeszektōnbjel elemei: ");
            foreach (int elem in egeszektombje1)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            Console.Write("egeszektōnbje3 elemei: ");
            foreach (int elem in egeszektombje3) //ez a foreach ciklusszervezés, ami végig megy az összes elemen, de belül az elen-ek nen módosíthatók
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            Console.Write("egeszektōnbje2 elemei: ");
            foreach (int elem in egeszektombje2)
            {
                Console.Write(elem + " ");
                //értékadás a tömb minden elenének
            }
            Console.Write("\negeszektömbje2 elenei frissen: ");

            for (int i = 0; i < egeszektombje2.Length; i++)
            {// a foreach-el ellentétben a for ciklusban tudjuk módosítani az elemeket, mert nem csak egy másolattal dolgozunk egeszektonbje2[i] = i;
                Console.Write(egeszektombje2[i] + " ");
            }
            Console.WriteLine();

            //Legfontosabb műveletek tömbökkel
            Console.WriteLine("\n\nA tömb elemeinek száma "+egeszektombje2.Length);
            Console.WriteLine("A tömb elemeinek típusa szövegként: "+egeszektombje2.ToString());
            // tömb elemeinek sormarendezése
            Array.Sort(egeszektombje1);
            Console.Write("egeszektōnbjel elemei rendezetten: ");
            foreach (int elem in egeszektombje1) {Console.Write(elem+" ");}
            Console.WriteLine();
            Array.Reverse(egeszektombje1); //sorrenfordítás
            Console.Write("egeszektōnbjel elemei fordítva: ");
            foreach (int elem in egeszektombje1) { Console.Write(elem + " "); }
            Console.WriteLine();
            //elem pozíciója a tömbben
            Console.WriteLine("\nA 10 ennyiedik az egeszektömbjel-ben: "+Array.IndexOf(egeszektombje1,10));
            Console.WriteLine("A 100 ennyiedik az egeszektōnbjel-ben: "+Array.IndexOf(egeszektombje1, 100));//-1 a jele, ha nincs benne"
            Console.WriteLine("A 5 ennyiedik az egeszektömbjel-ben:" + Array.IndexOf(egeszektombje1, 5));//ez történik, ha többször is benne van
            //Ha épp nem ezt tanuljuk, akkor használjhatjuk őket
            int osszeg = egeszektombje1.Sum();
            int legkisebb = egeszektombje1.Min();
            int legnagyobb = egeszektombje1.MaxO;
            Console.WriteLine($"\n\nÖsszeg: {osszeg), legkisebb: {legkisebb), legnagyobb: {legnagyobb}.");
            int[] masolat = (int[])egeszektombje1.clone();
            Console.WriteLine("Ez a másolattömb minden elenét megnöveli");
            for (int i = 0; i<masolat.Length; i++) { masolat[i]++; Console.Write(masolat[i]+" "); }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
