namespace Buoi3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Author không được để trống")]
        [StringLength(30, ErrorMessage = "Author không được dài hơn 30 ký tự")]
        [Display(Name = "Author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [StringLength(100, ErrorMessage = "Tiêu đề không được dài hơn 100 ký tự")]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Mô tả không được để trống")]
        [StringLength(100)]
        public string Descriptio_n { get; set; }


        [Required(ErrorMessage = "Giá bán không được để trống")]
        [Range(1000,1000000, ErrorMessage = "Giá bán phải lớn hơn 1000 và nhỏ hơn 1000000")]
        public decimal? Price { get; set; }


        [Required(ErrorMessage = "Tên ảnh không được để trống")]
        [StringLength(50, ErrorMessage = "Tên ảnh không được dài hơn 50 ký tự")]
        public string Images { get; set; }
    }
}
