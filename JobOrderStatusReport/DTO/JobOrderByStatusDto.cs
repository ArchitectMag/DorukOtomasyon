using System;
using System.Data;
using System.Collections.Generic;

namespace JobOrderStatusReport.DTO
{
    public class JobOrderByStatusDto
    {
        public int JobOrderNo { get; set; }
        public DateTime JobStartDate { get; set; }
        public DateTime JobEndDate { get; set; }
        public List<DataRow> JobOrdersByStatus { get; set; }
    }
}