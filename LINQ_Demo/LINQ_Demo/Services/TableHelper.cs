using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo.Services;

public class TableHelper
{
    public void Print<T>(string label, IEnumerable<T> data)
    {
        Console.WriteLine($"\n[{label}]");
        var props = typeof(T).GetProperties();
        foreach (var pr in props) Console.Write($"{pr.Name,-20} | ");
        Console.WriteLine("\n" + new string('-', props.Length * 23));
        foreach (var row in data)
        {
            foreach (var pr in props) Console.Write($"{pr.GetValue(row),-20} | ");
            Console.WriteLine();
        }
    }
}
