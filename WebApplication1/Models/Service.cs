using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string BannerText { get; set; }
        [MaxLength(200)]
        public string Img { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
    }
}
