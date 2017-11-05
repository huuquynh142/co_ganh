using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co_ganh
{

    class Ban_co
    {
        private int _sodong= 4;
        private int _socot  = 4;
        private int khoitao = 40;
        public int Sodong
        {
            get { return _sodong; }
        }
        public int SoCot
        {
            get { return _socot; }
        }
        public void banco(Graphics graphics)
        {
            int demcot = 0;
            int demdong = 0;
            for (int i = 0; i <= _socot; i++)
            {

                if (i == 0)
                    graphics.DrawLine(veBanCo(), khoitao, khoitao, khoitao, _sodong * Oco._chieuCao + 38);
                else
                {
                    demcot++;
                    graphics.DrawLine(veBanCo(), i * Oco._chieuRong + khoitao - demcot, khoitao,
                        i * Oco._chieuRong + khoitao - demcot, _sodong * Oco._chieuCao + khoitao - demcot);
                }
            }
            for (int j = 0; j <= _sodong; j++)
            {
                
                if (j==0)
                    graphics.DrawLine(veBanCo(), khoitao, khoitao, _socot * Oco._chieuRong + 38 , khoitao);
                else { 
                    demdong++;
                graphics.DrawLine(veBanCo(), khoitao, j*Oco._chieuCao + khoitao - demdong,
                    _socot*Oco._chieuRong + khoitao - demdong, j*Oco._chieuCao + khoitao - demdong);
                }
            }
            graphics.DrawLine(veBanCo(), khoitao, khoitao, 4 * Oco._chieuRong + 37, 4 * Oco._chieuCao + 37);
            graphics.DrawLine(veBanCo(), khoitao, 4 * 120 + 38, 4 * Oco._chieuRong + 38, khoitao);
            graphics.DrawLine(veBanCo(), 2* Oco._chieuRong + 37 , khoitao, _socot * Oco._chieuRong + 37, 2 * Oco._chieuCao + 37);
            graphics.DrawLine(veBanCo(), 2 * Oco._chieuRong + 37, khoitao, khoitao, 2 * Oco._chieuCao + 38);
            graphics.DrawLine(veBanCo(), khoitao, 2 * 120 + 38, 2 * Oco._chieuRong + 37, _sodong * Oco._chieuCao + 37);
            graphics.DrawLine(veBanCo(), 2 * Oco._chieuRong + 37, _sodong * Oco._chieuCao + 37,
                _socot * Oco._chieuRong + 37, 2 * Oco._chieuCao + 37);
            
        }
        public void veQuanCo(Graphics gp , Point point , SolidBrush solidBrush)
        {
            gp.FillEllipse(solidBrush,point.X,point.Y , 50 , 50);
        }
        private Pen veBanCo()
        {
            return new Pen(Color.Red ,2f);
        }
           
    }
}
