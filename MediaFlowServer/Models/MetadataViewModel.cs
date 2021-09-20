using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaFlowServer.Models
{
    public class MetadataViewModel
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string ProductName { get; set; }
        public string Chapter { get; set; }
        public string Block { get; set; }
    }
}
