using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ClientAccountingProduct
    {
        public int ClientAccountingProductId { get; set; }
        public int ClientId { get; set; }
        public int AccountingProductId { get; set; }
        public decimal? DefaultValue { get; set; }
        public int KashFlowId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual Client Client { get; set; }
        public virtual AccountingProduct AccountingProduct { get; set; }
    }
}