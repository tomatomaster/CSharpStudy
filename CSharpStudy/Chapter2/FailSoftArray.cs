using System;

class FailSoftArray
{
    int[] a;
    public int Length;
    public bool ErrFlag;

    public FailSoftArray(int size)
    {
        a = new int[size];
        Length = size;
    }

    public int this[int index]
    {
        get
        {
            if (ok(index))
            {
                ErrFlag = false;
                return a[index];
            }
            else
                ErrFlag = true;
            return -1;
        }

        set
        {
            if (ok(index))
            {
                a[index] = value;
                ErrFlag = false;
            }
            else ErrFlag = true;
        }
    }

    private bool ok(int index)
    {
        if (index >= 0 & index < Length) return true;
        else return false;
    }

    class ImprovedFSDemo
    {
        static void Main()
        {
            FailSoftArray fs = new FailSoftArray(5);
            int x;

            for (int i = 0; i < (fs.Length * 2); i++)
            {
                fs[i] = i * 10;
            }
            for (int i = 0; i < (fs.Length * 2); i++)
            {
                x = fs[i];
                if (x != 1) Console.WriteLine(x + " ");
            }
            Console.WriteLine();

            Console.WriteLine("ShowError");
            for (int i = 0; i < (fs.Length * 2); i++)
            {
                fs[i] = i * 10;
                if (fs.ErrFlag)
                    Console.WriteLine("fs[{0}] out-of-bounds", i);
            }
            for (int i = 0; i < (fs.Length * 2); i++)
            {
                x = fs[i];
                if (x != 1) Console.WriteLine(x + " ");
                if (fs.ErrFlag)
                    Console.WriteLine("fs[{0}] out-of-bounds", i);
            }
        }
    }
}