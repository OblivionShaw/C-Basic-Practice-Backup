using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class Form1 : Form
    {
        private GameManager gm = new GameManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Piece piece = gm.PlaceAPiece(e.X, e.Y);
            if (piece != null)
            {
                this.Controls.Add(piece);

                // 檢查是否有人勝利

                if (gm.Winner == PieceType.BLACK)
                {
                    MessageBox.Show("黑棋勝利");
                }
                else if (gm.Winner == PieceType.WHITE)
                {
                    MessageBox.Show("白棋勝利");
                }

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = gm.CanBePlaced(e.X, e.Y) ? this.Cursor = Cursors.Hand : this.Cursor = Cursors.Default;
        }
    }
}
