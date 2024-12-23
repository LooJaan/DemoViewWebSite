﻿using System.Text;

namespace AppView.Helpers
{
    public class MyUtil
    {
        public static string UploadHinh(IFormFile Hinh, string folder)
        {
            try
            {
                var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh", folder, Hinh.FileName);
                using (var myFile = new FileStream(fullPath, FileMode.CreateNew))
                {
                    Hinh.CopyTo(myFile);
                }
                return Hinh.FileName;
            }catch (Exception ex)
            {
                return string.Empty;
            }
        }
        public static string GenerateRandomKey(int length = 5)
        {
            var pattern = @"qweasdzxcrtyfghvbnQWEASDZXCRTYFGHVBN!";
            var sb = new StringBuilder();
            var rd = new Random();
            for (int i = 0; i < length; i++)
            {
                sb.Append(pattern[rd.Next(0, pattern.Length)]);
            }
            return sb.ToString();
        }
    }
}
