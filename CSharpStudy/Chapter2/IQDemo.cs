using System;

class SimpleQueue
{
    char[] q;
    int putloc, getloc;

    public SimpleQueue(int size)
    {
        q = new char[size + 1];
        putloc = getloc = 0;
    }

}