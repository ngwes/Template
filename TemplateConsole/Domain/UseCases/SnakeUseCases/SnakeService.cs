using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateConsole.Domain.Model;

namespace TemplateConsole.Domain.UseCases.SnakeUseCases
{
    public class SnakeService : ISnakeService
    {
        public void CreateSnake()
        {
            var snake = new Snake();
            Console.WriteLine("Add First piece");
            var piece = Console.ReadLine() ?? "";
            snake.AddStartingPiece(piece);
            Console.WriteLine("Add Second piece to the end");
            piece = Console.ReadLine() + "-------";
            snake.AddEndingPiece(piece);
            Console.WriteLine("Add Third piece to the head");
            piece = "8-)----" + Console.ReadLine();
            snake.AddStartingPiece(piece);
            Console.WriteLine("That's what you've built");
            Console.WriteLine(snake.Body);
        }

        public void CreateLazySnake()
        {
            var snake = new LazySnake();
            Console.WriteLine("Add First piece");
            var piece = Console.ReadLine() ?? "";
            snake.AddPieceToTheStart(piece);
            Console.WriteLine("Add Second piece to the end");
            piece = Console.ReadLine() + "-------";
            snake.AddPieceToTheEnd(piece);
            Console.WriteLine("Add Third piece to the head");
            piece = "8-)----" + Console.ReadLine();
            snake.AddPieceToTheStart(piece);
            Console.WriteLine("That's what you've built");
            Console.WriteLine(snake.Body);
        }
    }
}
