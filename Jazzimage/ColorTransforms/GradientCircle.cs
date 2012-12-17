﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace Jazzimage
{
	class GradientCircle : TransformParent
	{
		int _alpha;
		Gradient _gradient;
		double _originX;
		double _originY;

		public GradientCircle()
		{
			_alpha = RandomNumberProvider.GetInt(256);
			_gradient = new Gradient();
			_originX = RandomNumberProvider.GetDouble();
			_originY = RandomNumberProvider.GetDouble();
		}

		public override PointColor Transform(PointColor input)
		{
			double inX = input.X - 0.5;
			double inY = input.Y - 0.5;

			inX = inX % 1.0;
			inY = inY % 1.0;

			double dist = Math.Sqrt(Math.Pow(inX - _originX, 2.0) + Math.Pow(inY - _originY, 2.0));

			dist = dist % 1.0;

			Color outColor = _gradient.GetColorAtValue(dist);

			input.Color = Color.FromArgb(_alpha, outColor.R, outColor.G, outColor.B);

			return input;
		}
	}
}