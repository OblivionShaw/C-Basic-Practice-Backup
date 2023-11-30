using System;
using System.Collections.Generic;
using System.Text;

namespace Gomoku
{
    class GameManager
    {
        private Board board = new Board();
        private PieceType currentPlayer = PieceType.BLACK;

        private PieceType winner = PieceType.NONE;
        public PieceType Winner { get { return winner; } }

        public bool CanBePlaced(int x, int y)
        {
            return board.CanBePlaced(x, y);
        }

        public Piece PlaceAPiece(int x, int y)
        {
            Piece piece = board.PlaceAPiece(x, y, currentPlayer);
            if (piece != null)
            {
                // 檢查當前下棋者是否勝利
                checkWinner();

                // 交換選手
                currentPlayer = currentPlayer != PieceType.BLACK ? PieceType.BLACK : PieceType.WHITE;
                return piece;
            }
            return null;
        }

        private void checkWinner()
        {
            int centerX = board.LastPlacedNode.X;
            int centerY = board.LastPlacedNode.Y;

            // 檢查8方向
            for (int xDir = -1; xDir <= 1; xDir++)
            {
                for (int yDir = -1; yDir <= 1; yDir++)
                {
                    // 排除中間的情況
                    if (xDir == 0 && yDir == 0)
                        continue;

                    // 紀錄現在看到幾顆相同的棋子
                    // 檢查正向
                    int count = 1;
                    
                    while (count < 5)
                    {
                        int targetX = centerX + count * xDir;
                        int targetY = centerY + count * yDir;

                        // 檢查顏色
                        if (targetX < 0 | targetX >= Board.NODE_COUNT ||
                            targetY < 0 | targetY >= Board.NODE_COUNT ||
                            board.GetPieceType(targetX, targetY) != currentPlayer)
                            break;

                        count++;
                    }

                    // 檢查反向
                    int countReverse = 0;
                    while (countReverse < 5)
                    {
                        int targetX = centerX - countReverse * xDir;
                        int targetY = centerY - countReverse * yDir;

                        // 檢查顏色
                        if (targetX < 0 | targetX >= Board.NODE_COUNT ||
                            targetY < 0 | targetY >= Board.NODE_COUNT ||
                            board.GetPieceType(targetX, targetY) != currentPlayer)
                            break;

                        countReverse++;
                    }

                    // 檢查是否5顆棋子
                    if (count + countReverse - 1 == 5)
                        winner = currentPlayer;
                }
            }
        }
    }
}
