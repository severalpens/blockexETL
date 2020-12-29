using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blockex.ExtractionModels.Btc.UnconfirmedTxs.Blockcypher
{
    public class BtcUcBlockcypherX
    {
        [Key]
        public int Id { get; set; }

        public int lock_time { get; set; }
        public int ver { get; set; }
        public int size { get; set; }

        public List<BtcUcBlockcypherInput> inputs { get; set; } = new List<BtcUcBlockcypherInput>();

        public long time { get; set; }
        public int tx_index { get; set; }
        public int vin_sz { get; set; }
        public string hash { get; set; }
        public int vout_size { get; set; }
        public string relayed_by { get; set; }
        public List<BtcUcBlockcypherOut> Out { get; set; }  = new List<BtcUcBlockcypherOut>();

    }
    public class BtcUcBlockcypherInput
    {
        [Key]
        public int Id { get; set; }

        public long sequence { get; set; }
        public BtcUcBlockcypherOut prev_out { get; set; }

    }

    public class BtcUcBlockcypherOut
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