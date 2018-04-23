﻿using System.Linq;
using Microsoft.Diagnostics.Runtime;

namespace DmpAnalyze.Metrics
{
    public static class MetricCollectors
    {
        public static Metric CollectThreadCountMetric(ClrRuntime runtime) => 
            new Metric("Threads count", runtime.Threads.Count);
        
        public static WorkingSetMetric CollectWorkingSetMetric(this ClrRuntime runtime)
        {
            // TODO is this a correct way?
            var value = runtime.EnumerateMemoryRegions()
                .Where(r => r.Type != ClrMemoryRegionType.ReservedGCSegment)
                .Aggregate(0L, (a, r) => a + (long) r.Size);
            
            return new WorkingSetMetric("Working set size", value);
        }
    }
}