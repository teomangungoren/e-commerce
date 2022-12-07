using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace PresentationLayer.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "Parola en az 8 karakterli olmalıdır"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Parola en az 1 küçük harf içermelidir"
            };

         
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUper",
                Description = "Parola en az 1 büyük harf içermelidir "
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Parola en az 1 sayısal karakter içermelidir "
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola en az 1 alfanümerik karakter içermelidir "
            };
        }

    }
}
