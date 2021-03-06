﻿namespace IndicatorLights
{
    /// <summary>
    /// A simple interface for controllers that work off a scalar quatity (e.g. resource level).
    /// </summary>
    public interface IScalar
    {
        double ScalarValue { get; }
    }
}
