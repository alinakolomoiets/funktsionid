using System;
using System.Collections.Generic;
using System.Text;

namespace funktsionid
{
    class Inimised
    {
        static void Main (string []args)
        {
            LinkedList<int> alguses = new LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                alguses.AddLast(int.Parse(Console.ReadLine()));
            }
            LinkedList<int>.Enumerator ahel1 = alguses.GetEnumerator();
            while(ahel1.MoveNext())
            {
                Console.WriteLine(ahel1.Current);
            }
            int j = 0;
            foreach (int item in alguses)
            {
                if (j==0)
                {
                    
                }
                j++;
            }
            Console.ReadLine();

            //Dictionary<int,string>opilased= new Dictionary<int, string>(6);
            //opilased.Add(74589, "Mihail");
            //opilased.Add(74590, "Aleksandr");
            //opilased.Add(74591, "Edgar");
            //opilased.Add(74592, "Mark");
            //opilased.Add(74593, "Daniil");
            //opilased.Add(74594, "Alina");
            //string nimi = opilased[74590];
            //opilased[74590] = "Aleksander";
            //foreach (KeyValuePair<int,string> keyValue in opilased)
            //{
            //    Console.WriteLine(keyValue.Key + "-" + keyValue.Value);
            //}


            //List<Inimised> inimised = new List<Inimised>();
            //inimised.Add(new Inimised() { Nimi = "Mati" });
            //inimised.Add(new Inimised() { Nimi = "Kati" });
            //inimised.Add(new Inimised() { Nimi = "Mark" });
            //foreach (Inimised inimine in inimised)
            //{
            //    Console.Write(inimine.Nimi + ", ");
            //}
        }
        
    }
}
