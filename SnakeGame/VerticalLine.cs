﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// marking of line is symbol '*'
// construct new vertical line
namespace SnakeGame {
    class VerticalLine : Figure {
        public VerticalLine(int x, int y, int length) {
            for (int i = 0; i < length; i++) {
                Obj.Add(new Point(x, y + i, '*'));
            }
        }
    } 
}