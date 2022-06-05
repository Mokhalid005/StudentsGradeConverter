
while (true)
{
    Console.Write("Enter the student Grade:\t");
    int.TryParse(Console.ReadLine(), out int grade);

    // using if statement
    if (grade < 50) result('F');
    if (grade >= 50 && grade < 60) result('E');
    if (grade >= 60 && grade < 75) result('D');
    if (grade >= 75 && grade < 85) result('C');
    if (grade >= 85 && grade < 90) result('B');
    if (grade >= 90 && grade <= 100) result('A');
    if (grade > 100) Console.WriteLine("Error");

    // using switch statement 
    switch (grade)
    {
        case < 50:
            result('F');
            break;
        case (>= 50 and < 60):
            result('E');
            break;
        case (>= 60 and < 75):
            result('D');
            break;
        case (>= 75 and < 85):
            result('C');
            break;
        case (>= 85 and < 90):
            result('B');
            break;
        case (>= 90 and <= 100):
            result('A');
            break;
        case > 100:
            Console.WriteLine("Error");
            break;
    }
    Console.Write("Continue Converting! [y/n]?\t");
    if (Console.ReadLine() == "n") { break; }
}

void result(char g) { Console.WriteLine($"Your Grade is {g}"); }
