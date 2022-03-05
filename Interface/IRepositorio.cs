using System.Collections.Generic;

namespace APP.Series.Interface
{
    public interface IRepositorio<T>
    {
       List<T> Lista();
       T RetornaPorId(int id);
       void Insere(T entidade);
       void Exclui(int id);
       void Atualizada(int id, T entidade);
       int ProximoId();
    }
}