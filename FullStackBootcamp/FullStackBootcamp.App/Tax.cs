using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBootcamp.App;

class Tax
{
    public decimal CalculateTaxWithSwitch(decimal price, int rate)
    {
        var priceWithTax = 0;

        switch (rate)
        {
            case 1:
                priceWithTax = (int)price * 10 / 100;
                break;
            case 2:
                priceWithTax = (int)price * 20 / 100;
                break;
            case 3:
                priceWithTax = (int)price * 30 / 100;
                break;
            default:
                priceWithTax = (int)price * 40 / 100;
                break;
        }

        return priceWithTax;
    }
    public int CalculateTax(decimal price, int rate)
    {
        var priceWithTax = 0;

        if(rate == 10)
        {
            priceWithTax = (int)price * 10 / 100;
        }
        else if(rate == 20)
        {
            priceWithTax = (int)price * 20 / 100;
        }
        else if (rate == 30)
        {
            priceWithTax = (int)price * 30 / 100;
        }
        else
        {
            priceWithTax = (int)price * 40 / 100;
        }

        return priceWithTax;
    }

    public int CalculateTax2(decimal price, int rate)
    {
        if(rate == 10)
        {
            return (int)price * 10 / 100;
        }
        if(rate == 20)
        {
            return (int)price * 20 / 100;
        }
        if (rate == 30)
        {
            return (int)price * 30 / 100;
        }
        throw new Exception("Rate değeri 10 ile 30 arasonda olmalıdır.");

    }

    public void Calculate(decimal price, int rate)
    {
        var priceWithTax = 0;

        if (rate == 10)
        {
            priceWithTax = (int)price * 10 / 100;
            Console.WriteLine(priceWithTax);
            return;
        }

        if (rate == 20)
        {
            priceWithTax = (int)price * 20 / 100;
            Console.WriteLine(priceWithTax);
        }

        if (rate == 30)
        {
            priceWithTax = (int)price * 30 / 100;
            Console.WriteLine(priceWithTax);
        }
    }
}

public class User
{
    public string Email { get; set; }
    public string Password { get; set; }


    public bool Validate()
    {


        if (string.IsNullOrEmpty(Password)) // string.IsNullOrEmpty() : String ifadenin boş olup olmadığını kontrol eder.
        {
            return false;
        }


        if (string.IsNullOrEmpty(Password))
        {
            return false;
        }

        if (Password.StartsWith("1234")) // StartsWith() : String ifadenin belirtilen ifade ile başlayıp başlamadığını kontrol eder.
        {
            return false;
        }

        if (Password.Length > 8) // Length : String ifadenin uzunluğunu döndürür.
        {
            return false;
        }


        return true;
    }
}



/*
 Karar Yapıları
 - if, else if, else
 if (condition)
 {
     // code block
 }
 else if (condition)
 {
     // code block
 }
 else
 {
     // code block
 }
if - else if - else yapısı birbirine bağlıdır. if bloğu çalıştığında else if bloğu çalışmaz. else if bloğu çalıştığında else bloğu çalışmaz. Ama çok fazla else if kullanmak kodun okunabilirliğini ve performansını düşürebilir. Bu nedenle kullanmaktan kaçınılmalıdır. Clean Code prensiplerine uygun olmalıdır.


 */

/*
 switch - case
    switch (expression)
    {
        case value1:
            // code block
            break;
        case value2:
            // code block
            break;
        default:
            // code block
            break;
    }

// Switch - case mümkün oldukça kullanma. Yararından çok zararı olabilir. 
 */