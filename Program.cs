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

// int[] GenerateScheduleSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];

//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = i + 1;
//     }

//     return slots;
// }
// int[] GenerateEvenSlots(int lessonsCount)
// {
//     int[] slots2 = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots2[i] = (i + 1) * 2;
//     }
//     return slots2;
// }

// int[] slots = GenerateScheduleSlots(6);
// int[] slots2 = GenerateEvenSlots(6);

// foreach (int slot in slots) {
//     Console.WriteLine(slot);
// }

// foreach (int slot in slots2) {
//     Console.WriteLine(slot);
// }
//Задача А

// int n = int.Parse(Console.ReadLine());
// int[] kva(int n)
// {
//     int[] slot = new int[n];
//     for (int i = 0; i < n; i++)
//     {
//         slot[i] = (i + 1) * (i + 1);
//     }
//     return slot;
// }
// int[] slots = kva(n);
// foreach (int y in slots)
// {
//     Console.WriteLine(y);
// }
// //Задача Б
// int[] mass = { 1, -2, -5, 0, 6, 8, -10, -3, 7 };
// for (int i = 0; i < mass.Length; i++)
// {
//     if (mass[i] < 0)
//     {
//         mass[i] = 0;
//     }
// }
// foreach (int x in mass)
// {
//     Console.WriteLine(x);
// }
//6
int[] mass2 = { 1, -2, 7, 5, 3 };
Array.Sort(mass2);
int med = mass2.Length / 2;
Console.WriteLine(mass2[med]);
//7
int[] SquareAll(int[] numbers)
{
    int[] Sq2 = new int[numbers.Length];
    for (int i = 0; i < Sq2.Length; i++)
    {
        Sq2[i] = numbers[i] * numbers[i];
    }
    return Sq2;
}
int[] all_n = SquareAll(new int[] {2,6,7,42,1});
foreach (int n in all_n)
{
    Console.WriteLine(n);
}