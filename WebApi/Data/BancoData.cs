using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Data
{
    public class BancoData
    {
        public static bool Registrar(Banco oBanco)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.conexiondb))
            {
                SqlCommand cmd = new SqlCommand("usp_registrarb", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombresBPbp", oBanco.NombresBP);
                cmd.Parameters.AddWithValue("@saldoac", oBanco.saldoac);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        internal static bool Modificar(Controllers.Banco oBanco)
        {
            throw new NotImplementedException();
        }

        public static bool Modificar(Banco oBanco)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.conexiondb))
            {
                SqlCommand cmd = new SqlCommand("usp_registrarb", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombresBPbp", oBanco.NombresBP);
                cmd.Parameters.AddWithValue("@saldoac", oBanco.saldoac);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static List<Banco> Listar()
        {
            List<Banco> oListaBanco = new List<Banco>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.conexiondb))
            {
                SqlCommand cmd = new SqlCommand("usp_listarb", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListaBanco.Add(new Banco()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                NombresBP = dr["NombresBP"].ToString(),
                                saldoac = Convert.ToInt32(dr["saldoac"])
                            });
                        }

                    }



                    return oListaBanco;
                }
                catch (Exception)
                {
                    return oListaBanco;
                }
            }
        }

        public static Banco Obtener(int idBanco)
        {
            Banco oBanco = new Banco();
            using (SqlConnection oConexion = new SqlConnection(Conexion.conexiondb))
            {
                SqlCommand cmd = new SqlCommand("usp_obtenerb", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", idBanco);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oBanco = new Banco()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                NombresBP = dr["NombresBP"].ToString(),
                                saldoac = Convert.ToInt32(dr["saldoac"])
                            };
                        }

                    }
                    return oBanco;
                }
                catch (Exception)
                {
                    return oBanco;
                }
            }
        }

        public static bool Eliminar(int id)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.conexiondb))
            {
                SqlCommand cmd = new SqlCommand("usp_eliminarb", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBanco", id);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception )
                {
                    return false;
                }
            }
        }

    }
}