using System.Collections.Generic;

namespace Function_Point_Calculator.Data
{
    public static class MetricsData
    {
        // Function Point Weights (UFP)
        public static readonly Dictionary<string, (int Low, int Average, int High)> ComplexityWeights =
            new Dictionary<string, (int, int, int)>()
        {
            { "External Input", (3, 4, 6) },
            { "External Output", (4, 5, 7) },
            { "External Inquiry", (3, 4, 6) },
            { "Internal Logical File", (7, 10, 15) },
            { "External Interface File", (5, 7, 10) }
        };

        // AVC (Language Factors)
        public static readonly Dictionary<string, int> AVC =
            new Dictionary<string, int>()
        {
            { "Assembly", 320 },
            { "C", 128 },
            { "COBOL/Fortran", 105 },
            { "Pascal", 90 },
            { "Ada", 70 },
            { "C++", 64 },
            { "Visual Basic", 32 },
            { "Object-Oriented Languages", 30 },
            { "Smalltalk", 22 },
            { "Code Generators", 15 },
            { "SQL/Oracle", 12 },
            { "Spreadsheets", 6 },
            { "Graphical Languages", 4 }
        };
    }
}