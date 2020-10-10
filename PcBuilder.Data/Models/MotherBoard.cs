using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class MotherBoard
    {
        public MotherBoard()
        {
            Header = new HashSet<Header>();
            MortherBoardMemory = new HashSet<MortherBoardMemory>();
            MotherBoardPort = new HashSet<MotherBoardPort>();
            MotherBoardSlot = new HashSet<MotherBoardSlot>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int ManufacturerId { get; set; }
        public int SocketId { get; set; }
        public int ChipsetId { get; set; }
        public int? ColorId { get; set; }
        public bool? RaidSupport { get; set; }
        public int? WirelesNetworking { get; set; }
        public int? OnboardEthernet { get; set; }
        public int? FormFactorTypeId { get; set; }
        public int MemorySlotCount { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ChipsetType Chipset { get; set; }
        public virtual OnBoardEthernet OnboardEthernetNavigation { get; set; }
        public virtual SocketType Socket { get; set; }
        public virtual WirelesNetworking WirelesNetworkingNavigation { get; set; }
        public virtual ICollection<Header> Header { get; set; }
        public virtual ICollection<MortherBoardMemory> MortherBoardMemory { get; set; }
        public virtual ICollection<MotherBoardPort> MotherBoardPort { get; set; }
        public virtual ICollection<MotherBoardSlot> MotherBoardSlot { get; set; }
    }
}
