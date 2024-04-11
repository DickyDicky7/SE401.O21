using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
	internal class TypeExpression : Expression
	{
		public void InterpretContext(Context context)
		{
			if (context.getIsAircraft() == true)
			{
				string ac_model = context.getModel();
				if (context.getLenght() == 5 && context.getLastChar().Equals("F"))//F-> Freighter
				{
					Console.WriteLine("Aircraft type is Cargo/Freighter");
				}
				else
					Console.WriteLine("Aircraft type is Passenger Transportation");
			}
			else
				Console.WriteLine("Type could not be interpreted");
		}
	}
}
