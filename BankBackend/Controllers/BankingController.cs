using BankBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {
        [HttpGet("summary/{userId}")]
        public ActionResult<BankingSummary> GetBankingSummary(string userId)
        {
            // In a real application, you would fetch this data from a database based on the userId.
            // For this example, we'll return some mock data.

            var summary = new BankingSummary
            {
                SavingsAmount = 12500.50m,
                Leases = new List<Lease>
                {
                    new Lease { LeaseId = "L001", Description = "Car Loan", Amount = 450.75m, DueDate = DateTime.UtcNow.AddDays(15) },
                    new Lease { LeaseId = "L002", Description = "Appliance Loan", Amount = 85.20m, DueDate = DateTime.UtcNow.AddDays(20) }
                },
                FixedDeposits = new List<FixedDeposit>
                {
                    new FixedDeposit { FdId = "FD01", PrincipalAmount = 5000, InterestRate = 2.5, MaturityDate = DateTime.UtcNow.AddYears(1) },
                    new FixedDeposit { FdId = "FD02", PrincipalAmount = 10000, InterestRate = 3.0, MaturityDate = DateTime.UtcNow.AddYears(2) }
                },
                Dues = new List<Due>
                {
                    new Due { DueId = "D001", Description = "Credit Card Bill", Amount = 300.00m, DueDate = DateTime.UtcNow.AddDays(10) },
                    new Due { DueId = "D002", Description = "Utility Bill", Amount = 120.50m, DueDate = DateTime.UtcNow.AddDays(5) }
                }
            };

            return Ok(summary);
        }
    }
} 