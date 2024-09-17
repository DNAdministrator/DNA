﻿#region Usings

using System.ComponentModel.DataAnnotations;
using System.IO;

#endregion

namespace DNA3.CustomValidators {

    #region Methods

    public class FolderExists : ValidationAttribute {

        protected override ValidationResult IsValid(object value, ValidationContext context) {

            ValidationResult result;
            string path = value.ToString();

            if (Directory.Exists(path)) {
                result = ValidationResult.Success;
            } else {
                result = new ValidationResult("Path must be relative to the application root folder");
            }
            return result;

        }

    }

    #endregion

}
