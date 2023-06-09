﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class string_builders
    {
        private char[] _arr;
        private int _capacity = 16;
        private int _length = 0;
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < _length)
                {
                    throw new Exception($"Length must be more than {_length}");
                }
                if (value > _capacity && value <= 2 * _capacity)
                {
                    Capacity *= 2;
                }
                if (value > 2 * _capacity)
                {
                    Capacity = value;
                }
                _length = value;

            }
        }
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value cannot be less than zero");
                }
                if (value < Length)
                {
                    throw new Exception($"Capacity must be more than {Length}");
                }
                _capacity = value;
                Array.Resize(ref _arr, _capacity);
            }
        }
        public void CustomBuilder()
        {
            _arr = new char[_capacity];
        }
        public void Append(char ch)
        {
            if (Length == Capacity)
            {
                Capacity = Capacity * 2;
            }
            _arr[Length] = ch;
            Length++;
        }
        public void ReplaceChar(char oldchar, char newchar)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_arr[i] == oldchar)
                {
                    _arr[i] = newchar;
                }
            }
        }
        public char[] GetResult()
        {
            return _arr;
        }

    }
            
        }   

