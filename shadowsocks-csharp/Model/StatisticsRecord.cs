using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shadowsocks.Model
{
    // Simple processed records for a short period of time
    public class StatisticsRecord
    {
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public string ServerIdentifier { get; set; }

        // in ping-only records, these fields would be null
        public int? AverageLatency;
        public int? MinLatency;
        public int? MaxLatency;

        private bool EmptyLatencyData => (AverageLatency == null) && (MinLatency == null) && (MaxLatency == null);

        public int? AverageInboundSpeed;
        public int? MinInboundSpeed;
        public int? MaxInboundSpeed;

        private bool EmptyInboundSpeedData
            => (AverageInboundSpeed == null) && (MinInboundSpeed == null) && (MaxInboundSpeed == null);

        public int? AverageOutboundSpeed;
        public int? MinOutboundSpeed;
        public int? MaxOutboundSpeed;

        private bool EmptyOutboundSpeedData
            => (AverageOutboundSpeed == null) && (MinOutboundSpeed == null) && (MaxOutboundSpeed == null);

        // if user disabled ping test, response would be null
        public int? AverageRoundtripTime;
        public int? MinRoundtripTime;
        public int? MaxRoundtripTime;
        public float? PackageLoss;

        private bool EmptyRoundtripData
            => (AverageRoundtripTime == null) && (MinRoundtripTime == null) && (MaxRoundtripTime == null) && (PackageLoss == null);

        public bool IsEmptyData() {
            return EmptyInboundSpeedData && EmptyOutboundSpeedData && EmptyRoundtripData && EmptyLatencyData;
        }

        public StatisticsRecord()
        {
        }

        /// <summary>
        /// TCP records
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="inboundSpeedRecords"></param>
        /// <param name="outboundSpeedRecords"></param>
        /// <param name="latencyRecords"></param>
        public StatisticsRecord(string identifier, ICollection<int> inboundSpeedRecords, ICollection<int> outboundSpeedRecords, ICollection<int> latencyRecords)
        {
            ServerIdentifier = identifier;
            var inbound = inboundSpeedRecords?.Where(s => s > 0).ToList();
            if (inbound != null && inbound.Any())
            {
                AverageInboundSpeed = (int) inbound.Average();
                MinInboundSpeed = inbound.Min();
                MaxInboundSpeed = inbound.Max();
            }
            var outbound = outboundSpeedRecords?.Where(s => s > 0).ToList();
            if (outbound!= null && outbound.Any())
            {
                AverageOutboundSpeed = (int) outbound.Average();
                MinOutboundSpeed = outbound.Min();
                MaxOutboundSpeed = outbound.Max();
            }
            var latency = latencyRecords?.Where(s => s > 0).ToList();
            if (latency!= null && latency.Any())
            {
                AverageLatency = (int) latency.Average();
                MinLatency = latency.Min();
                MaxLatency = latency.Max();
            }
        }

        /// <summary>
        /// ICMP (ping) records
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="roundtripRecords"></param>
        public StatisticsRecord(string identifier, ICollection<int?> roundtripRecords)
        {
            ServerIdentifier = identifier;
            SetRoundtripTime(roundtripRecords);
        }

        public void SetRoundtripTime(ICollection<int?> roundtripTimeRecords)
        {
            if (roundtripTimeRecords == null) return;
            var records = roundtripTimeRecords.Where(response => response != null).Select(response => response.Value).ToList();
            if (!records.Any()) return;
            AverageRoundtripTime = (int?)records.Average();
            MinRoundtripTime = records.Min();
            MaxRoundtripTime = records.Max();
            PackageLoss = roundtripTimeRecords.Count(response => response != null) / (float)roundtripTimeRecords.Count;
        }
    }
}
