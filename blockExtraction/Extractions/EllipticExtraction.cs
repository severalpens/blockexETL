using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Blockex.Context;
using Blockex.ExtractionModels.Elliptic;
using Microsoft.EntityFrameworkCore;

namespace Blockex
{
    class EllipticExtraction
    {
        private readonly MainContext context;

        public EllipticExtraction(MainContext _context)
        {
           context = _context;
        }

        public async Task Extract(bool truncate)
        {
            if (truncate)
            {
                await TruncateUnconfirmedTables();
            }

            List<EllipticTx> txs = await context.EllipticTxs.ToListAsync();

            foreach (EllipticTx tx in txs)
            {
                await context.SaveChangesAsync();
            }

        }

        private Task<EllipticTx> GetData(object transaction)
        {
            throw new NotImplementedException();
        }

        public async Task TruncateUnconfirmedTables()
        {
            await context.Database.ExecuteSqlRawAsync("exec TruncateUnconfirmedTables");
        }
        public async Task<EllipticTx> GetData(string tx)
        {

            HttpDataFeed httpDataFeed = new HttpDataFeed("https://blockchain.info/");
            System.Net.Http.HttpResponseMessage response = 
                await httpDataFeed.GetAsync($"rawtx/{tx}");
            return await response.Content.ReadAsAsync<EllipticTx>();
        }



    }
}
