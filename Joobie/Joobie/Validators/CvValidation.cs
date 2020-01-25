﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Joobie.Validators
{
    public class CvValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;

            if (file == null)
            {
                return ValidationResult.Success;
                //return new ValidationResult("Image is required");
            }
            try
            {
                string fileExtension = Path.GetExtension(file.FileName);
                if (string.Equals(fileExtension, ".pdf", StringComparison.OrdinalIgnoreCase))
                    return ValidationResult.Success;
            }
            catch { }
            return new ValidationResult("Wrong type of file. File must be in pdf format.");
        }
    }
}
