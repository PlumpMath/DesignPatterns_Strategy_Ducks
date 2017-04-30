using System;

namespace DesignPatterns_Strategy_Ducks
{
	public abstract class Duck
	{
		public FlyBehavior flyBehavior;
		public QuackBehavior quackBehavior;

		public Duck ()
		{
		}

		public abstract void display ();

		public void setFlyBehavior(FlyBehavior fb)
		{
			flyBehavior= fb;

		}

		public void setQuackBehavior(QuackBehavior qb){
			quackBehavior = qb;

		}
		public void performFly(){
			flyBehavior.fly ();
		}

		public void performQuack()
		{
			quackBehavior.quack ();
		}

		public void swim() {

			Console.WriteLine ("All ducks float, even decoys!");
		}
	}
}

