namespace GuyubApp.API.Models
{
    public class Rumah
    {
        public int Id { get; set; }
        public string NoRumah { get; set; }
        public string NamaKKWarga { get; set; }
        public int Dihuni { get; set; }
        public int IPLSesuaiAturan { get; set; }
        public int IPLAktual { get; set; }
        public Blok Blok { get; set; }
        public int BlokId { get; set; }
    }
}