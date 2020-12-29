using System.Collections.Generic;
using Blockex.ExtractionModels.Btc.UnconfirmedTxs.Blockchain;
using Blockex.ExtractionModels.Btc.UnconfirmedTxs.Blockcypher;
using Blockex.ExtractionModels.Elliptic;
using Microsoft.EntityFrameworkCore;
using Blockex.ExtractionModels;
using Blockex.ExtractionModels.Eth;

namespace Blockex.Context
{

    public class ApplicationDbContext : DbContext
    {
        //Blockcypher.com
        public DbSet<BtcUcBlockcypher> BtcUcBlockcyphers { get; set; }
        public DbSet<BtcUcBlockcypherBody> BtcUcBlockcypherBodies { get; set; }
        public DbSet<BtcUcBlockcypherX> BtcUcBlockcypherXs { get; set; }
        public DbSet<BtcUcBlockcypherInput> BtcUcBlockcypherInputs { get; set; }
        public DbSet<BtcUcBlockcypherOut> BtcUcBlockcypherOuts { get; set; }

        //Blockchain.com
        public DbSet<BtcUcBlockchain> BtcUcBlockchains { get; set; }
        public DbSet<BtcUcBlockchainBody> BtcUcBlockchainBodies { get; set; }
        public DbSet<BtcUcBlockchainX> BtcUcBlockchainXs { get; set; }
        public DbSet<BtcUcBlockchainInput> BtcUcBlockchainInputs { get; set; }
        public DbSet<BtcUcBlockchainOut> BtcUcBlockchainOuts { get; set; }
        public DbSet<EthBlock> EthBlocks { get; set; }
        public DbSet<EthTransaction> EthTransactions { get; set; }
        public DbSet<HexNumber> HexNumbers { get; set; }
        public DbSet<SourceHeader> SourceHeaders { get; set; }





        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            
            options.UseSqlServer("Server= localhost;Database=blockex;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }

}