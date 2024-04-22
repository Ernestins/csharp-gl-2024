using DrawApp.DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            drawObjs = new List<DO.DrawObj>();
            DrawObj.CallBack = checkDirty;
        }

        private void checkDirty()
        {
            this.Text = "DrawApp 0.1 alpha";
            if (DrawObj.Dirty)
                this.Text += "*";
        }

        private List<DO.DrawObj> drawObjs;

        private void pDrawContext_Paint(object sender, PaintEventArgs e)
        {
            var gdi = e.Graphics;

            foreach (var i in drawObjs)
                i.Paint(gdi);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var r = new DO.Rectangle(100, 80, 300, 100);
            drawObjs.Add(r);
            gridProperties.SelectedObject = r;
            pDrawContext.Invalidate();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var r = new DO.Square(100, 80, 80);
            drawObjs.Add(r);
            gridProperties.SelectedObject = r;
            pDrawContext.Invalidate();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var r = new DO.Circle(100, 80, 80);
            drawObjs.Add(r);
            gridProperties.SelectedObject = r;
            pDrawContext.Invalidate();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var r = new DO.Elipse(100, 80, 300, 100);
            drawObjs.Add(r);
            gridProperties.SelectedObject = r;
            pDrawContext.Invalidate();
        }

        private void btnDrawObjsInsert_Click(object sender, EventArgs e)
        {
            var x = Int32.Parse(edX.Text);
            var y = Int32.Parse(edY.Text);
            var w = Int32.Parse(edW.Text);
            var h = Int32.Parse(edH.Text);

            DO.DrawObj d;

            if (sender == btnSquare)
                d = new DO.Square(x, y, w);
            else if (sender == btnRect)
                d = new DO.Rectangle(x, y, w, h);
            else if (sender == btnCircle)
                d = new DO.Circle(x, y, w);
            else if (sender == btnElipse)
                d = new DO.Elipse(x, y, w, h);
            else
                return;
            drawObjs.Add(d);
            gridProperties.SelectedObject = d;
            pDrawContext.Invalidate();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            var dx = Int32.Parse(edDX.Text);
            var dy = Int32.Parse(edDY.Text);

            foreach (var d in drawObjs)
            {
                d.Unpaint(pDrawContext.CreateGraphics());
                d.MoveXY(dx, dy);
                d.Paint(pDrawContext.CreateGraphics());
            }
                
        }
    }
}
