using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTP_0473.Models
{
    public class DTP_cau3
    {
        [Key]
        public string Masinhvien { get; set;}
        public string Hovaten { get; set;}
        public string Diachi { get; set;}
    }
}
//dotnet-aspnet-codegenerator controller -name DTP_cau3Controller -m DTP_cau3 -dc ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite