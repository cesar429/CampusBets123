//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CampusBets.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Events
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Events()
        {
            this.Bet_Tiket = new HashSet<Bet_Tiket>();
        }
    
        public string Id_Ev { get; set; }
        public string Id_Team1 { get; set; }
        public string Id_Team2 { get; set; }
        public Nullable<System.DateTime> Date_And_Time { get; set; }
        public string Id_Tip { get; set; }
        public Nullable<double> Odd_1 { get; set; }
        public Nullable<double> Odd_x { get; set; }
        public Nullable<double> Odd_2 { get; set; }
        public Nullable<double> Odd_GG { get; set; }
        public Nullable<double> Odd_peste25 { get; set; }
        public Nullable<double> Odd_sub25 { get; set; }
        public Nullable<double> Odd_SC { get; set; }
        public Nullable<double> Odd_1x { get; set; }
        public Nullable<double> Odd_12 { get; set; }
        public Nullable<double> Odd_x2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bet_Tiket> Bet_Tiket { get; set; }
        public virtual Teams Teams { get; set; }
        public virtual Teams Teams1 { get; set; }
        public virtual Tip_Event Tip_Event { get; set; }
    }
}
