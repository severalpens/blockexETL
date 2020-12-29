using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Blockex.Context;
using Microsoft.EntityFrameworkCore;
using Blockex.ExtractionModels.Eth;
namespace Blockex
{
    class EthExtraction
    {
        private readonly ApplicationDbContext context;

        public EthExtraction(ApplicationDbContext _context)
        {
           context = _context;
        }

        public async Task Extract(bool truncate)
        {
            if (truncate)
            {
                await TruncateTables();
            }
            List<SourceHeader> data = await GetData();
            await StoreData(data);
        }

        public async Task TruncateTables()
        {
            await context.Database.ExecuteSqlRawAsync("exec sp_TruncateTables");
        }
        public async Task<List<SourceHeader>> GetData()
        {
            HttpDataFeed httpDataFeed = new HttpDataFeed();
            System.Net.Http.HttpResponseMessage response = await httpDataFeed.GetAsync("v1/eth/blocks/all");
            return await response.Content.ReadAsAsync<List<SourceHeader>>();
        }

        public async Task StoreData(System.Collections.Generic.List<SourceHeader> data)
        {
            context.SourceHeaders.AddRange(data);
            await context.SaveChangesAsync();
        }


    }
}
