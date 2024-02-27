using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlicesPi24
{
    public class PiCalcData
    {
        #region Instance fields
        private double _pi;
        private bool _quit;
        private long _iterations;
        #endregion

        #region Constructor
        public PiCalcData()
        {
            _pi = 0.0;
            _quit = false;
            _iterations = 0;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Holds the currently calculated value of pi. 
        /// </summary>
        public double Pi
        {
            get { return _pi; }
            set { _pi = value; }
        }

        /// <summary>
        /// Holds the status w.r.t. quitting the calculation.
        /// </summary>
        public bool Quit
        {
            get { return _quit; }
            set { _quit = value; }
        }

        /// <summary>
        /// Holds the total number of iterations performed
        /// so far during the calculation.
        /// </summary>
        public long Iterations
        {
            get { return _iterations; }
            set { _iterations = value; }
        }
        #endregion
    }
}
