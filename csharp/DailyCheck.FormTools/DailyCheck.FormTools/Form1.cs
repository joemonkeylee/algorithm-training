using DailyCheck.FormTools.BasicUtils;
using DailyCheck.FormTools.LeeK;

namespace DailyCheck.FormTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            q989();
        }

        private void q989()
        {
            //int[] num = new int[4];
            //int k = 34;
            //num[0] = 1;
            //num[1] = 2;
            //num[2] = 0;
            //num[3] = 0;

            //int[] num = { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };
            //int k = 1;

            //int[] num = { 2, 7, 4 };
            //int k = 181;

            //int[] num = { 2 };
            //int k = 7;

            //int[] num = { 0 };
            //int k = 3;

            //int[] num = { 1, 2, 6, 3, 0, 7, 1, 7, 1, 9, 7, 5, 6, 6, 4, 4, 0, 0, 6, 3 };
            //int k = 516;

            //int[] num = { 3, 5, 8, 6, 9, 7, 8, 3, 8, 5, 4, 1, 6, 7, 4, 1, 0, 1, 7, 7, 1, 5, 3, 2, 9, 3, 4, 1, 0, 5, 8, 6, 9, 9, 4, 8, 7, 0, 2, 8, 2, 4, 7, 0, 4, 4, 3, 7, 2, 2 };
            //int k = 142;

            //int[] num = { 2, 7, 4 };
            //int k = 181;

            int[] num = { 0 };
            int k = 23;

            Q989 q989 = new Q989(num, k);
            var result = q989.Main(q989.num, q989.k);

            MessageBox.Show(string.Join("", result));
        }
    }
}