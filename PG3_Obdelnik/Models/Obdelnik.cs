namespace PG3_Obdelnik.Models
{
	public class Obdelnik
	{
		#region Vlastnosti
		private int stranaA = 10;
		private int stranaB = 10;
		private int maxRozmer = 100;

		public int MaxRozmer
		{
			get => maxRozmer; set
			{
				//prevedeno na kladne cislo
				maxRozmer = Math.Abs(value);
				if (maxRozmer < 10) { maxRozmer = 10; }

				//kontrola na max rozmer pro strany a, b
				if (StranaA > maxRozmer)
				{
					stranaA = maxRozmer;
				}
				if (StranaB > maxRozmer)
				{
					stranaB = maxRozmer;
				}

			}
		}
		public int StranaA
		{
			get => stranaA;
			set
			{
				if (stranaA != value)
				{
					if (value > MaxRozmer)
					{
						stranaA = MaxRozmer;
					}
					else if (value < 1)
					{
						stranaA = 1;
					}
					else
					{
						stranaA = value;
					}
				}
			}
		}
		public int StranaB
		{
			get => stranaB; set
			{
				if (stranaB != value)
				{
					if (value > MaxRozmer)
					{
						stranaB = MaxRozmer;
					}
					else if (value < 1)
					{
						stranaB = 1;
					}
					else
					{
						stranaB = value;
					}
				}
			}
		}

		public int Obsah => StranaA * StranaB;
		public int Obvod => 2 * (StranaA + StranaB);
		public double Uhlopricka => Math.Sqrt(StranaA * StranaA + Math.Pow(StranaB, 2));
		#endregion

		#region Metody
		private void Pokus()
		{

		}
		#endregion
	}
}
