using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockex.ExtractionModels.Elliptic
{
    public class EllipticTx
    {
        [Key]
        public long Id { get; set; }

        public string TxHash { get; set; }

    }
    public class EllipticClass
    {
        [Key]
        public long Id { get; set; }
        public string Class { get; set; }

    }

    public class EllipticEdgelist
    {
        [Key]
        public long Id { get; set; }
        public long EllipticId2 { get; set; }

    }

    public class EllipticFeatureList
    {
        [Key]
        public long Id { get; set; }
        public int TimeStep { get; set; }
        public List<EllipticScore> Scores { get; set; }

    }

    public class EllipticScore
    {
        [Key]
        public int Id { get; set; }

        public double Score { get; set; }

    }
}
