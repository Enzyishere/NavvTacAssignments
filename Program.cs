{ 
        int rows= 3;
        for (int i =rows; i<=3; i++)
        {
            for (int j = 1; j<=i; j++)
            {
                Console.Write("*"); 
            }
            Console.WriteLine();
        }
    }



    int rows = 3;

    for (int i = rows; i >= 1; i--)
    {
        for (int j = i; j >= 1; j--)
        {
            Console.Write(j);
        }
        Console.WriteLine();
    }

{
    // Define the list of marks
    int[] marks = { 0, 98, 67, 9, 45, 44, 23, 2 };

    // Initialize variables for average, max, and min
    double average = 0;
    int max = marks[0]; // Initialize max with the first element of the array
    int min = marks[0]; // Initialize min with the first element of the array
    int sum = 0;

    // Calculate sum, max, and min using a loop
    foreach (int mark in marks)
    {
        sum += mark;

        if (mark > max)
            max = mark;

        if (mark < min)
            min = mark;
    }

    // Calculate average
    if (marks.Length > 0)
        average = (double)sum / marks.Length;

    // Display results
    Console.WriteLine("Marks: " + string.Join(", ", marks));
    Console.WriteLine("Average: " + average);
    Console.WriteLine("Maximum Mark: " + max);
    Console.WriteLine("Minimum Mark: " + min);
}



