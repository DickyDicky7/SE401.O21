using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
	internal class BrandExpression : Expression
	{
		public void InterpretContext(Context context)
		{
			if (context.getIsAircraft() == true)
			{
				if (context.getFirstChar().Equals("A"))
					Console.WriteLine("Brand is Airbus");
				else if (context.getFirstChar().Equals("B"))
					Console.WriteLine("Brand is Boeing");
			}
			else
				Console.WriteLine("Brand could not be interpreted");
		}
	}
}
