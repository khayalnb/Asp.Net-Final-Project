using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class BioInformation
    {
        [Required,StringLength(50)]
        public int Id { get; set; }

        [Required,StringLength(100)]
        public string Phone { get; set; }
       
        public string LogoImage { get; set; }

        [Required]
        public string FacebookLink { get; set; }

        [Required]
        public string PinterstLink { get; set; }

        [Required]
        public string VimeoLink { get; set; }

        [Required]
        public string TwitterLink { get; set; }

        [Required,StringLength(255)]
        public  string Adress { get; set; }

        [Required,StringLength(100)]
        public string Phone1 { get; set; }

        [Required, StringLength(100)]
        public string Phone2 { get; set; }

        [Required, StringLength(255)]
        public string EmailAdress { get; set; }

        [Required, StringLength(255)]
        public string WebAdress { get; set; }

        [Required]
        public string Title { get; set; }


    }
}
