using System;

namespace SnapRename
{
    public class PhotoFile
    {
        public string OldName { get; set; }
        public string NewName { get; set; }
        public string FullPath { get; set; }

        public DateTime? DateTaken { get; set; }
    }
}