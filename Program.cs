using System;

namespace DesignPatterns_Strategy_Ducks
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Duck mallard = new MallardDuck ();
			mallard.performQuack();
			mallard.performFly ();

			Duck model = new ModelDuck ();
			model.performFly ();
			model.setFlyBehavior (new FlyRocketPowered ());
			model.performFly ();

		}
	}
}
