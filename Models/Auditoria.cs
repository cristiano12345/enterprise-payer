using System;

namespace LoanPayer.domain
{
    public class Auditoria
    {
        public DateTime? DtInsert { get; set; }

        public DateTime? DtUpdate{ get; set; }

        public DateTime? DtDelete { get; set; }
        
        public long? IdUserCreate { get; set; }
        
        public long? IdUserUpdate { get; set; }
       
        public long? IdUserDelete { get; set; }
    }
}
