
Console.WriteLine("Enter your first number");
String read1 = Console.ReadLine();
int num1 = Convert.ToInt32(read1);

Console.WriteLine("Enter your first number");
String read2 = Console.ReadLine();
int num2 = Convert.ToInt32(read2);



int add = num1 + num2;
int minus = num1 - num2;
int multiply = num1 * num2;
double divide = num1 / num2;

while(true)
{
    Console.WriteLine("'+'To add, '-'To minus, '*'To multiply '/'To divide  ");
    String symbol = Console.ReadLine();
    if (symbol == "+")
    {
        Console.WriteLine("The sum is" + add);
        continue;
    }
}

Console.WriteLine("The input is null");
