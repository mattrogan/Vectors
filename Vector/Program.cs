using System;

namespace VectorNS
{

    public class Vector
    {

        protected float[] _vector;

        public Vector(float[] dims)
        {
            _vector = dims;
        }

        public Vector()
        {
            _vector = new float[2];
        }

        public void Set(int index, float value)
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

        public float Get(int index)
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

        public Vector ScalarProduct(float scalar)
        {
            float[] dims = (float[])_vector.Clone();
            for (int i = 0; i < Size(); i++)
            {
                dims[i] *= scalar;
            }
            return new Vector(dims);
        }

        public override string ToString()
        {
            return "<" + String.Join(", ", _vector) + ">";
        }

        public override bool Equals(object? obj)
        {
            // Check other object is a Vector
            if (typeof(Vector).IsInstanceOfType(obj))
            {
                Vector other = (Vector)obj;

                // Check other object has same dimensions
                if (this.Size() == other.Size())
                {
                    for (int i = 0; i < Size(); i++)
                    {
                        if (this.Get(i) != other.Get(i))
                        {
                            // Non-matching dimensions
                            return false;
                        }
                    }
                    // All dimensions have the same value
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int Size()
        {
            return _vector.Length;
        }

        public Vector Add(object? obj)
        {
            if (typeof(Vector).IsInstanceOfType(obj))
            {
                Vector other = (Vector)obj;
                if (this.Size() == other.Size())
                {
                    float[] dims = new float[Size()];
                    for (int i = 0; i < Size(); i++)
                    {
                        dims[i] = this.Get(i) + other.Get(i);
                    }
                    return new(dims);
                }
                else
                {
                    throw new InvalidDataException("dimensions must be equal");
                }
            }
            else
            {
                throw new ArgumentException("can only add vectors to other vectors");
            }
        }

        public static void Main()
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