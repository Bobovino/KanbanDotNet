using System.Collections.Generic;
using System.Linq;
using KanbanApi.Models;

namespace KanbanApi.Services
{
    public class BoardService
    {
        private readonly List<Board> _boards = new List<Board>();

        public IEnumerable<Board> GetAllBoards()
        {
            return _boards;
        }

        public Board GetBoardById(int id)
        {
            return _boards.FirstOrDefault(b => b.Id == id);
        }

        public void CreateBoard(Board board)
        {
            _boards.Add(board);
        }

        public void UpdateBoard(Board board)
        {
            var existingBoard = GetBoardById(board.Id);
            if (existingBoard != null)
            {
                existingBoard.Name = board.Name;
                existingBoard.Tasks = board.Tasks;
            }
        }

        public void DeleteBoard(int id)
        {
            var board = GetBoardById(id);
            if (board != null)
            {
                _boards.Remove(board);
            }
        }
    }
}