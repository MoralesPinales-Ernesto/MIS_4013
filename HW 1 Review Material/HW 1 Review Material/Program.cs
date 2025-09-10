

using System.Runtime.InteropServices;

int custID;
int cogQty;
int gearQty;
string user; 

Console.WriteLine("Hello. Please enter your customer ID <<");
user = Console.ReadLine();
custID = int.Parse(user);

Console.WriteLine("Please input the number of Cogs you would like to purchase <<");
user = Console.ReadLine();
cogQty = int.Parse(user);

Console.WriteLine("Please input the number of Gears you would like to purchase <<");
user = Console.ReadLine();
gearQty = int.Parse(user);

Reciept receipt = new Reciept(custID, cogQty, gearQty);
receipt.PrintReciept();






public class Reciept
{
    public int customerID;
    public int CogQuantity;
    public int GearQuantity;
    public DateTime SaleDate;
    private double SalesTaxPercent = .089;
    private double CogPrice = 79.99;
    private double GearPrice = 250.00;

    public Reciept()
    {
        customerID = 0;
        CogQuantity = 0;
        GearQuantity = 0;
        SaleDate = DateTime.Now;
    }


    public Reciept(int id, int cog, int gear)
    {
        customerID = id;
        CogQuantity = cog;
        GearQuantity = gear;
        SaleDate = DateTime.Now;

    }

    public double CalculateTotal()
    {
        double total = CalculateNetAmount() + CalculateTaxAmount();
        return total;
    }

    private double CalculateNetAmount()
    {
        int totalItems = CogQuantity + GearQuantity;

        if (totalItems > 16 || CogQuantity > 10 || GearQuantity > 10)
        {
            CogPrice = CogPrice * 1.125;
            GearPrice = GearPrice * 1.125;
        }
        else
        {
            CogPrice = CogPrice * 1.15;
            GearPrice = GearPrice * 1.15;
        }

            double netAmount = (CogQuantity * CogPrice) + (GearQuantity * GearPrice);
        return netAmount;
    }

    private double CalculateTaxAmount()
    {
        double taxAmount = CalculateNetAmount() * SalesTaxPercent;
        return taxAmount;
    }

    public void PrintReciept()
    {
        Console.WriteLine("Customer ID: " + customerID);
        Console.WriteLine("Sale Date: " + SaleDate);
        Console.WriteLine("Cogs Purchased: " + CogQuantity + " at $" + CogPrice + " each");
        Console.WriteLine("Gears Purchased: " + GearQuantity + " at $" + GearPrice + " each");
        Console.WriteLine("Net Amount: $" + CalculateNetAmount());
        Console.WriteLine("Sales Tax: $" + CalculateTaxAmount());
        Console.WriteLine("Total Amount: $" + CalculateTotal());
    }
}

