using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using notepad;

namespace NotepaadWinform
{
    public partial class Notepad : System.Windows.Forms.Form
    {
        String path = String.Empty;



        public Notepad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string ReturnMessageFromFormat(string type)
        {
            switch (type)
            {
                case "ino":
                    return "Arduino";
                    break;
                case "cs":
                    return "C#";
                    break;
                case "cpp":
                    return "C++";
                    break;
                case "c":
                    return "C";
                    break;
                case "btwo":
                    return "Braintwo";
                    break;
                case "json":
                    return "Json";
                    break;
                case "xml":
                    return "Xml";
                    break;
                case "html":
                    return "HTML";
                    break;
                case "css":
                    return "CSS";
                    break;
                case "js":
                    return "JavaScript";
                    break;
                default:
                    return "Text";
                    break;

            }
        }

        private void exitPrompt()
        {
            DialogResult = MessageBox.Show("Do you want to save current file?",
                "Notepad",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(path = saveFileDialog1.FileName, RTB_Main.Text);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(path))
            {
                File.WriteAllText(path, RTB_Main.Text);
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RTB_Main.Text = File.ReadAllText(path = openFileDialog1.FileName);
                string[] SplitExtension = openFileDialog1.FileName.Split('.');
                labelFormat.Text = ReturnMessageFromFormat(SplitExtension[1]);

            }
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(RTB_Main.Text))
            {
                exitPrompt();

                if (DialogResult == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    RTB_Main.Text = String.Empty;
                    path = String.Empty; ;
                }
                else if (DialogResult == DialogResult.No)
                {
                    RTB_Main.Text = String.Empty; ;
                    path = String.Empty; ;
                }

            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog pgSetup = new PageSetupDialog();
            pgSetup.PageSettings = new System.Drawing.Printing.PageSettings();
            pgSetup.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            pgSetup.ShowNetwork = false;
            pgSetup.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            //Call ShowDialog  
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RTB_Main.CanUndo)
                {
                    RTB_Main.Undo();               
                }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB_Main.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB_Main.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB_Main.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB_Main.SelectedText = string.Empty;
        }

        private void searchWithBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string search = RTB_Main.SelectedText;
            System.Diagnostics.Process.Start("https://www.bing.com/search?q="+search);
        }

        void Search(string searchValue)
        {
            RTB_Main.Find(searchValue);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find f = new Find(RTB_Main);
            f.Show();
        }

       

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == true)
            {
                RTB_Main.WordWrap = false;
                RTB_Main.ScrollBars = (RichTextBoxScrollBars)ScrollBars.Both;
                wordWrapToolStripMenuItem.Checked = false;
            }
            else
            {
                RTB_Main.WordWrap = true;
                RTB_Main.ScrollBars = (RichTextBoxScrollBars)ScrollBars.Vertical;
                wordWrapToolStripMenuItem.Checked = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                RTB_Main.Font = RTB_Main.Font = new Font(fontDialog1.Font, fontDialog1.Font.Style);
                
            }
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad f = new Notepad();
            f.ShowDialog();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           RTB_Main.Text = System.DateTime.Now.ToString();
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new Info();
            about.Show();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB_Main.SelectionFont = new Font(RTB_Main.SelectionFont.FontFamily, 12.0F);


        }

        private void colorTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            if (cl.ShowDialog() == DialogResult.OK)
            {
                RTB_Main.ForeColor = cl.Color;
            }
        }

        private void colorBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            if (cl.ShowDialog() == DialogResult.OK)
            {
                RTB_Main.BackColor = cl.Color;
            }
        }

        private void colorSelectTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            
            if (cl.ShowDialog() == DialogResult.OK)
            {
                RTB_Main.SelectionColor = cl.Color;
            }
        }

        private void colorSelectBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();

            if (cl.ShowDialog() == DialogResult.OK)
            {
                RTB_Main.SelectionBackColor = cl.Color;
            }
        }

        private void searchWithGoogleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string search = RTB_Main.SelectedText;
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + search);
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find f = new Find(RTB_Main);
            f.Show();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find f = new Find(RTB_Main);
            f.Show();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB_Main.SelectAll();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
    }    
}
