using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Blockex.Context;
using Blockex.ExtractionModels.Btc.UnconfirmedTxs.Blockchain;
using Blockex.ExtractionModels.Btc.UnconfirmedTxs.Blockcypher;
using Microsoft.EntityFrameworkCore;

namespace Blockex
{
    class UnconfirmedExtraction
    {
        private readonly ApplicationDbContext context;

        public UnconfirmedExtraction(ApplicationDbContext _context)
        {
           context = _context;
        }

        public async Task Extract(bool truncate)
        {
            if (truncate)
            {
                await TruncateTables();
            }
            List<BtcUcBlockchain> data = await GetData();
            await StoreData(data);
        }

        public async Task TruncateTables()
        {
            await context.Database.ExecuteSqlRawAsync("exec sp_TruncateTables");
        }
        public async Task<List<BtcUcBlockchain>> GetData()
        {
            HttpDataFeed httpDataFeed = new HttpDataFeed();
            System.Net.Http.HttpResponseMessage response = 
                await httpDataFeed.GetAsync("v1/btc/unconfirmed/all");
            return await response.Content.ReadAsAsync<List<BtcUcBlockchain>>();
        }

        public async Task StoreData(List<BtcUcBlockchain> data)
        {
            context.BtcUcBlockchains.AddRange(data);
            await context.SaveChangesAsync();
        }


    }
}
