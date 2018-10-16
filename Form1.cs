using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class board_Form : Form
    {
        public board_Form()
        {
            InitializeComponent();
        }

        Graphics boardGraphics;

        int[] markedPositions = new int[9]; // 0 = nothing, 1 = X, 2 = O

        bool xTurn = true;
        bool gameOver = false;
        int turnCount = 0, xWinsCount = 0, oWinsCount = 0, tieCount = 0;

        Pen linePen = new Pen(Color.Black, 1);
        Pen xPen = new Pen(Color.Red, 10);
        Pen oPen = new Pen(Color.Blue, 10);

        private void board_Form_Load(object sender, EventArgs e)
        {
            boardGraphics = board_Panel.CreateGraphics();
        }

        private void newGame_Button_Click(object sender, EventArgs e)
        {
            createBoard();
        }

        private void board_Panel_MouseClick(object sender, MouseEventArgs e)
        {
            activateTurn(e.Location);
        }

        private void createBoard()
        {
            turnCount = 0;
            gameOver = false;

            boardGraphics.Clear(board_Panel.BackColor);
            turn_Label.Text = (xTurn) ? "Turn: X" : "Turn: O";

            int boardWidth = board_Panel.Width;
            int boardHeight = board_Panel.Height;

            boardGraphics.DrawLine(linePen, new Point(boardWidth / 3, 10), new Point(boardWidth / 3, boardHeight - 10));
            boardGraphics.DrawLine(linePen, new Point(2 * boardWidth / 3, 10), new Point(2 * boardWidth / 3, boardHeight - 10));

            boardGraphics.DrawLine(linePen, new Point(10, boardHeight / 3), new Point(boardWidth - 10, boardHeight / 3));
            boardGraphics.DrawLine(linePen, new Point(10, 2 * boardHeight / 3), new Point(boardWidth - 10, 2 * boardHeight / 3));

            Array.Clear(markedPositions, 0, markedPositions.Length);
        }

        private void activateTurn(Point position)
        {
            int column = getColumn(position.X);
            int row = getRow(position.Y);
            int arrayIndex = column + (row * 3);

            turnCount++;

            if (markedPositions[arrayIndex] == 0 && !gameOver)
            {
                markedPositions[arrayIndex] = (xTurn) ? 1 : 2;
                drawOnBoard(new Point(row, column));
                xTurn = !xTurn;
                turn_Label.Text = (xTurn) ? "Turn: X" : "Turn: O";
            }
            else
            {
                MessageBox.Show((gameOver) ? "Game Already Finished" : "Already Marked!", "Error");
                return;
            }

            #region Game Logic
            if (turnCount >= 5)
            {
                bool? xWin = null;

                for (int mark = 0; mark < markedPositions.Length; mark++)
                {
                    if (markedPositions[mark] != 0)
                    {
                        if (mark <= 2)
                        {
                            if (markedPositions[mark] == markedPositions[mark + 3] && markedPositions[mark] == markedPositions[mark + 6])
                            {
                                xWin = (!xTurn) ? true : false;
                                break;
                            }
                            else if (markedPositions[mark] == markedPositions[mark + 3] && markedPositions[mark] == markedPositions[mark + 6])
                            {
                                xWin = (!xTurn) ? true : false;
                                break;
                            }
                        }
                        else if (mark <= 6)
                        {
                            if ((mark % 3) == 0 && markedPositions[mark] == markedPositions[mark + 1] && markedPositions[mark] == markedPositions[mark + 2])
                            {
                                xWin = (!xTurn) ? true : false;
                                break;
                            }
                        }

                        if (mark == 0)
                        {
                            if (markedPositions[mark] == markedPositions[mark + 4] && markedPositions[mark] == markedPositions[mark + 8])
                            {
                                xWin = (!xTurn) ? true : false;
                                break;
                            }
                            else if (markedPositions[mark] == markedPositions[mark + 1] && markedPositions[mark] == markedPositions[mark + 2])
                            {
                                xWin = (!xTurn) ? true : false;
                                break;
                            }
                        }
                        else if (mark == 2)
                        {
                            if (markedPositions[mark] == markedPositions[mark + 2] && markedPositions[mark] == markedPositions[mark + 4])
                            {
                                xWin = (!xTurn) ? true : false;
                                break;
                            }
                        }
                    }
                }

                if (xWin == null && turnCount == 9) //Check if there is a draw
                {
                    giveDraw();
                }

                if (xWin != null)
                {
                    giveWin(Convert.ToBoolean(xWin));
                }
            }
            #endregion

        }

        private void drawOnBoard(Point boardPosition)
        {
            Point startingPoint = new Point((boardPosition.Y * (board_Panel.Width / 3)) + 10, (boardPosition.X * (board_Panel.Height / 3)) + 10);
            Point endPoint = new Point(startingPoint.X + (board_Panel.Width / 3) - 15, startingPoint.Y + (board_Panel.Height / 3) - 15);
            Rectangle ellipseBounds = new Rectangle(startingPoint.X, startingPoint.Y, endPoint.X - startingPoint.X, endPoint.Y - startingPoint.Y);
            if (xTurn)
            {
                boardGraphics.DrawLine(xPen, startingPoint, endPoint);
                boardGraphics.DrawLine(xPen, new Point(startingPoint.X, endPoint.Y), new Point(endPoint.X, startingPoint.Y));
            }
            else
            {
                boardGraphics.DrawEllipse(oPen, ellipseBounds);
            }
        }

        private int getRow(int yLocation)
        {
            int boardHeight = board_Panel.Height;

            if (yLocation < boardHeight / 3)
            {
                return 0;
            }
            else if (yLocation > 2 * boardHeight / 3)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        private int getColumn(int xLocation)
        {
            int boardWidth = board_Panel.Width;

            if (xLocation < boardWidth / 3)
            {
                return 0;
            }
            else if (xLocation > 2 * boardWidth / 3)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        private void board_Form_Shown(object sender, EventArgs e)
        {
            createBoard();
        }

        private void giveWin(bool xWin)
        {
            turn_Label.Text = "Game Over";
            gameOver = true;
            if (xWin)
            {
                tictactoe.Properties.Settings.Default.xWinsTotal++;
                xWinsCount++;
                MessageBox.Show("X's win!", "Game Over");
            }
            else
            {
                tictactoe.Properties.Settings.Default.oWinsTotal++;
                oWinsCount++;
                MessageBox.Show("O's win!", "Game Over");
            }
        }

        private void giveDraw()
        {
            turn_Label.Text = "Game Over";
            gameOver = true;
            tictactoe.Properties.Settings.Default.tieGamesTotal++;
            tieCount++;
            MessageBox.Show("Draw", "Game Over");
        }

        private void viewStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CURRENT SESSION:\nX Wins: " + xWinsCount + "\nO Wins: " + oWinsCount + "\nDraw Games: " + tieCount + "\nTotal Games: " + (xWinsCount + oWinsCount + tieCount) + "\n\nALL SESSIONS:\nX Wins: " + tictactoe.Properties.Settings.Default.xWinsTotal + "\nO Wins: " + tictactoe.Properties.Settings.Default.oWinsTotal + "\nDraw Games: " + tictactoe.Properties.Settings.Default.tieGamesTotal + "\nTotal Games: " + (tictactoe.Properties.Settings.Default.xWinsTotal + tictactoe.Properties.Settings.Default.oWinsTotal + tictactoe.Properties.Settings.Default.tieGamesTotal), "Game Statistics");
        }
    }
}
