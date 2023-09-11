using FluentValidation;

namespace _07_FluentValidation
{
    //Func
    //Predicate
    //Action bu üçünü gördüğümüzde orada Lambda ifadesi yazabiliriz. 
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Mail).MaximumLength(100).WithMessage("{0} en fazla {1} karakter olmaıdır.")
                .MinimumLength(30).WithMessage("en az 30");

            RuleFor(x => x.Password).NotNull().WithMessage("Zorunlu alan");
           
        }
    }
}
