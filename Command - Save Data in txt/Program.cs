using Microsoft.VisualBasic;
//sposób dodawania danych to plików .txt synchroniczny
string fileName = "myfile.txt"; // Nazwa pliku, do którego zapisujemy dane

//string path = @"files/" + fileName;

string path = Path.Combine(@"files\", fileName); // tworzy ścieżkę do pliku.

using (StreamWriter sw = new(path, true)) // Otwiera plik w trybie dopisywania (append mode)
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
    using(StreamWriter sw = new StreamWriter(path)) // Otwiera plik w trybie zapisu
    {
        await sw.WriteLineAsync(msg); // Asynchronicznie zapisuje tekst do pliku
        sw.Close();
    }
}

WriteToFile("Async Text");