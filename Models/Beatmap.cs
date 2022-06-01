using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BeatLeaderAuth.Models
{
    public class Beatmap
    {
        public int BeatmapID { get; set; }
        public int SongID { get; set; }

        [Range(0, 1500)]
        [Display(Name = "Note Count")]
        public int Notes { get; set; }

        [Range(0, 1500)]
        [Display(Name = "Wall Obstacles")]
        public int Walls { get; set; }


        [Display (Name = "Bomb Obstacles")]
        [Range(0, 1500)]
        public int Bombs { get; set; }

        [Range(0, 1500)]
        [Display(Name = "Note Blocks")]
        public int Slash { get; set; }

        [Range(0, 150000)]
        [Display(Name = "Play Count")]
        public int MapPlays { get; set; }

        [Display(Name = "Song Name")]
        public Song song { get; set; }

        public ICollection<Score> Scores { get; set; }

    }
}