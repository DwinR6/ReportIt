using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SQLite;
using System.Threading.Tasks;

namespace ReportIt.Model
{
    public class Config_Data
    {
        SQLiteAsyncConnection Database;
        //Conector de la Clase.
        public Config_Data()
        {
            string DbFilePath = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData), "ReportIt.db");
            //Crear la conexion a la BD.
            Database = new SQLiteAsyncConnection(DbFilePath);
            //Crear Tablas ToDoItems.
            Database.CreateTableAsync<Tbl_Violencia>().Wait();
        }


        //Crear Operaciones Crud.
        public Task<int> Insertar(Model.Tbl_Violencia tbl_Violencia)
        {
            return Database.InsertAsync(tbl_Violencia);
        }


        // Obtener datos por ID.
        public Task<Model.Tbl_Violencia> ObtenerTodoPorId(int id)
        {
            //Select * from tablr where id == @id.
            return Database.Table<Tbl_Violencia>().Where(ti => ti.Id == id).FirstOrDefaultAsync();
        }



        //Actualizar Datos.
        public Task<int> ActualizarDatos(Tbl_Violencia tbl_Violencia)
        {
            return Database.UpdateAsync(tbl_Violencia);
        }



        //Borrar datos.
        public Task<int> BorrarDatos(Tbl_Violencia tbl_Violencia)
        {
            return Database.DeleteAsync(tbl_Violencia);
        }


        //Obtener todos los items de la tabala.
        public Task<List<Tbl_Violencia>> ObtenerTodosItems()
        {
            //Select * from ToDoItemsDB.
            return Database.Table<Tbl_Violencia>().ToListAsync();
        }



        //Obtener datos por el id.
        public Task<List<Tbl_Violencia>> ObtenerCategoriaItemId(int IdCategoria)
        {
            return Database.QueryAsync<Tbl_Violencia>($"SELECT * FROM [T_Tareas WHERE [CategoryId] = {IdCategoria}");
        }

    }
}
