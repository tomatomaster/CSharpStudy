using System;

class Rectangle
{

    int side1;
    int side2;

    public Rectangle(int i, int j)
    {
        side1 = i;
        side2 = j;
    }

    public int RectInfo(out bool isSquare)
    {
        if (side1 == side2) isSquare = true;
        else isSquare = false;
        return side1 * side2;
    }

    class OutDemo
    {
        static void Main()
        {
            Rectangle rect = new Rectangle(10, 10);
            bool result;
            var result2 = rect.RectInfo(out result);
            Console.Write("{0} {1}", result, result2);
        }
    }
}