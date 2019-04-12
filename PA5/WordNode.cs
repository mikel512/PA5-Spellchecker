﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA5
{
    class WordNode
    {
        // Fields
        private string _word;
        private int _editDistance;

        // Constructors
        public WordNode(string word, int distance)
        {
            _word = word;
            _editDistance = distance;
        }
        
        // Properties
        public string Word
        {
            get { return _word; }
            set { _word = value; }
        }
         
        public int EditDistance
        {
            get { return _editDistance; }
            set
            {
                if(value >= -1)
                {
                    _editDistance = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }


    }
}