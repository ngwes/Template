using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateConsole.Domain.Model
{
    internal class LazySnake
    {
        private readonly List<Func<Snake, Snake>> actions = new List<Func<Snake, Snake>>();
        public string Body => Materialize().Body;
        public LazySnake Do(Action<Snake> action) => AddAction(action);
        private Snake Materialize() => actions.Aggregate(new Snake(), (snake, f) => f(snake));

        private LazySnake AddAction(Action<Snake> action)
        {
            actions.Add(snake => { action(snake); return snake; });
            return this;
        }

        // one of the possibilites
        public LazySnake AddPieceToTheEnd(string piece) => Do(s => s.AddEndingPiece(piece));
    }

    internal static class LazySnakeExtensions
    {
        public static LazySnake AddPieceToTheStart(this LazySnake sb, string piece)
        {
            return sb.Do(s => s.AddStartingPiece(piece));
        }

    }
}
