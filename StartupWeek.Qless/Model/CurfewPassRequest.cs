using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupWeek.Qless.Model
{
    public class CurfewPassRequest
    {
        /// <summary>
        /// Requester ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// List of family member IDs who also need the permission to travel along with the user
        /// </summary>
        public List<int> FamilyMembers { get; set; }

        /// <summary>
        /// This isnt useful for now. This is when we need to get permission to visit a particular location
        /// </summary>
        public int? DestinationLocationId { get; set; }

        /// <summary>
        /// Home Address
        /// </summary>
        public string CurrentLocationAddress { get; set; }

        /// <summary>
        /// We will keep it simple for now and just take the location address from client side. In the future we can probably pass lat/long coordinates
        /// </summary>
        public List<string> DestinationLocationAddresses { get; set; }
    }
}
