using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using NextFive.Cine.DataAccess.Helpers;
using NextFive.Cine.DataAccess.Interface.Cine;
using NextFive.Cine.Entidades.Cine;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.DataAccess.Implementation.Cine
{
    public class CineDataAccess //: ICineDataAccess
    {
        private static DatabaseProviderFactory oDatabaseProviderFactory = new DatabaseProviderFactory();
        private Database oDBCineNextFive = oDatabaseProviderFactory.Create(Conexion.CnNextFive_Cine);
        private SqlDatabase sqlBdCineNextFive = new SqlDatabase(ConfigurationManager.ConnectionStrings[Conexion.CnNextFive_Cine].ToString());

        public ListaPelicula ListarPelicula()
        {
            ListaPelicula oListaPelicula = new ListaPelicula();
            DbCommand oDbCommand = oDBCineNextFive.GetStoredProcCommand("Usp_getPelicula");
            using (IDataReader oIDataReader = oDBCineNextFive.ExecuteReader(oDbCommand))
            {
                int iIdPelicula = oIDataReader.GetOrdinal("IdPelicula");
                int iNombre = oIDataReader.GetOrdinal("Nombre");
                int iDescripcion = oIDataReader.GetOrdinal("Descripcion");
                int iIdCategoria = oIDataReader.GetOrdinal("IdCategoria");
                int iDuracion = oIDataReader.GetOrdinal("Duracion");
                int iCartelera = oIDataReader.GetOrdinal("Cartelera");
                int iFechaInicioCartelera = oIDataReader.GetOrdinal("FechaInicioCartelera");
                int iFechaFinCartelera = oIDataReader.GetOrdinal("FechaFinCartelera");
                while (oIDataReader.Read())
                {
                    Peliculas obj = new Peliculas();
                    obj.IdPelicula = DataUtil.DbValueToDefault<int>(oIDataReader[iIdPelicula]);
                    obj.Nombre = DataUtil.DbValueToDefault<string>(oIDataReader[iNombre]);
                    obj.Descripcion = DataUtil.DbValueToDefault<string>(oIDataReader[iDescripcion]);
                    obj.Categoria = new Categoria();
                    obj.Categoria.IdCategoria = DataUtil.DbValueToDefault<int>(oIDataReader[iIdCategoria]);
                    obj.Duracion = DataUtil.DbValueToDefault<string>(oIDataReader[iDuracion]);
                    obj.Cartelera = DataUtil.DbValueToDefault<bool>(oIDataReader[iCartelera]);
                    obj.FechaInicioCartelera = DataUtil.DbValueToDefault<DateTime>(oIDataReader[iFechaInicioCartelera]);
                    obj.FechaFinCartelera = DataUtil.DbValueToDefault<DateTime>(oIDataReader[iFechaFinCartelera]);
                    oListaPelicula.Add(obj);
                }
            }
            return oListaPelicula;
        }
        public RespuestaTransaccion InsertarVotacion(Votacion oVotacion)
        {
            RespuestaTransaccion oRespuestaTransaccion = new RespuestaTransaccion();

            DbCommand oDbCommand = sqlBdCineNextFive.GetStoredProcCommand("Usp_InsVotaciones");
            sqlBdCineNextFive.AddInParameter(oDbCommand, "@IdUsuario", DbType.Int32, oVotacion.Usuario.IdUsuario);
            sqlBdCineNextFive.AddInParameter(oDbCommand, "@IP", DbType.String, oVotacion.IP);
            sqlBdCineNextFive.AddInParameter(oDbCommand, "@Pelicula", DbType.String, oVotacion.Peliculas.Nombre);
            sqlBdCineNextFive.AddInParameter(oDbCommand, "@Comentario", DbType.String, oVotacion.Comentario);
            //oDBCineNextFive.ExecuteNonQuery(oDbCommand);

            oRespuestaTransaccion.IdTransaccion = (int)sqlBdCineNextFive.ExecuteScalar(oDbCommand);
            oRespuestaTransaccion.MensajeTransaccion = oRespuestaTransaccion.IdTransaccion == 0 ? 
                                                        "No se registro la votación" 
                                                        : "Usted ha votado por " + oVotacion.Peliculas.Nombre;
            return oRespuestaTransaccion;
        }
    }
}
