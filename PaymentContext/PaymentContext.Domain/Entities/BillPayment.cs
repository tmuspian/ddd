using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BillPayment : Payment
    {
        public BillPayment(string barCode, string billNumber,DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email) :
        base( paidDate,  expireDate,  total,  totalPaid,  payer,  document,  address,  email)
        {          
            BarCode = barCode;
            BillNumber = billNumber;
        }

        public string BarCode { get; private set; }
        public string BillNumber { get; private set; }
    }
}