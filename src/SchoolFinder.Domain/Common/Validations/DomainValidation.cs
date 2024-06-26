﻿using SchoolFinder.Domain.Common.CustomExceptions;
using System.Globalization;
using System.Net.Mail;

namespace SchoolFinder.Domain.Common.Validations
{
    public class DomainValidation
    {
        public static void NotNull(object? target, string fieldName)
        {
            if (target is null)
                throw new EntityValidationException($"{fieldName} não pode ser nulo.");
        }

        public static void NotNullOrEmpty(object? target, string fieldName)
        {
            bool throwError = false;

            if (target is null)
                throwError = true;

            if (target is string && string.IsNullOrWhiteSpace(target.ToString()))
                throwError = true;
            else if (target is int && int.Parse(target.ToString()!) <= 0)
                throwError = true;
            else if (target is decimal && decimal.Parse(target.ToString()!) <= 0)
                throwError = true;
            else if (target is Guid && Guid.Parse(target.ToString()!) == Guid.Empty)
                throwError = true;
            else if (target is DateTime && DateTime.Parse(target.ToString()!, new CultureInfo("pt-BR")) == default)
                throwError = true;

            if (throwError)
                throw new EntityValidationException($"{fieldName} não pode ser vazio ou nulo.");
        }

        public static void MinLength(string target, int minLength, string fieldName)
        {
            if (target.Length < minLength)
                throw new EntityValidationException($"{fieldName} deve ter no mínimo {minLength} caracteres.");
        }

        public static void MaxLength(string target, int maxLength, string fieldName)
        {
            if (target.Length > maxLength)
                throw new EntityValidationException($"{fieldName} deve ter no máximo {maxLength} caracteres.");
        }

        public static void Email(string emailAddress, string fieldName)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(emailAddress))
                    throw new Exception();

                if (!MailAddress.TryCreate(emailAddress, out var mailAddress))
                    throw new Exception();

                var hostParts = mailAddress.Host.Split('.');
                if (hostParts.Length == 1)
                    throw new Exception();
                if (hostParts.Any(p => p == string.Empty))
                    throw new Exception();
                if (hostParts[^1].Length < 2)
                    throw new Exception();
                if (mailAddress.User.Contains(' '))
                    throw new Exception();
                if (mailAddress.User.Split('.').Any(p => p == string.Empty))
                    throw new Exception();
            }
            catch (Exception)
            {
                throw new EntityValidationException($"{fieldName} deve ser um e-mail válido.");
            }
        }
    }
}
