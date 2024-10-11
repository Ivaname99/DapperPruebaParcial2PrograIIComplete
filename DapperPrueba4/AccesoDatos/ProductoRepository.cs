using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ProductoRepository
    {
        public List<Productos> ObtenerTodos()
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String SelectAll = "";
                SelectAll = SelectAll + "SELECT [Id] " + "\n";
                SelectAll = SelectAll + "      ,[Nombre] " + "\n";
                SelectAll = SelectAll + "      ,[Descripcion] " + "\n";
                SelectAll = SelectAll + "      ,[Precio] " + "\n";
                SelectAll = SelectAll + "      ,[Stock] " + "\n";
                SelectAll = SelectAll + "      ,[Marca] " + "\n";
                SelectAll = SelectAll + "      ,[Categoria] " + "\n";
                SelectAll = SelectAll + "  FROM [dbo].[Productos]";

                var ProductList = conexion.Query<Productos>(SelectAll).ToList();
                return ProductList;
            }
        }

        public Productos ObtenerPorId(int id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String SelectForId = "";
                SelectForId = SelectForId + "SELECT [Id] " + "\n";
                SelectForId = SelectForId + "      ,[Nombre] " + "\n";
                SelectForId = SelectForId + "      ,[Descripcion] " + "\n";
                SelectForId = SelectForId + "      ,[Precio] " + "\n";
                SelectForId = SelectForId + "      ,[Stock] " + "\n";
                SelectForId = SelectForId + "      ,[Marca] " + "\n";
                SelectForId = SelectForId + "      ,[Categoria] " + "\n";
                SelectForId = SelectForId + "  FROM [dbo].[Productos] " + "\n";
                SelectForId = SelectForId + "  WHERE Id = @Id";

                var ProductoId = conexion.QueryFirstOrDefault<Productos>(SelectForId, new {Id = id});
                return ProductoId;
            }
        }

        public int InsertarProducto(Productos producto)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String Insertar = "";
                Insertar = Insertar + "INSERT INTO [dbo].[Productos] " + "\n";
                Insertar = Insertar + "           ([Id] " + "\n";
                Insertar = Insertar + "           ,[Nombre] " + "\n";
                Insertar = Insertar + "           ,[Descripcion] " + "\n";
                Insertar = Insertar + "           ,[Precio] " + "\n";
                Insertar = Insertar + "           ,[Stock] " + "\n";
                Insertar = Insertar + "           ,[Marca] " + "\n";
                Insertar = Insertar + "           ,[Categoria]) " + "\n";
                Insertar = Insertar + "     VALUES " + "\n";
                Insertar = Insertar + "           (@Id " + "\n";
                Insertar = Insertar + "           ,@Nombre " + "\n";
                Insertar = Insertar + "           ,@Descripcion " + "\n";
                Insertar = Insertar + "           ,@Precio " + "\n";
                Insertar = Insertar + "           ,@Stock " + "\n";
                Insertar = Insertar + "           ,@Marca " + "\n";
                Insertar = Insertar + "           ,@Categoria)";

                var NewProd = conexion.Execute(Insertar, new
                {
                    Id = producto.Id,
                    Nombre = producto.Nombre,
                    Descripcion = producto.Descripcion,
                    Precio = producto.Precio,
                    Stock = producto.Stock,
                    Marca = producto.Marca,
                    Categoria = producto.Categoria,
                });
                return NewProd;
            }

        }

        public int ActualizarProducto(Productos producto)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String UpdateProd = "";
                UpdateProd = UpdateProd + "UPDATE [dbo].[Productos] " + "\n";
                UpdateProd = UpdateProd + "   SET [Id] = @Id " + "\n";
                UpdateProd = UpdateProd + "      ,[Nombre] = @Nombre " + "\n";
                UpdateProd = UpdateProd + "      ,[Descripcion] = @Descripcion " + "\n";
                UpdateProd = UpdateProd + "      ,[Precio] = @Precio " + "\n";
                UpdateProd = UpdateProd + "      ,[Stock] = @Stock " + "\n";
                UpdateProd = UpdateProd + "      ,[Marca] = @Marca " + "\n";
                UpdateProd = UpdateProd + "      ,[Categoria] = @Categoria " + "\n";
                UpdateProd = UpdateProd + " WHERE Id=@Id";

                var UpProducto = conexion.Execute(UpdateProd, new
                {
                    Id = producto.Id,
                    Nombre = producto.Nombre,
                    Descripcion = producto.Descripcion,
                    Precio = producto.Precio,
                    Stock = producto.Stock,
                    Marca = producto.Marca,
                    Categoria = producto.Categoria,
                });
                return UpProducto;
            }

        }

        public int EliminarProducto(int id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String DeleteProd = "";
                DeleteProd = DeleteProd + "DELETE FROM [dbo].[Productos] " + "\n";
                DeleteProd = DeleteProd + "      WHERE Id=@Id";

                var DelProducto = conexion.Execute(DeleteProd, new { Id = id });
                return DelProducto;
            }

        }
    }
}
