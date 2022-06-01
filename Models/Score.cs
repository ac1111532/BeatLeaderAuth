using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BeatLeaderAuth.Models
{
    public class Score
    {
        public int ScoreID { get; set; }

        public int BeatmapID { get; set; }

        [Required]
        [Display(Name = "Score Multiplier (0, 2, 6, 8)")]
        public int Multiplier { get; set; }

        [Required]
        [Display(Name = "Completion Rank")]
        public string Rank { get; set; }

        [Required]
        [Display(Name = "Accuracy Percentage")]
        public decimal Percentage { get; set; }

        [Required]
        [Display(Name = "Total Score")]
        public int? score { get; set; }

        [Required]
        [Display(Name = "Full Combo?")]
        public bool FullCombo { get; set; }
        public Beatmap Beatmap { get; set; }
        public Player Player { get; set; }


    }
}
