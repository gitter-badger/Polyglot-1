﻿namespace Dimi.Polyglot.Model
{
    /// <summary>
    /// Language class
    /// </summary>
    public class Language
    {
        public string ISOCode { get; set; }
        public string Description { get; set; }
        public string CultureAlias { get; set; }
        public int Sequence { get; set; }
    }
}