using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co_ganh
{
    class KiemTra
    {
        public Boolean cothedichuyen( int lastDong , int lastCot , int currenDong , int currenCot , int currenSohuu)
        { 
            if(currenSohuu == 0)
            {
                if ((Math.Abs(currenDong - lastDong) == 0 || Math.Abs(currenDong - lastDong) == 1)
                    && (Math.Abs(currenCot - lastCot) == 0 || Math.Abs(currenCot - lastCot) == 1)) {
                    if ((lastDong + lastCot) % 2 != 0)
                    {
                        if ((currenDong + currenCot) % 2 == 0)
                            return true;
                        else
                            return false;
                    }
                    return true;
                }
            }
           
             return false;
        }
        
    }
}
