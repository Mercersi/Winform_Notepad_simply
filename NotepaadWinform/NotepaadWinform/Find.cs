using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotepaadWinform;

namespace notepad
{
    public partial class Find : Form
    {
        public Notepad ntp;
        public String fstring;
        public String freplace;
        public RichTextBox RTB_Main;
        public int index = 0;
        public Find(RichTextBox RTB)
        {
            InitializeComponent();
            RTB_Main = RTB;
        }

        
        //Find
        private void Find_s(RichTextBox RTB_Main)
        {

            if (getFindWord() != "")
            {
                index = 0;
                while (index != -1 && index < RTB_Main.Text.Length)
                {
                    index = RTB_Main.Text.IndexOf(getFindWord(), index);
                    if (index != -1)
                    {
                        RTB_Main.Select(index, getFindWord().Length);
                        RTB_Main.SelectionBackColor = Color.Yellow;
                        index++;

                    }
                }
            }
            MessageBox.Show("End of file");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fstring = txb_Find.Text;
            Find_s(RTB_Main);
        }

        private void Find_1(RichTextBox RTB_Main)
        {
            index = RTB_Main.Text.IndexOf(getFindWord(), index);
            if (index != -1)
            {
                RTB_Main.Select(index, getFindWord().Length);
                RTB_Main.SelectionBackColor = Color.Yellow;
                index++;

            }
            else { MessageBox.Show("End of file"); index = 0; }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {

            fstring = txb_Find.Text;
            Find_1(RTB_Main);

        }

        public String getFindWord()
        {
            return fstring;
        }
    
        //Replace
        private void Replace(RichTextBox richTextBox)
        {

            String findWord = fstring;
            String replaceWord = freplace;
            if (findWord != "")
            {
                richTextBox.Text = richTextBox.Text.Replace(findWord, replaceWord);
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Nothing to replace", "Done", MessageBoxButtons.OK);
        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
             
            index = RTB_Main.Text.IndexOf(getFindWord(), index);
            if (index != -1)
            {
                RTB_Main.Select(index, getFindWord().Length);
                RTB_Main.SelectedText = freplace;
                index++;

            }
            else { MessageBox.Show("End of file"); index = 0; }
        }

        private void btn_ReplaceAll_Click(object sender, EventArgs e)
        {
            fstring = txb_Find.Text;
            freplace = txb_Replace.Text;
            Replace(RTB_Main);
            RTB_Main.SelectAll();
            RTB_Main.SelectionBackColor = RTB_Main.BackColor;
            RTB_Main.Select(1, 1);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            fstring = "";
            freplace = "";
            RTB_Main.SelectAll();
            RTB_Main.SelectionBackColor = RTB_Main.BackColor;
            RTB_Main.Select(1, 1);
            this.Close();
        }


    }
}
