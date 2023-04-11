using AulaIComparable.Entities;

string path = @"c:\Curso - C#\Exercicios - C#\Seção 14\in.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<Employee> list = new List<Employee>();
        while (!sr.EndOfStream)
        {
            list.Add(new Employee(sr.ReadLine()));
        }
        list.Sort();
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp);
        }
    }

}
catch (IOException e)
{
    Console.WriteLine("An error accuried");
    Console.WriteLine(e.Message);
}
