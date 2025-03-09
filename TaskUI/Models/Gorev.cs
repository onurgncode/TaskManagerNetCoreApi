using System.ComponentModel.DataAnnotations;

namespace StaticKimlikKarti.Models
{
    public class Gorev
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Başlık alanı boş bırakılamaz.")]
        public string baslik { get; set; }
        [Required(ErrorMessage = "Başlık alanı boş bırakılamaz.")]
        public byte tarih { get; set; }
        [Required(ErrorMessage = "Başlık alanı boş bırakılamaz.")]
        public DateTime olusturulma { get; set; }
        [Required(ErrorMessage = "Başlık alanı boş bırakılamaz.")]
        public string yazigirin { get; set; }

        
    }
}
