
namespace DrawApp.DO
{
    public class Circle : DrawObj
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

        public int Radius { get; set; }

        public Circle(int x, int y, int r)
        {
            X = x;
            Y = y;
            Radius = r;
        }
        public Circle(int x, int y, int r, Color fore)
            : this(x, y, r)
        {
            base.ForeColor = fore;
        }
        public override void Paint(Graphics gdc)
        {
            gdc.DrawEllipse(new Pen(Adapter(base.ForeColor), 1.0F)
                              ,X, Y, 2*Radius, 2*Radius);
        }

        public override void MoveXY(int dx, int dy)
        {
            X += dx; Y += dy;
        }
    }

    public class Elipse : Circle
    {
        public int RadiusY { get; set; }

        public Elipse(int x, int y, int rx, int ry)
            : base(x, y, rx)
        {
            RadiusY = ry;
        }
        public Elipse(int x, int y, int rx, int ry, Color fore)
            : this(x, y, rx, ry)
        {
            base.ForeColor = fore;
        }
        public override void Paint(Graphics gdc)
        {
            gdc.DrawEllipse(new Pen(Adapter(base.ForeColor), 1.0F)
                              , X, Y, 2 * Radius, 2 * RadiusY);
        }

    }
}
