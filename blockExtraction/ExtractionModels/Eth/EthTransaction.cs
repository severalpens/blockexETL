using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blockex.ExtractionModels.Eth
{
    public class EthTransaction
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string BlockHash { get; set; }
        public string TransactionIndex { get; set; }
        public int Confirmations { get; set; }

        public HexNumber GasPrice { get; set; } = new HexNumber();
        public HexNumber GasLimit { get; set; } = new HexNumber();

        public string To { get; set; }
        public HexNumber Value { get; set; } = new HexNumber();
        public int Nonce { get; set; }
        public string data { get; set; }
        public string r { get; set; }
        public string s { get; set; }
        public string v { get; set; }
        public string creates { get; set; }
        public string ChainId { get; set; }


    }
}
