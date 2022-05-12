using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        Bitmap canvas;
        Graphics objDibujador;
        bool isPainting = false, isRunning = false;
        int? primerX = null, segundoX = null;
        int? primerY = null, segundoY = null;
        Figuras figuraActiva;

        enum Figuras
        {
            Lapiz,
            Brocha,
            Cuadrado,
            Triangulo,
            Pentagono,
            Borrador,
            Linea,
            Circulo,
            Bucket,
            Letras,
            ColorSelect
        }

        public Principal()
        {
            InitializeComponent();
            txtEscribir.Visible = false;
            canvas = new Bitmap(paintArea.Width, paintArea.Height);
            objDibujador = Graphics.FromImage(canvas);
            objDibujador.Clear(Color.White);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdAbrirArchivo.Filter = "Archivos de Imagen (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png; ";
            if (ofdAbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                canvas = new Bitmap(ofdAbrirArchivo.FileName);
                paintArea.Image = (Image)canvas;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdGuardarArchivo.Filter = "Archivos de Imagen (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png ";
            if (sfdGuardarArchivo.ShowDialog() == DialogResult.OK)
            {
                canvas.Save(sfdGuardarArchivo.FileName);
            }
        }

        private void btnLapiz_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Lapiz;
        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Borrador;
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Circulo;
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Cuadrado;
        }

        private void btnPentagono_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Pentagono;
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Triangulo;
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Letras;
            txtEscribir.Visible = true;
            if (fdgLetra.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btnBrocha_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Brocha;
        }

        private void btnCubeta_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Bucket;
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Linea;
        }

        private void paintArea_MouseDown(object sender, MouseEventArgs e)
        {
            isPainting = true;
            primerX = e.X;
            primerY = e.Y;
        }

        private void paintArea_MouseMove(object sender, MouseEventArgs e)
        {
            stsCoordenadas.Text = e.X.ToString() + " , " + e.Y.ToString() + " px";
            
            switch (figuraActiva)
            {
                case Figuras.Lapiz:
                    if (isPainting)
                    {
                        paintArea.Image = (Image)canvas;
                        Point posicion = new Point(primerX ?? e.X, primerY ?? e.Y);
                        objDibujador = Graphics.FromImage(canvas);

                        Pen lapizSeleccionado = new Pen(btnColorSeleccionado.BackColor, float.Parse(nudGrosor.Text));
                        lapizSeleccionado.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        lapizSeleccionado.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        lapizSeleccionado.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                        objDibujador.DrawLine(lapizSeleccionado, posicion, e.Location);
                        primerX = e.X;
                        primerY = e.Y;
                    }
                    break;
                case Figuras.Borrador:
                    if (isPainting)
                    {
                        paintArea.Image = (Image)canvas;
                        Point posicion = new Point(primerX ?? e.X, primerY ?? e.Y);
                        objDibujador = Graphics.FromImage(canvas);

                        Pen borradorSeleccionado = new Pen(paintArea.BackColor, (float.Parse(nudGrosor.Text)));
                        borradorSeleccionado.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        borradorSeleccionado.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        borradorSeleccionado.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                        objDibujador.DrawLine(borradorSeleccionado, posicion, e.Location);
                        primerX = e.X;
                        primerY = e.Y;
                    }
                    break;
                case Figuras.Brocha:
                    if (isPainting)
                    {                     
                        paintArea.Image = (Image)canvas;
                        Point coordenadas = new Point(primerX ?? e.X, primerY ?? e.Y);
                        objDibujador = Graphics.FromImage(canvas);

                        Pen brush = new Pen(btnColorSeleccionado.BackColor, (float)nudGrosor.Value);
                        brush.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        brush.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        brush.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                        objDibujador.DrawLine(brush, coordenadas, e.Location);
                        objDibujador.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        primerX = e.X;
                        primerY = e.Y; 
                    }
                    break;
                default:
                    break;
            }
        }

        private void paintArea_MouseUp(object sender, MouseEventArgs e)
        {
            isPainting = false;
            segundoX = e.X;
            segundoY = e.Y;
            
            switch (figuraActiva)
            {
                case Figuras.Linea:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);

                    Pen lapizSeleccionado = new Pen(btnColorSeleccionado.BackColor, (float)nudGrosor.Value);
                    objDibujador.DrawLine(lapizSeleccionado, (float)primerX, (float)primerY, (float)segundoX, (float)segundoY);
                    break;
                case Figuras.Bucket:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);
                    Color pixel = canvas.GetPixel(e.X, e.Y);
                    FloodFill(canvas, e.Location, pixel, btnColorSeleccionado.BackColor);
                    break;
                case Figuras.Cuadrado:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);
                    Pen lapizSeleccionado2 = new Pen(btnColorSeleccionado.BackColor, (float)nudGrosor.Value);
                    if ((primerX ?? e.X) > (segundoX ?? e.X) && (primerY ?? e.Y) > (segundoY ?? e.Y))
                    {
                        objDibujador.DrawRectangle(lapizSeleccionado2, segundoX ?? e.X, segundoY ?? e.Y, (primerX ?? e.X) - (segundoX ?? e.X), (primerY ?? e.Y) - (segundoY ?? e.Y));
                    }
                    if ((primerX ?? e.X) < (segundoX ?? e.X) && (primerY ?? e.Y) < (segundoY ?? e.Y))
                    {
                        objDibujador.DrawRectangle(lapizSeleccionado2, primerX ?? e.X, primerY ?? e.Y, (segundoX ?? e.X) - (primerX ?? e.X), (segundoY ?? e.Y) - (primerY ?? e.Y));
                    }
                    if ((primerX ?? e.X) > (segundoX ?? e.X) && (primerY ?? e.Y) < (segundoY ?? e.Y))
                    {
                        objDibujador.DrawRectangle(lapizSeleccionado2, segundoX ?? e.X, primerY ?? e.Y, (primerX ?? e.X) - (segundoX ?? e.X), (segundoY ?? e.Y) - (primerY ?? e.Y));
                    }
                    if ((primerX ?? e.X) < (segundoX ?? e.X) && (primerY ?? e.Y) > (segundoY ?? e.Y))
                    {
                        objDibujador.DrawRectangle(lapizSeleccionado2, primerX ?? e.X, segundoY ?? e.Y, (segundoX ?? e.X) - (primerX ?? e.X), (primerY ?? e.Y) - (segundoY ?? e.Y));
                    }
                    break;
                case Figuras.Circulo:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);
                    Pen lapizSeleccionado3 = new Pen(btnColorSeleccionado.BackColor, (float)nudGrosor.Value);
                    if ((primerX ?? e.X) > (segundoX ?? e.X) && (primerY ?? e.Y) > (segundoY ?? e.Y))
                    {
                        objDibujador.DrawEllipse(lapizSeleccionado3, segundoX ?? e.X, segundoY ?? e.Y, (primerX ?? e.X) - (segundoX ?? e.X), (primerY ?? e.Y) - (segundoY ?? e.Y));
                    }
                    if ((primerX ?? e.X) < (segundoX ?? e.X) && (primerY ?? e.Y) < (segundoY ?? e.Y))
                    {
                        objDibujador.DrawEllipse(lapizSeleccionado3, primerX ?? e.X, primerY ?? e.Y, (segundoX ?? e.X) - (primerX ?? e.X), (segundoY ?? e.Y) - (primerY ?? e.Y));
                    }
                    if ((primerX ?? e.X) > (segundoX ?? e.X) && (primerY ?? e.Y) < (segundoY ?? e.Y))
                    {
                        objDibujador.DrawEllipse(lapizSeleccionado3, segundoX ?? e.X, primerY ?? e.Y, (primerX ?? e.X) - (segundoX ?? e.X), (segundoY ?? e.Y) - (primerY ?? e.Y));
                    }
                    if ((primerX ?? e.X) < (segundoX ?? e.X) && (primerY ?? e.Y) > (segundoY ?? e.Y))
                    {
                        objDibujador.DrawEllipse(lapizSeleccionado3, primerX ?? e.X, segundoY ?? e.Y, (segundoX ?? e.X) - (primerX ?? e.X), (primerY ?? e.Y) - (segundoY ?? e.Y));
                    }
                    break;
                case Figuras.Triangulo:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);

                    int puntoMedioX = ((segundoX ?? e.X) + (primerX ?? e.X)) / 2;
                    int puntoMedioY = ((segundoY ?? e.Y) + (primerY ?? e.Y)) / 2;

                    int deltaX = (-1) * ((segundoX ?? e.X) - (primerX ?? e.X));
                    int deltaY = ((segundoY ?? e.Y) - (primerY ?? e.Y));

                    float catetoX = (float)(deltaX * Math.Cos(30 * Math.PI / 180));
                    float catetoY = (float)(deltaY * Math.Cos(30 * Math.PI / 180));

                    //Point coordenadas = new Point(primerX ?? e.X, primerY ?? e.Y);
                    PointF[] points = { new PointF(primerX ?? e.X, primerY ?? e.Y), new PointF(segundoX ?? e.X, segundoY ?? e.Y), new PointF(puntoMedioX + catetoY, puntoMedioY + catetoX) };
                    Pen lapizTriangulo = new Pen(btnColorSeleccionado.BackColor, (float)nudGrosor.Value); ;
                    objDibujador.DrawPolygon(lapizTriangulo, points);

                    //double distanciaCuadrada = Math.Pow((segundoX ?? e.X) - (primerX ?? e.X), 2) + Math.Pow((segundoY ?? e.Y) - (primerY ?? e.Y), 2);
                    //objDibujador.DrawPolygon(lapizTriangulo, getTriangleVertices(3, (float)(Math.Sqrt(distanciaCuadrada)), coordenadas));
                    break;
                case Figuras.Pentagono:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);

                    double distancia = Math.Sqrt(Math.Pow((segundoX ?? e.X) - (primerX ?? e.X), 2) + Math.Pow((segundoY ?? e.Y) - (primerY ?? e.Y), 2));

                    int puntoMedioXP = ((segundoX ?? e.X) + (primerX ?? e.X)) / 2;
                    int puntoMedioYP = ((segundoY ?? e.Y) + (primerY ?? e.Y)) / 2;
                    
                    int deltaXP = (-1) * ((segundoX ?? e.X) - (primerX ?? e.X));
                    int deltaYP = ((segundoY ?? e.X) - (primerY ?? e.Y));


                    float angulo = (float)Math.Atan(((double)deltaYP / (double)deltaXP));


                    float catetoPmx = (float)(deltaXP * (Math.Cos(((36) * Math.PI / 180))));
                    float catetoPmy = (float)(deltaYP * (Math.Cos(((36) * Math.PI / 180))));


                    float catetoXP3; 
                    float catetoYP3; 

                    float punto3x;
                    float punto3y;

                    float catetoXP5; 
                    float catetoYP5; 

                    //Point coordenadas = new Point(primerX ?? e.X, primerY ?? e.Y);
                   
                    Pen lapizPentagono = new Pen(btnColorSeleccionado.BackColor, (float)nudGrosor.Value);
                    if ((primerX ?? e.X) < (segundoX ?? e.X))
                    {
                        catetoXP3 = -(float)(distancia * Math.Cos(((18) * Math.PI / 180) - angulo));
                        catetoYP3 = (float)(distancia * Math.Cos(((72) * Math.PI / 180) + angulo));

                        punto3x = ((segundoX ?? e.X) + catetoYP3) - (float)(distancia * Math.Cos(((36) * Math.PI / 180) - angulo));
                        punto3y = ((segundoY ?? e.Y) + catetoXP3) - (float)(distancia * Math.Cos(((54) * Math.PI / 180) + angulo));

                        catetoXP5 = -(float)(distancia * Math.Cos(((18) * Math.PI / 180) + angulo));
                        catetoYP5 = (float)(distancia * Math.Cos(((72) * Math.PI / 180) - angulo));

                        PointF[] pointsP = { new PointF(primerX ?? e.X, primerY ?? e.Y), new PointF(segundoX ?? e.X, segundoY ?? e.Y), new PointF(((segundoX ?? e.X) + catetoYP3), ((segundoY ?? e.Y) + catetoXP3)), new PointF(punto3x, punto3y), new PointF(((primerX ?? e.X) - catetoYP5), ((primerY ?? e.Y) + catetoXP5)) };
                        objDibujador.DrawPolygon(lapizPentagono, pointsP);
                    }
                    else
                    {
                        catetoXP3 = -(float)(distancia * Math.Cos(((18) * Math.PI / 180) + angulo));
                        catetoYP3 = (float)(distancia * Math.Cos(((72) * Math.PI / 180) - angulo));

                        catetoXP5 = -(float)(distancia * Math.Cos(((18) * Math.PI / 180) - angulo));
                        catetoYP5 = (float)(distancia * Math.Cos(((72) * Math.PI / 180) + angulo));

                        punto3x = ((segundoX ?? e.X) - catetoYP5) + (float)(distancia * Math.Cos(((36) * Math.PI / 180) - angulo));
                        punto3y = ((segundoY ?? e.Y) - catetoXP5) + (float)(distancia * Math.Cos(((54) * Math.PI / 180) + angulo));

                        PointF[] pointsP = { new PointF(primerX ?? e.X, primerY ?? e.Y), new PointF(segundoX ?? e.X, segundoY ?? e.Y), new PointF(((segundoX ?? e.X) - catetoYP5), ((segundoY ?? e.Y) - catetoXP5)), new PointF(punto3x, punto3y)/*new PointF(puntoMedioXP + 2 * catetoPmy, puntoMedioYP + 2 * catetoPmx)*/, new PointF(((primerX ?? e.X) + catetoYP3), ((primerY ?? e.Y) - catetoXP3)) };
                        objDibujador.DrawPolygon(lapizPentagono, pointsP);
                    }
                    
                    
                    
                    //objDibujador.DrawPolygon(lapizPentagono, getPoligonVertices(5, (float)distancia, coordenadas));
                    break;
                case Figuras.Letras:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);

                    Font miFuente;
                    miFuente = fdgLetra.Font;
                    String txt;
                    txt = txtEscribir.Text;
                    Point coordenadasTxt = new Point((primerX ?? e.X)-2, (primerY ?? e.Y)-20);
                    SolidBrush escribirTexto = new SolidBrush(btnColorSeleccionado.BackColor);
                    objDibujador.DrawString(txt, miFuente, escribirTexto, coordenadasTxt);



                    break;
                case Figuras.ColorSelect:
                    Color pixelSeleccionado = canvas.GetPixel(e.X, e.Y);
                    btnColorSeleccionado.BackColor = pixelSeleccionado;
                    break;
                default:
                    break;
            }
        }

        private void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            Stack<Point> pixels = new Stack<Point>();
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            pixels.Push(pt);

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < bmp.Width && a.X > 0 &&
                        a.Y < bmp.Height && a.Y > 0)
                {

                    if (bmp.GetPixel(a.X, a.Y) == targetColor)
                    {
                        bmp.SetPixel(a.X, a.Y, replacementColor);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            paintArea.Refresh();
            return;
        }

        private PointF[] getPoligonVertices(int sides, float radius, Point center)
        {
            List<PointF> points = new List<PointF>();
            float step = 360.0f / sides;
            int startingAngle = 90;
            float angle = startingAngle;
            for (double i = startingAngle; i < startingAngle + 360.0; i += step)
            {
                points.Add(DegreesToXY(angle, radius, center));
                angle += step;
            }
            return points.ToArray();
        }

        private PointF DegreesToXY(float degrees, float radius, Point origin)
        {
            PointF xy = new PointF();
            double radians = degrees * Math.PI / 180.0;
            xy.X = (float)Math.Cos(radians) * radius + origin.X;
            xy.Y = (float)Math.Sin(-radians) * radius + origin.Y;
            return xy;
        }

        private void paintArea_SizeChanged(object sender, EventArgs e)
        {
            stsCoordenadasDelPanel.Text = paintArea.Width + ", " + paintArea.Height + "px";
            if (isRunning)
            {
                Bitmap canvasResize = new Bitmap(paintArea.Width, paintArea.Height);
                if (canvas.Width > canvasResize.Width)
                {
                    canvasResize = new Bitmap(canvasResize.Width, canvasResize.Height);
                }
                if (canvas.Height > canvasResize.Height)
                {
                    canvasResize = new Bitmap(canvasResize.Width, canvasResize.Height);
                }
                objDibujador = Graphics.FromImage(canvasResize);
                objDibujador.Clear(Color.White);
                objDibujador.DrawImage(canvas, 0, 0);
                canvas = canvasResize;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objDibujador.Clear(paintArea.BackColor = Color.White);
            btnColorSeleccionado.BackColor = Color.Black;
            paintArea.Refresh();
        }

        private void btnGetColor_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.ColorSelect;
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnColorSeleccionado_Click(object sender, EventArgs e)
        {

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBotonActivo_Click(object sender, EventArgs e)
        {

        }

        private void nudGrosor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            isRunning = true;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe miObjetoAcercaDe = new AcercaDe();
            miObjetoAcercaDe.Show();
        }

        private void btnPaletaDeColores_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = btnPaletaDeColores.BackgroundImage;
            if (cdgPaletaDeColores.ShowDialog() == DialogResult.OK)
            {
                btnColorSeleccionado.BackColor = cdgPaletaDeColores.Color;
            }
        }
    }
}
