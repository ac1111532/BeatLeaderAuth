using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BeatLeaderAuth.Models
{
    public class Player
    {
        public int PlayerID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Player Name")]
        public string PlayerName { get; set; }

        [Required]
        [Display(Name = "Account Age (Months)")]
        public int AccountAge { get; set; }

        [Required]
        [Display(Name = "VR Headset")]
        public string PlayerHMD { get; set; }

        [Required]
        [Display(Name = "Game Platform")]
        public string PlayerPlatform { get; set; }

        [Required]
        [Range(0, 300)]
        [Display(Name = "Mods Installed")]
        public int Modcount { get; set; }

        [Required]
        [Range(0, 10000)]
        [Display(Name = "Total Levels Beaten")]
        public int LevelsBeaten { get; set; }
        public ICollection<Score> Scores { get; set; }

    }
}