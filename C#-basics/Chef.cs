using System;

public class Chef
{
	public void MakeChicken()
	{
		Console.WriteLine("The Chef makes chicken");
	}

	public void MakeSalad()
	{
		Console.WriteLine("The Chef makes salad");
	}

    // Virtual for overriding method
    public virtual void MakeSpecialDish()
	{
		Console.WriteLine("The Chef makes bbq ribs");
	}
}
