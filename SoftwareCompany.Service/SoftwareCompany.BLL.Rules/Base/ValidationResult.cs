using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SoftwareCompany.BLL.Rules.Contract;

namespace SoftwareCompany.BLL.Rules.Base
{
    public class ValidationResult : ITraceable
    {
        private bool isValid = true;

        private List<string> errorMessageCollection = new List<string>();

        /// <summary>
        /// Makes valid result as default
        /// </summary>
        public ValidationResult()
        {
        }

        /// <summary>
        /// Merges a number of results into one total summary.
        /// </summary>
        /// <param name="validationResultCollection"></param>
        public ValidationResult(List<ValidationResult> validationResultCollection)
        {
            foreach (ValidationResult validationResult in validationResultCollection)
            {
                if (validationResult.IsValid == false)
                {
                    this.isValid = false;
                    this.errorMessageCollection.AddRange(validationResult.ErrorMessageCollection);
                }
            }
        }

        /// <summary>
        /// Makes invalid result as default
        /// </summary>
        public ValidationResult(bool isValid, string errorMessage)
        {
            this.isValid = isValid;

            if (isValid && errorMessage != string.Empty)
            {
                throw new InvalidDataException("Valid validation result connot have any error messages");
            }
            else if (!isValid && errorMessage == string.Empty)
            {
                throw new InvalidDataException("Invalid validation result should have at least one error message");
            }

            if (errorMessage != string.Empty)
            {
                this.errorMessageCollection.Add(errorMessage);
            }
        }

        public bool IsValid
        {
            get { return isValid; }
        }

        public List<string> ErrorMessageCollection
        {
            get { return errorMessageCollection; }
        }

        public string GetTrace()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Validation result: {0}\r\n", this.isValid);

            if (this.errorMessageCollection.Count > 0)
            {
                stringBuilder.AppendLine("Broken rules:");
                string errorMessage = this.GetErrorMessage();
                stringBuilder.AppendLine(errorMessage);
            }

            return stringBuilder.ToString();
        }

        public string GetErrorMessage()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string errorMessage in errorMessageCollection)
            {
                stringBuilder.AppendLine(errorMessage);
            }

            return stringBuilder.ToString();
        }
    }
}
