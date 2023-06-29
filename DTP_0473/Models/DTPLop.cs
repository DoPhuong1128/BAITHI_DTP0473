using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTP_0473.Models
{
    public class DTPLop
    {
        [Key]
        public string Malop { get; set;}
        public string ten { get; set;}
        public string Diachi { get; set;}
    }
}