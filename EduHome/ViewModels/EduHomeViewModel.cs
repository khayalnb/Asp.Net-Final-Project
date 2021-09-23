using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class EduHomeViewModel
    {
        public List<Slide> Slides { get; set; }

        public BioInformation BioInformation { get; set; }

        public ContactMessage ContactMessage { get; set; }
    }
}
