using System;

delegate void StrMod(ref string str);

class StringOps
{
    static void ReplacesSpaces(ref string a)
    {
        a = a.Replace(' ', '-');
    }

    static void Reverse(ref string a)
    {
        string temp = "";
        int i, j;

        for (j = 0, i = a.Length - 1; i >= 0; i--, j++)
        {
            temp += a[i];
        }

        a = temp;
    }

    static void Main()
    {
        StrMod strOp;
        strOp = ReplacesSpaces;
        strOp += Reverse;
        var str = "This is a test";
        Console.WriteLine(str);
        strOp(ref str);
        Console.WriteLine(str);
    }
}

