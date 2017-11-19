using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace co_ganh
{
    public partial class coghanh : Form
    {
        public static SolidBrush solidBack;
        public static SolidBrush solidWhite;
        Ban_co ban_Co;
        private Graphics graphics;
        Oco[,] _arrayChess;
        private List<Oco> listquanco;
        private List<Oco> ListCoThat;
        private List<Oco> list;
        private List<Oco> listQuanKeNhau;
        private Boolean danhco = false;
        private int lastDong = 0;
        private int lastcot = 0;
        private int lastsohuu = 0;
        int demQuanTrang = 0;
        int demQuanĐen = 0;
        KiemTra check;
        public static String tennguoi1 = "";
        public static String tennguoi2 = "";
        public static int luotdi = 1;
        private Boolean canMove = true;
        public coghanh()
        {
            _arrayChess = new Oco[5, 5];
            listquanco = new List<Oco>();
            ListCoThat = new List<Oco>();
            listQuanKeNhau = new List<Oco>();
            list = new List<Oco>();
            solidWhite = new SolidBrush(Color.White);
            solidBack = new SolidBrush(Color.Black);
            InitializeComponent();
            ban_Co = new Ban_co();
            check = new KiemTra();
            graphics = panel_co_ganh.CreateGraphics();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            khoitaomangoco();
            //khoitaoquanco();
        }

        private void panel_co_ganh_Paint(object sender, PaintEventArgs e)
        {

            ban_Co.banco(graphics);
            velaiquanco(graphics);
        }
        public void khoitaomangoco()
        {
            for (int i = 0; i <= ban_Co.Sodong; i++)
            {
                for (int j = 0; j <= ban_Co.SoCot; j++)
                {
                    _arrayChess[i, j] = new Oco(i, j, new Point(j * Oco._chieuRong + 15, i * Oco._chieuCao + 15), 0);
                }
            }
        }
        public bool DanhCo(int MouseX, int MouseY, Graphics gp, int sohuu)
        {
            if (MouseX % (Oco._chieuRong) == 0 || MouseY % (Oco._chieuCao) == 0)
                return false;
            int cot = MouseX / (Oco._chieuRong);
            int dong = MouseY / (Oco._chieuCao);
            _arrayChess[dong, cot].Sohuu = sohuu;
            ban_Co.veQuanCo(gp, _arrayChess[dong, cot].Vitri, solidBack);
            listquanco.Add(_arrayChess[dong, cot]);
            luotdi = sohuu;
            return true;
        }

        public void khoitaoquanco()
        {
            for (int i = 0; i <= ban_Co.Sodong; i++)
            {
                for (int j = 0; j <= ban_Co.SoCot; j++)
                {
                    if (i == 0)
                        Nguoichoi1(i, j);
                    else
                    if (j == 0)
                        if (i > 0 && i < 3)
                            Nguoichoi1(i, j);
                        else
                            nguoichoi2(i, j);
                    if (i == ban_Co.Sodong)
                        if (j > 0)
                            nguoichoi2(i, j);
                    if (j == ban_Co.SoCot)
                        if (i > 0 && i < 2)
                            Nguoichoi1(i, j);
                        else
                            if (i > 1 && i < ban_Co.Sodong)
                            nguoichoi2(i, j);
                }
            }
        }
        private void Nguoichoi1(int i, int j)
        {
            _arrayChess[i, j].Sohuu = 1;
            ban_Co.veQuanCo(graphics, _arrayChess[i, j].Vitri, solidBack);
            listquanco.Add(_arrayChess[i, j]);
        }

        private void nguoichoi2(int i, int j)
        {
            _arrayChess[i, j].Sohuu = 2;
            ban_Co.veQuanCo(graphics, _arrayChess[i, j].Vitri, solidWhite);
            listquanco.Add(_arrayChess[i, j]);
        }

        private void panel_co_ganh_MouseClick(object sender, MouseEventArgs e)
        {

            int currentcot = e.X / (Oco._chieuRong);
            int currnetdong = e.Y / (Oco._chieuCao);
            int currensohuu = 0;
            clearnList();
            list.Clear();
            listQuanKeNhau.Clear();
            List<Oco> kiemtradoc = new List<Oco>();
            List<Oco> kiemtranghang = new List<Oco>();
            List<Oco> kiemtracheonguoc = new List<Oco>();
            List<Oco> kiemtracheoxuoi = new List<Oco>();

            if (!danhco)
            {
                for (int row = 0; row < listquanco.Count; row++)
                {
                    layViTri(row, currnetdong, currentcot);
                }
            } else
            {
                for (int row = 0; row < listquanco.Count; row++)
                {
                    if (listquanco[row].Dong == currnetdong && listquanco[row].Cot == currentcot)
                    {
                        currensohuu = listquanco[row].Sohuu;
                    }
                }
                if (check.cothedichuyen(lastDong, lastcot, currnetdong, currentcot, currensohuu))
                {

                    for (int row = 0; row < listquanco.Count; row++)
                    {
                        if (listquanco[row].Dong == lastDong && listquanco[row].Cot == lastcot)
                        {
                            listquanco.RemoveAt(row);
                            _arrayChess[lastDong, lastcot].Sohuu = 0;
                            DanhCo(e.X, e.Y, graphics, lastsohuu);

                            kiemtradoc = kiemtraDoc(listquanco, currnetdong, currentcot, lastsohuu);
                            kiemtranghang = kiemtraNgang(listquanco, currnetdong, currentcot, lastsohuu);
                            kiemtracheoxuoi = kiemTraCheoXuoi(listquanco, currnetdong, currentcot, lastsohuu);
                            kiemtracheonguoc = kiemTraCheoNguoc(listquanco, currnetdong, currentcot, lastsohuu);

                        }
                    }

                }
                if (kiemtradoc.Count == 2)
                {
                    for (int i = 0; i < kiemtradoc.Count; i++)
                    {
                        kiemtradoc[i].Sohuu = lastsohuu;
                        luotdi = lastsohuu;
                    }
                }
                if (kiemtranghang.Count == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        kiemtranghang[i].Sohuu = lastsohuu;
                        luotdi = lastsohuu;
                    }
                }
                if (kiemtracheonguoc.Count == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        kiemtracheonguoc[i].Sohuu = lastsohuu;
                        luotdi = lastsohuu;
                    }
                }
                if (kiemtracheoxuoi.Count == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        kiemtracheoxuoi[i].Sohuu = lastsohuu;
                        luotdi = lastsohuu;
                    }
                }

                for (int row = 0; row < listquanco.Count; row++)
                {
                    if (listquanco[row].Dong == currnetdong && listquanco[row].Cot == currentcot)
                    {
                        for (int i = 0; i < listquanco.Count; i++)
                        {
                            kiemtraHetnuoc(i, currnetdong, currentcot);
                        }

                    }
                }
                clearnList();
                for (int item = 0; item < list.Count; item++)
                {
                    kiemtradoc = new List<Oco>();
                    kiemtranghang = new List<Oco>();
                    kiemtracheoxuoi = new List<Oco>();
                    kiemtracheonguoc = new List<Oco>();
                    if (list[item].Dong > 0 && list[item].Dong < ban_Co.Sodong && list[item].Cot > 0 && list[item].Cot < ban_Co.SoCot)
                    {
                        kiemtradoc = kiemtraDoc(listquanco, currnetdong, currentcot, list[item].Sohuu);
                        kiemtranghang = kiemtraNgang(listquanco, currnetdong, currentcot, list[item].Sohuu);
                        kiemtracheoxuoi = kiemTraCheoXuoi(listquanco, currnetdong, currentcot, list[item].Sohuu);
                        kiemtracheonguoc = kiemTraCheoNguoc(listquanco, currnetdong, currentcot, list[item].Sohuu);


                        if (kiemtradoc.Count == 2 && kiemtranghang.Count == 2 && kiemtracheoxuoi.Count == 0 && kiemtracheonguoc.Count == 0)
                        {
                            for (int i = 0; i < listquanco.Count; i++)
                            {
                                if (listquanco[i].Dong == list[item].Dong && listquanco[i].Cot == list[item].Cot)
                                {
                                    if (list[item].Sohuu == 1)
                                        listquanco[i].Sohuu = 2;
                                    else
                                        listquanco[i].Sohuu = 1;
                                }
                            }
                        }
                        else
                        {
                            if (kiemtradoc.Count == 2 && kiemtranghang.Count == 2 && kiemtracheonguoc.Count == 2 && kiemtracheoxuoi.Count == 0)
                            {
                                for (int i = 0; i < listquanco.Count; i++)
                                {
                                    if (listquanco[i].Dong == list[item].Dong && listquanco[i].Cot == list[item].Cot)
                                    {
                                        if (list[item].Sohuu == 1)
                                            listquanco[i].Sohuu = 2;
                                        else
                                            listquanco[i].Sohuu = 1;
                                    }
                                }
                            }
                            else
                            {
                                if (kiemtradoc.Count == 2 && kiemtranghang.Count == 2 && kiemtracheonguoc.Count == 2 && kiemtracheoxuoi.Count == 2)
                                {
                                    for (int i = 0; i < listquanco.Count; i++)
                                    {
                                        if (listquanco[i].Dong == list[item].Dong && listquanco[i].Cot == list[item].Cot)
                                        {
                                            if (list[item].Sohuu == 1)
                                                listquanco[i].Sohuu = 2;
                                            else
                                                listquanco[i].Sohuu = 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (list[item].Dong == 0 || list[item].Dong == ban_Co.Sodong)
                    {
                        kiemtradoc = kiemtraDoc(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        kiemtranghang = kiemtraNgang(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        kiemtracheoxuoi = kiemTraCheoXuoi(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        kiemtracheonguoc = kiemTraCheoNguoc(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);

                        if (kiemtradoc.Count == 1 && kiemtranghang.Count == 2)
                        {
                            for (int i = 0; i < listquanco.Count; i++)
                            {
                                if (listquanco[i].Dong == list[item].Dong && listquanco[i].Cot == list[item].Cot)
                                {
                                    if (list[item].Sohuu == 1)
                                        listquanco[i].Sohuu = 2;
                                    else
                                        listquanco[i].Sohuu = 1;
                                }
                            }
                        }
                    }
                    if (list[item].Cot == 0 || list[item].Cot == ban_Co.SoCot)
                    {
                        kiemtradoc = kiemtraDoc(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        kiemtranghang = kiemtraNgang(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        kiemtracheoxuoi = kiemTraCheoXuoi(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        kiemtracheonguoc = kiemTraCheoNguoc(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);

                        if (kiemtradoc.Count == 2 && kiemtranghang.Count == 1)
                        {
                            for (int i = 0; i < listquanco.Count; i++)
                            {
                                if (listquanco[i].Dong == list[item].Dong && listquanco[i].Cot == list[item].Cot)
                                {
                                    if (list[item].Sohuu == 1)
                                        listquanco[i].Sohuu = 2;
                                    else
                                        listquanco[i].Sohuu = 1;
                                }
                            }
                        }
                    }
                    clearnList();
                    if (list[item].Dong == 0 && (list[item].Cot == 0 || list[item].Cot == ban_Co.SoCot))
                    {
                        kiemtradoc = kiemtraDoc(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        kiemtranghang = kiemtraNgang(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        kiemtracheoxuoi = kiemTraCheoXuoi(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        kiemtracheonguoc = kiemTraCheoNguoc(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);

                        if (kiemtradoc.Count == 1 && kiemtranghang.Count == 1 && (kiemtracheoxuoi.Count == 1 || kiemtracheonguoc.Count == 1))
                        {
                            for (int i = 0; i < listquanco.Count; i++)
                            {
                                if (listquanco[i].Dong == list[item].Dong && listquanco[i].Cot == list[item].Cot)
                                {
                                    if (list[item].Sohuu == 1)
                                        listquanco[i].Sohuu = 2;
                                    else
                                        listquanco[i].Sohuu = 1;
                                }
                            }
                        }
                    }
                    if (list[item].Dong == ban_Co.Sodong && (list[item].Cot == 0 || list[item].Cot == ban_Co.SoCot))
                    {
                        kiemtradoc = kiemtraDoc(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        kiemtranghang = kiemtraNgang(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        kiemtracheoxuoi = kiemTraCheoXuoi(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        kiemtracheonguoc = kiemTraCheoNguoc(listquanco, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        if (kiemtradoc.Count == 1 && kiemtranghang.Count == 1 && (kiemtracheoxuoi.Count == 1 || kiemtracheonguoc.Count == 1))
                        {

                            for (int i = 0; i < listquanco.Count; i++)
                            {
                                if (listquanco[i].Dong == list[item].Dong && listquanco[i].Cot == list[item].Cot)
                                {
                                    if (list[item].Sohuu == 1)
                                        listquanco[i].Sohuu = 2;
                                    else
                                        listquanco[i].Sohuu = 1;
                                }
                            }
                        }
                    }

                }
                for (int item = 0; item < list.Count - 1; item++)
                {
                    for (int j = item + 1; j < list.Count; j++)
                    {
                        if ((list[item].Dong == list[j].Dong && list[item].Cot > list[j].Cot) ||
                            (list[item].Dong > list[j].Dong && list[item].Cot == list[j].Cot) ||
                            (list[item].Dong > list[j].Dong && list[item].Cot > list[j].Cot))
                        {
                            Oco arr = list[item];
                            list[item] = list[j];
                            list[j] = arr;
                        }
                    }
                }
                List<Oco> abc = new List<Oco>();
                if (list.Count == 2) {
                    for (int item = 0; item < list.Count - 1; item++)
                    {

                        if (list[item].Dong == list[item + 1].Dong || list[item].Cot == list[item + 1].Cot)
                        {

                            abc.Add(list[item]);
                            abc.Add(list[item + 1]);
                        }

                    }
                }
                Oco asdasd = findBestMove(_arrayChess);
                Console.WriteLine(" lay dong  " + asdasd.Dong);
                Console.WriteLine(" lay cot  " + asdasd.Cot);
                graphics.Clear(panel_co_ganh.BackColor);
                ban_Co.banco(graphics);
                velaiquanco(graphics);
                kiemtrasoquan();
                danhco = false;
                luotdis();



            }
        }
        private void clearnList()
        {
            ListCoThat.Clear();
        }
        private void velaiquanco(Graphics graphics)
        {
            foreach (Oco oco in listquanco)
            {
                if (oco.Sohuu == 1)
                    ban_Co.veQuanCo(graphics, oco.Vitri, solidBack);
                else
                     if (oco.Sohuu == 2)
                    ban_Co.veQuanCo(graphics, oco.Vitri, solidWhite);
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listquanco = new List<Oco>();
            graphics.Clear(panel_co_ganh.BackColor);
            ban_Co.banco(graphics);
            velaiquanco(graphics);
            khoitaomangoco();
            khoitaoquanco();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playerVsPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listquanco = new List<Oco>();
            graphics.Clear(panel_co_ganh.BackColor);
            ban_Co.banco(graphics);
            velaiquanco(graphics);
            khoitaomangoco();
            khoitaoquanco();
            luotdis();

        }
        private void btnPP_Click(object sender, EventArgs e)
        {
            newGame newGame = new newGame();
            newGame.Show();
            listquanco = new List<Oco>();
            graphics.Clear(panel_co_ganh.BackColor);
            ban_Co.banco(graphics);
            velaiquanco(graphics);
            khoitaomangoco();
            khoitaoquanco();
            if (Application.OpenForms.OfType<newGame>().Any())
                timer1.Start();
            else
                timer1.Stop();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region kiem tra hang ngang
        private List<Oco> kiemtraNgang(List<Oco> oco, int dong, int cot, int lastsohuu)
        {
            List<Oco> checknganng = new List<Oco>();
            for (int i = 0; i < oco.Count; i++)
            {
                if (oco[i].Dong == dong)
                {
                    if (oco[i].Cot == cot - 1 && oco[i].Sohuu != lastsohuu)
                    {
                        checknganng.Add(oco[i]);
                    }
                    if (oco[i].Cot == cot + 1 && oco[i].Sohuu != lastsohuu)
                    {
                        checknganng.Add(oco[i]);
                    }
                }
            }

            return checknganng;
        }
        #endregion
        #region kiem tra hàng dọc
        private List<Oco> kiemtraDoc(List<Oco> oco, int dong, int cot, int lastsohuu)
        {
            List<Oco> checkDoc = new List<Oco>();
            for (int i = 0; i < oco.Count; i++)
            {
                if (oco[i].Cot == cot)
                {
                    if (oco[i].Dong == dong - 1 && oco[i].Sohuu != lastsohuu)
                    {
                        checkDoc.Add(oco[i]);
                    }
                    if (oco[i].Dong == dong + 1 && oco[i].Sohuu != lastsohuu)
                    {
                        checkDoc.Add(oco[i]);
                    }
                }
            }
            return checkDoc;
        }
        #endregion
        #region kiêm tra chéo
        private List<Oco> kiemTraCheoXuoi(List<Oco> oco, int dong, int cot, int lastsohuu)
        {
            List<Oco> ktCheoxuoi = new List<Oco>();
            for (int i = 0; i < oco.Count; i++)
            {
                if ((cot + dong) % 2 == 0)
                {
                    if ((cot - oco[i].Cot) == 1 && (dong - oco[i].Dong) == 1 && oco[i].Sohuu != lastsohuu)
                    {
                        ktCheoxuoi.Add(oco[i]);
                    }

                    if ((oco[i].Cot - cot) == 1 && (oco[i].Dong - dong) == 1 && oco[i].Sohuu != lastsohuu)
                    {
                        ktCheoxuoi.Add(oco[i]);
                    }
                }
            }
            return ktCheoxuoi;
        }
        private List<Oco> kiemTraCheoNguoc(List<Oco> oco, int dong, int cot, int lastsohuu)
        {
            List<Oco> ktCheonguoc = new List<Oco>();
            for (int i = 0; i < oco.Count; i++)
            {
                if ((cot + dong) % 2 == 0)
                {
                    if ((cot - oco[i].Cot) == 1 && (oco[i].Dong - dong) == 1 && oco[i].Sohuu != lastsohuu)
                    {
                        ktCheonguoc.Add(oco[i]);
                    }

                    if ((oco[i].Cot - cot) == 1 && (dong - oco[i].Dong) == 1 && oco[i].Sohuu != lastsohuu)
                    {
                        ktCheonguoc.Add(oco[i]);
                    }
                }
            }
            return ktCheonguoc;
        }
        #endregion
        #region kiểm tra chiến thắng
        private void kiemtrasoquan()
        {
            for (int i = 0; i < listquanco.Count; i++)
            {
                if (listquanco[i].Sohuu == 1)
                    demQuanĐen++;
                else
                    demQuanTrang++;
            }
            lbsoquanden.Text = demQuanĐen.ToString();
            lbsoquantrang.Text = demQuanTrang.ToString();
            if (demQuanĐen == 16)
            {
                MessageBox.Show("Người chơi " + tennguoi1 + " thắng !");
                return;
            }
            if (demQuanTrang == 16)
            {
                MessageBox.Show("Người chơi " + tennguoi2 + " thắng !");
                return;
            }
            demQuanTrang = 0;
            demQuanĐen = 0;
        }
        #endregion
        private void layViTri(int row, int dong, int cot)
        {
            if (listquanco[row].Dong == dong && listquanco[row].Cot == cot)
            {
                lastDong = dong;
                lastcot = cot;
                lastsohuu = listquanco[row].Sohuu;
                if (luotdi == lastsohuu)
                {
                    danhco = false;
                }
                else
                    danhco = true;
            }
        }
        public void luotdis()
        {
            if (luotdi == 1)
            {
                pcbTrang.Visible = true;
                pcbĐen.Visible = false;
            }
            else
            {
                pcbTrang.Visible = false;
                pcbĐen.Visible = true;
            }
            tengnuoichoi1.Text = tennguoi1.ToString();
            tenguoichoi2.Text = tennguoi2.ToString();
        }

        private void kiemtraHetnuoc(int i, int dong, int cot)
        {
            if (listquanco[i].Dong == dong)
            {
                if (listquanco[i].Cot == cot - 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    list.Add(listquanco[i]);
                }
                if (listquanco[i].Cot == cot + 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    list.Add(listquanco[i]);
                }
            }
            if (listquanco[i].Cot == cot)
            {
                if (listquanco[i].Dong == dong - 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    list.Add(listquanco[i]);
                }
                if (listquanco[i].Dong == dong + 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    list.Add(listquanco[i]);
                }
            }
            if ((cot + dong) % 2 == 0)
            {
                if ((cot - listquanco[i].Cot) == 1 && (dong - listquanco[i].Dong) == 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    list.Add(listquanco[i]);
                }

                if ((listquanco[i].Cot - cot) == 1 && (listquanco[i].Dong - dong) == 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    list.Add(listquanco[i]);
                }

                if ((cot - listquanco[i].Cot) == 1 && (listquanco[i].Dong - dong) == 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    list.Add(listquanco[i]);
                }

                if ((listquanco[i].Cot - cot) == 1 && (dong - listquanco[i].Dong) == 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    list.Add(listquanco[i]);
                }
            }
        }
        private void kiemtraLienKe(int i, int dong, int cot, int sohuu)
        {
            if (listquanco[i].Dong == dong)
            {
                if (listquanco[i].Cot == cot - 1 && listquanco[i].Sohuu == sohuu)
                {
                    listQuanKeNhau.Add(listquanco[i]);
                }
                if (listquanco[i].Cot == cot + 1 && listquanco[i].Sohuu == sohuu)
                {
                    listQuanKeNhau.Add(listquanco[i]);
                }
            }
            if (listquanco[i].Cot == cot)
            {
                if (listquanco[i].Dong == dong - 1 && listquanco[i].Sohuu == sohuu)
                {
                    listQuanKeNhau.Add(listquanco[i]);
                }
                if (listquanco[i].Dong == dong + 1 && listquanco[i].Sohuu == sohuu)
                {
                    listQuanKeNhau.Add(listquanco[i]);
                }
            }
            if ((cot + dong) % 2 == 0)
            {
                if ((cot - listquanco[i].Cot) == 1 && (dong - listquanco[i].Dong) == 1 && listquanco[i].Sohuu == sohuu)
                {
                    listQuanKeNhau.Add(listquanco[i]);
                }

                if ((listquanco[i].Cot - cot) == 1 && (listquanco[i].Dong - dong) == 1 && listquanco[i].Sohuu == sohuu)
                {
                    listQuanKeNhau.Add(listquanco[i]);
                }

                if ((cot - listquanco[i].Cot) == 1 && (listquanco[i].Dong - dong) == 1 && listquanco[i].Sohuu == sohuu)
                {
                    listQuanKeNhau.Add(listquanco[i]);
                }

                if ((listquanco[i].Cot - cot) == 1 && (dong - listquanco[i].Dong) == 1 && listquanco[i].Sohuu == sohuu)
                {
                    listQuanKeNhau.Add(listquanco[i]);
                }
            }
        }
        private void btnPC_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int randomIndex = rd.Next(0, 15);
            int cot = listquanco[randomIndex].Cot;
            int dong = listquanco[randomIndex].Dong;
            if (listquanco[randomIndex].Sohuu == 1)
                ban_Co.veQuanCo(graphics, listquanco[randomIndex].Vitri, solidWhite);

            Console.WriteLine(dong + " + " + cot);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            luotdis();
        }


        #region thuật toán kìm kiếm


        bool isMovesLeft(Oco[,] board)
        {
            for (int i = 0; i <= 4; i++)
                for (int j = 0; j <= 4; j++)
                    if (board[i, j].Sohuu == 0)
                        return true;
            return false;
        }

        int evaluate(Oco[,] b)
        {
            clearnList();
            int demngang = 0;
            int demcot = 0;
            int demcheoxuoi = 0;
            int demnguoc = 0;
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    if (b[i, j].Dong == i)
                    {
                        if (b[i, j].Cot == j - 1 && b[i, j].Sohuu != 2)
                            demngang++;
                        if (b[i, j].Cot == j + 1 && b[i, j].Sohuu != 2)
                            demngang++;
                    }
                    if (b[i,j].Cot == j)
                    {
                        if (b[i, j].Dong == i - 1 && b[i, j].Sohuu != 2)
                            demcot++;
                        if (b[i, j].Dong == i + 1 && b[i, j].Sohuu != 2)
                            demcot++;
                    }
                    if ((i + j) % 2 == 0)
                    {
                        if ((j - b[i, j].Cot) == 1 && (i - b[i, j].Dong) == 1 && b[i, j].Sohuu != 2)
                            demcheoxuoi++;
                        if ((b[i, j].Cot - j) == 1 && (b[i, j].Dong - i) == 1 && b[i, j].Sohuu != 2)
                            demcheoxuoi++;
                        if ((j - b[i, j].Cot) == 1 && (b[i, j].Dong - i) == 1 && b[i, j].Sohuu != 2)
                            demnguoc++;
                        if ((b[i,j].Cot - j) == 1 && (i - b[i,j].Dong) == 1 && b[i,j].Sohuu != 2)
                            demnguoc++;                      
                    }
                }
            }
            Console.Write(" -----------------------------   \n" );
            if (demngang == 2)
                return -10;
            else
                return +10;
            //kiem tra cot
            if (demcot == 2)
                return -10;
            else
                return +10;
            if (demnguoc == 2)
                return -10;
            else
                return +10;
            //kiem tra cot
            if (demnguoc == 2)
                return -10;
            else
                return +10;
            return 0;


        }

        int minimax(Oco[,] board, int depth, bool isMax)
        {
            int score = evaluate(board);

            if (score == +10)
                return score;

            if (score == -10)
                return score;

            if (isMovesLeft(board) == false)
                return 0;

            if (isMax)
            {
                int best = -1000;

                for (int i = 0; i <= 4; i++)
                {
                    for (int j = 0; j <= 4; j++)
                    {

                        if (board[i,j].Sohuu == 0)
                        {
 
                            board[i,j].Sohuu = 2;

                            best = Math.Max(best,
                                minimax(board, depth + 1, !isMax));

                            board[i,j].Sohuu = 0;
                        }
                    }
                }
                return best;
            }


            else
            {
                int best = 1000;

                for (int i = 0; i <= 4; i++)
                {
                    for (int j = 0; j <= 4; j++)
                    {

                        if (board[i,j].Sohuu == 0)
                        {
  
                            board[i,j].Sohuu = 1;

                            best = Math.Min(best,
                                   minimax(board, depth + 1, !isMax));


                            board[i,j].Sohuu = 0;
                        }
                    }
                }
                return best;
            }
        }
        Oco findBestMove(Oco[,] board)
        {
            int bestVal = -1000;
            Oco bestMove = new Oco();
            bestMove.Dong = -1;
            bestMove.Cot = -1;

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {

                    if (board[i,j].Sohuu == 0)
                    {
                        board[i,j].Sohuu = 1;
                        int moveVal = minimax(board, 0, false);

                        board[i,j].Sohuu = 0;
                      
                        if (moveVal > bestVal)
                        {
                                bestMove.Dong = i;
                                bestMove.Cot = j;
                                bestVal = moveVal;
                        }
                    }
                }
            }
            
            return bestMove;
        }
        #endregion

    }
}
