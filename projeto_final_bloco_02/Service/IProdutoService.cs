using projeto_final_bloco_02.Model;

namespace projeto_final_bloco_02.Service
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> GetAll();
        Task<Produto?> GetById(long id);
        Task<IEnumerable<Produto>> GetByNome(string titulo);
        Task<Produto?> Create(Produto postagem);
        Task<Produto?> Update(Produto postagem);
        Task Delete(Produto postagem);
    }
}
