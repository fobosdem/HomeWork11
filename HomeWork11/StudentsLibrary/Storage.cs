using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
    public class Storage
    {
		public int Weight { get; set; }
		public Storage()
		{
			Random rnd = new Random();
			Weight = rnd.Next(40, 140);
		}
    }
}
