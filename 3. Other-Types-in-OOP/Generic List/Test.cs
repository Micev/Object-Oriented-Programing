using System;
class Test
{
    public static void Main()
    {
        GenericList<int> List = new GenericList<int>();

        List.Add(0);
        List.Add(1);
        List.Add(2);
        List.Add(3);
        List.Add(4);
        List.Add(5);
        List.Add(6);
        List.Add(7);
        Console.WriteLine(List); // 0 1 2 3 4 5 6 7
        List.Remove(5);
        List.Remove(1);
        Console.WriteLine(List);// 0 2 3 4 6 7
        List.Insert(1, 1);
        List.Insert(5, 5);
        Console.WriteLine(List);//0 1 2 3 4 5 6 7
        Console.WriteLine(List.Find(5));//2
        Console.WriteLine(List.Contains(6));//True
        Console.WriteLine(List.Find(6));//6s
        Console.WriteLine(List.Min());//0
        Console.WriteLine(List.Max());//7

        object[] allAttributes = typeof(GenericList<int>).GetCustomAttributes(typeof(Version), false);
        Console.WriteLine("Version: " + allAttributes[0]);
    }
}

