using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    //
   public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity) //Ivalidator ile new lemeye gerek kalmadı
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context); //validaor yerine ne gönderilirse o yazılır
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            //var context = new ValidationContext<Car>(entity); //car için doğrulama yapıcam dedim parametre de gönderdim entity
            //CarValidator carValidator = new CarValidator(); //doğrulama için carvalidator lazım new ledim
            //var result = carValidator.Validate(context); //carvalidator ı kullanarak dogrula gönderilen context i yani entity i
            //if (!result.IsValid) // sonuç geçerli değil ise (!)
            //{
            //    throw new ValidationException(result.Errors); //hata fırlat
            //}
        }
    }
}
