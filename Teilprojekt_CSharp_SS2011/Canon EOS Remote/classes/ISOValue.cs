﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Canon_EOS_Remote
{
    /**
     * Version 0.1
     * */
    class ISOValue
    {
        #region Declaration of class members

        private string decValue;
        private UInt32 hexValue;

        #endregion

        #region Getter and Setter of class members

        public UInt32 HexValue
        {
            get { return hexValue; }
            set { hexValue = value; }
        }

        public string DecValue
        {
            get { return decValue; }
            set { decValue = value; }
        }

        #endregion

        #region Construtors

        public ISOValue(string decValue, UInt32 hexValue)
        {
            this.decValue = decValue;
            this.hexValue = hexValue;
        }

        #endregion
    }
}
