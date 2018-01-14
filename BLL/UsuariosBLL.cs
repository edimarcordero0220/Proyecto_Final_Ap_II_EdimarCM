using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class UsuariosBLL
    {
        public static void Insertar(Usuarios u)
        {
            try
            {
                Sistema_DiscoGrafico_EdimarCM db = new Sistema_DiscoGrafico_EdimarCM();
                db.usuario.Add(u);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();
            Sistema_DiscoGrafico_EdimarCM db = new Sistema_DiscoGrafico_EdimarCM();
            lista = db.usuario.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            Sistema_DiscoGrafico_EdimarCM db = new Sistema_DiscoGrafico_EdimarCM();
            Usuarios cl = db.usuario.Find(v);

            db.usuario.Remove(cl);
            db.SaveChanges();
        }
        public static Usuarios Buscar(int Id)
        {
            Sistema_DiscoGrafico_EdimarCM db = new Sistema_DiscoGrafico_EdimarCM();
            return db.usuario.Find(Id);
        }
        public static List<Usuarios> GetListaNombre(string tmp)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Sistema_DiscoGrafico_EdimarCM db = new Sistema_DiscoGrafico_EdimarCM();
            lista = db.usuario.Where(p => p.Nombre == tmp).ToList();
            return lista;
        }

        public static List<Usuarios> GetId(int usuarioid)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Sistema_DiscoGrafico_EdimarCM db = new Sistema_DiscoGrafico_EdimarCM();
            lista = db.usuario.Where(p => p.UsuarioId == usuarioid).ToList();
            return lista;
        }
        public static List<Usuarios> GetContrasena(string tmp)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Sistema_DiscoGrafico_EdimarCM db = new Sistema_DiscoGrafico_EdimarCM();
            lista = db.usuario.Where(p => p.Clave == tmp).ToList();
            return lista;
        }


    }
}
