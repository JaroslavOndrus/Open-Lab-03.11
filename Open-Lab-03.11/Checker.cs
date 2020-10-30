using NUnit.Framework.Internal;
using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string strOpacne = "";
            int dlzka = str.Length;
            for(int i = dlzka - 1; i >= 0; i--)
            {
                strOpacne = strOpacne + str[i].ToString();
            }

            if(str == strOpacne)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
