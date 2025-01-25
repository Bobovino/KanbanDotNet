using Microsoft.AspNetCore.Mvc;
using KanbanApi.Models;
using KanbanApi.Services;
using System.Collections.Generic;

namespace KanbanApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoardController : ControllerBase
    {
        private readonly BoardService _boardService;

        public BoardController(BoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Board>> GetBoards()
        {
            return Ok(_boardService.GetAllBoards());
        }

        [HttpGet("{id}")]
        public ActionResult<Board> GetBoardById(int id)
        {
            var board = _boardService.GetBoardById(id);
            if (board == null)
            {
                return NotFound();
            }
            return Ok(board);
        }

        [HttpPost]
        public ActionResult<Board> CreateBoard(Board board)
        {
            _boardService.CreateBoard(board);
            return CreatedAtAction(nameof(GetBoardById), new { id = board.Id }, board);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBoard(int id, Board board)
        {
            if (id != board.Id)
            {
                return BadRequest();
            }

            var existingBoard = _boardService.GetBoardById(id);
            if (existingBoard == null)
            {
                return NotFound();
            }

            _boardService.UpdateBoard(board);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBoard(int id)
        {
            var board = _boardService.GetBoardById(id);
            if (board == null)
            {
                return NotFound();
            }

            _boardService.DeleteBoard(id);
            return NoContent();
        }
    }
}