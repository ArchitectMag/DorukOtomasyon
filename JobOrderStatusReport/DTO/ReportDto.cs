using System.Collections.Generic;

namespace JobOrderStatusReport.DTO
{
    public class ReportDto
    {
        public int JobOrderNumber { get; set; }
        public int TotalMinutes { get; set; }
        public List<StatusDurationDto> StatusDurations { get; set; } = new List<StatusDurationDto>();
    }
}