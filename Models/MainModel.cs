using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XO_WebApp.Models
{
    public class MainModel
    {
        public string Action = "SinglePlayer";
        public string xo="";
        public string CurrentPlayer = "X";
        public string cellname = "";
        public int size = 9;
        //простой вариант для хранения данных поля: создать 25 значений
        //а1..а5, b1..b5,c,d, e1..e5
        //второй вариант: создать массив или онг же словарь Dictionary Field["a5"]
        public Dictionary<string, string> Field = new Dictionary<string, string>();

        public string[,] Field2 = new string[10, 10];


        public List<string> htmlStrings = new List<string>();
        public List<string> beginhtml = new List<string>();
        public List<string> endhtml = new List<string>();
        //двухмерный массив
        public string[,] strarr = new string[10,10];
        public MainModel()
        {
            int ia = (int)'a';
            char a = 'a';
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    string key = a.ToString() + j.ToString();
                    Field.Add(key, "_");
                    Field2[i, j] = "_";
                }
                ia++;
                a = (char)ia;
            }
            //html
            char aa = 'a';
            int iaa = (int)'a';
            for (int i = 0; i < size; i++)
            {
                string strb = "<div id=\"str"+i+"\" style=\"display: inline-block; \">";
                beginhtml.Add(strb);
                for (int j = 0; j < size; j++)
                {
                    string str = "";
                    // href = "/Home/test?cellname=a0&xplayer=X"
                    str = str + "<div style=\"margin:5px;padding:5px\"><a  href=\"/Home/test?cellname=" + aa + j + "\" > ";
                        //@Model.Field[\""+aa+j+"\"]
                       // +"</a></div>";
                    strarr[i, j] = str;
                }
                string stre = "</div>";
                endhtml.Add(stre);
                iaa++;
                aa = (char)iaa;
            }
        }
    }
}
