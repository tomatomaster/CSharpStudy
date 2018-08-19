using System;

public interface IQ<T>
{
    void Put(T obj);

    T Get();
}

class QueueFullException : ApplicationException
{
    public QueueFullException() : base() { }
    public QueueFullException(string str) : base(str) { }

    public override string ToString()
    {
        return "\n" + Message;
    }
}

class SimpleQueue<T> : IQ<T>
{

    T[] q;
    int putloc, getloc;

    public SimpleQueue(int size)
    {
        q = new T[size + 1];
        putloc = getloc = 0;
    }
    public T Get()
    {
        if (getloc == putloc)
            throw new NotImplementedException();

        getloc++;
        return q[getloc];
    }

    public void Put(T obj)
    {
        if (putloc == q.Length - 1)
            throw new QueueFullException();

        putloc++;
        q[putloc] = obj;
    }
}