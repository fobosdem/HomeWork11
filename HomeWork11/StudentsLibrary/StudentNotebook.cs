﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
	public class StudentNotebook : IBaseStudent
	{
		public string Name { get; set; }
		public int[] Numbers { get; set; }

		public StudentNotebook(string name)
		{
			Name = name;
			Numbers = new int[100];
			for (int i = 0; i < 100; i++)
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
				for (int i = 0; i < Numbers.Length; i++)
				{
					if (Numbers[i] != guessNumber)
					{
						flag = false;
					}
					else flag = true;
				}
			}while(!flag);

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
