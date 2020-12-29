using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blockex.ExtractionModels.Eth
{
    public class SourceHeader
    {
        [Key]
        public int Id { get; set; }

        public string _id { get; set; }
        public string Blockchain { get; set; }
        public string Source { get; set; }
        public EthBlock Body { get; set; } = new EthBlock();
    }
}
