using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockex.ExtractionModels.Btc.UnconfirmedTxs.Blockcypher
{
    public class BtcUcBlockcypherBody
    {
        [Key]
        public int Id { get; set; }

        public string Op { get; set; }
        public BtcUcBlockcypherX x { get; set; } = new BtcUcBlockcypherX();
        public string created_at { get; set; }

    }
}
