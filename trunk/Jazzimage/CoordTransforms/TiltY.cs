﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jazzimage
{
    class TiltY : TransformParent
    {
        double _amount;

        public TiltY()
        {
            _amount = RandomNumberProvider.GetRandDouble();
        }

        public override PointColor Transform(PointColor input)
        {
            input.Y = input.Y + (input.X * _amount);

            return input;
        }
    }
}
