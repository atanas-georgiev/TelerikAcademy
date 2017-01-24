namespace Tweeter.Mvc.Infrastructure.Validation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    [AttributeUsage(AttributeTargets.Property)]
    public class AtLeastThreeTagsAttribute : ValidationAttribute
    {

        public AtLeastThreeTagsAttribute()
        {
            this.ErrorMessage = "{0} should does not contain at least three tags separated with ';' ";
        }

        public override bool IsValid(object value)
        {
            var valueAsString = value as string;
            if (valueAsString == null)
            {
                throw new ArgumentException("Does not contain attribute not set on string property");
            }

            if (valueAsString.Split(';').Length >= 3)
            {
                return true;
            }

            return false;
        }
    }
}