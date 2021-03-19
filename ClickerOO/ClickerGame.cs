using System;

namespace ClickerOO
{
    class ClickerGame
    {
        private int _pointsPerClick;
        public int Points { get; private set; }

        public ClickerGame()
        {
            Points = 0;
            _pointsPerClick = 1;
        }

        public void Click()
        {
            Points += _pointsPerClick;
        }

        public void Upgrade()
        {
            if (Points >= 10)
            {
                Points -= 10;
                _pointsPerClick++;
            }
        }

        //public int GetPoints()
        //{
        //    return _points;
        //}

        //protected void SetPoints(int points)
        //{
        //    _points = points;
        //}

        /*
            public ClickerGame() : this(0, 1)
            {
            }

            public ClickerGame(int points, int pointsPerClick)
            {
                _points = points;
                _pointsPerClick = pointsPerClick;
            }
         */


    }
}
