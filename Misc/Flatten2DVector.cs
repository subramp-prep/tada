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

        private IList<IList<int>> _vec2d;
        private int _x;
        private int _y;
        private int _elementCount;

        public Vector2D(IList<IList<int>> vec2d)
        {
            _vec2d = vec2d;
            _x = 0;
            _y = 0;

            foreach (var x in vec2d)
            {
                for (int i = 0; i < x.Count; i++)
                {
                    _elementCount++;
                }
            }
        }


        public bool HasNext()
        {
            return _elementCount-- > 0;
        }

        public int Next()
        {
            int element = 0;
            if (_y < _vec2d[_x].Count)
            {
                element = _vec2d[_x][_y++];
            }
            else
            {
                _y = 0; // reset
                _x++;

                if (_x < _vec2d.Count)
                {
                    element = _vec2d[_x][_y++];
                }
            }

            return element;
        }
    }
}