using System;

namespace GuyubApp.API.Models
{
    public class IuranNonWajib
    {
        public int Id { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public string Deskripsi { get; set; }
        public int IuranBayar { get; set; }
        public Rumah Rumah { get; set; }
        public int RumahId { get; set; }
        
    }
}