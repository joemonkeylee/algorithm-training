using DailyCheck.FormTools.Questions.字符串;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace DailyCheck.FormTools
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            Assembly assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(item => item.FullName.Contains("CodeTester.questions")).ToList();
            string str = "{0};{1};{2}";
            int index = 1;
            foreach (var type in types)
            {
                var arr = type.FullName.Split('.');
                data.Add(string.Format(str, index, arr[2], arr[3]));
            }
            this.Init(data.ToArray());
        }

        public void Init(string[] strData)
        {
            //设置树形组件的基础属性
            treeView1.CheckBoxes = true;
            treeView1.FullRowSelect = true;
            treeView1.Indent = 20;
            treeView1.ItemHeight = 20;
            treeView1.LabelEdit = false;
            treeView1.Scrollable = true;
            treeView1.ShowPlusMinus = true;
            treeView1.ShowRootLines = true;


            //需要加载树形的源数据
            //string[] strData = { "1;内地;柳岩", "2;内地;杨幂", "3;欧美;卡戴珊", "4;日韩;李成敏", "5;日韩;宇都宫紫苑" };

            //解析到DataTable数据集
            DataTable dtData = new DataTable();
            dtData.Columns.Add("ID");
            dtData.Columns.Add("GROUP");
            dtData.Columns.Add("NAME");

            foreach (string item in strData)
            {
                string[] values = item.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (values.Length == 3)
                {
                    DataRow row = dtData.NewRow();
                    row["ID"] = values[0];
                    row["GROUP"] = values[1];
                    row["NAME"] = values[2];
                    dtData.Rows.Add(row);
                }
            }


            TreeNode tn = new TreeNode();
            tn.Name = "全部";
            tn.Text = "全部";


            //将数据集加载到树形控件当中
            foreach (DataRow row in dtData.Rows)
            {
                string strValue = row["GROUP"].ToString();
                if (tn.Nodes.Count > 0)
                {
                    if (!tn.Nodes.ContainsKey(strValue))
                    {
                        BindTreeData(tn, dtData, strValue);
                    }
                }
                else
                {
                    BindTreeData(tn, dtData, strValue);
                }
            }

            treeView1.Nodes.Add(tn);
            //treeView1.ExpandAll();
        }

        private void BindTreeData(TreeNode tn, DataTable dtData, string strValue)
        {
            TreeNode tn1 = new TreeNode();
            tn1.Name = strValue;
            tn1.Text = strValue;
            tn.Nodes.Add(tn1);

            DataRow[] rows = dtData.Select(string.Format("GROUP='{0}'", strValue));
            if (rows.Length > 0)
            {
                foreach (DataRow dr in rows)
                {
                    TreeNode tn2 = new TreeNode();
                    tn2.Name = dr["GROUP"].ToString();
                    tn2.Text = dr["NAME"].ToString();
                    tn1.Nodes.Add(tn2);
                }
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //鼠标勾选树节点时需要使树节点为选中状态，反之忽略
            if (isMouseClick)
            {
                treeView1.SelectedNode = e.Node;
            }

            //获取勾选项名称
            StringBuilder sb = new StringBuilder();
            GetTreeNodesCheckName(sb, treeView1.Nodes);
            //txt_CheckValue.Text = sb.ToString().Trim(';');
        }

        private void GetTreeNodesCheckName(StringBuilder sb, TreeNodeCollection tnc)
        {
            foreach (TreeNode item in tnc)
            {
                if (item.Checked) { sb.AppendFormat("{0};", item.Text); }

                GetTreeNodesCheckName(sb, item.Nodes);
            }
        }

        bool isMouseClick = true;
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //选中或勾选树节点时触发子树节点或父树节点的逻辑操作
            isMouseClick = false;

            SetCheckedChildNodes(e.Node, e.Node.Checked);

            SetCheckedParentNodes(e.Node, e.Node.Checked);

            //var tree = sender as TreeView;
            //txbResult.Text = tree.SelectedNode.Text;

            isMouseClick = true;
        }

        //树节点的父树节点逻辑操作
        private static void SetCheckedParentNodes(TreeNode tn, bool CheckState)
        {
            if (tn.Parent != null)
            {
                //当选中树节点勾选后同级所有树节点都勾选时，父树节点为勾选状态；
                //当选中树节点中的同级树节点其中有一个树节点未勾选则父树节点为未勾选状态；
                bool b = false;
                for (int i = 0; i < tn.Parent.Nodes.Count; i++)
                {
                    bool state = tn.Parent.Nodes[i].Checked;
                    if (!state.Equals(CheckState))
                    {
                        b = !b;
                        break;
                    }
                }
                tn.Parent.Checked = b ? (Boolean)false : CheckState;

                SetCheckedParentNodes(tn.Parent, CheckState);
            }
        }

        //树节点的子树节点逻辑操作
        private static void SetCheckedChildNodes(TreeNode tn, bool CheckState)
        {
            if (tn.Nodes.Count > 0)
            {
                //当前树节点状态变更，子树节点同步状态
                foreach (TreeNode tn1 in tn.Nodes)
                {
                    tn1.Checked = CheckState;

                    SetCheckedChildNodes(tn1, CheckState);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = new 亦我();
            //txbResult.Text += string.Join("", model.Replace("abc1abc".ToCharArray(), "abc".ToCharArray(), "ab".ToCharArray())); txbResult.Text += Environment.NewLine;//ab1ab 
            //txbResult.Text += string.Join("", model.Replace("zabhbgdcabhbgdc".ToCharArray(), "ab".ToCharArray(), "z".ToCharArray())); txbResult.Text += Environment.NewLine;//zzhbgdczhbg
            //txbResult.Text += string.Join("", model.Replace("zabhbgdzcabhbgdc".ToCharArray(), "z".ToCharArray(), "ab".ToCharArray())); txbResult.Text += Environment.NewLine;//ababhbgdabcabhbg

            txbResult.Text += string.Join("", model.Replace("abc1abc".ToCharArray(), "abc".ToCharArray(), "ab".ToCharArray())); txbResult.Text += Environment.NewLine;//ab1ab 
            txbResult.Text += string.Join("", model.Replace("zabhbgdcabhbgdc".ToCharArray(), "ab".ToCharArray(), "z".ToCharArray())); txbResult.Text += Environment.NewLine;//zzhbgdczhbg
            txbResult.Text += string.Join("", model.Replace("zabhbgdzcabhbgdc".ToCharArray(), "z".ToCharArray(), "ab".ToCharArray())); txbResult.Text += Environment.NewLine;//ababhbgdabcabhbg

            //txbResult.Text += model.Replace("abc1abc".ToCharArray(), "abc".ToCharArray(), "ab".ToCharArray()); txbResult.Text += Environment.NewLine;//ab1ab 
            //txbResult.Text += model.Replace("zabhbgdcabhbgdc".ToCharArray(), "ab".ToCharArray(), "z".ToCharArray()); txbResult.Text += Environment.NewLine;//zzhbgdczhbg
            //txbResult.Text += model.Replace("zabhbgdzcabhbgdc".ToCharArray(), "z".ToCharArray(), "ab".ToCharArray()); txbResult.Text += Environment.NewLine;//ababhbgdabcabhbg

            //txbResult.Text += model.Replace("abc1abc", "abc", "ab"); txbResult.Text += Environment.NewLine;//ab1ab 
            //txbResult.Text += model.Replace("zabhbgdcabhbgdc", "ab", "z"); txbResult.Text += Environment.NewLine;//zzhbgdczhbg
            //txbResult.Text += model.Replace("zabhbgdzcabhbgdc", "z", "ab"); txbResult.Text += Environment.NewLine;//ababhbgdabcabhbg

            //s = "abc", t = "ahbgdc" true
            //s = "axc", t = "ahbgdc" false
            //s = "ace", t = "abcde" false
            //var model = new 判断子序列();
            //txbResult.Text += model.IsSubsequence("abc", "ahbgdc"); txbResult.Text += Environment.NewLine;//true
            //txbResult.Text += model.IsSubsequence("axc", "ahbgdc"); txbResult.Text += Environment.NewLine;//false
            //txbResult.Text += model.IsSubsequence("ace", "abcde"); txbResult.Text += Environment.NewLine;//true
            //txbResult.Text += model.IsSubsequence("aec", "abcde"); txbResult.Text += Environment.NewLine;//false
            //txbResult.Text += model.IsSubsequence("", "ahbgdc"); txbResult.Text += Environment.NewLine;//true
            //txbResult.Text += model.IsSubsequence("a", "b"); txbResult.Text += Environment.NewLine;//false
            //txbResult.Text += model.IsSubsequence("bb", "ahbgdc"); txbResult.Text += Environment.NewLine;//false


            //var model = new 字符串中的第一个唯一字符();
            //txbResult.Text += model.FirstUniqChar("leetcode").ToString(); txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.FirstUniqChar("loveleetcode").ToString(); txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.FirstUniqChar("aabb").ToString(); txbResult.Text += Environment.NewLine;


            //var model = new 反转字符串中的元音字母();
            //var arr = new char[] { 'h', 'e', 'l', 'l', 'o' };
            //txbResult.Text += " apG0i4maAs::sA0m4i0Gp0";
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.ReverseVowels(" apG0i4maAs::sA0m4i0Gp0").ToString();
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += " ipG0A4mAas::si0m4a0Gp0";
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.ReverseVowels("a.").ToString();
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.ReverseVowels(".,").ToString();
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.ReverseVowels("hello").ToString();
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.ReverseVowels("leetcode").ToString();
            //txbResult.Text += Environment.NewLine;

            //var model = new 反转字符串();
            //var arr = new char[] { 'h', 'e', 'l', 'l', 'o' };
            //model.ReverseString(arr);

            //var model = new 单词规律();
            //txbResult.Text += model.WordPattern("abba", "dog cat cat dog").ToString(); txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.WordPattern("abba", "dog cat cat fish").ToString(); txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.WordPattern("aaaa", "dog cat cat dog").ToString(); txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.WordPattern("abba", "dog dog dog dog").ToString(); txbResult.Text += Environment.NewLine;

            //var model = new 有效的字母异位词();
            //txbResult.Text += model.IsAnagram("rat", "car");

            //var model = new 实现strStr();
            //txbResult.Text += model.StrStr("hello", "ll");
            //txbResult.Text += model.StrStr("mississippi", "issipi");
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.StrStr("aaaaa", "bba");
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.StrStr("", "");
            //txbResult.Text += Environment.NewLine;

            //var model = new 同构字符串();
            //txbResult.Text += model.IsIsomorphic("badc", "baba");
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.IsIsomorphic("egg", "add");
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.IsIsomorphic("foo", "bar");
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.IsIsomorphic("paper", "title");
            //txbResult.Text += Environment.NewLine;

            //var model = new Excel表列序号();
            //txbResult.Text += model.TitleToNumber("A");
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.TitleToNumber("AB");
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.TitleToNumber("ZY");

            //var model = new Excel表列名称();
            //txbResult.Text += model.ConvertToTitle(1);
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.ConvertToTitle(701);
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.ConvertToTitle(28);
            //txbResult.Text += Environment.NewLine;
            //txbResult.Text += model.ConvertToTitle(52);

            //var model = new 有效的括号();
            //txbResult.Text = model.IsValid("]").ToString();

            //var model = new 最长公共前缀();
            //string[] arr = new string[] { "flower", "flow", "flight" };
        }

        //private void treeView1_Click(object sender, EventArgs e)
        //{
        //    var tree = sender as TreeView;
        //    txbResult.Text = tree.SelectedNode.Text;
        //}
    }
}
