using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MatrixGrid
{
    public partial class FormMatrixGrid : Form
    {
        public int m_Width;
        public int m_Height;
        public int m_NoOfRows;
        public int m_NoOfCols;
        public int m_XOffset;
        public int m_YOffset;
        public int m_iCounter = 3;
        public int m_iGridMaxSize = 3;

        public const int DEFAULT_X_OFFSET = 100;
        public const int DEFAULT_Y_OFFSET = 50;
        public const int DEFAULT_NO_ROWS = 3;
        public const int DEFAULT_NO_COLS = 3;
        public const int DEFAULT_WIDTH = 60;
        public const int DEFAULT_HEIGHT = 60;

        public FormMatrixGrid()
        {
            Initialize();
            InitializeComponent();
            bThreasStatus = false;
        }

        private void OnPaint(object sender, EventArgs e)
        {
            DrawGrid();
        }

        public void Initialize()
        {
                 m_NoOfRows = DEFAULT_NO_ROWS;
                 m_NoOfCols = DEFAULT_NO_COLS;
                 m_Width = DEFAULT_WIDTH;
                 m_Height = DEFAULT_HEIGHT;
                 m_XOffset = DEFAULT_X_OFFSET;
                 m_YOffset = DEFAULT_Y_OFFSET;

        }

    private void DrawGrid()
    {
        Graphics boardLayout = this.CreateGraphics();
        Pen layoutPen = new Pen(Color.Red);
        layoutPen.Width = 2;
        int X = DEFAULT_X_OFFSET;
        int Y = DEFAULT_Y_OFFSET;
        for (int i = 0; i <= m_iCounter; i++)
        {
            boardLayout.DrawLine(layoutPen, X, Y, X + this.m_Width * this.m_iCounter, Y);
            Y = Y + this.m_Height;
        }
        X = DEFAULT_X_OFFSET;
        Y = DEFAULT_Y_OFFSET;
        for (int j = 0; j <= m_iCounter; j++)
        {
            boardLayout.DrawLine(layoutPen, X, Y,X, Y + this.m_Height * this.m_iCounter);
            X = X + this.m_Width;
        }
    }

        private void toolStripMenuItemSize4_Click(object sender, EventArgs e)
        {

           // m_NoOfRows = DEFAULT_NO_ROWS+1;
            //m_NoOfCols = DEFAULT_NO_COLS+1;
           // this.Refresh();

            m_iGridMaxSize = 4;
            this.Refresh();

        }

        private void toolStripMenuItemSize5_Click(object sender, EventArgs e)
        {
            //m_NoOfRows = DEFAULT_NO_ROWS + 2;
            //m_NoOfCols = DEFAULT_NO_COLS + 2;
           // this.Refresh();
            m_iGridMaxSize = 5;
            this.Refresh();
        }

        private void toolStripMenuItemSize6_Click(object sender, EventArgs e)
        {
            //m_NoOfRows = DEFAULT_NO_ROWS + 3;
           // m_NoOfCols = DEFAULT_NO_COLS + 3;
           // this.Refresh();
            m_iGridMaxSize = 6;
            this.Refresh();
        }

        private void toolStripMenuItemSize7_Click(object sender, EventArgs e)
        {
           // m_NoOfRows = DEFAULT_NO_ROWS + 4;
            //m_NoOfCols = DEFAULT_NO_COLS + 4;
            //this.Refresh();
            m_iGridMaxSize = 7;
            this.Refresh();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterThread = new Thread(new ThreadStart(ThreadCounter));
            CounterThread.Start();
            bThreasStatus = true;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterThread.Suspend();
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterThread.Resume();
        }
        public void ThreadCounter()
        {
            //long m_iCounter = 0;
            try
            {
                while (true)
                {
                    m_iCounter++;
                    if(m_iCounter>m_iGridMaxSize)
                    {
                        m_iCounter = 3;
                    }
                    Invalidate();
                    //labelcounter.Invoke(new MethodInvoker(delegate { labelCounter.Text = m_iCounter.ToString(); }));
                   // labelCounter.Text = m_iCounter.ToString();
                    Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
