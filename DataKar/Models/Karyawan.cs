using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataKar.Models
{
    public class Karyawan
    {
        
        public int ID { get; set; }
        [Required(ErrorMessage ="Data Tidak Boleh Kosong")]
        [DisplayName("Nama")]
        [Column(TypeName ="nvarchar(12)")]
        public string Nama { get; set; }

        [Required(ErrorMessage = "Data Tidak Boleh Kosong")]
        [DisplayName("Alamat")]
        [Column(TypeName = "nvarchar(24)")]
        public string Alamat { get; set; }

        [Required(ErrorMessage = "Data Tidak Boleh Kosong")]
        [DisplayName("Telepon")]
        [Column(TypeName = "nvarchar(12)")]
        public string Telepon { get; set; }

        [Required(ErrorMessage = "Data Tidak Boleh Kosong")]
        [DisplayName("Tanggal Lahir")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime TLahir { get; set; }
    }
}
