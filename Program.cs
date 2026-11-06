// Console.Write("Сколько студентов в группе");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];
// int c1 = 0;
// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
// }

// foreach (int grade in grades)
// {
//     c1 += grade;
//     Console.WriteLine(grade);
// }
// double sred1 = c1 / grades.Length;
// Console.WriteLine($" Средний балл {sred1}");

// int[] points = { 4, 7, 2, 9, 5 };
// for (int i = 0; i < points.Length; i++)
// {
//     if (points[i] < 10)
//     {
//         points[i] = points[i] + 1;
//     }
// }

// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }

// int[] grades = { 4, 5, 3, 5, 4, 2 };

// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1])
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }

int[] GenerateScheduleSlots(int lessonsCount)
{
    int[] slots = new int[lessonsCount];

    for (int i = 0; i < lessonsCount; i++)
    {
        slots[i] = i + 1;
    }

    return slots;
}
int[] GenerateEvenSlots(int lessonsCount)
{
    int[] slots2 = new int[lessonsCount];
    for (int i = 0; i < lessonsCount; i++)
    {
        slots2[i] = (i + 1) * 2;
    }
    return slots2;
}

int[] slots = GenerateScheduleSlots(6);
int[] slots2 = GenerateEvenSlots(6);

foreach (int slot in slots) {
    Console.WriteLine(slot);
}

foreach (int slot in slots2) {
    Console.WriteLine(slot);
}
