﻿using System.Text;

namespace FlashLFQ
{
    class SummedFeatureGroup
    {
        public readonly string BaseSequence;
        public readonly double[] intensitiesByFile;
        public readonly string[] detectionType;

        public SummedFeatureGroup(string baseSeq, double[] intensitiesByFile, string[] detectionType)
        {
            BaseSequence = baseSeq;
            this.intensitiesByFile = intensitiesByFile;
            this.detectionType = detectionType;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("" + BaseSequence + '\t');
            sb.Append(string.Join("\t", intensitiesByFile) + '\t');
            sb.Append(string.Join("\t", detectionType));

            return sb.ToString();
        }
    }
}
