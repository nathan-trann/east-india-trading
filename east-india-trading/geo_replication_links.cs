//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace east_india_trading
{
    using System;
    using System.Collections.Generic;
    
    public partial class geo_replication_links
    {
        public Nullable<int> database_id { get; set; }
        public Nullable<System.DateTimeOffset> start_date { get; set; }
        public Nullable<System.DateTimeOffset> modify_date { get; set; }
        public System.Guid link_guid { get; set; }
        public string partner_server { get; set; }
        public string partner_database { get; set; }
        public Nullable<byte> replication_state { get; set; }
        public string replication_state_desc { get; set; }
        public Nullable<byte> role { get; set; }
        public string role_desc { get; set; }
        public Nullable<byte> secondary_allow_connections { get; set; }
        public string secondary_allow_connections_desc { get; set; }
        public Nullable<int> percent_copied { get; set; }
    }
}
