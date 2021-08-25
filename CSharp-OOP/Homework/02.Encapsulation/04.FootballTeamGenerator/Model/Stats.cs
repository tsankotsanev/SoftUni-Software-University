using System;

namespace _04.FootballTeamGenerator.Model
{
    public class Stats
    {
        private int _endurance;
        private int _sprint;
        private int _dribble;
        private int _passing;
        private int _shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        private int Endurance
        {
            set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException(string.Format(Common.Validator.InvalidRating,
                        nameof(Endurance), Common.Validator.MinValueOfStats, Common.Validator.MaxValueOfStats));
                }
                _endurance = value;
            }
        }
        private int Sprint
        {
            set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException(string.Format(Common.Validator.InvalidRating,
                        nameof(Sprint), Common.Validator.MinValueOfStats, Common.Validator.MaxValueOfStats));
                }
                _sprint = value;
            }
        }
        private int Dribble
        {
            set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException(string.Format(Common.Validator.InvalidRating, nameof(Dribble),
                         Common.Validator.MinValueOfStats, Common.Validator.MaxValueOfStats));
                }
                _dribble = value;
            }
        }
        private int Passing
        {
            set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException(string.Format(Common.Validator.InvalidRating,
                        nameof(Passing), Common.Validator.MinValueOfStats, Common.Validator.MaxValueOfStats));
                }
                _passing = value;
            }
        }
        private int Shooting
        {
            set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException(string.Format(Common.Validator.InvalidRating,
                        nameof(Shooting), Common.Validator.MinValueOfStats, Common.Validator.MaxValueOfStats));
                }
                _shooting = value;
            }
        }
        private bool IsValid(int value) => value is >= Common.Validator.MinValueOfStats and <= Common.Validator.MaxValueOfStats;

        public double Average()
        {
            var average =
                (_endurance + _dribble + _shooting + _passing + _sprint) / 5.00;

            return average;
        }
    }
}
