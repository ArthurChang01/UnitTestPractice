using System;

namespace CAS.UT.Practice.Libs
{
    public class TennisGame
    {
        #region Fields

        private readonly string _name;

        #endregion Fields

        #region Constructors

        public TennisGame()
        {
        }

        public TennisGame(string name, DateTimeOffset? occuredDate = null)
        {
            _name = name;
            OccuredDate = occuredDate ?? DateTimeOffset.Now;
        }

        #endregion Constructors

        #region Properties

        public string DisplayName => $"{_name}{OccuredDate:yyyyMMdd}";

        public DateTimeOffset OccuredDate { get; } = DateTimeOffset.Now;

        #endregion Properties
    }
}