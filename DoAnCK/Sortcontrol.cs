﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using System.Drawing;
using System.Threading;

namespace DoAnCK
{
    public class Sortcontrol
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

        public static void MergeSort(List<string> data, MetroFramework.Controls.MetroLabel[] ctrl)
        {
            
        }
        public static void RadixSort(List<string> data, MetroFramework.Controls.MetroLabel[] ctrl)
        {
            int tt = 0;
            int n = data.Count;
            int[] count = new int[10];
            int[,] arr = new int[10, 9];
            int[,] ctrlTT = new int[10, 9];
            string[] newData = new string[10];
            MetroFramework.Controls.MetroLabel[] newCtrl = new MetroFramework.Controls.MetroLabel[9];
            for (int i = 0; i < n; i++)
            {
                ctrl[i].BackColor = Color.Green;
                int kq = int.Parse(data[i]) % 10;
                Thread.Sleep(500);

                arr[kq, count[kq]] = int.Parse(data[i]);
                ctrlTT[kq, count[kq]] = i;
                Thread move = new Thread(() => moveToCol(ctrl[i], kq, count[kq]));
                move.IsBackground = true;
                move.Start();
                move.Join();
                count[kq]++;
                

            }
            for (int i = 0; i < data.Count; i++)
            {
                ctrl[i].BackColor = Color.Teal;
            }


            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                for (int j = 0; j < count[i]; j++)
                {
                    newCtrl[tt] = ctrl[ctrlTT[i, j]];
                    newData[tt] = newCtrl[tt].Text;
                    Thread move = new Thread(() => moveTo(newCtrl[tt], tt, data));
                    move.IsBackground = true;
                    move.Start();
                    move.Join();
                    tt++;
                }
            }
            for (int i = 0; i < data.Count; i++)
            {
                ctrl[i].BackColor = Color.Teal;
            }

            tt = 0;
            count = new int[10];
            arr = new int[10, 9];
            ctrlTT = new int[10, 9];
            ctrl = new MetroFramework.Controls.MetroLabel[9];

            for (int i = 0; i < n; i++)
            {
                newCtrl[i].BackColor = Color.Green;
                int kq = (int.Parse(newData[i]) / 10) % 10;
                Thread.Sleep(500);

                arr[kq, count[kq]] = int.Parse(newData[i]);
                ctrlTT[kq, count[kq]] = i;
                Thread move = new Thread(() => moveToCol(newCtrl[i], kq, count[kq]));
                move.IsBackground = true;
                move.Start();
                move.Join();
                count[kq]++;
            }
            for (int i = 0; i < data.Count; i++)
            {
                newCtrl[i].BackColor = Color.Teal;
            }
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                for (int j = 0; j < count[i]; j++)
                {
                    ctrl[tt] = newCtrl[ctrlTT[i, j]];
                    Thread move = new Thread(() => moveTo(ctrl[tt], tt, data));
                    move.IsBackground = true;
                    move.Start();
                    move.Join();
                    tt++;
                }
            }
            for (int i = 0; i < data.Count; i++)
            {
                ctrl[i].BackColor = Color.Teal;
            }
        }

        private static void moveTo(MetroFramework.Controls.MetroLabel ctrl, int stt, List<string> data)
        {
            int x = 1050 / 2 - (76 * data.Count + 20 * (data.Count - 1)) / 2 - 76 - 20 + (76 + 20) * (stt + 1);
            int y = (400 / 2) - (76 / 2);

            ctrl.Location = new Point(x, y);
            ctrl.BackColor = Color.Orange;
            Thread.Sleep(500);
        }
        private static void moveToCol(MetroFramework.Controls.MetroLabel ctrl, int col, int count)
        {
            int y = 350 - 76 * count;

            switch (col)
            {
                case 0:
                    {
                        ctrl.Location = new Point(50, y);
                        ctrl.BackColor = Color.Orange;
                        Thread.Sleep(1);
                    }
                    break;
                case 1:
                    {
                        ctrl.Location = new Point(50 + 10 + 76, y);
                        ctrl.BackColor = Color.Orange;
                        Thread.Sleep(1);
                    }
                    break;
                case 2:
                    {
                        ctrl.Location = new Point(50 + 10 * 2 + 76 * 2, y);
                        ctrl.BackColor = Color.Orange;
                        Thread.Sleep(1);
                    }
                    break;
                case 3:
                    {
                        ctrl.Location = new Point(50 + 10 * 3 + 76 * 3, y);
                        ctrl.BackColor = Color.Orange;
                        Thread.Sleep(1);
                    }
                    break;
                case 4:
                    {
                        ctrl.Location = new Point(50 + 10 * 4 + 76 * 4, y);
                        ctrl.BackColor = Color.Orange;
                        Thread.Sleep(1);
                    }
                    break;
                case 5:
                    {
                        ctrl.Location = new Point(50 + 10 * 5 + 76 * 5, y);
                        ctrl.BackColor = Color.Orange;
                        Thread.Sleep(1);
                    }
                    break;
                case 6:
                    {
                        ctrl.Location = new Point(50 + 10 * 6 + 76 * 6, y);
                        ctrl.BackColor = Color.Orange;
                        Thread.Sleep(1);
                    }
                    break;
                case 7:
                    {
                        ctrl.Location = new Point(50 + 10 * 7 + 76 * 7, y);
                        ctrl.BackColor = Color.Orange;
                        Thread.Sleep(1);
                    }
                    break;
                case 8:
                    {
                        ctrl.Location = new Point(50 + 10 * 8 + 76 * 8, y);
                        ctrl.BackColor = Color.Orange;
                        Thread.Sleep(1);
                    }
                    break;
                case 9:
                    {
                        ctrl.Location = new Point(50 + 10 * 9 + 76 * 9, y);
                        ctrl.BackColor = Color.Orange;
                        Thread.Sleep(1);
                    }
                    break;
            }
        }

        private static void SwapControl(MetroFramework.Controls.MetroLabel ctrl, Point p, int x, int sl)
        {
            //ctrl.TabIndex = 100;
            while (true)
            {
                if (ctrl.Location.X == p.X)
                    break;
                ctrl.Location = new Point(ctrl.Location.X + x, ctrl.Location.Y);
                Thread.Sleep(sl);
            }
            //ctrl.TabIndex = 50;
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
