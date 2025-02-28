string fileName = "file.txt";
string path = Path.Combine(@"Myfiles\" + fileName);
List<string> lines = new();
string l;
if (File.Exists(path))
{
    using (StreamReader sr = new(path))
    {
        while ((l = sr.ReadLine()) != null)
        {
            lines.Add(l);
        }

        Console.WriteLine(lines[1]);
    }
}