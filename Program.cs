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

int[] points = { 4, 7, 2, 9, 5 };
for (int i = 0; i < points.Length; i++)
{
    if (points[i] < 10)
    {
        points[i] = points[i] + 1;
    }
}

foreach (int point in points)
{
    Console.WriteLine(point);
}