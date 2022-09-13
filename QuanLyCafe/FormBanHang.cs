using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class FormBanHang : Form
    {
        /*private const int TABLE_NUMS = 25;
        private const int COLUMN_NUMS = 5;
        private const int ROW_NUMS = 5;
        private const int TABLE_WIDTH = 80;
        private const int TABLE_HEIGHT = 70;*/

        private const int DONG = 5;
        private const int COT = 5;
        private const int TABLE_WIDTH = 104;
        private const int TABLE_HEIGHT = 70;

        public FormBanHang()
        {
            InitializeComponent();
            TaoBan(DONG, COT);
        }

        /*private void TaoBan()
        {
            Button btn;
            for (int i = 0; i < TABLE_NUMS; i++)
            {
                btn = new Button();
                btn.Width = TABLE_WIDTH;
                btn.Height = TABLE_HEIGHT;
                //btn.Left = (i % COLUMN_NUMS) * btn.Width;
                //btn.Top = (i / COLUMN_NUMS) * btn.Height;
                btn.Text = @"Bàn " + (i + 1).ToString();
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                //btn.BackgroundImage = Image.FromFile(@"C:\Users\xuant\Desktop cfe.jpg");
                btn.BackColor = Color.White;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Name = "btnBanSo" + (i + 1).ToString();
                btn.Size = new Size(btn.Width, btn.Height);
            }
        }*/

        private void TaoBan(int dong, int cot)
        {
            int x, y = 23, count = 1;
            for (int i = 0; i < dong; i++)
            {
                x = 24;
                for (int j = 0; j < cot; j++)
                {
                    TaoNut(x, y, count);
                    x += 131;
                    count++;
                }
                y += 91;
            }
        }
        private void TaoNut(int x, int y, int count)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(Width, Height);
            btn.Text = "Bàn " + count;
            btn.BackColor = Color.White;
        }
    }
}
