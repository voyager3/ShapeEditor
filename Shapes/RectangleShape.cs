﻿using System.Drawing;

namespace Shapes
{
    public class RectangleShape : IShape
    {
        private readonly Point upperLeftCorner_;
        private readonly PenBillet billet_;
        private readonly int width_;
        private readonly int height_;

        public RectangleShape(Point upperLeftCorner, Point lowerRightCorner, PenBillet billet)
        {
            upperLeftCorner_ = upperLeftCorner;
            billet_ = billet;
            width_ = lowerRightCorner.X - upperLeftCorner.X;
            height_ = lowerRightCorner.Y - upperLeftCorner.Y;
        }

        public void Draw(Graphics graphics)
        {
            using (var pen = billet_.CreatePen())
            {
                graphics.DrawRectangle(pen, upperLeftCorner_.X, upperLeftCorner_.Y, width_, height_);
            }
        }   
    }
}
