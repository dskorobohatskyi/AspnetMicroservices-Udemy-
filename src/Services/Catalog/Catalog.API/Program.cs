using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //float grn_dollar = 36.57f;
            //float sum_to_send = 1060f;
            //float percent_to_sub = 0.5f + 0.25f + 2f;
            //Console.WriteLine("Summa(grn) to send - " + grn_dollar * sum_to_send);
            ////Console.WriteLine("Summa(grn) received - " + (grn_dollar * sum_to_send - (grn_dollar * sum_to_send) * percent_to_sub / 100f));
            //float received_sum_with_percent_applied_grn = (grn_dollar * sum_to_send - (grn_dollar * sum_to_send) * percent_to_sub / 100f);
            //Console.WriteLine("Summa(grn) received - " + received_sum_with_percent_applied_grn);

            //float dollar_by_grn_buy = 37.037f;
            //float dollar_to_lear = 17.5f;
            //float real_lear_to_grn = 2.08f;
            ////Console.WriteLine("Summa(dollar) received - " + received_sum_with_percent_applied_grn / dollar_by_grn_buy);
            //Console.WriteLine("Lears to take wishdraw - " + received_sum_with_percent_applied_grn / real_lear_to_grn);

            ////CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
