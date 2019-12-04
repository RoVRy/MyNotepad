using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyNotepad
{
    public partial class MainWin : Form
    {
        public string Filename = "Безымянный.txt";

        public MainWin()
        {
            InitializeComponent();
            ChangeFilenameInTitle(Filename);
        }

        private void ChangeFilenameInTitle(string filename)
        {
            this.Text = Path.GetFileName(filename);
            if (OpenFileDialog.ReadOnlyChecked == true) this.Text += " (только чтение)";
            this.Text += " - Мой блокнот";
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Когда-нибудь напишу", "Увы!");
        }

        private void StatusLineMenuItem_Click(object sender, EventArgs e)
        {
			bool a = StatusLine.Visible;
			Size b = TextField.Size;
			int c = StatusLine.Height;
			StatusLine.Visible = !a;
			StatusMenuItem.Checked = !a;
			if (!a)
			{
				b.Height -= c;
			}
			else b.Height += c;
			TextField.Size = b;
			RefreshStatus();
        }

        private void FontSetupItem_Click(object sender, EventArgs e)
        {
            FontDialog.ShowDialog();
            TextField.Font = FontDialog.Font;
        }

        private void PrintMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog.ShowDialog();
        }

        private void PageSetupMenuItem_Click(object sender, EventArgs e)
        {
            PageSetup.ShowDialog();
        }

        private void WordWrapMenuItem_Click(object sender, EventArgs e)
        {
            bool a;
            a = TextField.WordWrap;
            TextField.WordWrap = !a;
            WordWrapMenuItem.Checked = !a;
        }

        private void TextFieldChanged(object sender, EventArgs e)
        {
			RefreshStatus();
        }

		private void RefreshStatus()
		{
            Point n = new System.Drawing.Point(TextField.Lines.Length);
			if (StatusLine.Visible == true)
			{
				int fc = TextField.GetFirstCharIndexOfCurrentLine(),
					row = TextField.GetLineFromCharIndex(fc),
					col = TextField.TextLength - fc;
				TextRow.Text = row.ToString();
				TextColumn.Text = col.ToString();
                DebugLine.Text = TextField.SelectionStart.ToString();
			}
		}

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
        }

        private void ProceedFileOpen(object sender, CancelEventArgs e)
        {
            Filename = OpenFileDialog.FileName;
            ChangeFilenameInTitle(Filename);
            ReadFile(Filename);
        }

        private void ExitMyNotepad(object sender, EventArgs e)
        {
            this.Close();
			Application.Exit();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm AboutWindow = new AboutForm();
            this.AddOwnedForm(AboutWindow);
            AboutWindow.Show();
		}

        private void GetDroppedFile(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] drgfiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                ChangeFilenameInTitle(drgfiles[0]);
                ReadFile(drgfiles[0]);
            }
        }

        private void HandleDrag(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) ||
               e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        private void ReadFile(string Fn)
        {
            Encoding CodePage = Encoding.ASCII;
            StreamReader Handle = new StreamReader(Fn,true);
            TextField.Text = Handle.ReadToEnd();
        }

        private void SomeTyped(object sender, KeyPressEventArgs e)
        {
            RefreshStatus();
        }
    }
}