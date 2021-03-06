using System;
using System.Collections.Generic;

namespace Esece.Collections
{
    public class TupleList<T1, T2, T3, T4> : List<Tuple<T1, T2, T3, T4>>
    {
        public void Add(T1 a, T2 b, T3 c, T4 d)
        {
            Add(Tuple.Create(a, b, c, d));
        }

        public void Add(T1 a, T2 b, T3 c)
        {
            Add(Tuple.Create(a, b, c, default(T4)));
        }

        public void Add(T1 a, T2 b)
        {
            Add(Tuple.Create(a, b, default(T3), default(T4)));
        }

        public void Add(T1 a)
        {
            Add(Tuple.Create(a, default(T2), default(T3), default(T4)));
        }
    }
}
