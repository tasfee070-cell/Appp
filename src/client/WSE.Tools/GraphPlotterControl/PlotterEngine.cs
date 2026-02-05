using System;
using System.Collections.Generic;

namespace WSE.Tools.GraphPlotterControl;

public class PlotterEngine
{
    public List<DataPoint> GenerateFunctionPoints(Func<double, double> function, double start, double end, double step = 0.1)
    {
        var points = new List<DataPoint>();
        for (double x = start; x <= end; x += step)
        {
            points.Add(new DataPoint(x, function(x)));
        }
        return points;
    }
}
