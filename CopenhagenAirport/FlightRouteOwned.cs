//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CopenhagenAirport
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlightRouteOwned
    {
        public string OriginAirport { get; set; }
        public string DestAirport { get; set; }
        public string AirlineOwner { get; set; }
    
        public virtual Airline Airline { get; set; }
        public virtual Airport Airport { get; set; }
        public virtual Airport Airport1 { get; set; }
    }
}
