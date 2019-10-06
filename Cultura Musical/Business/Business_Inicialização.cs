using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Inicialização
    {
        public void Cadastro(Database.tb_login cadastro, string conf)
        {
            if (conf != cadastro.sen_usuario)
            {
                throw new ArgumentException("Senhas diferentes");
            }
            if (cadastro.nm_usuario.Length > 30)
            {
                throw new ArgumentException("Nome de usuário não pode ser maior que 30 caracteres");
            }
            if (cadastro.sen_usuario == string.Empty || cadastro.nm_usuario == string.Empty)
            {
                throw new ArgumentException("Verifique se existem campos vazios");
            }
            if (cadastro.sen_usuario.Length > 30)
            {
                throw new ArgumentException("Senha não pode ser maior que 30 caracteres");
            }
            Database.Database_Inicialização db = new Database.Database_Inicialização();
            db.Cadastro(cadastro);
           
        }
    }
}
