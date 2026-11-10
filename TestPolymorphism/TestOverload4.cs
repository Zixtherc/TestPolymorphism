//class TestOverload4
//{
//    public void DisplayOverload(int a) => Console.WriteLine("DisplayOverload " + a);
//    public void DisplayOverload(string a) => Console.WriteLine("DisplayOverload " + a);
//    public void DisplayOverload(string a, int b) => Console.WriteLine("DisplayOverload " + a + b);
//}

class TestOverload
{
    public void DisplayOverload() { Console.WriteLine("DisplayOverload void"); }
    public int DisplayOverload() { Console.WriteLine("DisplayOverload int"); return 0; }
}