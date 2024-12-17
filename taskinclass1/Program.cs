Console.WriteLine("Enter Name: ");
string name1 = Console.ReadLine();
Console.WriteLine("Enter Language (en,es,fr,tr): ");
string language1 = Console.ReadLine();

if(language1 =="en")
{
    Console.WriteLine("Hello " + name1);
}
else if(language1 =="es")
{
    Console.WriteLine("Hola "+ name1);
}
else if (language1 == "fr")
{
    Console.WriteLine("Bonjour " + name1);
}
else if (language1 == "tr")
{
    Console.WriteLine("Merhaba " + name1);
}
else
{
    Console.WriteLine("Error");
}
//////////////////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("------------------------------------------------------------------------ " );

Console.WriteLine("Enter the first Number:  ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the Second Number:  ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("they are equal " + num1 + " = " + num2);
}
else if (num1 > num2)
{
    Console.WriteLine("the first number is bigger " + num1 + " > " + num2);
}
else if (num2 > num1)
{
    Console.WriteLine("the second number is bigger " + num2 + " > " + num1);
}
else
{
    Console.WriteLine("Error");
}

Console.WriteLine("------------------------------------------------------------------------ ");
/////////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Enter Mark:  ");
double grade = Convert.ToDouble(Console.ReadLine());

if (grade >= 80)
{
    Console.WriteLine("Your grade is A");
}
else if(grade >=70 && grade <80 )
{
    Console.WriteLine("Your grade is B");
}
else if (grade >= 60 && grade < 70)
{
    Console.WriteLine("Your grade is C");
}
else if (grade >= 50 && grade < 60)
{
    Console.WriteLine("Your grade is D");
}
else
{
    Console.WriteLine("Your grade is F");
}