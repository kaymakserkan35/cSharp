using DecoratorB.Data;
using System;

namespace DecoratorB
{
    class Program
    {
        static void Main(string[] args)
        {
            AEmail email = new Email("serkan.hotmail", "onur.gmail");
            email.EmailGonder("saf mesaj");

            AEmail şifreliEmail = new MesajSifreleEmailDecorator(email);
            şifreliEmail.EmailGonder("şifrelenmiş mesaj");

            AEmail dosyalıEmail = new DosyaEkleEmailDecorator(email,"document.zip");
            dosyalıEmail.EmailGonder("dosya ekli mesaj");
        } 
    }
}
