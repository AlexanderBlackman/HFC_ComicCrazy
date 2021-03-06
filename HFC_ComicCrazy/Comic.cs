﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HFC_ComicCrazy
{
    class Comic
    {
        public string Name { get; set; }
        public int Issue { get; set; }

        public override string ToString() => $"{Name} (Issue #{Issue})";

        public static readonly IEnumerable<Comic> Catalogue =
            new List<Comic>
            {
                new Comic { Name="Johny America vs. the Pinko", Issue=6},
                new Comic { Name="Rock and Roll (limited edition)", Issue=19},
                new Comic { Name="Woman's Work", Issue=36},
                new Comic { Name="Hippie Madness (misprinted)", Issue=57},
                new Comic {Name = "Revenge of the New Wave Freak (damaged)", Issue=68},
                new Comic { Name="Black Monday", Issue =74},
                new Comic { Name = "Tribal Tattoo Madness", Issue=83},
                new Comic { Name = "The Death of the Object", Issue=97},
            };

        public static readonly IReadOnlyDictionary<int, decimal> Prices =
            new Dictionary<int, decimal>
            {
                { 6, 3600m },
                { 19, 500m },
                { 36, 650m },
                { 57, 13525m },
                { 68, 250m },
                { 74, 75m },
                { 83, 25.75m },
                { 97, 35.25m },
            };
    }
}
