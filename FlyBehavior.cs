using System;

namespace DesignPatterns_Strategy_Ducks
{
	public interface FlyBehavior
	{
		void fly();
	}

	public class FlyWithWings: FlyBehavior
	{
		public void fly()
		{
			Console.WriteLine ("I'm flying!");
		}
	}

	public class FlyNoWay: FlyBehavior
	{

		public void fly(){
			Console.WriteLine ("I can't fly");
		}
	}

	public class FlyRocketPowered: FlyBehavior
	{
		public void fly()
		{
			Console.WriteLine ("I'm flying with rockets");
		}
	}
		
}



