using InternetGameBlog.Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Services.Contracts
{
    public interface IImageService
    {
        Task<string> UploadImage(IFormFile imageFile, string nameFolder, User user);
    }
}
