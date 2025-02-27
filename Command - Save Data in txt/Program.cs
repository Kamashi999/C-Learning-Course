using Microsoft.VisualBasic;
//sposób dodawania danych to plików .txt synchroniczny
string fileName = "myfile.txt";

//string path = @"files/" + fileName;

string path = Path.Combine(@"files\", fileName);

using (StreamWriter sw = new(path, true))
{
    sw.Write("Date: ");
    sw.Write(DateTime.Now);
    sw.Close();
}

//sposób dodawania danych to plików .txt asynchroniczny

static async void WriteToFile(string msg)
{
    string fileName = "myfileASync.txt";
    string path = Path.Combine(@"files\", fileName);
    using(StreamWriter sw = new StreamWriter(path))
    {
        await sw.WriteLineAsync(msg);
        sw.Close();
    }
}

WriteToFile("Async Text");