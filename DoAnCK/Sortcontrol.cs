using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using System.Drawing;
using System.Threading;

namespace DoAnCK
{
    public static class Sortcontrol
    {
        public static void BubbleSort(List<string> data, MetroFramework.Controls.MetroLabel[] ctrl)
        {

            bool swapped = true;
            int n = data.Count;
            Thread.Sleep(1000);
            do
            {
                swapped = false;
                n--;

                for (int i = 0; i < n; i++)
                {
                    ctrl[i].BackColor = Color.Green;
                    ctrl[i + 1].BackColor = Color.Green;
                    Thread.Sleep(700);

                    if (int.Parse(data[i + 1]) < int.Parse(data[i]))
                    {
                        var t = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = t;

                        Point p1 = ctrl[i].Location;
                        Point p2 = ctrl[i + 1].Location;

                        Thread threadA = new Thread(() => SwapControl(ctrl[i], p2, 2, 1));
                        threadA.IsBackground = true;
                        threadA.Start();

                        Thread threadB = new Thread(() => SwapControl(ctrl[i + 1], p1, -2, 1));
                        threadB.IsBackground = true;
                        threadB.Start();

                        while (true)
                        {
                            if (!threadA.IsAlive && !threadB.IsAlive)
                            {
                                ctrl[i + 1].BackColor = Color.Teal;
                                break;
                            }
                        }

                        var temp = ctrl[i];
                        ctrl[i] = ctrl[i + 1];
                        ctrl[i + 1] = temp;
                        swapped = true;

                    }
                    else
                    {
                        ctrl[i].BackColor = Color.Teal;
                    }
                    if (i == n - 1)
                    {
                        ctrl[i + 1].BackColor = Color.Orange;
                    }
                }
            } while (swapped);

            for (int i = 0; i < data.Count; i++)
            {
                ctrl[i].BackColor = Color.Teal;
            }
        }
        public static void MergeSort(List<string> dulieu, MetroFramework.Controls.MetroLabel[] ctrl)
        {

        }
        public static void QuickSort(List<string> dulieu, MetroFramework.Controls.MetroLabel[] ctrl)
        {

        }

        private static void SwapControl(MetroFramework.Controls.MetroLabel ctrl, Point p, int x, int sl)
        {
            ctrl.TabIndex = 100;
            while (true)
            {
                if (ctrl.Location.X == p.X)
                    break;
                ctrl.Location = new Point(ctrl.Location.X + x, ctrl.Location.Y);
                Thread.Sleep(sl);
            }
            ctrl.TabIndex = 50;
        }
        private static void MoveUpDown(MetroFramework.Controls.MetroLabel ctrl, int upDown)
        {
            for (int i = 1; i < 50; i++)
            {
                ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + upDown);
                Thread.Sleep(1);
            }
        }
        public static int Partition(List<string> dulieu, int l, int r, MetroFramework.Controls.MetroLabel[] ctrl)
        {
            int ndx = 1;
            int pivot = int.Parse(dulieu[l]);
            for (int i = l + 1; i <= r; i++)
            {
                if (int.Parse(dulieu[i]) > pivot)
                {
                    ndx++;
                    Swap(dulieu, ndx, i);
                }
            }
            Swap(dulieu, ndx, l);
            return ndx;
        }
        public static void Swap(List<string> dulieu, int i, int j)
        {
            var t = dulieu[i];
            dulieu[i] = dulieu[j];
            dulieu[j] = t;
        }
    }
}
