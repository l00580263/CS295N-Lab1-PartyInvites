using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {

        #region fields
        public static List<GuestResponse> responses = new List<GuestResponse>();
        #endregion


        #region methods
        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }



        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
        #endregion
    }
}
