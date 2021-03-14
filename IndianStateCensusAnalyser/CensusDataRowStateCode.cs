using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    public class CensusDataRowStateCode
    {
        public int serialNumber;
        public string stateName;
        public int tin;
        public string stateCode;
        /// <summary>
        /// parameterised constructor
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="stateName"></param>
        /// <param name="tin"></param>
        /// <param name="stateCode"></param>
        public CensusDataRowStateCode(string serialNumber, string stateName, string tin, string stateCode)
        {
            this.serialNumber = Convert.ToInt32(serialNumber);
            this.stateName = stateName;
            this.tin = Convert.ToInt32(tin);
            this.stateCode = stateCode;
        }
        
    }
}
