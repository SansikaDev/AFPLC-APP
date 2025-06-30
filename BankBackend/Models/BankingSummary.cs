using System;
using System.Collections.Generic;

namespace BankBackend.Models
{
    public class BankingSummary
    {
        public decimal SavingsAmount { get; set; }
        public List<Lease> Leases { get; set; }
        public List<FixedDeposit> FixedDeposits { get; set; }
        public List<Due> Dues { get; set; }
    }

    public class Lease
    {
        public string LeaseId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
    }

    public class FixedDeposit
    {
        public string FdId { get; set; }
        public decimal PrincipalAmount { get; set; }
        public double InterestRate { get; set; }
        public DateTime MaturityDate { get; set; }
    }

    public class Due
    {
        public string DueId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
    }
} 