/* GRADE STATİSTİCS PROGRAM*/ 
int total = 0;
int counter = 0;
int highest = 0;
int lowest = 0;


Console.Write("Enter a grade, -1 to quit: ");
int grade=int.Parse(Console.ReadLine());

while(grade!=-1)
{
    if(counter == 0)
    {
        highest = grade; 
        lowest = grade;
    }
    else
    {
        if (grade > highest)
            highest = grade;
        if(grade<lowest)
            lowest = grade;

    }
    total += grade;
    counter += 1;
    Console.Write("Enter a grade, -1 tı quit:  ");
    grade=int.Parse(Console.ReadLine());

}

if (counter > 0)
{
    double average = (double)total / counter;

    Console.WriteLine($"Count: {counter}");
    Console.WriteLine($"Sum: {total}");
    Console.WriteLine($"Average: {average:F2}");
    Console.WriteLine($"Highest grade: {highest}");
    Console.WriteLine($"Lowest grade: {lowest}");
}
else
{
    Console.WriteLine("NO GRADES WERE ENTERED");
}

/* MULTIPLALICATION TABLE */

Console.WriteLine("Enter a number from 1 to 10:");
int numbers=int .Parse(Console.ReadLine());


while (numbers >=0 && numbers >= 10)
{
    Console.WriteLine("INVALID NUMBER!\nPlease enter a number from 1 to 10.");
    numbers=int .Parse(Console.ReadLine());
}
   

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"{numbers}*{i}={numbers * i}");
}