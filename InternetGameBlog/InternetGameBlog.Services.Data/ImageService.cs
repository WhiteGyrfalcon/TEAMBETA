using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using InternetGameBlog.Data.Models;
using InternetGameBlog.Data.Repository;
using InternetGameBlog.Services.Contracts;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGameBlog.Services.Data
{
    public class ImageService : IImageService
    {
        private readonly IRepository repo;
        private readonly Cloudinary cloudinary;

        public ImageService(IRepository repo, Cloudinary cloudinary)
        {
            this.repo = repo;
            this.cloudinary = cloudinary;
        }

        public async Task<string> UploadImage(IFormFile imageFile, string nameFolder, User user)
        {
            using var stream = imageFile.OpenReadStream();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(user.Id, stream),
                Folder = nameFolder
            };

            var uploadResult = await cloudinary.UploadAsync(uploadParams);

            if (uploadResult.Error != null)
            {
                throw new InvalidOperationException(uploadResult.Error.Message);
            }

            user.ProfilePicUrl = uploadResult.Url.ToString();

            this.repo.Update(user);

            await repo.SaveChangesAsync();

            return user.ProfilePicUrl;
        }
    }
}
