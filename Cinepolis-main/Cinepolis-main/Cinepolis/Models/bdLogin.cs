using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Cinepolis.Models
{
    public class bdLogin
    {
        readonly SQLiteAsyncConnection db;
        public bdLogin()
        {
        }

        public bdLogin(String pathbasedatos)
        {
            db = new SQLiteAsyncConnection(pathbasedatos);

            // -- Creación de tablas de base de datos
            db.CreateTableAsync<Usuario>();
        }

        public Task<List<Usuario>> listaempleados()
        {

            return db.Table<Usuario>().ToListAsync();
        }

        // buscar un empleado especifico por el codigo
        /*
        public Task<constructorLogin> ObtenerEmpleado(Int32 pcodigo)
        {
            return db.Table<constructorLogin>().Where(i => i.codigo == pcodigo).FirstOrDefaultAsync();
        }
        */
        public Task<Usuario> ObtenerCliente()
        {
            return db.Table<Usuario>().Where(i => i.correo != "").FirstOrDefaultAsync();
        }



        // Guardar o actualizar empleado

        public Task<Int32> EmpleadoGuardar(Usuario emple)
        {
            if (emple.codigo != 0)
            {
                return db.UpdateAsync(emple);
            }
            else
            {
                return db.InsertAsync(emple);
            }
        }

        public Task<Int32> EmpleadoBorrar(Usuario emple)
        {
            return db.DeleteAsync(emple);
        }



    }
}
