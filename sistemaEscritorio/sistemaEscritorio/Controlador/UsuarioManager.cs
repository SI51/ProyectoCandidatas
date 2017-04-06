using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemaLibreria.Modelo;
using System.Data.Entity;
using sistemaEscritorio.Comun;
using sistemaEscritorio.Controlador.Helpers;
using System.Windows.Forms;

namespace sistemaEscritorio.Controlador
{
    public class UsuarioManager
    {
        public static UsuarioHelper Autentificar(int empleado, String sPassword)
        {
            UsuarioHelper uHelper = new UsuarioHelper();
            Usuario user = BuscarPorEmail(empleado);
            if (user != null)
            {
                if (user.sPassword == LoginTool.GetMD5(sPassword))
                {
                    uHelper.usuario = user;
                    uHelper.esValido = true;
                }
                else
                {
                    uHelper.sMensaje = "Datos Incorrectos";
                }
            }
            return uHelper;
        }

        private static Usuario BuscarPorEmail(int empleado)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Usuarios.Include("fkRoles")
                        .Include("fkRoles.PermisosNegadosRol")
                        .Include("fkRoles.PermisosNegadosRol.fkPermiso")
                        .Where(r => r.iEmpleadoUsuario == empleado).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void RegistrarNuevoUsuario(Usuario nUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Usuarios.Add(nUsuario);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static Usuario getById(int pkUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Usuarios.Where(r => r.bStatus == true && r.pkUsuario == pkUsuario).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<Usuario> BuscarporIDLi(Boolean Status)
        {
            try
            {

                using (var ctx = new DataModel())
                {
                    return ctx.Usuarios.Where(r => r.bStatus == Status).ToList();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Rol getById2(int pkrol)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Roles.Where(r => r.bStatus == true && r.pkRoles == pkrol).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void Modificar(Usuario nUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Usuarios.Attach(nUsuario);
                    ctx.Entry(nUsuario).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                //TODO: NO ACTUALIZA.
                throw;
            }
        }
        public static void guardar(Usuario nusuario, int pkRoles, int iempleado)
        {
            Rol roles = getById2(pkRoles);
            try
            {
                using (var ctx = new DataModel())
                {
                    nusuario.fkRoles = roles;
                    nusuario.iEmpleadoUsuario = iempleado;
                    ctx.Roles.Attach(roles);
                    ctx.Entry(nusuario).State = EntityState.Added;

                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<Rol> getAll2(Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Roles.Where(r => r.bStatus == status).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Eliminar(int pkUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    Usuario nUsuario = UsuarioManager.getById(pkUsuario);
                    nUsuario.bStatus = false;

                    ctx.Entry(nUsuario).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
