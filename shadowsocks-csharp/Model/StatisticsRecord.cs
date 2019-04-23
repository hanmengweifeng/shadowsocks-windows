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

        public TCPRecord TCP { get; set; } = new TCPRecord();
        public ICMPRecord ICMP { get; set; } = new ICMPRecord();

        public bool IsEmptyData
            => TCP.IsEmptyData && ICMP.IsEmptyData;


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
                TCP.AverageInboundSpeed = (int) inbound.Average();
                TCP.MinInboundSpeed = inbound.Min();
                TCP.MaxInboundSpeed = inbound.Max();
            }
            var outbound = outboundSpeedRecords?.Where(s => s > 0).ToList();
            if (outbound!= null && outbound.Any())
            {
                TCP.AverageOutboundSpeed = (int) outbound.Average();
                TCP.MinOutboundSpeed = outbound.Min();
                TCP.MaxOutboundSpeed = outbound.Max();
            }
            var latency = latencyRecords?.Where(s => s > 0).ToList();
            if (latency!= null && latency.Any())
            {
                TCP.AverageLatency = (int) latency.Average();
                TCP.MinLatency = latency.Min();
                TCP.MaxLatency = latency.Max();
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
            ICMP.AverageRoundtripTime = (int?)records.Average();
            ICMP.MinRoundtripTime = records.Min();
            ICMP.MaxRoundtripTime = records.Max();
            ICMP.PackageLoss = roundtripTimeRecords.Count(response => response != null) / (float)roundtripTimeRecords.Count;
        }

        public class TCPRecord
        {
            public int? AverageLatency;
            public int? MinLatency;
            public int? MaxLatency;
            private bool EmptyLatencyData
                => (AverageLatency == null) && (MinLatency == null) && (MaxLatency == null);

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

            public bool IsEmptyData
                => EmptyLatencyData && EmptyInboundSpeedData && EmptyOutboundSpeedData;
        }

        public class ICMPRecord
        {
            public int? AverageRoundtripTime;
            public int? MinRoundtripTime;
            public int? MaxRoundtripTime;
            public float? PackageLoss;
            public bool IsEmptyData
                => (AverageRoundtripTime == null) && (MinRoundtripTime == null) && (MaxRoundtripTime == null) && (PackageLoss == null);

        }
    }
}
