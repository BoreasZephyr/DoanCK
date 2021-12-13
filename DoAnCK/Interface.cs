using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Threading;

namespace DoAnCK
{
    public partial class Interface : MetroFramework.Forms.MetroForm
    {
        private const int MAXCOLUMN = 6;
        private List<string> data = new List<string>();
        private ToolTip toolTip = new ToolTip();
        public Interface()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            TaoCot();
            AddRandomDataToTB();
            HienThiCot();
            
        }
        private Thread threadBubble;
        private Thread threadMerge;
        private Thread threadRadix;
        private Thread threadEnable;
        private void Interface_Load(object sender, EventArgs e)
        {

        }
        private void EnableControl()
        {
            while (true)
            {
                if (threadBubble.IsAlive == false && threadMerge.IsAlive == false && threadRadix.IsAlive == false) 
                {
                    tbSortData.Enabled = true;
                    btnRandom.Enabled = true;
                    btnSort.Enabled = true;
                    btnBuble.Enabled = true;
                    btnMerge.Enabled = true;
                    btnRadix.Enabled = true;
                    break;
                }
            }
        }
        private void DisableControl()
        {
            tbSortData.Enabled = false;
            btnRandom.Enabled = false;
            btnSort.Enabled = false;
        }
        private void TaoCot()
        {
            for (int i = 0; i < MAXCOLUMN; i++)
            {
                lbCol[i] = new MetroFramework.Controls.MetroLabel();
                panelAnimation.Controls.Add(lbCol[i]);
                lbCol[i].BackColor = Color.Teal;
                lbCol[i].FontWeight = MetroLabelWeight.Bold;
                lbCol[i].ForeColor = SystemColors.ControlText;
                lbCol[i].Theme = MetroThemeStyle.Dark;
                lbCol[i].TabIndex = 1;
                lbCol[i].TextAlign = ContentAlignment.MiddleCenter;
                lbCol[i].Visible = true;
                lbCol[i].CustomBackground = true;
                lbCol[i].CustomForeColor = true;
            }
        }
        private void HienThiCot()
        {
            int khoangCachCot = 20;
            int chieuRongCot;
            int chieuDaiMotDV = 7;
            int chieuRongKhung = 1050;
            int chieuCaoKhung = 400;

            data = tbSortData.Text.Split(',').ToList();
            int soCot = data.Count;
            int y, chieuCaoCot;
            for (int i = 0; i < MAXCOLUMN; i++)
            {
                lbCol[i].Visible = false;
                lbCol[i].BackColor = Color.Teal;
            }
            chieuCaoCot = 20 + chieuDaiMotDV * 8;
            chieuRongCot = chieuCaoCot;
            y = (chieuCaoKhung / 2) - (chieuCaoCot / 2);
            int x = chieuRongKhung / 2 - (chieuRongCot * soCot + khoangCachCot * (soCot - 1)) / 2 - chieuRongCot - khoangCachCot;
            //hien thi o
            for (int i = 0; i < soCot; i++)
            {
                x += chieuRongCot + khoangCachCot;
                lbCol[i].Location = new Point(x, y);
                lbCol[i].Size = new Size(chieuRongCot, chieuCaoCot);
                lbCol[i].Text = data[i];
                lbCol[i].Visible = true;
            }
        }
        private void AddRandomDataToTB()
        {
            List<int> list = new List<int>();
            Randomlist.CreateRandom(list, 1, 50);
            Random rand = new Random();
            int soCot = rand.Next(4, MAXCOLUMN);
            tbSortData.Text = "";
            for (int i = 1; i <= soCot; i++)
            {
                if (i == soCot)
                {
                    tbSortData.Text = tbSortData.Text + Convert.ToString(list[i]);
                }
                else
                {
                    tbSortData.Text = tbSortData.Text + Convert.ToString(list[i]) + ",";
                }
            }
        }

        private void tbSortData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            int t;
            data = tbSortData.Text.Split(',').ToList();
            int soCot = data.Count;

            for (int i = 0; i < soCot; i++)
            {
                if (!int.TryParse(data[i], out t) || int.Parse(data[i]) > 50 || soCot > MAXCOLUMN || soCot < 4)
                {
                    MessageBox.Show(this, "Lỗi!\n- Dữ liệu là các ố nguyên được phân tách bởi dấu phẩy\n- Mỗi con số không lớn hơn 50\n- Số lượng các con số tối thiểu là 4 và lớn nhất là 6", "Interface", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            HienThiCot();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            data = tbSortData.Text.Split(',').ToList();
            int soCot = data.Count;
            int t;

            for (int i = 0; i < soCot; i++)
            {
                if (!int.TryParse(data[i], out t) || int.Parse(data[i]) > 50 || soCot > MAXCOLUMN || soCot<4)
                {
                    MessageBox.Show(this, "Lỗi!\n- Dữ liệu là các ố nguyên được phân tách bởi dấu phẩy\n- Mỗi con số không lớn hơn 50\n- Số lượng các con số tối thiểu là 4 và lớn nhất là 6", "Interface", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            HienThiCot();
            DisableControl();
            threadBubble = new Thread(() => Sortcontrol.BubbleSort(data, lbCol));
            //threadMerge
            threadMerge = new Thread(() => Sortcontrol.MergeSort(data, lbCol));
            //threadRadix
            threadRadix = new Thread(() => Sortcontrol.RadixSort(data, lbCol));
            if (btnBuble.Checked)
            {
                btnBuble.Enabled = true;
                btnMerge.Enabled = false;
                btnRadix.Enabled = false;
                threadBubble.IsBackground = true;
                threadBubble.Start();
            }
            else if (btnMerge.Checked)
            {
                btnBuble.Enabled = false;
                btnMerge.Enabled = true;
                btnRadix.Enabled = false;
                threadMerge.IsBackground = true;
                threadMerge.Start();
            }
            else if (btnRadix.Checked)
            {
                btnBuble.Enabled = false;
                btnMerge.Enabled = false;
                btnRadix.Enabled = true;
                threadRadix.IsBackground = true;
                threadRadix.Start();
            }
            threadEnable = new Thread(EnableControl);
            threadEnable.IsBackground = true;
            threadEnable.Start();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            AddRandomDataToTB();
            HienThiCot();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (btnBuble.Checked)
                threadBubble.Abort();
            else if (btnMerge.Checked)
                threadMerge.Abort();
            else if (btnRadix.Checked)
                threadRadix.Abort();
        }
    }
}
