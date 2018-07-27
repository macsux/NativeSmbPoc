using System;
using System.Collections.Generic;
using SharpCifs.Smb;

namespace ShareMount
{
    public class FormModel
    {
        public string Url { get; set; }
        public List<string> Files { get; set; }
        public string Exception { get; set; }
    }
}