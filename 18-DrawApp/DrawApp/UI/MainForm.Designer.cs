namespace DrawApp.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStripContainer1 = new ToolStripContainer();
            pDrawContext = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            edX = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            edY = new ToolStripTextBox();
            toolStripLabel3 = new ToolStripLabel();
            edW = new ToolStripTextBox();
            toolStripLabel4 = new ToolStripLabel();
            edH = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            btnSquare = new ToolStripButton();
            btnRect = new ToolStripButton();
            btnCircle = new ToolStripButton();
            btnElipse = new ToolStripButton();
            gridProperties = new PropertyGrid();
            splitter1 = new Splitter();
            toolStripSeparator3 = new ToolStripSeparator();
            edDX = new ToolStripTextBox();
            toolStripLabel5 = new ToolStripLabel();
            edDY = new ToolStripTextBox();
            _dx = new ToolStripLabel();
            btnMove = new ToolStripButton();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(pDrawContext);
            toolStripContainer1.ContentPanel.Size = new Size(823, 637);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(823, 664);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // pDrawContext
            // 
            pDrawContext.BackColor = Color.White;
            pDrawContext.Dock = DockStyle.Fill;
            pDrawContext.Location = new Point(0, 0);
            pDrawContext.Name = "pDrawContext";
            pDrawContext.Size = new Size(823, 637);
            pDrawContext.TabIndex = 0;
            pDrawContext.Paint += pDrawContext_Paint;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripSeparator1, toolStripLabel1, edX, toolStripLabel2, edY, toolStripLabel3, edW, toolStripLabel4, edH, toolStripSeparator2, btnSquare, btnRect, btnCircle, btnElipse, toolStripSeparator3, _dx, edDX, toolStripLabel5, edDY, btnMove });
            toolStrip1.Location = new Point(4, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(819, 27);
            toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 24);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(21, 24);
            toolStripLabel1.Text = "X:";
            // 
            // edX
            // 
            edX.Name = "edX";
            edX.Size = new Size(50, 27);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(20, 24);
            toolStripLabel2.Text = "Y:";
            // 
            // edY
            // 
            edY.Name = "edY";
            edY.Size = new Size(50, 27);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(39, 24);
            toolStripLabel3.Text = "W|R:";
            // 
            // edW
            // 
            edW.Name = "edW";
            edW.Size = new Size(50, 27);
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(44, 24);
            toolStripLabel4.Text = "H|RY:";
            // 
            // edH
            // 
            edH.Name = "edH";
            edH.Size = new Size(50, 27);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnSquare
            // 
            btnSquare.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSquare.Image = (Image)resources.GetObject("btnSquare.Image");
            btnSquare.ImageTransparentColor = Color.Magenta;
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(29, 24);
            btnSquare.Text = "toolStripButton5";
            btnSquare.Click += btnDrawObjsInsert_Click;
            // 
            // btnRect
            // 
            btnRect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRect.Image = (Image)resources.GetObject("btnRect.Image");
            btnRect.ImageTransparentColor = Color.Magenta;
            btnRect.Name = "btnRect";
            btnRect.Size = new Size(29, 24);
            btnRect.Text = "toolStripButton5";
            btnRect.Click += btnDrawObjsInsert_Click;
            // 
            // btnCircle
            // 
            btnCircle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.ImageTransparentColor = Color.Magenta;
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(29, 24);
            btnCircle.Text = "toolStripButton5";
            btnCircle.Click += btnDrawObjsInsert_Click;
            // 
            // btnElipse
            // 
            btnElipse.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnElipse.Image = (Image)resources.GetObject("btnElipse.Image");
            btnElipse.ImageTransparentColor = Color.Magenta;
            btnElipse.Name = "btnElipse";
            btnElipse.Size = new Size(29, 24);
            btnElipse.Text = "toolStripButton5";
            btnElipse.Click += btnDrawObjsInsert_Click;
            // 
            // gridProperties
            // 
            gridProperties.Dock = DockStyle.Right;
            gridProperties.Location = new Point(827, 0);
            gridProperties.Name = "gridProperties";
            gridProperties.Size = new Size(219, 664);
            gridProperties.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Right;
            splitter1.Location = new Point(823, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 664);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // edDX
            // 
            edDX.Name = "edDX";
            edDX.Size = new Size(50, 27);
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(31, 24);
            toolStripLabel5.Text = "DY:";
            // 
            // edDY
            // 
            edDY.Name = "edDY";
            edDY.Size = new Size(50, 27);
            // 
            // _dx
            // 
            _dx.Name = "_dx";
            _dx.Size = new Size(32, 24);
            _dx.Text = "DX:";
            // 
            // btnMove
            // 
            btnMove.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMove.Image = (Image)resources.GetObject("btnMove.Image");
            btnMove.ImageTransparentColor = Color.Magenta;
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(29, 24);
            btnMove.Text = "toolStripButton5";
            btnMove.Click += btnMove_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 664);
            Controls.Add(toolStripContainer1);
            Controls.Add(splitter1);
            Controls.Add(gridProperties);
            Name = "MainForm";
            Text = "DrawApp 0.1 alpha";
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private Panel pDrawContext;
        private ToolStripButton toolStripButton1;
        private PropertyGrid gridProperties;
        private Splitter splitter1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox edX;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox edY;
        private ToolStripLabel toolStripLabel3;
        private ToolStripTextBox edW;
        private ToolStripLabel toolStripLabel4;
        private ToolStripTextBox edH;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnSquare;
        private ToolStripButton btnRect;
        private ToolStripButton btnCircle;
        private ToolStripButton btnElipse;
        private ToolStripLabel _dx;
        private ToolStripTextBox edDX;
        private ToolStripLabel toolStripLabel5;
        private ToolStripTextBox edDY;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnMove;
    }
}