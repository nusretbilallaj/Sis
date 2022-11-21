using System.ComponentModel.DataAnnotations.Schema;

namespace Sis.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public int KomunaId { get; set; }
        [ForeignKey("KomunaId")]
        public Komuna Komuna { get; set; }
    }
}
