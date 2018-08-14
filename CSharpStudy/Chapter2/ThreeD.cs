using System;
class ThreeD
{
    int x, y, z;
    public ThreeD() { x = y = z = 0; }
    public ThreeD(int i, int j, int k) { x = i; y = j; z = k; }
    public static ThreeD operator +(ThreeD op1, ThreeD op2)
    {
        ThreeD result = new ThreeD();
        result.x = op1.x + op2.x;
        result.y = op1.y + op2.y;
        result.z = op1.z + op2.z;
        return result;
    }

    public static bool operator ==(ThreeD op1, ThreeD op2)
    {
        return true;
    }

    public static bool operator !=(ThreeD op1, ThreeD op2)
    {
        return true;
    }

    public void Show()
    {
        Console.WriteLine("{0} {1} {2}", x, y, z);
    }

    static void Main()
    {
        ThreeD a = new ThreeD(1, 2, 3);
        ThreeD b = new ThreeD(10, 20, 30);
        var c = a + b;
        c.Show();
    }

}