using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupWeek.Qless
{
    public class CurfewPass
    {
        /// <summary>
        /// Curfew Pass Id
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The User the curfew pass belongs to
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Start Time for the Pass
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Time Limit in Minutes
        /// </summary>
        public int TimeLimit { get; set; }

        /// <summary>
        /// List of cities the user is allowed to be in
        /// </summary>
        public List<string> AllowedLocations { get; set; }


    }
}
