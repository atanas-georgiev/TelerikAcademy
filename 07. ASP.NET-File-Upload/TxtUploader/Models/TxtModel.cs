
using System.ComponentModel.DataAnnotations;

namespace TxtUploader.Models
{
    public class TxtModel
    {
        public int Id { get; set; }

        [MinLength(1)]
        [MaxLength(100)]
        public string FileName { get; set; }

        public byte[] FileContent { get; set; }
    }
}