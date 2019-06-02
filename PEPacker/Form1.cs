using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEPacker
{   
    public partial class Form1 : Form
    {
        public Stream FileStream;//声明文件流

        public struct PEInfoClass
        {
            public string a;
        }

        public Stream OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "可执行文件 (*.exe)|*.exe";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((FileStream = openFileDialog.OpenFile()) != null)
                { 
                    return FileStream;
                }
            }
            return FileStream = null;
        }

        public void FileHeaderListViewItemAdd(string str,string value)
        {        
            ListViewItem FileHeaderListViewItem = new ListViewItem();
            FileHeaderListViewItem.Text = str;
            FileHeaderListViewItem.SubItems.Add(value);
            FileHeaderListView.Items.Add(FileHeaderListViewItem);
        }

        public int ListViewUpdate()
        {        
            FileHeaderListView.Items.Clear();
            FileHeaderListView.BeginUpdate();
            for (int i = 0; i < 10 ; i++)
            {
                
                ListViewItem FileHeaderListViewItem = new ListViewItem();
                FileHeaderListViewItem.Text = "1";
                FileHeaderListViewItem.SubItems.Add("第2列,第" + i + "行");
                this.FileHeaderListView.Items.Add(FileHeaderListViewItem);
            }
            MessageBox.Show("7777");
            FileHeaderListView.EndUpdate();
            return 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 制作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProcesser();
        }

        private void ProcessPEInfo_Click(object sender, EventArgs e)
        {
            FileProcesser();
        }

        public int FileProcesser()
        {
            Stream FileStream = OpenFile();
            if (FileStream == null)
            {
                MessageBox.Show("文件打开失败！", "警告");
            }
            else
            {
                MessageBox.Show("文件打开成功！", "提示");


                //FileHeaderListView
                FileHeaderListView.Items.Clear();
                FileHeaderListView.BeginUpdate();

                byte[] buffer = new byte[2];
                FileStream.Seek(0, SeekOrigin.Begin);
                FileStream.Read(buffer, 0, buffer.Length);
                string value = BitConverter.ToString(buffer).Replace("-", string.Empty).ToUpper();
                FileHeaderListViewItemAdd("MZ头",value);

                FileHeaderListView.EndUpdate();


                //xxxxxxxxxx
                FileStream.Close();
            }
            return 0;
        }

        private void BeginPackBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hahaha");
        }
    }
}
