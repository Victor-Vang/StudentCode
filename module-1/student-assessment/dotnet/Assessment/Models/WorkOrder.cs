using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Models
{
    public class WorkOrder
    {

        // Constructor

        public WorkOrder(string name, int length, int width)
        {
            this.Name = name;
            this.Length = length;
            this.Width = width;
        }

        // Properties
        public string Name { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public decimal EstimatedTotal
        {
            get
            {
                decimal totalForJob = ((decimal)(Length * Width)) * (4.99M / 100.00M);
                return totalForJob;
            }
        }

        // Methods

        public decimal ActualTotal(bool rush, bool icy)
        {
            if (rush && icy)
            {
                decimal totalWithRushAndIceUnrounded = EstimatedTotal + 33.96M + 24.75M;
                decimal totalWithRushAndIceRounded = Math.Round(totalWithRushAndIceUnrounded, 2);
                return totalWithRushAndIceRounded;
            }
            else if (rush)
            {
                decimal totalWithRush = EstimatedTotal + 16.98M;
                return totalWithRush;
            }
            else if (icy)
            {
                decimal totalWithIce = EstimatedTotal + 24.75M;
                return totalWithIce;
            }
            return EstimatedTotal;
        }

        public override string ToString()
        {
            return $"WORK ORDER - {Name} - {EstimatedTotal}";
        }

    }
}
