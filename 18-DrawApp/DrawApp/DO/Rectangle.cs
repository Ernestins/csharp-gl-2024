namespace DrawApp.DO
{
    public class Rectangle : DrawObj
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; Dirty = true; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; Dirty = true; }
        }


        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int w, int h)  
        {
            X = x;
            Y = y;
            Width = w;
            Height = h;
        }
        public Rectangle(int x, int y, int w, int h, Color fore)
            : this(x, y, w, h)
        {
            base.ForeColor = fore;
        }


        public override void Paint(Graphics gdc)
        {
            gdc.DrawRectangle(new Pen(Adapter(base.ForeColor), 1.0F)
                              , X, Y, Width, Height);
        }

        public override void MoveXY(int dx, int dy)
        {
            X += dx; Y += dy;
        }
    }
    public class Square : Rectangle
    {
        public Square(int x, int y, int a)
          : base(x, y, a, a) { }
        public Square(int x, int y, int a, Color fore)
          : base(x, y, a, a, fore) { }
    }


}
