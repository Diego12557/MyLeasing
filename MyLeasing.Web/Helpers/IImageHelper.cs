using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyLeasing.Web.Helpers
{
	public interface IImageHelper
	{
		//Devuelve la ruta
		Task<string> UploadImageAsync(IFormFile imageFile);
	}
}
