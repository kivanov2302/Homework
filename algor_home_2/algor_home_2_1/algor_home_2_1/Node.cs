﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algor_home_2_1
{
    public class Node
    {
        public int Value { get; set; }
        public Node PrevNode { get; set; }
        public Node NextNode { get; set; }
        public Node(int value)
        {
            Value = value;
        }
        public Node()
        {
        }
    }

}
