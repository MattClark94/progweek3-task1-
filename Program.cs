int grade1, grade2, grade3, grade4, grade5, grade6;
int average;
char choice; 
do
{

    try
    {
        Console.WriteLine(" Enter Grade 1 ");
        grade1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Enter Grade 2 ");
        grade2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Enter Grade 3 ");
        grade3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Enter Grade 4 ");
        grade4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Enter Grade 5 ");
        grade5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Enter Grade 6 ");
        grade6 = Convert.ToInt32(Console.ReadLine());

        average = (grade1 + grade2 + grade3 + grade4 + grade5 + grade6) / 6;

        switch (average)
        {
            case (>= 70):
                Console.WriteLine(" 1st ");
                break;

            case (>= 60):
                Console.WriteLine(" 2.1 ");
                break;

            case (>= 50):
                Console.WriteLine(" 2.2 ");
                break;

            case (> 40):
                Console.WriteLine(" 3rd ");
                break;

            case (40):
                Console.WriteLine(" Pass ");
                break;

            case (< 40):
                Console.WriteLine(" Fail ");
                break;
        }
    }
    catch
    {
      Console.WriteLine(" Incorrect Input ");  
    }
    Console.WriteLine(" Do you want to try again? ");                                                       
    choice=Convert.ToChar(Console.ReadLine());

} while (choice !='N');
Console.ReadKey();