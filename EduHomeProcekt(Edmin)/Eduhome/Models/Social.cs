using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30,ErrorMessage ="30-dan sora yazmagi dusunme haa")]
        public string Name { get; set; }
        [MaxLength(100, ErrorMessage = "100-dan sora yazmagi dusunme haa")]
        public string Icon { get; set; }
        [MaxLength(100, ErrorMessage = "100-dan sora yazmagi dusunme haa")]
        public string Link { get; set; }
    }
}
