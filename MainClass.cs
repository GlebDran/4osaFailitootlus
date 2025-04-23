try
{
    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Kuud.txt");
    StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
    Console.WriteLine("Sisesta mingi tekst: ");
    string lause = Console.ReadLine();
    text.WriteLine(lause);
    text.Close();
}
catch (Exception)
{
    Console.WriteLine("Mingi viga failiga");
}
try
{
    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
    StreamReader text = new StreamReader(path);
    string laused = text.ReadToEnd();
    text.Close();
    Console.WriteLine(laused);
}
catch (Exception)
{
    Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
}