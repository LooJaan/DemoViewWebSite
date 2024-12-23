﻿using System.ComponentModel.DataAnnotations;

namespace AppView.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "*")]
        [MaxLength(20, ErrorMessage = " Tối đa 20 ký tự")]
        public string MaKh { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string? MatKhau { get; set; }

        [Display(Name = "Họ tên")]
        [MaxLength(50, ErrorMessage = " Tối đa 50 ký tự")]
        public string HoTen { get; set; }

        public bool GioiTinh { get; set; } = true;

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime? NgaySinh { get; set; }

        [Display(Name ="Địa chỉ")]
        [MaxLength(50, ErrorMessage = " Tối đa 50 ký tự")]
        public string DiaChi { get; set; }

        [Display(Name = "Số điện thoại")]
        [MaxLength(24, ErrorMessage = " Tối đa 24 ký tự")]
        [RegularExpression(@"0[1235789]\d{8}$", ErrorMessage = "Chưa đúng định dạng VN")]
        public string DienThoai { get; set; }


        [EmailAddress(ErrorMessage = " Chưa đúng định dạng")]
        public string Email { get; set; } 

        public string? Hinh { get; set; }
    }
}
