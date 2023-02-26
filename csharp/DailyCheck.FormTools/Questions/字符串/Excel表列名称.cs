using System.Linq;
using System.Text;

namespace DailyCheck.FormTools.Questions.字符串
{
    /// <summary>
    /// 168
    /// </summary>
    public class Excel表列名称
    {
        public string ConvertToTitle(int cn)
        {
            StringBuilder sb = new StringBuilder();
            while (cn > 0)
            {
                cn--;
                sb.Append((char)(cn % 26 + 'A'));
                cn /= 26;
            }
            return string.Join("", sb.ToString().Reverse());
        }


        //public string ConvertToTitle(int columnNumber)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    Dictionary<int, char> dict = new Dictionary<int, char>();
        //    dict.Add(0, 'Z');
        //    dict.Add(1, 'A');
        //    dict.Add(2, 'B');
        //    dict.Add(3, 'C');
        //    dict.Add(4, 'D');
        //    dict.Add(5, 'E');
        //    dict.Add(6, 'F');
        //    dict.Add(7, 'G');
        //    dict.Add(8, 'H');
        //    dict.Add(9, 'I');
        //    dict.Add(10, 'J');
        //    dict.Add(11, 'K');
        //    dict.Add(12, 'L');
        //    dict.Add(13, 'M');
        //    dict.Add(14, 'N');
        //    dict.Add(15, 'O');
        //    dict.Add(16, 'P');
        //    dict.Add(17, 'Q');
        //    dict.Add(18, 'R');
        //    dict.Add(19, 'S');
        //    dict.Add(20, 'T');
        //    dict.Add(21, 'U');
        //    dict.Add(22, 'V');
        //    dict.Add(23, 'W');
        //    dict.Add(24, 'X');
        //    dict.Add(25, 'Y');
        //    dict.Add(26, 'Z');
        //    int share;
        //    int left;
        //    while (true)
        //    {
        //        if (columnNumber <= 26)
        //        {
        //            sb.Append(dict[columnNumber]);
        //            break;
        //        }
        //        else
        //        {
        //            share = columnNumber / 26;
        //            left = columnNumber - 26 * share;
        //            sb.Append(dict[columnNumber - 26 * share]);

        //            if (left == 0)
        //            {
        //                columnNumber = share - 1;
        //            }
        //            else
        //            {
        //                columnNumber = share;
        //            }
        //        }
        //    }
        //    return string.Join("", sb.ToString().Reverse());
        //}
    }
}
