using System.Text;

namespace TemplateConsole.Domain.Model
{
    internal class Snake
    {
        private List<string> _pieces;
        public string Body => GetSnakeBody();

        public Snake()
        {
            _pieces = new List<string>();
        }
        public void AddEndingPiece(string piece)
        {
            _pieces.Add(piece);
        }
        public void AddStartingPiece(string piece)
        {
            _pieces.Insert(0, piece);
        }

        private string GetSnakeBody()
        {
            var sb = new StringBuilder();
            _pieces.ForEach(piece => sb.Append(piece));
            return sb.ToString();
        }
    }
}
