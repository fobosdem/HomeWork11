using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsLibrary;

namespace ConsoleApp
{
	class Program
	{
		static void Main()
		{
			Storage storage = new Storage();
			Console.WriteLine("Chose number of players form 2 to 8");
			int number;
			do
			{
				Console.Write("Number of players");
			} while (!int.TryParse(Console.ReadLine(), out number) || number == 0);
			switch (number)
			{
				case 2:
					string[] names = new string[2];
					for (int i = 0; i < 2; i++)
					{
						Console.Write($"Name of {i + 1} player: ");
						names[i] = Console.ReadLine();
					}

					Cheater cheater = new Cheater(names[0]);
					CommonStudent commonStudent = new CommonStudent(names[1]);

					ListOfStudents.studentList.Add(cheater);
					ListOfStudents.studentList.Add(commonStudent);
					break;
				case 3:
					string[] names2 = new string[3];
					for (int i = 0; i < 3; i++)
					{
						Console.Write($"Name of {i + 1} player: ");
						names2[i] = Console.ReadLine();
					}

					Cheater cheater2 = new Cheater(names2[0]);
					CommonStudent commonStudent2 = new CommonStudent(names2[1]);
					UberCheater ubercheater = new UberCheater(names2[2]);

					ListOfStudents.studentList.Add(cheater2);
					ListOfStudents.studentList.Add(commonStudent2);
					ListOfStudents.studentList.Add(ubercheater);
					break;
				case 4:
					string[] names4 = new string[4];
					for (int i = 0; i < 4; i++)
					{
						Console.Write($"Name of {i + 1} player: ");
						names4[i] = Console.ReadLine();
					}

					Cheater cheater4 = new Cheater(names4[0]);
					CommonStudent commonStudent4 = new CommonStudent(names4[1]);
					UberCheater ubercheater4 = new UberCheater(names4[2]);
					UberStudent uberStudent = new UberStudent(names4[3]);

					ListOfStudents.studentList.Add(cheater4);
					ListOfStudents.studentList.Add(commonStudent4);
					ListOfStudents.studentList.Add(ubercheater4);
					ListOfStudents.studentList.Add(uberStudent);
					break;
				case 5:
					string[] names5 = new string[5];
					for (int i = 0; i < 5; i++)
					{
						Console.Write($"Name of {i + 1} player: ");
						names5[i] = Console.ReadLine();
					}

					Cheater cheater5 = new Cheater(names5[0]);
					CommonStudent commonStudent5 = new CommonStudent(names5[1]);
					UberCheater ubercheater5 = new UberCheater(names5[2]);
					UberStudent uberStudent5 = new UberStudent(names5[3]);
					StudentNotebook studentNotebook5 = new StudentNotebook(names5[4]);

					ListOfStudents.studentList.Add(cheater5);
					ListOfStudents.studentList.Add(commonStudent5);
					ListOfStudents.studentList.Add(ubercheater5);
					ListOfStudents.studentList.Add(uberStudent5);
					ListOfStudents.studentList.Add(studentNotebook5);
					break;
			}
			int iterations = 0;
			do
			{
				foreach (IBaseStudent student in ListOfStudents.studentList)
				{
					if (student.Guess(storage))
					{
						Console.WriteLine($"Winner {student.Name}");
						break;
					}
				}
				iterations++;
			} while (iterations < 100);
			Console.ReadKey();

		}
	}
}
