using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _8.Threeuple
{
    public class Tuple<T,K,S>
    {
        private T item1;
        private K item2;
        private S item3;

        public Tuple(T item1,K item2, S item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public override string ToString()
        {
            return $"{item1} -> {item2} -> {item3}";
        }
    }
}
