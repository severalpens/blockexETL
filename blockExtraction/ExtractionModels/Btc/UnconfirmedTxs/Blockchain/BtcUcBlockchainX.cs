using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blockex.ExtractionModels.Btc.UnconfirmedTxs.Blockchain
{
    public class BtcUcBlockchainX
    {
        [Key]
        public int Id { get; set; }

        public int lock_time { get; set; }
        public int ver { get; set; }
        public int size { get; set; }

        public List<BtcUcBlockchainInput> inputs { get; set; } = new List<BtcUcBlockchainInput>();

        public long time { get; set; }
        public int tx_index { get; set; }
        public int vin_sz { get; set; }
        public string hash { get; set; }
        public int vout_size { get; set; }
        public string relayed_by { get; set; }
        public List<BtcUcBlockchainOut> Out { get; set; }  = new List<BtcUcBlockchainOut>();

    }
    public class BtcUcBlockchainInput
    {
        [Key]
        public int Id { get; set; }

        public long sequence { get; set; }
        public BtcUcBlockchainOut prev_out { get; set; }

    }

    public class BtcUcBlockchainOut
    {
        [Key]
        public int Id { get; set; }

        public bool spent { get; set; }
        public int tx_index { get; set; }
        public string addr { get; set; }
        public long value { get; set; }
        public int n { get; set; }
        public string script { get; set; }

    }

}