using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JeaViPOS
{
    public static class Theme
    {
        public static readonly Color Accent = Color.FromArgb(37, 99, 235);
        public static readonly Color AccentHover = Color.FromArgb(29, 78, 216);
        public static readonly Color Page = Color.FromArgb(243, 244, 246);
        public static readonly Color Ink = Color.FromArgb(17, 24, 39);
        public static readonly Color Muted = Color.FromArgb(107, 114, 128);
        public static readonly Color Line = Color.FromArgb(229, 231, 235);
        public static readonly Color Danger = Color.FromArgb(220, 38, 38);
        public static readonly Color DangerHover = Color.FromArgb(185, 28, 28);
        public static readonly Color LowRowBack = Color.FromArgb(254, 242, 242);
        public static readonly Color LowRowText = Color.FromArgb(153, 27, 27);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        private static void StyleButton(Button b, Color back, Color hover, Color fore, bool outlined)
        {
            b.UseVisualStyleBackColor = false;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = outlined ? 1 : 0;
            if (outlined) b.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            b.FlatAppearance.MouseOverBackColor = hover;
            b.FlatAppearance.MouseDownBackColor = hover;
            b.BackColor = back;
            b.ForeColor = fore;
            b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            b.Cursor = Cursors.Hand;
        }

        public static void StylePrimary(Button b)
        { StyleButton(b, Accent, AccentHover, Color.White, false); }

        public static void StyleSecondary(Button b)
        { StyleButton(b, Color.White, Color.FromArgb(243, 244, 246), Ink, true); }

        public static void StyleDanger(Button b)
        { StyleButton(b, Danger, DangerHover, Color.White, false); }

        // Gives every TextBox / ComboBox on the form the same clean look
        public static void StyleInputs(Control root)
        {
            foreach (Control c in root.Controls)
            {
                if (c is TextBox)
                {
                    var t = (TextBox)c;
                    t.BorderStyle = BorderStyle.FixedSingle;
                    t.Font = new Font("Segoe UI", 10.5F);
                }
                else if (c is ComboBox)
                {
                    var cb = (ComboBox)c;
                    cb.FlatStyle = FlatStyle.Flat;
                    cb.Font = new Font("Segoe UI", 10.5F);
                }
                if (c.HasChildren) StyleInputs(c);
            }
        }

        // Gray hint text inside an empty TextBox
        public static void SetPlaceholder(TextBox tb, string text)
        {
            if (tb.IsHandleCreated) SendMessage(tb.Handle, 0x1501, (IntPtr)1, text);
            else tb.HandleCreated += (s, e) => SendMessage(tb.Handle, 0x1501, (IntPtr)1, text);
        }

        public static void StyleGrid(DataGridView g)
        {
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.None;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.GridColor = Line;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 42;
            g.RowTemplate.Height = 38;

            var h = g.ColumnHeadersDefaultCellStyle;
            h.BackColor = Color.FromArgb(249, 250, 251);
            h.ForeColor = Muted;
            h.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            h.SelectionBackColor = h.BackColor;
            h.SelectionForeColor = h.ForeColor;
            h.Padding = new Padding(10, 0, 0, 0);

            var c = g.DefaultCellStyle;
            c.Font = new Font("Segoe UI", 10F);
            c.ForeColor = Ink;
            c.BackColor = Color.White;
            c.SelectionBackColor = Color.FromArgb(219, 234, 254);
            c.SelectionForeColor = Ink;
            c.Padding = new Padding(10, 0, 0, 0);

            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);
        }
    }
}