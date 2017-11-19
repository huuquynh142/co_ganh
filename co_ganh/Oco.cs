using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co_ganh
{
    class Oco
    {
        public const int _chieuRong = 120;
        public const int _chieuCao = 120;
        private int _dong;
        private int _cot;
        private Point _vitri;
        private int _sohuu;

        public int Dong
        {
            get { return _dong; }
            set { _dong = value; }
        }
        public int Cot
        {
            get { return _cot; }
            set { _cot = value; }
        }
        public Point Vitri
        {
            get { return _vitri; }
            set { _vitri = value; }
        }
        public int Sohuu
        {
            get { return _sohuu; }
            set { _sohuu = value; }
        }
        public Oco(int dong, int cot, Point vitri, int sohuu)
        {
            this._cot = cot;
            this._dong = dong;
            this._sohuu = sohuu;
            this._vitri = vitri;
        }

        public Oco()
        {
        }
    }
}
