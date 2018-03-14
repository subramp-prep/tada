using System;
using System.Collections.Generic;

namespace Misc
{
    public class Vector2D
    {
        //Implement an iterator to flatten a 2d vector.
        //For example,
        //Given 2d vector =

        //[
        //  [1,2],
        //  [3],
        //  [4,5,6]
        //]
        //By calling next repeatedly until hasNext returns false, 
        //the order of elements returned by next should be: [1,2,3,4,5,6].

        //Follow up:
        //As an added challenge, try to code it using only 
        //iterators in C++ or iterators in Java.

        /**
         * Your Vector2D will be called like this:
         * Vector2D i = new Vector2D(vec2d);
         * while (i.HasNext()) v[f()] = i.Next();
         */

        IList<IList<int>> _vec2d;
        int _x;
        int _y;

        public Vector2D(IList<IList<int>> vec2d)
        {
            _vec2d = vec2d;
            _x = 0;
            _y = 0;

            Console.WriteLine(_vec2d.Count);
            Console.WriteLine(_vec2d[_x].Count);
        }

        public bool HasNext()
        {
            return _x <= _vec2d.Count &&
                   _y <= _vec2d[_x].Count;
        }

        public int Next()
        {
            //foreach (var elem in _vec2d)
            //{
            //    foreach (var e in elem)
            //    {

            //    }
            //}

            int element = 0;
            for (; _x < _vec2d.Count; _x++)
            {
                for (; _y < _vec2d[_x].Count; _y++)
                {
                    element = _vec2d[_x][_y];
                    break;
                }
                break;
            }

            return element;
        }
    }
}
