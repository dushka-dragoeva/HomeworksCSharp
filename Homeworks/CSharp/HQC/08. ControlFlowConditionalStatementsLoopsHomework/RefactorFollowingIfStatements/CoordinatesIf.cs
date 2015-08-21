/* Part2 Refactor the following if statement
          if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
          {
             VisitCell();
          }*/

namespace RefactorFollowingIfStatements
{
    using System;

    public class CoordinatesIf
    {
        public const int MIN_X = 1;
        public const int MAX_X = 155;
        public const int MIN_Y = 1;
        public const int MAX_Y = 200;

        public static void Main(string[] args)
        {
            int x = 5;
            int y = 66;
            bool isXInRange = IsValueInRange(x, MIN_X, MAX_X);
            bool isYInRange = IsValueInRange(y, MIN_Y, MAX_Y);
            bool shouldVisitCell = !IsCellVisited(x, y);
            if (isXInRange && isYInRange && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }

        private static bool IsValueInRange(int value, int minValue, int maxValue)
        {
            bool isInRange = minValue <= value && value <= maxValue;
            return isInRange;
        }

        private static bool IsCellVisited(int x, int y)
        {
            bool isVisited = false;
            //// some logic according task
            return isVisited;
        }
    }
}