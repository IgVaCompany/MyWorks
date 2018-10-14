using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
            // так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
            //return (Math.Abs(r1.Top)<Math.Abs(r2.Bottom) || Math.Abs(r1.Bottom)>Math.Abs(r2.Top) || Math.Abs(r1.Right)<Math.Abs(r2.Left) || Math.Abs(r1.Left)>Math.Abs(r2.Right));
            //if ((r1.Top < r2.Bottom || r1.Bottom < r2.Top || r1.Right < r2.Left || r1.Left > r2.Right) && (r1.Width!=0 && r1.Height!=0 && r2.Width!=0 && r2.Height!=0))
            //    return true;
            //else if (r2.Top == r1.Bottom && r2.Left == r1.Right || r1.Top == r2.Bottom && r1.Left == r2.Right)
            //    return true;
            //else
            //{
            //    return false;
            //}

            if (((((r1.Left >= r2.Left) && (r1.Left <= r2.Right))
                || ((r1.Right >= r2.Left) && (r1.Right <= r2.Right))))
                && (((r1.Top >= r2.Top) && (r1.Top <= r2.Bottom))
                || ((r1.Bottom >= r2.Top) && (r1.Bottom <= r2.Bottom))
                || ((r1.Top <= r2.Top) && (r1.Bottom >= r2.Bottom))))
                return true;

            if (((((r2.Left >= r1.Left) && (r2.Left <= r1.Right))
                || ((r2.Right >= r1.Left) && (r2.Right <= r1.Right))))
                && (((r2.Top >= r1.Top) && (r2.Top <= r1.Bottom))
                || ((r2.Bottom >= r1.Top) && (r2.Bottom <= r1.Bottom))
                || ((r2.Top <= r1.Top) && (r2.Bottom >= r1.Bottom))))
                return true;

            return false;
        }

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
		    if (AreIntersected(r1, r2) && IndexOfInnerRectangle(r1, r2) == -1)
		    {
                //int heightSum = r1.Height + r2.Height;
                //int distBetweenTopDown = r2.Top - r1.Top;
                //int heightNew = heightSum - distBetweenTopDown;

                //int withSum = r1.Width + r2.Width;
                //int distBetweenLeftRight = r2.Right - r1.Left;
                //int withNew = withSum - distBetweenLeftRight;

                //return heightNew * withNew;

		        int withNew = (Math.Max(r1.Left, r2.Left) - Math.Min(r1.Right, r2.Right));
                int heightNew = (Math.Max(r1.Top,r2.Top) - Math.Min(r1.Bottom,r2.Bottom));

		        return heightNew * withNew;

		    }
		    else if (AreIntersected(r1, r2) && IndexOfInnerRectangle(r1, r2) == 0)
		    {
		        return r1.Width*r1.Height;
		    }
            else if (AreIntersected(r1, r2) && IndexOfInnerRectangle(r1, r2) == 1)
            {
                return r2.Width*r2.Height;
            }
		    else
		    {
                return 0;
            }
			
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
		    if (r1.Left <= r2.Left && r1.Top <= r2.Top && r1.Bottom >= r2.Bottom && r1.Right >= r2.Right)
		        return 1;
            else if (r1.Left >= r2.Left && r1.Top >= r2.Top && r1.Bottom <= r2.Bottom && r1.Right <= r2.Right)
                return 0;
            else
            {
                return -1;
            }
        }
	}
}