using System;

namespace CAS.UT.Practice.Libs
{
    public class TennisGame
    {
        #region Fields

        private readonly string _name;
        private readonly IScoreCal _service;

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

        public TennisGame(string name, IScoreCal service)
            : this(name)
        {
            _service = service;
        }

        #endregion Constructors

        #region Properties

        public string DisplayName => $"{_name}{OccuredDate:yyyyMMdd}";

        public DateTimeOffset? OccuredDate { get; }

        public bool IsEnd { get; private set; }

        public string Score => _service?.CalculateScore(this) ?? "LoveAll";

        #endregion Properties

        #region Public Methods

        public void ForceTerminate()
        {
            if (IsEnd)
                throw new IllegalOperationException("Property: IsEnd is true.");

            if (OccuredDate > DateTimeOffset.Now)
                throw new IllegalOperationException("OccuredDate is future time.");

            IsEnd = true;
        }

        #endregion Public Methods
    }
}