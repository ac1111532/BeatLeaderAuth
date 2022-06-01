using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BeatLeaderAuth.Models
{
    public class Song
    {
        public int SongID { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        [Display(Name = "Song Name")]

        public string SongName { get; set; }

        [Range(0, 200)]
        [Required]
        [Display(Name = "Song Length (Seconds)")]
        public int SongLength { get; set; }

        [Range(0, 500)]
        [Required]
        [Display(Name = "Song Speed (Beats Per Minute)")]
        public int SongBPM { get; set; }

        [Range(0, 100)]
        [Required]
        [Display(Name = "File Size (MB)")]
        public int Size { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        [Display(Name = "Artist Name")]
        public string Artist { get; set; }
        public Beatmap Beatmap { get; set; }


    }
}