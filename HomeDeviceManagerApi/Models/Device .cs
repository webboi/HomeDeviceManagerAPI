using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeDeviceManagerApi.Models
{
    public class Device
    {
        [Key]
       public  int DeviceId { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string DeviceName { get; set; } = "";

        [Column(TypeName ="nvarchar(100)")]
        public string Type { get; set; } = "";
        [Column(TypeName = "nvarchar(100)")]
        public string ExpirationDate { get; set; } = "";
        [Column(TypeName = "nvarchar(100)")]
        public bool IsOn { get; set; } 

    }
}
