using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class DimDate
    {
        public DimDate()
        {
            FactOrderItemRefunds = new HashSet<FactOrderItemRefund>();
            FactOrderRefunds = new HashSet<FactOrderRefund>();
            FactOrders = new HashSet<FactOrder>();
        }

        public int DateKey { get; set; }
        public DateTime FullDate { get; set; }
        public string DateEnglishName { get; set; }
        public short DayOfWeek { get; set; }
        public string DayOfWeekEnglishName { get; set; }
        public short DayOfMonth { get; set; }
        public string DayOfMonthEnglishName { get; set; }
        public short DayOfQuarter { get; set; }
        public string DayOfQuarterEnglishName { get; set; }
        public short DayOfTrimester { get; set; }
        public string DayOfTrimesterEnglishName { get; set; }
        public short DayOfHalfYear { get; set; }
        public string DayOfHalfYearEnglishName { get; set; }
        public short DayOfYear { get; set; }
        public string DayOfYearEnglishName { get; set; }
        public string Weekday { get; set; }
        public int Week { get; set; }
        public string WeekEnglishName { get; set; }
        public int WeekOfYear { get; set; }
        public string WeekOfYearEnglishName { get; set; }
        public int TenDays { get; set; }
        public string TenDaysEnglishName { get; set; }
        public short TenDaysOfMonth { get; set; }
        public string TenDaysOfMonthEnglishName { get; set; }
        public short TenDaysOfQuarter { get; set; }
        public string TenDaysOfQuarterEnglishName { get; set; }
        public short TenDaysOfTrimester { get; set; }
        public string TenDaysOfTrimesterEnglishName { get; set; }
        public short TenDaysOfHalfYear { get; set; }
        public string TenDaysOfHalfYearEnglishName { get; set; }
        public short TenDaysOfYear { get; set; }
        public string TenDaysOfYearEnglishName { get; set; }
        public int Month { get; set; }
        public string MonthEnglishName { get; set; }
        public short MonthOfQuarter { get; set; }
        public string MonthOfQuarterEnglishName { get; set; }
        public short MonthOfTrimester { get; set; }
        public string MonthOfTrimesterEnglishName { get; set; }
        public short MonthOfHalfYear { get; set; }
        public string MonthOfHalfYearEnglishName { get; set; }
        public short MonthOfYear { get; set; }
        public string MonthOfYearEnglishName { get; set; }
        public short Quarter { get; set; }
        public string QuarterEnglishName { get; set; }
        public short QuarterOfHalfYear { get; set; }
        public string QuarterOfHalfYearEnglishName { get; set; }
        public short QuarterOfYear { get; set; }
        public string QuarterOfYearEnglishName { get; set; }
        public short Trimester { get; set; }
        public string TrimesterEnglishName { get; set; }
        public short TrimesterOfYear { get; set; }
        public string TrimesterOfYearEnglishName { get; set; }
        public short HalfYear { get; set; }
        public string HalfYearEnglishName { get; set; }
        public short HalfYearOfYear { get; set; }
        public string HalfYearOfYearEnglishName { get; set; }
        public short Year { get; set; }
        public string YearEnglishName { get; set; }

        public virtual ICollection<FactOrderItemRefund> FactOrderItemRefunds { get; set; }
        public virtual ICollection<FactOrderRefund> FactOrderRefunds { get; set; }
        public virtual ICollection<FactOrder> FactOrders { get; set; }
    }
}
