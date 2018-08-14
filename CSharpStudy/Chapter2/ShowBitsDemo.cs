using System;

class ShowBits
{
    public int numbits;
    public ShowBits(int n)
    {
        numbits = n;
    }

    public void Show(ulong val)
    {
        ulong mask = 1;

        mask <<= numbits - 1;
        int spacer = 0;
        for (; mask != 0; mask >>= 1)
        {
            if ((val & mask) != 0)
                Console.Write("1");
            else
                Console.Write("0");
            spacer++;
            if ((spacer % 8) == 0)
            {
                Console.Write(" ");
                spacer = 0;
            }
        }
        Console.WriteLine();
    }

    class ShowBitsDemo
    {
        static void Main()
        {
            ShowBits b = new ShowBits(1024);
            b.Show(134252542422432425);
        }
    }
}