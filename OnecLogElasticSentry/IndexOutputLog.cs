﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnecLogElasticSentry
{
    class IndexOutputLog
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Base { get; set; }
        public string Event { get; set; }
        public string Metadata { get; set; }
        public string Computer { get; set; }
        public string Transaction{ get; set; }
        public string Level { get; set; }
        public string User { get; set; }
        public string Application { get; set; }
        public string Presentation { get; set; }
        public string NumberConnection { get; set; }
        public string NumberSession{ get; set; }
        public string Comment { get; set; }
        public string Server { get; set; }
        public long NumberTransaction { get; set; }
    }
}
