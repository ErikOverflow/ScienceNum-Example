using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YardDefense
{
    [Serializable]
    public struct ScienceNum
    {
        //Should always be between 1 and 9.9999
        public float baseValue;
        public int eFactor;


        public static ScienceNum operator -(ScienceNum sn1, ScienceNum sn2)
        {

            //sn1 = 1e10
            //sn2 = 1e9

            //Output = 9e9
            int factorDiff = sn1.eFactor - sn2.eFactor; //1
            if (factorDiff >= 8)
                return sn1;
            sn2.baseValue /= Mathf.Pow(10,factorDiff);
            sn2.eFactor += factorDiff;

            //sn2 = .1e10
            //== 0.9e10
            //At this point, sn1 and sn2 have the same factor
            sn1.baseValue -= sn2.baseValue;
            //== 0.9e10
            if (sn1.baseValue == 0)
                return sn1;
            //otherwise, recalculate the scienceNum
            int eChange = Mathf.FloorToInt(Mathf.Log10(Mathf.Abs(sn1.baseValue)));
            sn1.baseValue /= Mathf.Pow(10, eChange);
            sn1.eFactor += eChange;
            return sn1;
        }

        public static ScienceNum operator /(ScienceNum sn1, ScienceNum sn2)
        {

            sn1.baseValue /= sn2.baseValue;
            sn1.eFactor -= sn2.eFactor;

            if (sn1.baseValue < 1f)
            {
                sn1.eFactor -= 1;
                sn1.baseValue *= 10;
            }

            if (sn1.baseValue >= 10f)
            {
                sn1.eFactor += 1;
                sn1.baseValue /= 10;
            }

            return sn1;
        }

        public float Conversion()
        {
            return baseValue * Mathf.Pow(10, eFactor);
        }
    }
}

//Max int: 2,147,483,647
//Max float: 3.4e38
//Max double: 1.7e308
