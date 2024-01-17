HashSet<int> alunos = new();

Console.Write("How many students for course A?");

int nCourseA = int.Parse(Console.ReadLine());
for (int i = 0; i < nCourseA; i++)
{
    int codeStudent = int.Parse(Console.ReadLine());
    alunos.Add(codeStudent);
}

Console.Write("How many students for course B?");

int nCourseB = int.Parse(Console.ReadLine());
for (int i = 0; i < nCourseB; i++)
{
    int codeStudent = int.Parse(Console.ReadLine());
    alunos.Add(codeStudent);
}

Console.Write("How many students for course C?");

int nCourseC = int.Parse(Console.ReadLine());
for (int i = 0; i < nCourseC; i++)
{
    int codeStudent = int.Parse(Console.ReadLine());
    alunos.Add(codeStudent);
}

Console.WriteLine("Total: " + alunos.Count);
