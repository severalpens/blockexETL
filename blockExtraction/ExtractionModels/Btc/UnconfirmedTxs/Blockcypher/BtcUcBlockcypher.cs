using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Blockex.ExtractionModels.Btc.UnconfirmedTxs.Blockcypher
{
    public class BtcUcBlockcypher
    {
        [Key]
        public int Id { get; set; }

        public string _id { get; set; }
        public string Blockchain { get; set; }
        public string Source { get; set; }

        public BtcUcBlockcypherBody body { get; set; } = new BtcUcBlockcypherBody();

    }
}
