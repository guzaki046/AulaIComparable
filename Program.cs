string path = @"c:\Curso - C#\Exercicios - C#\Seção 14\in.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<string> list = new List<string>();
        while (!sr.EndOfStream)
        {
            list.Add(sr.ReadLine());
        }
        list.Sort();
        foreach (string str in list)
        {
            Console.WriteLine(str);
        }
    }

}
catch (IOException e)
{
    Console.WriteLine("An error accuried");
    Console.WriteLine(e.Message);
}
