using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    static class Schemes
    {
        public static string Intro = "_________________________________________________________________________\n"+
            "                                    |\n" +
            "BOEING 777                          |\n" +
            "Composite Pattern                   |\n" +
            "                                  .-'-.\n" +
            "                                 ' ___ '\n" +
            "                       ---------'  .-.  '---------\n" +
            "       _________________________'  '-'  '_________________________\n" +
            "        ''''''-|---|--/    \\==][^',_m_,'^][==/    \\--|---|-''''''\n" +
            "                      \\    /  ||/   H   \\||  \\    /\n" +
            "                       '--'   OO   O|O   OO   '--'\n"+
            "_________________________________________________________________________";

        private static string _weightScheme = "\n__________________________________________________________________________________________________________________________________\n" +
            "                                                                                                         ********\n" +
            "                                                                                                        *      *\n" +
            "                                                                                                       *      *\n" +
            "      *******|**********|***********|***********|************|************|****************************      *\n" +
            "    *  (  )  |Pilots:   |Stewardess:|First Cl:  |Business Cl:|Economy Cl: |   () () () () () ()            *\n" +
            "  *          |{0}|{1}|{2}|{3}|{4}|*        *                    *\n" +
            " *           |          |           |           |            |            |  *        *                *\n" +
            "*************|**********|***********|***********|************|************|************************* \n" +
            "                                                            *         *\n" +
            "                                                             *         * \n" +
            "                                                              *         *\n" +
            "                                                                **********\n" +
            "Summary: {5}"+
            "\n__________________________________________________________________________________________________________________________________\n";

        public static string WeightScheme(WeightCard weightCard)
        {
            string pilots = ConvertToStringWithSize(weightCard.PilotWeight, 10);
            string stewardess = ConvertToStringWithSize(weightCard.StewardessWeight, 11);
            string firstClass = ConvertToStringWithSize(weightCard.FirstClassWeight, 11);
            string businessCl = ConvertToStringWithSize(weightCard.BusinessClassWeight, 12);
            string economyCl = ConvertToStringWithSize(weightCard.EconomyClassWeight, 12);
            string summary = Math.Round(weightCard.GetSummaryWeight()).ToString();
            return String.Format(_weightScheme, pilots, stewardess, firstClass, businessCl, economyCl, summary);
        }
        private static string ConvertToStringWithSize(float value, int size)
        {
            string result = Math.Round(value).ToString();
            int resLen = result.Length;
            if (result.Length < size)
            {
                string newRes = "";
                for (int i = 0; i < size-resLen; i++)
                {
                    newRes += " ";
                }
                result = newRes += result;
            }
            else if(result.Length > size)
            {
                result = result.Substring(0, size);
            }
                
            return result;
        }
    }


}
