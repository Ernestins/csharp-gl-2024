using System.Runtime.CompilerServices;

namespace DrawApp.DO
{
    public delegate void Notify();

    public enum Color : Byte { White, Black };

    public abstract class DrawObj
    {
        public static Notify? CallBack { get; set; } = null; // better to use event but we use delegate

        private static bool dirty;

        public static bool Dirty
        {
            get { return dirty; }
            set { dirty = value; CallBack?.Invoke(); }
        }


        public Color ForeColor { get; set; } = Color.Black;
        public Color BackColor { get; set; } = Color.White;


        public System.Drawing.Color Adapter(DO.Color c)
            => c switch
            {
                Color.White => System.Drawing.Color.White,
                Color.Black => System.Drawing.Color.Black,
                _ => throw new NotImplementedException(),
            };


        public abstract void Paint(Graphics gdc);
        public          void Unpaint(Graphics gdc)
        {
            var tmp = ForeColor;
            try
            {
                ForeColor = BackColor;
                this.Paint(gdc);
            } finally {
                ForeColor = tmp;
            }
        }

        public abstract void MoveXY(int dx, int dy);

    }
}



