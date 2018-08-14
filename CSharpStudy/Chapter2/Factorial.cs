using System;

public class Test
{

    static void Main()
    {

    }

    public class Factorial
    {
        public int Method(int i, int result)
        {
            result = i * result;
            if (i == 1) return result * 1;
            i = i - 1;
            return Method(i, result);
        }
    }
}