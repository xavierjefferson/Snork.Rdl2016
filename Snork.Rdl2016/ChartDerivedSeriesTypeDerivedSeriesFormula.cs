using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Snork.Rdl2016
{
    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Constants.Namespace)]
    public enum ChartDerivedSeriesTypeDerivedSeriesFormula
    {
        /// <remarks />
        BollingerBands,

        /// <remarks />
        MovingAverage,

        /// <remarks />
        ExponentialMovingAverage,

        /// <remarks />
        TriangularMovingAverage,

        /// <remarks />
        WeightedMovingAverage,

        /// <remarks />
        MACD,

        /// <remarks />
        DetrendedPriceOscillator,

        /// <remarks />
        Envelopes,

        /// <remarks />
        Performance,

        /// <remarks />
        RateOfChange,

        /// <remarks />
        RelativeStrengthIndex,

        /// <remarks />
        StandardDeviation,

        /// <remarks />
        TRIX,

        /// <remarks />
        Mean,

        /// <remarks />
        Median
    }
}