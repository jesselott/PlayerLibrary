using System;
using System.ComponentModel.DataAnnotations;

namespace PlayerLibrary.Models
{
    public class Player
    {
        //admin properties
        [Required]
        public int Id { get; set; }
        [Required]
        public int PersonId { get; set; }
        [StringLength(25)]
        public string TeamAssigned { get; set; }
        [StringLength(2)]
        public string Position { get; set; }

        //vital statistics
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(25)]
        public string LastName { get; set; }
        public string HomeTownAndState { get; set; }
        public string FavoritePlayer { get; set; }
        public DateTime WhenStarted { get; set; }

        //statistic properties
        public int GamesPlayed { get; set; }
        
        //hitting stats
        public int AtBats { get; set; }
        public int Hits { get; set; }
        public int Runs { get; set; }
        public int RunsBattedIn { get; set; }
        public int HomeRuns { get; set; }
        public int StolenBases { get; set; }
        public int CaughtStealing { get; set; }
        public int SacrificeBunts { get; set; }
        public int SacrificeFlies { get; set; }
        public int Doubles { get; set; }
        public int Triples { get; set; }
        public int StrikeOuts { get; set; }
        public int Walks { get; set; }
        //batting stats with formulas
        public float SluggingPct
        {
            get { return Hits + (float)(2 * Doubles) + 
                    (float)(3* Triples) + 
                    (float)(4 * HomeRuns) / 
                    (float)AtBats;
            }
        }
        public float OnBaseAvg
        {
            get { return 
                    (float)Hits + 
                    (float)Walks /
                    (float)AtBats + 
                    (float)Hits + 
                    (float)SacrificeBunts + 
                    (float)SacrificeFlies;
            }
        }
        public float OnBasePlusSlugging
        {
            get
            {
                return OnBaseAvg + 
                    SluggingPct;
            }
        }
        public float BattingAvg
        {
            get
            {
                return (float)Hits / 
                    (float)AtBats;
            } 
        }
        
        //fielding stats
        public int PutOuts { get; set; }
        public int Assists { get; set; }
        public int Errors { get; set; }

        public int Chances
        {
            get { return PutOuts + Assists + Errors; }
        }

        //fielding stats that require formulas
        public float FieldingPct
        {
            get
            {
                return (float) Errors /
                       (float) Chances;
            }
        }

    }
}
