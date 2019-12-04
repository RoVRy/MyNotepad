using System.Windows.Forms;
namespace MyNotepad
{
    public partial class MainWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip MenuLine;
            System.Windows.Forms.ToolStripMenuItem FileMenu;
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PageSetupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.FindMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindNextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator5 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertDateNTimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSetupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator6 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusLine = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.Separator9 = new System.Windows.Forms.ToolStripSeparator();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextColumn = new System.Windows.Forms.ToolStripStatusLabel();
            this.DebugLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.DebugText = new System.Windows.Forms.ToolStripStatusLabel();
            this.PageSetup = new System.Windows.Forms.PageSetupDialog();
            this.TextField = new System.Windows.Forms.RichTextBox();
            this.ContextMenuLine = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UndoContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator7 = new System.Windows.Forms.ToolStripSeparator();
            this.CutContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator8 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            MenuLine = new System.Windows.Forms.MenuStrip();
            FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            MenuLine.SuspendLayout();
            this.StatusLine.SuspendLayout();
            this.ContextMenuLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuLine
            // 
            MenuLine.AllowItemReorder = true;
            MenuLine.GripMargin = new System.Windows.Forms.Padding(2);
            MenuLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            FileMenu,
            this.EditMenu,
            this.FormatMenu,
            this.ViewMenu,
            this.HelpMenu});
            MenuLine.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            MenuLine.Location = new System.Drawing.Point(0, 0);
            MenuLine.Name = "MenuLine";
            MenuLine.Padding = new System.Windows.Forms.Padding(0);
            MenuLine.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            MenuLine.Size = new System.Drawing.Size(448, 19);
            MenuLine.TabIndex = 0;
            // 
            // FileMenu
            // 
            FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.Separator1,
            this.PageSetupMenuItem,
            this.PrintMenuItem,
            this.Separator2,
            this.ExitMenuItem});
            FileMenu.Name = "FileMenu";
            FileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            FileMenu.Size = new System.Drawing.Size(48, 19);
            FileMenu.Text = "&Файл";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Image = global::MyNotepad.Properties.Resources.DocumentHS;
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewMenuItem.Size = new System.Drawing.Size(204, 22);
            this.NewMenuItem.Text = "Создать";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Image = global::MyNotepad.Properties.Resources.openHS;
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenuItem.Size = new System.Drawing.Size(204, 22);
            this.OpenMenuItem.Text = "Открыть...";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Image = global::MyNotepad.Properties.Resources.saveHS;
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenuItem.Size = new System.Drawing.Size(204, 22);
            this.SaveMenuItem.Text = "Сохранить";
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Size = new System.Drawing.Size(204, 22);
            this.SaveAsMenuItem.Text = "Сохранить как...";
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(201, 6);
            // 
            // PageSetupMenuItem
            // 
            this.PageSetupMenuItem.Image = global::MyNotepad.Properties.Resources.PrintSetupHS;
            this.PageSetupMenuItem.Name = "PageSetupMenuItem";
            this.PageSetupMenuItem.Size = new System.Drawing.Size(204, 22);
            this.PageSetupMenuItem.Text = "Параметры страницы...";
            this.PageSetupMenuItem.Click += new System.EventHandler(this.PageSetupMenuItem_Click);
            // 
            // PrintMenuItem
            // 
            this.PrintMenuItem.Image = global::MyNotepad.Properties.Resources.PrintHS;
            this.PrintMenuItem.Name = "PrintMenuItem";
            this.PrintMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintMenuItem.Size = new System.Drawing.Size(204, 22);
            this.PrintMenuItem.Text = "Печать...";
            this.PrintMenuItem.Click += new System.EventHandler(this.PrintMenuItem_Click);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(201, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ExitMenuItem.Text = "Выход";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMyNotepad);
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoMenuItem,
            this.Separator3,
            this.CutMenuItem,
            this.CopyMenuItem,
            this.PasteMenuItem,
            this.DeleteMenuItem,
            this.Separator4,
            this.FindMenuItem,
            this.FindNextMenuItem,
            this.ReplaceMenuItem,
            this.GoMenuItem,
            this.Separator5,
            this.SelectAllMenuItem,
            this.InsertDateNTimeMenuItem});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(59, 19);
            this.EditMenu.Text = "&Правка";
            // 
            // UndoMenuItem
            // 
            this.UndoMenuItem.Image = global::MyNotepad.Properties.Resources.Edit_UndoHS;
            this.UndoMenuItem.Name = "UndoMenuItem";
            this.UndoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoMenuItem.Size = new System.Drawing.Size(214, 22);
            this.UndoMenuItem.Text = "Отменить";
            // 
            // Separator3
            // 
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(211, 6);
            // 
            // CutMenuItem
            // 
            this.CutMenuItem.Image = global::MyNotepad.Properties.Resources.CutHS;
            this.CutMenuItem.Name = "CutMenuItem";
            this.CutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutMenuItem.Size = new System.Drawing.Size(214, 22);
            this.CutMenuItem.Text = "Вырезать";
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Image = global::MyNotepad.Properties.Resources.CopyHS;
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyMenuItem.Size = new System.Drawing.Size(214, 22);
            this.CopyMenuItem.Text = "Копировать";
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.Image = global::MyNotepad.Properties.Resources.PasteHS;
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteMenuItem.Size = new System.Drawing.Size(214, 22);
            this.PasteMenuItem.Text = "Вставить";
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Image = global::MyNotepad.Properties.Resources.DeleteHS;
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteMenuItem.Size = new System.Drawing.Size(214, 22);
            this.DeleteMenuItem.Text = "Удалить";
            // 
            // Separator4
            // 
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(211, 6);
            // 
            // FindMenuItem
            // 
            this.FindMenuItem.Image = global::MyNotepad.Properties.Resources.FindHS;
            this.FindMenuItem.Name = "FindMenuItem";
            this.FindMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FindMenuItem.Size = new System.Drawing.Size(214, 22);
            this.FindMenuItem.Text = "Найти...";
            // 
            // FindNextMenuItem
            // 
            this.FindNextMenuItem.Image = global::MyNotepad.Properties.Resources.FindNextHS;
            this.FindNextMenuItem.Name = "FindNextMenuItem";
            this.FindNextMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.FindNextMenuItem.Size = new System.Drawing.Size(214, 22);
            this.FindNextMenuItem.Text = "Найти далее";
            // 
            // ReplaceMenuItem
            // 
            this.ReplaceMenuItem.Image = global::MyNotepad.Properties.Resources.SychronizeListHS;
            this.ReplaceMenuItem.Name = "ReplaceMenuItem";
            this.ReplaceMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ReplaceMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ReplaceMenuItem.Text = "Заменить...";
            // 
            // GoMenuItem
            // 
            this.GoMenuItem.Image = global::MyNotepad.Properties.Resources.NextPageHS;
            this.GoMenuItem.Name = "GoMenuItem";
            this.GoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.GoMenuItem.Size = new System.Drawing.Size(214, 22);
            this.GoMenuItem.Text = "Перейти...";
            // 
            // Separator5
            // 
            this.Separator5.Name = "Separator5";
            this.Separator5.Size = new System.Drawing.Size(211, 6);
            // 
            // SelectAllMenuItem
            // 
            this.SelectAllMenuItem.Name = "SelectAllMenuItem";
            this.SelectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllMenuItem.Size = new System.Drawing.Size(214, 22);
            this.SelectAllMenuItem.Text = "Выделить всё";
            // 
            // InsertDateNTimeMenuItem
            // 
            this.InsertDateNTimeMenuItem.Image = global::MyNotepad.Properties.Resources.ExpirationHS;
            this.InsertDateNTimeMenuItem.Name = "InsertDateNTimeMenuItem";
            this.InsertDateNTimeMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.InsertDateNTimeMenuItem.Size = new System.Drawing.Size(214, 22);
            this.InsertDateNTimeMenuItem.Text = "Вставить дату и время";
            // 
            // FormatMenu
            // 
            this.FormatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordWrapMenuItem,
            this.FontSetupMenuItem});
            this.FormatMenu.Name = "FormatMenu";
            this.FormatMenu.Size = new System.Drawing.Size(62, 19);
            this.FormatMenu.Text = "Фор&мат";
            // 
            // WordWrapMenuItem
            // 
            this.WordWrapMenuItem.Checked = true;
            this.WordWrapMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WordWrapMenuItem.Name = "WordWrapMenuItem";
            this.WordWrapMenuItem.Size = new System.Drawing.Size(183, 22);
            this.WordWrapMenuItem.Text = "Перенос по словам";
            this.WordWrapMenuItem.Click += new System.EventHandler(this.WordWrapMenuItem_Click);
            // 
            // FontSetupMenuItem
            // 
            this.FontSetupMenuItem.Image = global::MyNotepad.Properties.Resources.FontHS;
            this.FontSetupMenuItem.Name = "FontSetupMenuItem";
            this.FontSetupMenuItem.Size = new System.Drawing.Size(183, 22);
            this.FontSetupMenuItem.Text = "Шрифт...";
            this.FontSetupMenuItem.Click += new System.EventHandler(this.FontSetupItem_Click);
            // 
            // ViewMenu
            // 
            this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMenuItem});
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(39, 19);
            this.ViewMenu.Text = "&Вид";
            // 
            // StatusMenuItem
            // 
            this.StatusMenuItem.Checked = true;
            this.StatusMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StatusMenuItem.Name = "StatusMenuItem";
            this.StatusMenuItem.Size = new System.Drawing.Size(173, 22);
            this.StatusMenuItem.Text = "Строка состояния";
            this.StatusMenuItem.Click += new System.EventHandler(this.StatusLineMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpMenuItem,
            this.Separator6,
            this.AboutMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(65, 19);
            this.HelpMenu.Text = "&Справка";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Image = global::MyNotepad.Properties.Resources.Help;
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(156, 22);
            this.HelpMenuItem.Text = "Вызов справки";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // Separator6
            // 
            this.Separator6.Name = "Separator6";
            this.Separator6.Size = new System.Drawing.Size(153, 6);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(156, 22);
            this.AboutMenuItem.Text = "О программе";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // StatusLine
            // 
            this.StatusLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1,
            this.TextRow,
            this.Separator9,
            this.StatusLabel2,
            this.TextColumn,
            this.DebugLine,
            this.DebugText});
            this.StatusLine.Location = new System.Drawing.Point(0, 326);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusLine.Size = new System.Drawing.Size(448, 23);
            this.StatusLine.TabIndex = 1;
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(27, 18);
            this.StatusLabel1.Text = "Стр";
            // 
            // TextRow
            // 
            this.TextRow.AutoSize = false;
            this.TextRow.Name = "TextRow";
            this.TextRow.Size = new System.Drawing.Size(40, 18);
            this.TextRow.Text = "0";
            // 
            // Separator9
            // 
            this.Separator9.Name = "Separator9";
            this.Separator9.Size = new System.Drawing.Size(6, 23);
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.AutoSize = false;
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(30, 18);
            this.StatusLabel2.Text = "Кол";
            this.StatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextColumn
            // 
            this.TextColumn.AutoSize = false;
            this.TextColumn.Name = "TextColumn";
            this.TextColumn.Size = new System.Drawing.Size(40, 18);
            this.TextColumn.Text = "0";
            // 
            // DebugLine
            // 
            this.DebugLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DebugLine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DebugLine.Name = "DebugLine";
            this.DebugLine.Size = new System.Drawing.Size(290, 18);
            this.DebugLine.Spring = true;
            this.DebugLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DebugText
            // 
            this.DebugText.Name = "DebugText";
            this.DebugText.Size = new System.Drawing.Size(0, 18);
            // 
            // TextField
            // 
            this.TextField.AcceptsTab = true;
            this.TextField.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.TextField.AllowDrop = true;
            this.TextField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextField.ContextMenuStrip = this.ContextMenuLine;
            this.TextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextField.HideSelection = false;
            this.TextField.Location = new System.Drawing.Point(0, 19);
            this.TextField.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.TextField.MaxLength = 16777216;
            this.TextField.Name = "TextField";
            this.TextField.Size = new System.Drawing.Size(448, 308);
            this.TextField.TabIndex = 2;
            this.TextField.Text = "";
            this.TextField.DragDrop += new System.Windows.Forms.DragEventHandler(this.GetDroppedFile);
            this.TextField.DragEnter += new System.Windows.Forms.DragEventHandler(this.HandleDrag);
            this.TextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomeTyped);
            this.TextField.TextChanged += new System.EventHandler(this.TextFieldChanged);
            // 
            // ContextMenuLine
            // 
            this.ContextMenuLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoContextMenuItem,
            this.Separator7,
            this.CutContextMenuItem,
            this.CopyContextMenuItem,
            this.PasteContextMenuItem,
            this.Separator8,
            this.DeleteContextMenuItem});
            this.ContextMenuLine.Name = "TextContextMenu";
            this.ContextMenuLine.Size = new System.Drawing.Size(140, 126);
            // 
            // UndoContextMenuItem
            // 
            this.UndoContextMenuItem.Name = "UndoContextMenuItem";
            this.UndoContextMenuItem.Size = new System.Drawing.Size(139, 22);
            this.UndoContextMenuItem.Text = "Отменить";
            // 
            // Separator7
            // 
            this.Separator7.Name = "Separator7";
            this.Separator7.Size = new System.Drawing.Size(136, 6);
            // 
            // CutContextMenuItem
            // 
            this.CutContextMenuItem.Name = "CutContextMenuItem";
            this.CutContextMenuItem.Size = new System.Drawing.Size(139, 22);
            this.CutContextMenuItem.Text = "Вырезать";
            // 
            // CopyContextMenuItem
            // 
            this.CopyContextMenuItem.Name = "CopyContextMenuItem";
            this.CopyContextMenuItem.Size = new System.Drawing.Size(139, 22);
            this.CopyContextMenuItem.Text = "Копировать";
            // 
            // PasteContextMenuItem
            // 
            this.PasteContextMenuItem.Name = "PasteContextMenuItem";
            this.PasteContextMenuItem.Size = new System.Drawing.Size(139, 22);
            this.PasteContextMenuItem.Text = "Вставить";
            // 
            // Separator8
            // 
            this.Separator8.Name = "Separator8";
            this.Separator8.Size = new System.Drawing.Size(136, 6);
            // 
            // DeleteContextMenuItem
            // 
            this.DeleteContextMenuItem.Name = "DeleteContextMenuItem";
            this.DeleteContextMenuItem.Size = new System.Drawing.Size(139, 22);
            this.DeleteContextMenuItem.Text = "Удалить";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.DefaultExt = "txt";
            this.OpenFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            this.OpenFileDialog.RestoreDirectory = true;
            this.OpenFileDialog.ShowReadOnly = true;
            this.OpenFileDialog.SupportMultiDottedExtensions = true;
            this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ProceedFileOpen);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "txt";
            this.SaveFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            this.SaveFileDialog.RestoreDirectory = true;
            this.SaveFileDialog.SupportMultiDottedExtensions = true;
            // 
            // PrintDialog
            // 
            this.PrintDialog.UseEXDialog = true;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 349);
            this.Controls.Add(this.TextField);
            this.Controls.Add(this.StatusLine);
            this.Controls.Add(MenuLine);
            this.MainMenuStrip = MenuLine;
            this.Name = "MainWin";
            this.Text = "Мой блокнот";
            MenuLine.ResumeLayout(false);
            MenuLine.PerformLayout();
            this.StatusLine.ResumeLayout(false);
            this.StatusLine.PerformLayout();
            this.ContextMenuLine.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripMenuItem PageSetupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem UndoMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator3;
        private System.Windows.Forms.ToolStripMenuItem CutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator4;
        private System.Windows.Forms.ToolStripMenuItem FormatMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem FindMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindNextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplaceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator5;
        private System.Windows.Forms.ToolStripMenuItem SelectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertDateNTimeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WordWrapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontSetupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatusMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator6;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.PageSetupDialog PageSetup;
        private System.Windows.Forms.RichTextBox TextField;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TextRow;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.StatusStrip StatusLine;
        private System.Windows.Forms.ContextMenuStrip ContextMenuLine;
        private System.Windows.Forms.ToolStripMenuItem CutContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator8;
        private System.Windows.Forms.ToolStripSeparator Separator9;
        private System.Windows.Forms.ToolStripMenuItem DeleteContextMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel TextColumn;
        private System.Windows.Forms.ToolStripMenuItem UndoContextMenuItem;
		private System.Windows.Forms.ToolStripSeparator Separator7;
        private System.Windows.Forms.ToolStripStatusLabel DebugLine;
        private ToolStripStatusLabel DebugText;
    }
}

