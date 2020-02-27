namespace PointInRectangle
{  
    public class Rectangle
    {      
        public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
        {
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
            this.BottomRightX = bottomRightX;
            this.BottomRightY = bottomRightY;
        }

        public int TopLeftX { get; set; }

        public int TopLeftY { get; set; }

        public int BottomRightX { get; set; }

        public int BottomRightY { get; set; }

        public bool Contains(Point point) 
        {
            var xIsInHorizontal = point.X >= this.TopLeftX && point.X <= this.BottomRightX;
            var yIsInVertical = this.BottomRightY >= point.Y && point.Y >= this.TopLeftY;
            
            return xIsInHorizontal && yIsInVertical;
        }
    }
}