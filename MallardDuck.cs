using System;

namespace DesignPatterns_Strategy_Ducks
{
	public class MallardDuck: Duck
	{
		public MallardDuck ()
		{
			display ();
			quackBehavior = new Quack ();
			flyBehavior = new FlyWithWings ();

		}

		public override void display()
		{
			Console.WriteLine ("I'm a real Mallard duck");
		}
	}
}

