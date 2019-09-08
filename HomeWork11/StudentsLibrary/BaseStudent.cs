using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
	public interface IBaseStudent
	{
		string Name { get; set; }

		int[] Numbers { get; set; }
		bool Guess(Storage storage);
	}
}
