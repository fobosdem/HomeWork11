using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
	public class UberCheater : IBaseStudent
	{

		public string Name { get; set; }
		public int[] Numbers { get; set; }

		public UberCheater(string name)
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
			int guessNumber;
			bool flag = true;
			int j = 0;
			for (int i = 0; i < 100; i++)
			{
				if (Numbers[i] == 0)
				{
					j = Numbers[i - 1] + 1;
					break;
				}
			}
			do
			{
				guessNumber = j;
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
				j++;
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
