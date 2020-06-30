namespace CAS.UT.Practice.Libs
{
    public class ScoreCal : IScoreCal
    {
        public string CalculateScore(int player1Score, int player2Score)
        {
            return (player1Score, player2Score) switch
            {
                (1, 0) => "FifteenLove",
                (2, 0) => "ThirtyLove",
                (3, 0) => "FortyLove",
                (4, 0) => "Player1Win"
            };
        }
    }
}