using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockex.ExtractionModels.Btc.UnconfirmedTxs.Blockchain
{
    public class BtcUcBlockchainBody
    {
        [Key]
        public int Id { get; set; }

        public string Op { get; set; }
        public BtcUcBlockchainX x { get; set; } = new BtcUcBlockchainX();
        public string created_at { get; set; }

    }
}
