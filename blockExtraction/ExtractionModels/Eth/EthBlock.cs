using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blockex.ExtractionModels.Eth
{
    public class EthBlock
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string ParentHash { get; set; }
        public long Number { get; set; }
        public long Timestamp { get; set; }
        public string Nonce { get; set; }
        public long Difficulty { get; set; }
        public HexNumber GasLimit { get; set; } = new HexNumber();
        public HexNumber GasUsed { get; set; } = new HexNumber();
        public string Miner { get; set; }
        public string ExtraData { get; set; }
        public List<EthTransaction> Transactions { get; set; } = new List<EthTransaction>();



    }



}
