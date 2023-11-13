using System;

// Inheritance
public class ItalianChef : Chef
{
    // Overriding
    public override void MakeSpecialDish()
    {
        Console.WriteLine("The Chef makes chicken parm");
    }

    public void MakePasta()
    {
        Console.Write("The Chef makes pasta");
    }
}
