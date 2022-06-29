using ASP_Practise.Models;
using System.Collections.Generic;

namespace ASP_Practise.ViewModels
{
    public class HomeVM
    {
        public int Id { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<NoticeLeft> NoticeLefts { get; set; }
        public List<NoticeRight> NoticeRights { get; set; }

    }
}
