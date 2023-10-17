using RenterManager.Application.Enums;
using RenterManager.Domain.Contracts;
using System;

namespace RenterManager.Domain.Entities.Catalog
{
    public class Event : AuditableEntity<int>
    {
        public int ClientIdentifier { get; set; }
        public virtual Client Client { get; set; } 
        public DateTime ProposalExpirationDate { get; set; }
        public int Proposal { get; set; }
        public DateTime EventDate { get; set; }
        public Address Address { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
        public int GuestsNumber { get; set; }
        public string EventFormat { get; set; }
        public EventType EventType { get; set; }
    }
}