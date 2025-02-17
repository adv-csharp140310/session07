using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session06.Generics;
public class MyStackInt
{
    List<int> values = new List<int>();

    public void Push(int value)
    {
        values.Add(value);
    }

    public int Pop()
    {
        var value = values[values.Count - 1];
        values.RemoveAt(values.Count - 1);
        return value;
    }
}


public class MyStackString
{
    List<string> values = new List<string>();

    public void Push(string value)
    {
        values.Add(value);
    }

    public string Pop()
    {
        var value = values[values.Count - 1];
        values.RemoveAt(values.Count - 1);
        return value;
    }
}


public class MyStackGenric<T>
{
    List<T> values = new List<T>();

    public void Push(T value)
    {
        values.Add(value);
    }

    public T Pop()
    {
        var value = values[values.Count - 1];
        values.RemoveAt(values.Count - 1);
        return value;
    }

}