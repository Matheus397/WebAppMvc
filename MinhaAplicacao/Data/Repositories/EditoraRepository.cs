using Microsoft.EntityFrameworkCore;
using MinhaAplicacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAplicacao.Data.Repositories
{
    public class EditoraRepository : IEditoraRepository
    {
        protected readonly BibliotecaContexto _context;
        public EditoraRepository(BibliotecaContexto context)
        {
            _context = context;
        }

        public async Task<Editora> CreateEditora(Editora editora) 
        {
            _context.Editoras.Add(editora);
            await _context.SaveChangesAsync();

            return editora;
        }
           
        public async Task<Editora> EditoraById(int id) => await _context.Editoras.FindAsync(id);

        public async Task<IEnumerable<Editora>> ListAsync() => await _context.Editoras.ToListAsync();
        
    }
}
