﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }

    }
}
