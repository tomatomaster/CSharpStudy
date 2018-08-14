using System;

class Hoge
{
    static void Main()
    {
        var test = new Hoge.Test(3);
        Change(test);
        Console.Write(test.a);
    }

    static void Change(Test t)
    {
        t.a = 100;
        t = new Test(3);
    }

    class Test
    {
        public int a;
        public Test(int a)
        {
            this.a = a;
        }
    }
}