using PizzaSplit.Core;

Console.WriteLine("Pizza Split Console App");

double amount;

while (true)
{
    Console.Write("Enter the amount (euro): ");

    string? amountInput = Console.ReadLine();

    if (!double.TryParse(amountInput, out amount))
    {
        Console.WriteLine("Error: Enter a valid amount");
        continue;
    }

    if (amount < 0 || amount >= 10000)
    {
        Console.WriteLine("Error: Max amount is 0 < amount <= 10000");
        continue;
    }

    break;
}

int people;

while (true)
{
    Console.Write("Enter a number of people: ");

    string? peopleInput = Console.ReadLine();

    if (!int.TryParse(peopleInput, out people))
    {
        Console.WriteLine("Error: Enter a valid number of people");
        continue;
    }

    if (people < 1 || people > 20)
    {
        Console.WriteLine("Error: Max number of people is 1 to 20");
        continue;
    }

    break;
}

string tipInput;

while (true)
{
    Console.Write("Add 10% tip? (y/n): ");

    tipInput = Console.ReadLine() ?? "";

    if (tipInput.ToLower() != "y" && tipInput.ToLower() != "n")
    {
        Console.WriteLine("Error: Please enter y or n");
        continue;
    }

    break;
}

bool tips = tipInput.ToLower() == "y";

double result = BillCalculator.Calculate(people, amount, tips);

Console.WriteLine($"Amount per person: {result:F2} euro");
