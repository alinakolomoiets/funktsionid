using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funktsionid
{
	public class Functsioonid
	{
		public static int Korrutamine(int arv1, int arv2)
		{
			int kor = arv1 * arv2;
			return kor;
		}
		public static int[] Arvud_Massiviisse(int n, bool t_f)
		{
			Random rnd = new Random();
			int[] arvud = new int[n];
			for (int i = 0; i < n; i++)
			{
				if (t_f)
				{
					string input=Console.ReadLine();
					int output;
					if (int.TryParse(input, out output))
					{
						arvud[i] = output;
					}
					else
					{
						Console.WriteLine("Sisesta ainult arvud");
					}
				}
				else
				{
					arvud[i] = rnd.Next(1, 100);
				}
			}
			return arvud;
		}
		public static void Arvud_Ekraanike(Array massiiv)
		
		{
			int k,max = 0;
			foreach (var m in massiiv)
			{
				k = m.ToString().Length;
				if (k>max)
				{
					max = k;
				}
			}
			max ++;
			foreach (var m in massiiv)//massiiv ekraanile
			{
				
				Console.Write("{0,1}",m,max);
			}
		}
		public static double Keskmine (int n)
		{
			double[] arvud = new double[n];
			double kesk=0;
			for (int i = 0; i < n; i++)
			{
				arvud[i] = int.Parse(Console.ReadLine());
			}
			foreach (double item in arvud)
			{
				kesk=kesk + item;
			}
			kesk = Math.Round(kesk / n,4);
			return kesk;
		}

	}
}
