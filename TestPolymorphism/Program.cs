//class Program
//{
//    static void Main(string[] args)
//    {
//        TestOverload4 to = new TestOverload4();
//        to.DisplayOverload(100);
//        to.DisplayOverload("aaa");
//        to.DisplayOverload("bbb", 2);
//        Console.ReadKey();
//    }
//}

class Program
{
    static void Main(string[] args)
    {
        TestOverload to = new TestOverload();
        to.DisplayOverload();
        int i = to.DisplayOverload();
        Console.ReadKey();
    }
}