using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Blockex.Context;
using Microsoft.EntityFrameworkCore;
namespace Blockex
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }
        static async Task MainAsync()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            //EthExtraction ethExtraction = new EthExtraction(context);
            //await ethExtraction.Extract(false);

            UnconfirmedExtraction unconfirmedExtraction = new UnconfirmedExtraction(context);
            await unconfirmedExtraction.Extract(true);

            //EllipticExtraction ellipticTxExtraction = new EllipticExtraction(context);
            //await ellipticTxExtraction.Extract(true);

        }
    }


}
