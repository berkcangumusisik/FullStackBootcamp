
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchorous.App
{
    internal class SyncExample
    {
        public async Task RunAsync()
        {
            var httpClient = new HttpClient();

            //var resultAsTask = httpClient.GetAsync("https://www.google.com").Result; // 1dk dk

            //var resultAsTask2 = await httpClient.GetAsync("https://www.google.com");


            httpClient.GetAsync("https://www.googleeeddf.com").ContinueWith(x =>
            {
                if (x.IsFaulted)
                {
                }

                Console.WriteLine($"result:{x.Result.IsSuccessStatusCode}");
            }); //10dk


            //db 1 dk


            // var result = await resultAsTask3;


            //var result2 = await httpClient.GetAsync("https://www.hepsiburada.com");


            //if (result.IsSuccessStatusCode)
            //{
            //    return true;
            //}

            //if (result2.IsSuccessStatusCode)
            //{
            //    return true;
            //}
        }


        public async Task Save()
        {
            //  log start 10sn

            // await db  50 sn


            //  log finish  20 sn
        }

        public async Task<bool> MakeToRequest()
        {
            var httpClient = new HttpClient();
            var result1 = await httpClient.GetAsync("https://www.hepsiburada.com"); // 10sn
            var result2 = await httpClient.GetAsync("https://www.google.com"); // 10sn
            var result3 = await httpClient.GetAsync("https://www.sahibinden.com"); // 10sn


            if (result1.IsSuccessStatusCode && result2.IsSuccessStatusCode && result3.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }


        public async Task<bool> MakeToRequest2()
        {
            var httpClient = new HttpClient();
            var result1 = httpClient.GetAsync("https://www.hepsiburada.com"); // 15sn
            var result2 = httpClient.GetAsync("https://www.google.com"); // 10sn
            var result3 = httpClient.GetAsync("https://www.sahibinden.com"); // 10sn


            var resultAll = await Task.WhenAll(result1, result2, result3);


            if (resultAll.All(x => x.IsSuccessStatusCode == true))
            {
                return true;
            }


            return false;
        }

        public async Task<bool> MakeToRequest3()
        {
            var httpClient = new HttpClient();
            var result1 = httpClient.GetAsync("https://www.hepsiburada.com"); // 15sn
            var result2 = httpClient.GetAsync("https://www.google.com"); // 10sn
            var result3 = httpClient.GetAsync("https://www.sahibinden.com"); // 10sn


            Task.WaitAll(result1, result2, result3);


            if (result1.Result.IsSuccessStatusCode && result2.Result.IsSuccessStatusCode &&
                result3.Result.IsSuccessStatusCode)
            {
                return true;
            }


            return false;
        }
    }
}
/*
 * Senkron programlama, programın bir işlemi bitmeden diğer işleme geçmemesi anlamına gelir.
 * Örneğin bir kahve dükkanında sıra ile kahve yapılır ve kahve yapımı bitmeden diğer kahve yapımına geçilmez.
 * İyi bir örnek değildir. Çünkü kahve yapımı sırasında başka işler yapılabilir. Yazılım dünyasında ise bu işlemler CPU işlemleri olabilir.CPU işlemleri bitmeden diğer işlemlere geçilmez. Bu da programın yavaş çalışmasına neden olur.
 *
 * Asenkron programlama ise programın bir işlemi bitmeden diğer işleme geçmesine izin verir. Örneğin bir kahve dükkanında bir kişi kahve yaparken diğer kişi kahve yapmaya başlayabilir. Bu durumda kahve yapımı sırasında başka işler yapılabilir. Yazılım dünyasında ise bu işlemler CPU işlemleri olabilir. CPU işlemleri bitmeden diğer işlemlere geçilir. Bu da programın hızlı çalışmasına neden olur.
 * async ve await anahtar kelimeleri ile asenkron programlama yapılabilir.
 * Task ile asenkron programlama yapılabilir.
 * public async Task MethodName() şeklinde tanımlanır.
 * await anahtar kelimesi ile asenkron işlemler bekletilir.
 * */
