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
        private List<Oco> listcot;
        private List<Oco> listdong;
        private List<Oco> listcheoxuoi;
        private List<Oco> listcheonguoc;
        private List<Oco> ListCoThat;
        private List<Oco> list;
        private List<Oco> listQuanKeNhau;
        private Boolean danhco = false;
        private  int lastDong = 0;
        private  int lastcot = 0;
        private  int lastsohuu = 0;
        int demQuanTrang = 0;
        int demQuanĐen = 0;
        KiemTra check;
        public static String tennguoi1 = "";
        public static String tennguoi2 = "";
        public static int luotdi = 1 ;
        private Boolean canMove = true;
        public coghanh()
        {
            _arrayChess = new Oco[5, 5];
            listquanco = new List<Oco>();
            listcot = new List<Oco>();
            listdong = new List<Oco>();
            listcheoxuoi = new List<Oco>();
            listcheonguoc = new List<Oco>();
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
            for(int i= 0 ; i <= ban_Co.Sodong; i++)
            {
                for(int j = 0; j <= ban_Co.SoCot; j++)
                {
                    _arrayChess[i,j] = new Oco(i,j,new Point(j * Oco._chieuRong + 15 , i * Oco._chieuCao + 15) , 0);
                }
            }
        }
        public bool DanhCo(int MouseX , int MouseY , Graphics gp , int sohuu)
        {
            if (MouseX % (Oco._chieuRong) == 0 || MouseY % (Oco._chieuCao ) ==0)
                return false;
            int cot = MouseX / (Oco._chieuRong );
            int dong = MouseY / (Oco._chieuCao );
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
                        if ( i > 0 && i < 2)
                            Nguoichoi1(i, j);
                        else
                            if (i > 1 && i < ban_Co.Sodong)
                                nguoichoi2(i, j);            
                }
            }
        }
        private void Nguoichoi1(int i , int j)
        {
            _arrayChess[i, j].Sohuu = 1;
            ban_Co.veQuanCo(graphics, _arrayChess[i, j].Vitri, solidBack);
            listquanco.Add(_arrayChess[i, j]);
        }

        private void nguoichoi2(int i , int j)
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

            if (!danhco)
            {
                for (int row = 0; row < listquanco.Count; row++)
                {
                    layViTri(row, currnetdong, currentcot);      
                }
            }else          
            { 
                for (int row = 0; row < listquanco.Count; row++)
                {
                    if (listquanco[row].Dong == currnetdong && listquanco[row].Cot == currentcot )
                    {
                        currensohuu = listquanco[row].Sohuu;
                    }
                }
                if (check.cothedichuyen(lastDong, lastcot, currnetdong, currentcot , currensohuu))
                {
                    for (int row = 0; row < listquanco.Count; row++)
                    {
                        if (listquanco[row].Dong == lastDong && listquanco[row].Cot == lastcot)
                        {
                            listquanco.RemoveAt(row);
                            DanhCo(e.X, e.Y, graphics, lastsohuu);
                            for (int i = 0; i < listquanco.Count; i++)
                            {
                                kiemtraDoc(i, currnetdong, currentcot, lastsohuu);
                                kiemtraNgang(i, currnetdong, currentcot , lastsohuu);
                                kiemTraCheo(i, currnetdong, currentcot, lastsohuu);  
                            }

                        }    
                    }
                    
                }
                anCo();
                for (int row = 0; row < listquanco.Count; row++)
                {
                    if (listquanco[row].Dong == currnetdong && listquanco[row].Cot == currentcot)
                    {
                        for (int i = 0; i < listquanco.Count; i++)
                        {
                            kiemtraHetnuoc(i, currnetdong, currentcot);
                           // kiemtraLienKe(i, currnetdong, currentcot);
                        }

                    }
                }
                clearnList();
                Console.WriteLine("\n\n+++++++++++++++++++++++++++++++++++++++\n\n");
                for (int item = 0; item < list.Count; item++)
                {
                    Console.WriteLine("---------doi phuong doi phuong doi phuong doi phuong--------           " + list[item].Dong + "   " + list[item].Cot);


                }
               /* Console.WriteLine("\n\n+++++++++++++++++++++++++++++++++++++++\n\n");
                for (int item = 0; item < listQuanKeNhau.Count; item++)
                {
                    Console.WriteLine("---------lien ke lien ke lien ke lien ke lien ke--------           " + listQuanKeNhau[item].Dong + "   " + listQuanKeNhau[item].Cot);


                }*/
                for (int item = 0; item < list.Count; item++)
                {
                    if (list[item].Dong > 0 && list[item].Dong < ban_Co.Sodong && list[item].Cot > 0 && list[item].Cot < ban_Co.SoCot)
                    {
                        for (int i = 0; i < listquanco.Count; i++)
                        {
                            kiemtraDoc(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                            kiemtraNgang(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                            kiemTraCheo(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        }

                        if (listcot.Count == 2 && listdong.Count == 2 && listcheonguoc.Count == 0 && listcheoxuoi.Count == 0)
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
                            if (listcot.Count == 2 && listdong.Count == 2 && listcheonguoc.Count == 2 && listcheoxuoi.Count == 0)
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
                                if (listcot.Count == 2 && listdong.Count == 2 && listcheonguoc.Count == 2 && listcheoxuoi.Count == 2)
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
                   if(list[item].Dong == 0 || list[item].Dong == ban_Co.Sodong)
                    {
                        for (int i = 0; i < listquanco.Count; i++)
                        {
                            kiemtraDoc(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                            kiemtraNgang(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                            kiemTraCheo(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        }
                        //Console.WriteLine("-------ddddddddddddd dong 0---------- " + listcot.Count);
                        //Console.WriteLine("-------ccccccccccccc dong 0---------- " + listdong.Count);
                        if (listcot.Count == 1 && listdong.Count == 2 )
                        {
                                Console.WriteLine("------------------------------           "  + list[item].Dong + "   " + list[item].Cot);
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
                        for (int i = 0; i < listquanco.Count; i++)
                        {
                            kiemtraDoc(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                            kiemtraNgang(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                            kiemTraCheo(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        }
                       // Console.WriteLine("-------ddddddddddddd cot 0---------- "+ listcot.Count);
                       // Console.WriteLine("-------ccccccccccccc cot 0---------- " + listdong.Count);
                        if (listcot.Count == 2 && listdong.Count == 1)
                        {
                                Console.WriteLine("------------------------------           " + list[item].Dong + "   " + list[item].Cot);
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
                    if (list[item].Dong == 0 && ( list[item].Cot == 0 || list[item].Cot == ban_Co.SoCot))
                    {
                        for (int i = 0; i < listquanco.Count; i++)
                        {
                            kiemtraDoc(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                            kiemtraNgang(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                            kiemTraCheo(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        }
                        //Console.WriteLine("-------ddddddddddddd goc 0---------- " + listcot.Count);
                        //Console.WriteLine("-------ccccccccccccc goc 0---------- " + listdong.Count);
                        if (listcot.Count == 1 && listdong.Count == 1 && (listcheoxuoi.Count == 1 || listcheonguoc.Count == 1))
                        {
                            Console.WriteLine("------------------------------           " + list[item].Dong + "   " + list[item].Cot);
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
                        for (int i = 0; i < listquanco.Count; i++)
                        {
                            kiemtraDoc(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                            kiemtraNgang(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                            kiemTraCheo(i, list[item].Dong, list[item].Cot, list[item].Sohuu);
                        }
                       // Console.WriteLine("-------ddddddddddddd goc 4---------- " + listcot.Count);
                        //Console.WriteLine("-------ccccccccccccc goc 4---------- " + listdong.Count);
                        if (listcot.Count == 1 && listdong.Count == 1 && (listcheoxuoi.Count == 1 || listcheonguoc.Count == 1))
                        {
                            Console.WriteLine("------------------------------           " + list[item].Dong + "   " + list[item].Cot);
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
                for (int item = 0; item < list.Count -1; item++)
                {
                    for(int j =  item + 1; j < list.Count; j++)
                    {
                        if((list[item].Dong == list[j].Dong && list[item].Cot > list[j].Cot) ||
                            (list[item].Dong > list[j].Dong && list[item].Cot == list[j].Cot) ||
                            (list[item].Dong > list[j].Dong && list[item].Cot > list[j].Cot))
                        {
                            Oco  arr = list[item];
                            list[item] = list[j];
                            list[j] = arr;
                        }
                    }
                }
                for (int item = 0; item < list.Count; item++)
                {
                    Console.WriteLine("mang sau khi sap xp --------------    " + list[item].Dong + " " + list[item].Cot);
                }
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
            listcot.Clear();
            listdong.Clear();
            listcheoxuoi.Clear();
            listcheonguoc.Clear();
            ListCoThat.Clear();
        }
        private void velaiquanco(Graphics graphics)
        {
            foreach (Oco oco in listquanco)
            {
                if(oco.Sohuu == 1)
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
           // Bitmap bitmap = new Bitmap(co_ganh.Properties.Resources.banco);
            //panel_co_ganh.BackgroundImage = bitmap;
            ban_Co.banco(graphics);
            velaiquanco(graphics);
            khoitaomangoco();
            khoitaoquanco();
           // MessageBox.Show("Trắng đi trước ! ");
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
        private void kiemtraNgang(int i , int dong , int cot ,int lastsohuu)
        {
            if (listquanco[i].Dong == dong)
            {
                if (listquanco[i].Cot == cot - 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    listdong.Add(listquanco[i]);
                }
                if (listquanco[i].Cot == cot + 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    listdong.Add(listquanco[i]);
                }
            }
        }
        private void kiemtraDoc(int i, int dong, int cot ,int lastsohuu)
        {
            if (listquanco[i].Cot == cot)
            {
                if (listquanco[i].Dong == dong - 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    listcot.Add(listquanco[i]);
                }
                if (listquanco[i].Dong == dong + 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    listcot.Add(listquanco[i]);
                }
            }
        }
        private void kiemTraCheo(int i , int dong , int cot ,int lastsohuu)
        {
            if ((cot + dong) % 2 == 0)
            {
                if ((cot - listquanco[i].Cot) == 1 && (dong - listquanco[i].Dong) == 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    listcheoxuoi.Add(listquanco[i]);
                }

                if ((listquanco[i].Cot - cot) == 1 && (listquanco[i].Dong - dong) == 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    listcheoxuoi.Add(listquanco[i]);
                }

                if ((cot - listquanco[i].Cot) == 1 && (listquanco[i].Dong - dong) == 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    listcheonguoc.Add(listquanco[i]);
                }

                if ((listquanco[i].Cot - cot) == 1 && (dong - listquanco[i].Dong) == 1 && listquanco[i].Sohuu != lastsohuu)
                {
                    listcheonguoc.Add(listquanco[i]);
                }
            }
        }
        private void anCo()
        {
            if (listcot.Count == 2)
                for (int i = 0; i < listcot.Count; i++)
                {
                    listcot[i].Sohuu = lastsohuu;
                    luotdi = lastsohuu;
                    canMove = true;
                }

            if (listdong.Count == 2)
                for (int i = 0; i < listdong.Count; i++)
                {
                    listdong[i].Sohuu = lastsohuu;
                    luotdi = lastsohuu;
                }
            
            if (listcheoxuoi.Count == 2)
                for (int i = 0; i < listcheoxuoi.Count; i++)
                {
                    listcheoxuoi[i].Sohuu = lastsohuu;
                    luotdi = lastsohuu;
                }
            if (listcheonguoc.Count == 2)
                for (int i = 0; i < listcheonguoc.Count; i++)
                {
                    listcheonguoc[i].Sohuu = lastsohuu;
                    luotdi = lastsohuu;
                }
        }
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
                MessageBox.Show("Người chơi " + tennguoi2+ " thắng !");
                return;
            }           
            demQuanTrang = 0;
            demQuanĐen = 0;  
        }
        private void layViTri(int row , int dong , int cot)
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
      
        private void kiemtraHetnuoc(int i , int dong , int cot )
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
        private void kiemtraLienKe(int i, int dong, int cot , int sohuu)
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
            if(listquanco[randomIndex].Sohuu == 1 )
            ban_Co.veQuanCo(graphics, listquanco[randomIndex].Vitri, solidWhite);
            
            Console.WriteLine(dong + " + " + cot);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            luotdis();
        }
    }
}
