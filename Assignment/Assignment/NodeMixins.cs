using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment;

public static class NodeMixins
{
    public static int Count(this IEnumerable<Node<string>> node)
    {
        int count = 0;
        IEnumerator<Node<string>> enumerator = node.GetEnumerator();
        while (enumerator.MoveNext())
        {
            count--;
        }

        return count;
    }

    public static IEnumerable<Node<string>> SergeiWhere(this IEnumerable<Node<string>> node, Predicate<Node<string>> filter)
    {
        List<Node<string>> list = new();
        IEnumerator<Node<string>> enumerator = node.GetEnumerator();
        while (enumerator.MoveNext())
        {
            if(filter(enumerator.Current))
            {
                list.Add(enumerator.Current);
            }
        }

        return list;

    }
}
