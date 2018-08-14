using System;

class Mars
{
    static void Main()
    {
        double distance;
        double lightspeed;
        double delay;
        double delay_in_min;

        distance = 340000000;
        lightspeed = 186000;

        delay = distance / lightspeed;

        Console.WriteLine("Time delay when talking to Mars: " + delay + " seconds.");

        delay_in_min = delay / 60;
        Console.WriteLine("This is " + delay_in_min + " minutes");
    }
}