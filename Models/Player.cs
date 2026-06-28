using System;
using System.Linq;

namespace TicTacToeGame.Models
{
    internal class Player
    {
        private static readonly char[] _allowedSymbols = { 'X', 'O' };
        public string Name { get; }
        public char Symbol { get; }
        public Player(string name, char symbol)
        {
            if (name is null)
                throw new ArgumentNullException(nameof(name), "Input string (name) cannot be null");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty", nameof(name));

            if (!_allowedSymbols.Contains(char.ToUpper(symbol)))
                throw new ArgumentException("Invalid symbol", nameof(symbol));

            Name = name;
            Symbol = char.ToUpper(symbol);
        }
    }
}
