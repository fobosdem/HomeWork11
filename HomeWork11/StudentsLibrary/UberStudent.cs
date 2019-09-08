using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
	public class UberStudent : IBaseStudent
	{
		public string Name { get; set; }
		public int[] Numbers { get; set; }

		public UberStudent(string name)
		{
			Name = name;
			Numbers = new int[100];
			for (int i = 0; i < 100; i++)
			{
				Numbers[0] = 40;
				Numbers[i] = 0;
			}
		}
		public bool Guess(Storage storage)
		{
			int guessNumber = 0;
			for (int i = 0; i < 100; i++)
			{
				if (Numbers[i] == 0)
				{
					guessNumber =  Numbers[i-1]+1;
					break;
				}
			}

			for (int i = 0; i < 100; i++)
			{
				if (Numbers[i] == 0)
				{
					Numbers[i] = guessNumber;
					break;
				}
			}

			if (guessNumber == storage.Weight)
			{
				return true;
			}
			else return false;
		}
	}
}
