using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBootcamp.App.OOPConcepts;

internal class Encapsulation
{
    public class Tax
    {
        private List<int> Numbers { get; set; } = new List<int>() { 1, 2, 3, 4, 5 };

        public List<int> GetNumbers()
        {
            //return Numbers;
            var numbers = new int[Numbers.Count];
            Numbers.CopyTo(numbers.ToArray());
            return numbers.ToList();
        }

        public void WriteToConsole()
        {
            // foreach : Döngü içerisindeki elemanları tek tek döngü içerisinde işlem yapmamızı sağlar.
            // foreach (var değişken in koleksiyon) { işlem }
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }
        }


        public string BarcodeCode { get; private set; } = "Abc";
        public string BarcodeCode2 => "DEF";

        private string TaxName { get; set; } = "Tax1";


        public string GetTaxName()
        {
            return TaxName.ToLower();
        }

        public void SetTaxName(string taxName)
        {
            if (TaxName.Length > 5)
            {
                throw new Exception("");
            }

            TaxName = taxName;
        }
        private int _taxRate;
        public int TaxRate
        {
            get => _taxRate;
            set
            {
                if (value <= 1 || value >= 10)
                {
                    throw new Exception("Vergi oranı 1 ile 10 arasında olmalıdır.");
                }
                _taxRate = value;
            }
        }
        public void SaveToDatabase()
        {
            BarcodeCode = "dsfdsf";

            //save to database
        }

        public void Method1()
        {
        }
        public void Method2()
        {
            Method3();
        }
        private void Method3() { }
    }
}


/**
 * Encapsulation (Kapsülleme) : Bir nesnenin içerisindeki verilerin ve metotların dışarıdan erişilebilirliğini kontrol etme işlemidir.
 * 
 */