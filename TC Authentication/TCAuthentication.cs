using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_Authentication
{
    public class TCAuthentication
    {

        public static bool Authentication(string IdentificationNumber)
        {
            if (NumberCountControl(IdentificationNumber))
                if (NumberControl(Convert.ToInt32(IdentificationNumber[0]), Convert.ToInt32(IdentificationNumber[10])))
                    if (TenthNumberCheck(IdentificationNumber))
                        if (EleventhCheck(IdentificationNumber))
                            return true;
                        else
                            return false;
                    else
                        return false;
                else
                    return false;
            else
                return false;
        }
        
        public static bool NumberCountControl(string IdentificationNumber)
        {
            if (IdentificationNumber.Length == 11)
                return true;
            else
                return false;
        }

       
        public static bool NumberControl(int FirstNumber,int LastNumber)
        {
            if (FirstNumber != 0 && LastNumber%2==0)
                return true;
            else
                return false;
        }

        public static bool TenthNumberCheck(string IdentificationNumber)
        {
            int TotalTek = 0, TotalCift = 0;
            for (int i = 0; i < 9; i++)
                if (i % 2 == 0)
                    TotalTek += Convert.ToInt32(IdentificationNumber[i]);
                else
                    TotalCift += Convert.ToInt32(IdentificationNumber[i]);
          
            if ((((TotalTek * 7) - TotalCift) % 10) == Convert.ToInt32(IdentificationNumber[9]))
                return true;
            else
                return false;
        }

        public static bool EleventhCheck(string IdentificationNumber)
        {
            int Total = 0;
            for (int i = 0; i < 10; i++)
                Total += Convert.ToInt32(IdentificationNumber[i]);
            if (Total % 10 == Convert.ToInt32(IdentificationNumber[10]))
                return true;
            else
                return false;
        }
    }
}
