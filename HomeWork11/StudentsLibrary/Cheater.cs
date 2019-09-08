using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
	public class Cheater : IBaseStudent
	{
		public string Name { get; set; }
		public int[] Numbers { get; set; }

		public Cheater(string name)
		{
			Name = name;
			Numbers = new int[100];
			for(int i =0; i < 100; i++)
			{
				Numbers[i] = 0;
			}
		}

		public bool Guess(Storage storage)
		{
			Random rnd = new Random();
			int guessNumber;

			bool flag = true;
			do
			{
				guessNumber = rnd.Next(40, 140);
				foreach (var student in ListOfStudents.studentList)
				{
					for (int i = 0; i < student.Numbers.Length; i++)
					{
						if (student.Numbers[i] != guessNumber)
						{
							flag = false;
						}
						else flag = true;
					}
				}
			} while (!flag);

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
