using System;

namespace VectorNS
{

    class Vector
    {

        protected float[] _vector;

        Vector(float[] dims)
        {
            _vector = dims;
        }

        Vector()
        {
            _vector = new float[2];
        }

        void Set(int index, float value)
        {
            if (index >= Size())
            {
                throw new IndexOutOfRangeException("invalid vector dimension");
            }
            else
            {
                _vector[index] = value;
            }
        }

        float Get(int index)
        {
            if (index >= Size())
            {
                throw new IndexOutOfRangeException("invalid vector dimension");
            }
            else
            {
                return _vector[index];
            }
        }

        public override string ToString()
        {
            return "<" + String.Join(", ", _vector) + ">";
        }

        public int Size()
        {
            return _vector.Length;
        }

        static void Main()
        {
            float[] dims1 = { 3, 2 };
            float[] dims2 = { 1, -1 };
            Vector v1 = new(dims1);
            Vector v2 = new(dims2);
        }

    }

    /*class Vector3D : Vector
    {

    }*/


    
}