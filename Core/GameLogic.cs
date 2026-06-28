using System;
using TicTacToeGame.Models;
using TicTacToeGame.Enums;
using System.Drawing;

namespace TicTacToeGame.Core
{
    internal class GameLogic
    {
        private const char _emptyCell = ' ';
        private const byte _boardSize = 3;
        private Player _playerX;
        private Player _playerO;
        private Player _currentPlayer;
        private char[,] _board;
        private GameState _state;
        private Point[] _winningCells;
        public GameLogic(string playerXName, string playerOName)
        {
            _playerX = new Player(playerXName, 'X');
            _playerO = new Player(playerOName, 'O');
            _currentPlayer = _playerX;
            InitializeBoard();
            _state = GameState.InProgress;
            _winningCells = new Point[_boardSize];
        }
        private void InitializeBoard()
        {
            _board = new char[_boardSize, _boardSize];
            for(byte i = 0; i < _boardSize; i++)
            {
                for(byte j = 0; j < _boardSize; j++)
                {
                    _board[i, j] = _emptyCell;
                }
            }
        }
        private bool CheckWinnerCondition(Player player)
        {
            char symbol = player.Symbol;

            // Check rows
            for (int row = 0; row < _boardSize; row++)
            {
                if (_board[row, 0] == symbol &&
                    _board[row, 1] == symbol &&
                    _board[row, 2] == symbol)
                {
                    // Store the winning cells
                    _winningCells[0] = new Point(row, 0);
                    _winningCells[1] = new Point(row, 1);
                    _winningCells[2] = new Point(row, 2);
                    return true;
                }
            }

            // Check columns
            for (int col = 0; col < _boardSize; col++)
            {
                if (_board[0, col] == symbol &&
                    _board[1, col] == symbol &&
                    _board[2, col] == symbol)
                {
                    // Store the winning cells
                    _winningCells[0] = new Point(0, col);
                    _winningCells[1] = new Point(1, col);
                    _winningCells[2] = new Point(2, col);
                    return true;
                }
            }

            // Check main diagonal
            if (_board[0, 0] == symbol &&
                _board[1, 1] == symbol &&
                _board[2, 2] == symbol)
            {
                _winningCells[0] = new Point(0, 0);
                _winningCells[1] = new Point(1, 1);
                _winningCells[2] = new Point(2, 2);
                return true;
            }

            // Check secondary diagonal
            if (_board[0, 2] == symbol &&
                _board[1, 1] == symbol &&
                _board[2, 0] == symbol)
            {
                _winningCells[0] = new Point(0, 2);
                _winningCells[1] = new Point(1, 1);
                _winningCells[2] = new Point(2, 0);
                return true;
            }

            return false;
        }
        private bool IsBoardFull()
        {
            for (int row = 0; row < _boardSize; row++)
            {
                for (int col = 0; col < _boardSize; col++)
                {
                    if (_board[row, col] == _emptyCell)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void UpdateGameState()
        {
            if(CheckWinnerCondition(_playerX))
            {
                _state = GameState.PlayerXWins;
            }
            else if(CheckWinnerCondition(_playerO))
            {
                _state = GameState.PlayerOWins;
            }
            else if(IsBoardFull())
            {
                _state = GameState.Draw;
            }
            else
            {
                _state = GameState.InProgress;
            }
        }
        private void SwitchPlayer()
        {
            _currentPlayer = (_currentPlayer.Symbol == _playerX.Symbol) ? _playerO : _playerX;
        }
        public Point[] WinningCells
        {
            get { return _winningCells; }
        }
        public string CurrentPlayerName
        {
            get { return _currentPlayer.Name; }
        }
        public char CurrentPlayerSymbol
        {
            get { return _currentPlayer.Symbol; }
        }
        public char GetCell(int rowIndex, int colIndex)
        {
            if((rowIndex < _boardSize) && (colIndex < _boardSize))
                return _board[rowIndex, colIndex];
            throw new ArgumentOutOfRangeException("Invalid cell position");
        }
        public GameState State
        {
            get { return _state; }
        }
        public bool IsEmptyCell(byte rowIndex, byte colIndex)
        {
            return _board[rowIndex, colIndex] == _emptyCell;
        }
        public bool IsValidCell(byte rowIndex, byte colIndex)
        {
            return (rowIndex < _boardSize) && (colIndex < _boardSize) && IsEmptyCell(rowIndex, colIndex);
        }
        public bool MakeMove(byte rowIndex, byte colIndex)
        {
            if (!IsValidCell(rowIndex, colIndex) || _state != GameState.InProgress)
                return false;

            
            _board[rowIndex, colIndex] = _currentPlayer.Symbol;

            UpdateGameState();

            if (_state == GameState.InProgress)
            {
                SwitchPlayer();
            }

            return true;
        }
    }
}
