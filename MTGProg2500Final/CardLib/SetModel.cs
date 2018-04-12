using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public class SetModel
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string border { get; set; }
        public int mkm_id { get; set; }
        public List<object> booster { get; set; }
        public string mkm_name { get; set; }
        public string releaseDate { get; set; }
        public string magicCardsInfoCode { get; set; }
        public string gathererCode { get; set; }
        public string oldCode { get; set; }
        public bool? onlineOnly { get; set; }
        public string block { get; set; }
    }
}
