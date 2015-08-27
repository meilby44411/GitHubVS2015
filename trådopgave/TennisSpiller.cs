using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trådopgave {
    public class TennisSpiller {

        public TennisSpiller(string Navn) {
            this.Navn = Navn;
        }
        public bool HarBolden { get; set; }
        public string Navn { get; set; }

    }
}
