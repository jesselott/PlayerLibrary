namespace PlayerLibrary.Models
{
    public class Pitcher : Player
    {
        //pitching stats
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Saves { get; set; }
        public int GamesStarted { get; set; }
        public int CompleteGames { get; set; }
        public int ShutOuts { get; set; }
        public int InningsPitched { get; set; }
        public int HitsAllowed { get; set; }
        public int RunsAllowed { get; set; }
        public int EarnedRunsAllowed { get; set; }
        public int HomeRunsAllowed { get; set; }
        public int Ks { get; set; }
        public int WalksIssued { get; set; }
        public int HitByPitches { get; set; }
        public int WildPitches { get; set; }

        //pitching stats that require formulas
        public float WinningPct
        {
            get
            {
                return (float)Wins /
                    (float)Wins +
                    (float)Losses;
            }
        }
        public float EarnedRunAvg
        {
            get
            {
                return 9 * ((float)EarnedRunsAllowed /
                    (float)InningsPitched);

            }
        }
        public float KsPerNineInnings
        {
            get
            {
                return (float)Ks / 9;
            }
        }
        public float WalksAndHitsInningPitched
        {
            get
            {
                return (float)Walks +
                    (float)Ks /
                    (float)InningsPitched;
            }
        }

    }
}