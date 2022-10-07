﻿using System;

namespace Flow.Launcher.Core.ExternalPlugins
{
    public record UserPlugin
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Version { get; set; }
        public string Language { get; set; }
        public string Website { get; set; }
        public string UrlDownload { get; set; }
        public string UrlSourceCode { get; set; }
        public string IcoPath { get; set; }
        public DateTime LatestReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }

        /* Label Data for Plugin Store */
        public bool LabelNew { get; set; }
        public bool LabelInstalled { get; set; }
        public bool LabelUpdated { get; set; }
    }
}
