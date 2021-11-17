using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaClaroDom_EduardoCortes.Model;
using System.Net.Http;


namespace PruebaClaroDom_EduardoCortes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        HttpClient cliente = new HttpClient();

        public BooksController()
        {
            
        }

        private async Task GetBooksTask()
        {
            string response = await cliente.GetStringAsync("https://fakerestapi.azurewebsites.net/api/v1/Books");
        }

        [HttpGet]
        public IEnumerable<BooksModel> GetBooks()
        {
            return new List<BooksModel>();
        }

        [HttpGet("{_id}")]
        public BooksModel GetBook(int _id)
        {


            return new BooksModel();
        }
    }
}
