using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyLeasing.Web.Helpers
{
    public class ImageHelper : IImageHelper
    {
        public async Task<string> UploadImageAsync(IFormFile imageFile)
        {
            //Guid Cambial el nombre del archivo. En esta linea lo esta convirtiendo en String
            var guid = Guid.NewGuid().ToString();
            //Luego Armamos el nombre del archivo con el guid y Jpg
            var file = $"{guid}.jpg";
            //Luego combinamos la ruta
            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot\\images\\Properties",
                file);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }

            return $"~/images/Properties/{file}";
        }
    }
}
