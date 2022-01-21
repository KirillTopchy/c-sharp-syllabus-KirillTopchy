using System.Drawing;
using System.Windows.Forms;

namespace Sudoku.Core
{
    public enum CellType
    {
        Locked, Unlocked
    }

    public class Cell : Button
    {
        public int XLoc { get; set; }

        public int YLoc { get; set; }

        public int CellSize { get; set; }

        public CellType CellType { get; set; }

        public int CellValue { get; set; }

        // Cell design.
        public void SetupDesign()
        {
            Location = new Point(XLoc * CellSize, YLoc * CellSize);
            Size = new Size(CellSize, CellSize);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = Color.Black;
            Font = new Font(SystemFonts.DefaultFont.FontFamily, 15);
        }

        // Clear cell value.
        public void Clear()
        {
            Text = string.Empty;
            CellType = CellType.Unlocked;
        }
    }
}
