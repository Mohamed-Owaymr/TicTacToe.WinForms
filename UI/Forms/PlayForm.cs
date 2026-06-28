using System;
using System.Drawing;
using System.Windows.Forms;
using TicTacToeGame.Core;
using TicTacToeGame.Enums;

namespace TicTacToeGame.UI.Forms
{
    public partial class PlayForm : Form
    {
        private const int BoardX = 385;
        private const int BoardY = 120;
        private const int BoardSize = 330;
        private PictureBox[,] _cells = new PictureBox[3, 3];
        private GameLogic _gameLogic = new GameLogic("Player X" , "Player O");
        public PlayForm()
        {
            InitializeComponent();
            CreateCells();
            UpdateLiveLabels();
        }
        private void CreateCells()
        {
            int cellSize = BoardSize / 3;

            for (int row = 0; row < 3; ++row)
            {
                for (int col = 0; col < 3; ++col)
                {
                    PictureBox pbCell = new PictureBox();

                    pbCell.Width = cellSize;
                    pbCell.Height = cellSize;

                    pbCell.Left = BoardX + col * cellSize;
                    pbCell.Top = BoardY + row * cellSize;

                    pbCell.Image = Properties.Resources.question_mark_96;

                    pbCell.Cursor = Cursors.Hand;

                    pbCell.BackColor = Color.Black;

                    pbCell.BorderStyle = BorderStyle.FixedSingle;

                    pbCell.SizeMode = PictureBoxSizeMode.StretchImage;

                    pbCell.Tag = new Point(row, col);

                    pbCell.Click += Cell_Click;

                    _cells[row, col] = pbCell;

                    Controls.Add(pbCell);
                }
            }
        }
        private void UpdateLiveLabels()
        {
            lblTurn.Text = _gameLogic.CurrentPlayerName;

            switch (_gameLogic.State)
            {
                case GameState.InProgress:  lblWinner.Text = "In Progress"; break;
                case GameState.PlayerXWins: lblWinner.Text = "Player X Wins"; break;
                case GameState.PlayerOWins: lblWinner.Text = "Player O Wins"; break;
                case GameState.Draw: lblWinner.Text = "Draw"; break;
            }
        }
        private void UpdateCellImage(PictureBox cell , char playerSymbol)
        { 
            if(playerSymbol == 'X')
            {
                cell.Image = Properties.Resources.X;
            }
            else
            {
                cell.Image = Properties.Resources.O;
            }
        }
        private void HighlightWinningCells(Color color)
        {
            foreach (Point winningCellPoint in _gameLogic.WinningCells)
            {
                (_cells[winningCellPoint.X, winningCellPoint.Y]).BackColor = color;
            }
        }
        private void RestartCells()
        {
            foreach (PictureBox cell in _cells)
            {
                cell.Image = Properties.Resources.question_mark_96;
                cell.BackColor = Color.Black;
            }
        }
        private void RestartGame()
        {
            _gameLogic = new GameLogic("Player X", "Player O");
            RestartCells();
            EnableCells();
            UpdateLiveLabels();
        }
        private bool GameIsOver()
        {
            return _gameLogic.State != GameState.InProgress;
        }
        private void DisableCells()
        {
            foreach (PictureBox cell in _cells)
            {
                cell.Enabled = false;
            }
        }
        private void EnableCells()
        {
            foreach (PictureBox cell in _cells)
            {
                cell.Enabled = true;
            }
        }
        private void PlayForm_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.White, 5))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    BoardX,
                    BoardY,
                    BoardSize,
                    BoardSize);
            }
        }
        private void Cell_Click(object sender, EventArgs e)
        {
            if (GameIsOver())
            {
                DisableCells();
            }
            else
            {
                PictureBox cell = sender as PictureBox;
                Point cellPosition = (Point)cell.Tag;
                char currentPlayerSymbol = _gameLogic.CurrentPlayerSymbol;

                bool successMove = _gameLogic.MakeMove(
                    (byte)cellPosition.X,
                    (byte)cellPosition.Y
                );

                if (successMove)
                    UpdateCellImage(cell, currentPlayerSymbol);

                UpdateLiveLabels();
            }

            if (_gameLogic.State == GameState.PlayerXWins ||
                _gameLogic.State == GameState.PlayerOWins)
            {
                HighlightWinningCells(Color.Green);
            }
        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
