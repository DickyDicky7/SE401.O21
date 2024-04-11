using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
	internal class ModelExpression : Expression
	{
		public void InterpretContext(Context context)
		{
			if (context.getIsAircraft() == true)
			{
				Console.WriteLine("Model is : " + context.getModel().Substring(1, 3));
			}
			else
				Console.WriteLine("Model could not be interpreted");
		}
	}
}
