/* Exercise 8 Part A */

Console.WriteLine("This Program Will Write Even Numbers From 1-100");
int counter = 1;

//While Counter Is < 101 It Will Increment By 1, If A Number Divided By 2 == 0 Then It Will Print
while (counter < 101)
{
    if (counter % 2 == 0)
    {
        Console.WriteLine(counter);
    }
    counter++;
}
