
using DavidApp.Models;
using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace davidapp.data
{
    public  interface IApi 
    {
        [Get("/produto")]
        Task<IEnumerable<Produto>> GetAll();

      //  [Get("/{key}")]
      //  Task<ApiResponse<TAnyType>> GetById(TAnyKey key);

        [Post("/produto/save")]
        Task<HttpContent> Save([Body] Produto produto);

      //  [Put("/{key}")]
      //  Task<ApiResponse<TAnyType>> Update(TAnyKey key, [Body] TAnyType payload);

      //  [Delete("/{key}")]
      //  Task Delete(TAnyKey key);
    }
}
