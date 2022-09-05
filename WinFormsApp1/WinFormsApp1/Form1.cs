using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap _bitmap;
        Graphics grafika;
        bool malu = false; // malu jak malowanie
        Point p1, p2;
        Pen pedzel = new Pen(Color.Plum);
        Pen gumka = new Pen(Color.White);
        int opcja;
        int x, y, sX, sY, cX, cY;
        Color nowyKolor = Color.Plum;
        ColorDialog cd = new ColorDialog();
        public Form1()
        {
            InitializeComponent();
            _bitmap = new Bitmap(obraz.Width, obraz.Height);
            grafika = Graphics.FromImage(_bitmap);
            grafika.Clear(BackColor);
            obraz.Image = _bitmap;
            pedzel.LineJoin = LineJoin.Round;
            pedzel.StartCap = pedzel.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pedzel.Width = gumka.Width = 10;
            gumka.LineJoin = LineJoin.Bevel;
            gumka.StartCap = gumka.EndCap = System.Drawing.Drawing2D.LineCap.Square;
        }

        private void btnPedzel_Click(object sender, EventArgs e)
        {
            opcja = 1;
        }

        private void btnLinia_Click(object sender, EventArgs e)
        {
            opcja = 5;
        }

        private void btnBlok_Click(object sender, EventArgs e)
        {
            opcja = 4;
        }

        private void btnObrecz_Click(object sender, EventArgs e)
        {
            opcja = 3;
        }

        private void btnGumka_Click(object sender, EventArgs e)
        {
            opcja = 2;
        }

        private void obraz_Paint(object sender, PaintEventArgs e)
        {
            Graphics temp = e.Graphics;
            if (malu)
            {
                if (opcja == 3)
                {
                    temp.DrawEllipse(pedzel, cX, cY, sX, sY);
                }
                else if (opcja == 4)
                {
                    temp.DrawRectangle(pedzel, cX, cY, sX, sY);
                }
                else if (opcja == 5)
                {
                    temp.DrawLine(pedzel, cX, cY, x, y);
                }
            }
        }

        private void obraz_Click(object sender, EventArgs e)
        {

        }

        private void btnFarba_Click(object sender, EventArgs e)
        {
            opcja = 6;
        }

        static Point _ustawPunkt(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Width / pb.Width;
            float pY = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color staryK, Color nowyK)
        {
            Color cX = bm.GetPixel(x, y);
            if(cX == staryK)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x , y, nowyK);
            }
        }

        private void obraz_MouseClick(object sender, MouseEventArgs e)
        {
            if(opcja == 6)
            {
                Point punkt = _ustawPunkt(obraz, e.Location);
                Wypelnij(_bitmap, punkt.X, punkt.Y, nowyKolor);
            }
        }

        private void btnKolor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            nowyKolor = cd.Color;
            obraz.BackColor = cd.Color;
            pedzel.Color = cd.Color;

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Malunek(*.jpg)|*.jpg|(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = _bitmap.Clone(new Rectangle(0,0, obraz.Width, obraz.Height), _bitmap.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void suwak_scroll(object sender, EventArgs e)
        {
            pedzel.Width = gumka.Width = suwak.Value;
        }

        public void Wypelnij(Bitmap bm, int x, int y, Color nowyK)
        {
            Color staryK = bm.GetPixel(x, y);
            Stack<Point> piksel = new Stack<Point>();
            piksel.Push(new Point(x, y));
            bm.SetPixel(x, y, nowyK);

            if(staryK == nowyK) { return; }

            while (piksel.Count > 0) 
            { 
                Point p = piksel.Pop();
                if(p.X > 0 && p.Y > 0 && p.X < bm.Width-1 && p.Y < bm.Height-1)
                {
                    Validate(bm, piksel, p.X - 1, p.Y, staryK, nowyK);
                    Validate(bm, piksel, p.X, p.Y - 1, staryK, nowyK);
                    Validate(bm, piksel, p.X + 1, p.Y, staryK, nowyK);
                    Validate(bm, piksel, p.X, p.Y + 1, staryK, nowyK);
                }
            }

        }

        private void obraz_MouseDown(object sender, MouseEventArgs e)
        {
            malu = true;
            p2 = e.Location;

            cX = e.X;
            cY = e.Y;

        }

        private void obraz_MouseMove(object sender, MouseEventArgs e)
        {
            sX = x - cX;
            sY = y - cY;

            if (malu)
            {
                if(opcja == 1)
                {
                    p1 = e.Location;
                    grafika.DrawLine(pedzel, p1, p2);
                    p2 = p1;
                }
                else if(opcja == 2)
                {
                    p1 = e.Location;
                    grafika.DrawLine(gumka, p1, p2);
                    p2 = p1;
                }
            }
            obraz.Refresh();

            x = e.X;
            y = e.Y;
        }

        private void obraz_MouseUp(object sender, MouseEventArgs e)
        {
            malu = false;

            sX = x - cX;
            sY = y - cY;
            if(opcja == 3)
            {
                grafika.DrawEllipse(pedzel, cX, cY, sX, sY);
            }
            else if(opcja == 4)
            {
                grafika.DrawRectangle(pedzel, cX, cY, sX, sY);
            }
            else if(opcja==5)
            {
                grafika.DrawLine(pedzel, cX, cY, x, y);
            }
        }

        private void btnWyczy_Click(object sender, EventArgs e)
        {
            grafika.Clear(Color.White);
        }
    }
}