using DailyCheck.FormTools.BasicUtils;
using DailyCheck.FormTools.Questions;
using System;

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
            q3();
        }

        private void q3()
        {
            var temp = new _3().LengthOfLongestSubstring("aab");
            MessageBox.Show(string.Join("", temp));
        }

        private void q297()
        {
            var temp = new _297().deserialize("1,2,3,#,#,4,5");
            var str = new _297().serialize(temp);

        }

        private void q160()
        {
            var ListA = new _160.ListNode(4, new _160.ListNode(1, new _160.ListNode(8, new _160.ListNode(4, new _160.ListNode(5, null)))));
            var ListB = new _160.ListNode(5, new _160.ListNode(6, new _160.ListNode(1, new _160.ListNode(8, new _160.ListNode(4, new _160.ListNode(5, null))))));

            var result = new _160().GetIntersectionNode(ListA, ListB);
            MessageBox.Show(string.Join("", result));

        }


        private void q24()
        {
            var result = new _24().SwapPairs(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));
            MessageBox.Show(string.Join("", result));

        }

        private void q821()
        {
            //var result = new _821().ShortestToChar("loveleetcode", 'e');
            var result = new _821().ShortestToChar("aaba", 'b');

            MessageBox.Show(string.Join("", result));
        }


        /// <summary>
        /// day1.5
        /// </summary>
        private void q414()
        {
            //int[] num = { 1, 2, 2, 5, 3, 5 };
            //int[] num = { 1, 2 };
            ////int[] num = { 1, 2, 2 };
            //int[] num = { 3, 2, 1 };
            //int[] num = { 1, 2 };
            //int[] num = { 2, 2, 3, 1 };
            int[] num = { 1, 2, -2147483648 };
            _414 model = new _414();
            var result = model.ThirdMax(num);

            MessageBox.Show(string.Join("", result));

        }


        /// <summary>
        /// day1
        /// </summary>
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

            _989 q989 = new _989(num, k);
            var result = q989.Main(q989.num, q989.k);

            MessageBox.Show(string.Join("", result));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}