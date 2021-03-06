﻿using System.Collections.Generic;
using DmpAnalyze.Issues;
using DmpAnalyze.Metrics;
using Microsoft.Diagnostics.Runtime;

namespace DmpAnalyze
{
    public class Report
    {
        public IReadOnlyList<IIssue> Issues { get; internal set; }
        public IReadOnlyList<Metric> Metrics { get; internal set; }
        public IReadOnlyList<Stat> Stats { get; internal set; }
    }
}