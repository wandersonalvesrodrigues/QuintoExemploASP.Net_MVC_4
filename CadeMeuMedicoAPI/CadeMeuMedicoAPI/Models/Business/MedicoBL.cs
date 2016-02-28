using CadeMeuMedicoAPI.Models;
using CadeMeuMedicoAPI.Repository;
using System.Collections.Generic;

namespace CadeMeuMedicoAPI.Business
{
    public class MedicoBL
    {
        public static ICollection<Medico> BuscaMedicos()
        {
            var medicoRepositorio = new MedicoRepositorio(Contexto.GetContexto());

            return medicoRepositorio.BuscaMedicos();
        }

        public static Medico BuscaPorId(int id)
        {
            var medicoRepositorio = new MedicoRepositorio(Contexto.GetContexto());
            return medicoRepositorio.BuscaMedicosPorId(id);
        }

        public static bool Inserir(Medico medico)
        {
            bool inseridoSucesso = true;
            try
            {
                var medicoRepositorio = new MedicoRepositorio(Contexto.GetContexto());
                medicoRepositorio.Inserir(medico);
            }
            catch
            {
                inseridoSucesso = false;
            }

            return inseridoSucesso;
        }

        public static bool Atualizar(Medico medico)
        {
            bool inseridoSucesso = true;
            try
            {
                var medicoRepositorio = new MedicoRepositorio(Contexto.GetContexto());
                medicoRepositorio.Atualizar(medico);
            }
            catch
            {
                inseridoSucesso = false;
            }

            return inseridoSucesso;
        }

        public static bool Excluir(int id)
        {
            bool excluidoSucesso = true;
            try
            {
                var medicoRepositorio = new MedicoRepositorio(Contexto.GetContexto());
                medicoRepositorio.Deletar(id);
            }
            catch
            {
                excluidoSucesso = false;
            }
            return excluidoSucesso;
        }
    }
}