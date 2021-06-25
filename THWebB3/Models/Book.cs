namespace THWebB3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được trống")]
        [StringLength(30, ErrorMessage = "Tên không được vượt quá 30 ký tự")]
        [Display(Name = "Tác giả")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [StringLength(100, ErrorMessage = "Tiêu đề sách không được vượt quá 100 ký tự")]
        [Display(Name = "Tiêu đề")]
        public string Tittle { get; set; }

        [Required(ErrorMessage = "Nội dung không được để trống")]
        [StringLength(150)]
        [Display(Name = "Nội dung")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Hình ảnh không được để trống")]
        [StringLength(50)]
        [Display(Name = "Hình ảnh")]
        public string ImageCover { get; set; }

        [Required(ErrorMessage = "Giá sách không được để trống")]
        [Range(1000, 1000000, ErrorMessage = "Giá sách từ 1000 đến 1000000")]
        [Display(Name = "Giá sách")]
        public int Price { get; set; }
    }
}
