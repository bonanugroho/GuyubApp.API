using System;

namespace GuyubApp.API.Models
{
    public class IuranWajib
    {
        public int Id { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public string Nama { get; set; }
        public int IPLSesuaiAturan { get; set; }
        public int IPLAktual { get; set; }
        public int IPLBayar { get; set; }
        public Rumah Rumah { get; set; }
        public int RumahId { get; set; }
        
    }
}