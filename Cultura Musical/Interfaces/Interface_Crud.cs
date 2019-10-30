using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Interfaces
{
    class Interface_Crud
    {
        // Modelo de interface para padronização do crud Database/Business

        interface Crud<X>
        {
            void Cadastrar(X Model);

            void Alterar(X Model);

            List<X> ListarTodos();

            X Procurar(X Model);

            void Remover(int id);

        }
    }
}
