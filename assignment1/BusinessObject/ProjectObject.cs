﻿using System;

namespace BusinessObjects
{
    public class ProjectObject
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectAddress { get; set; }
        public string ProjectCity { get; set; }
        public string ProjectSponsor { get; set; }
        public string EstimatedStartDate { get; set; }
        public string EstimatedEndDate { get; set; }
    }
}
