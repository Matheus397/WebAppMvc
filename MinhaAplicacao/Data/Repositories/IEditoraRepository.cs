using MinhaAplicacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAplicacao.Data.Repositories
{
    public interface IEditoraRepository
    {
        Task<IEnumerable<Editora>> ListAsync();

        Task<Editora> EditoraById(int id);

        Task<Editora> CreateEditora(Editora editora);

    }
}
