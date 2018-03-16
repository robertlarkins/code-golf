namespace ExampleAlgorithms
{
    public class ArrayDimensionMapping
    {
        /// <summary>
        /// Row and column are the subscript values identifying which element in the array to access.
        /// The term subscript comes from matrix math for indexing a matrix element. An alternative
        /// name for these might be indices.
        /// Index notation is the term used for specifying individual elements.
        /// https://en.wikipedia.org/wiki/Index_notation#Index_notation_in_computing
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public int SubscriptToIndex(int row, int column, int width)
        {
            return row * width + column;
        }

        public (int row, int column) IndexToSubscript(int index, int width)
        {
            return (index / width, index % width);
        }
    }
}