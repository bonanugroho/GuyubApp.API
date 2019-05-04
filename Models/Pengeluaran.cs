using System;

namespace GuyubApp.API.Models
{
    public class Pengeluaran
    {
        public int Id { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public string Tipe { get; set; } //RUTIN & NON-RUTIN
        public string Deskripsi { get; set; }
        public int RpBayar { get; set; }
        public RT RT { get; set; }
        public int RtId { get; set; }
    }
}