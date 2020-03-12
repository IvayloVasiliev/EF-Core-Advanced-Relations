using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BillsPaymentSystem.Models.Attrubutes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ExpirationDayAttribute : ValidationAttribute
    {     
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var currentTime = DateTime.Now;
            var targetDateTime = (DateTime)value;

            if (currentTime > targetDateTime)
            {
                return new ValidationResult("Card is expired");
            }

            return ValidationResult.Success; 
        }

    }
}
