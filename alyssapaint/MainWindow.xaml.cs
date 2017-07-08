using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
namespace alyssapaint
{
    public partial class MainWindow : Window
    {
        Ellipse topLeftCircle = new Ellipse();
        Thickness speed = new Thickness(15, 15, 0, 0);

        Point mousePosition = new Point(0, 0);
        bool mousedown = false;
        Brush brush;

        public MainWindow()
        {
            InitializeComponent();

            //topLeftCircle.Width = 20;
            //topLeftCircle.Height = 20;
            //topLeftCircle.Stroke = Brushes.White;
            //canvas.Children.Add(topLeftCircle);

            DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Send);
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 16);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //topLeftCircle.Margin = new Thickness(topLeftCircle.Margin.Left + speed.Left, topLeftCircle.Margin.Top + speed.Top, 0, 0);

            //if (topLeftCircle.Margin.Top + topLeftCircle.Height >= canvas.ActualHeight)
            //{
            //    speed.Top *= -1;                
            //}

            //if (topLeftCircle.Margin.Left + topLeftCircle.Width >= canvas.ActualWidth)
            //{
            //    speed.Left *= -1;
            //}

            //if (topLeftCircle.Margin.Top <= 0)
            //{
            //    speed.Top *= -1;
            //}

            //if (topLeftCircle.Margin.Left <= 0)
            //{
            //    speed.Left *= -1;
            //}
           
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mousedown = true;
            mousePosition = e.GetPosition(leftTopCanvas);
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point newPosition = e.GetPosition(leftTopCanvas);
                Line leftTopLine = new Line();
                Line rightTopLine = new Line();
                Line leftBottomLine = new Line();
                Line rightBottomLine = new Line();

                leftTopLine.X1 = mousePosition.X;
                leftTopLine.Y1 = mousePosition.Y;
                leftTopLine.X2 = newPosition.X;
                leftTopLine.Y2 = newPosition.Y;
                leftTopLine.Stroke = brush;

                rightTopLine.X1 = rightTopCanvas.ActualWidth - mousePosition.X;
                rightTopLine.Y1 = mousePosition.Y;
                rightTopLine.X2 = rightTopCanvas.ActualWidth - newPosition.X;
                rightTopLine.Y2 = newPosition.Y;
                rightTopLine.Stroke = brush;

                leftBottomLine.X1 = mousePosition.X;
                leftBottomLine.Y1 = leftBottomCanvas.ActualHeight - mousePosition.Y;
                leftBottomLine.X2 = newPosition.X;
                leftBottomLine.Y2 = leftBottomCanvas.ActualHeight - newPosition.Y;
                leftBottomLine.Stroke = brush;

                rightBottomLine.X1 = rightBottomCanvas.ActualWidth - mousePosition.X;
                rightBottomLine.Y1 = rightBottomCanvas.ActualHeight - mousePosition.Y;
                rightBottomLine.X2 = rightBottomCanvas.ActualWidth - newPosition.X;
                rightBottomLine.Y2 = rightBottomCanvas.ActualHeight - newPosition.Y;
                rightBottomLine.Stroke = brush;

                mousePosition = newPosition;
                leftTopCanvas.Children.Add(leftTopLine);
                rightTopCanvas.Children.Add(rightTopLine);
                leftBottomCanvas.Children.Add(leftBottomLine);
                rightBottomCanvas.Children.Add(rightBottomLine);
            }
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mousedown = false;
        }

        private void Window_MouseLeave(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A)
            {
                brush = Brushes.MidnightBlue;
            }
            if (e.Key == Key.S)
            {
                brush = Brushes.MediumSpringGreen;
            }
            if (e.Key == Key.D)
            {
                brush = Brushes.Crimson;
            }
            if (e.Key == Key.F)
            {
                brush = Brushes.DarkBlue;
            }
            if (e.Key == Key.G)
            {
                brush = Brushes.MediumPurple;
            }
            if (e.Key == Key.H)
            {
                brush = Brushes.Maroon;
            }
            if (e.Key == Key.J)
            {
                brush = Brushes.Magenta;
            }
            if (e.Key == Key.K)
            {
                brush = Brushes.MediumAquamarine;
            }
            if (e.Key == Key.L)
            {
                brush = Brushes.MediumOrchid;
            }
            if (e.Key == Key.Z)
            {
                brush = Brushes.MediumSeaGreen;
            }
            if (e.Key == Key.X)
            {
                //brush = Brushes.MediumVioletRed;
                rightTopCanvas.Children.Clear();
                leftTopCanvas.Children.Clear();
                rightBottomCanvas.Children.Clear();
                leftBottomCanvas.Children.Clear();
            }
            if (e.Key == Key.C)
            {
                brush = Brushes.MistyRose;
            }
            if (e.Key == Key.V)
            {
                brush = Brushes.Navy;
            }
            if (e.Key == Key.B)
            {
                brush = Brushes.Indigo;
            }
            if (e.Key == Key.N)
            {
                brush = Brushes.ForestGreen;
            }
            if (e.Key == Key.M)
            {
                brush = Brushes.DodgerBlue;
            }
            if (e.Key == Key.Q)
            {
                brush = Brushes.DeepSkyBlue;
            }
            if (e.Key == Key.W)
            {
                brush = Brushes.Firebrick;
            }
            if (e.Key == Key.E)
            {
                brush = Brushes.Teal;
            }
            if (e.Key == Key.R)
            {
                brush = Brushes.SteelBlue;
            }
            if (e.Key == Key.T)
            {
                brush = Brushes.SeaShell;
            }
            if (e.Key == Key.Y)
            {
                brush = Brushes.RoyalBlue;
            }
            if (e.Key == Key.U)
            {
                brush = Brushes.Lavender;
            }
            if (e.Key == Key.I)
            {
                brush = Brushes.Green;
            }
            if (e.Key == Key.O)
            {
                brush = Brushes.Azure;
            }
            if (e.Key == Key.P)
            {
                brush = Brushes.CadetBlue;
            }
        }
    }
}
