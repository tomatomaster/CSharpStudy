using System;

delegate string StrMod(string str);

class DelegateTest
{
    static string ReplaceSpaces(string a)
    {
        Console.WriteLine("Replaces Space with hyphens. ");
        return a.Replace(' ', '-');
    }

    static string RemoveSpace(string a)
    {
        string temp = "";
        int i;

        for (i = 0; i < a.Length; i++)
            if (a[i] != ' ') temp += a[i];

        return temp;
    }

    static void Main()
    {
        StrMod strOp = ReplaceSpaces;
        string str;
        str = strOp("This is a test.");
        Console.WriteLine(str);

        strOp = RemoveSpace;
        str = strOp("This is a test.");
        Console.WriteLine(str);
    }
}