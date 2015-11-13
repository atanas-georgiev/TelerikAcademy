namespace Task07_MatrixPassableNonPassable
{
    public class Cell
    {
        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public override string ToString()
        {
            return "(" + this.X + "; " + this.Y + ")";
        }
    }
}
