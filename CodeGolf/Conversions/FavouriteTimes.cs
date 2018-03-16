using System.Collections.Generic;
using System.Linq;

namespace CodeGolf.Conversions
{
    public class FavouriteTimes
    {
        /// <summary>
        /// https://codegolf.stackexchange.com/questions/152275/finding-my-favorite-times#152276
        /// </summary>
        /// <returns></returns>
        public int[] TimeTillFavourite(int time)
        {
            var favourites = new List<int> { 0000, 0123, 1111, 1234, 2222, 2345 };

            if (favourites.Contains(time))
            {
                return new[] { 0 };
            }

            // https://msdn.microsoft.com/en-us/library/w4e7fxsh(v=vs.110).aspx
            favourites.B
        }
    }
}