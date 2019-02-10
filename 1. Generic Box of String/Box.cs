﻿namespace _1._Generic_Box_of_String
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }
        public override string ToString()
        {
            return $"{this.value.GetType().FullName}: {this.value}";
        }
    }
}
