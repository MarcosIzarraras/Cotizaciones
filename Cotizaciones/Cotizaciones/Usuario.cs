﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string correo { get; set; }
        public int numeroEmpleado { get; set; }
        public int tipoUsuario { get; set; }
        public int departamento { get; set; }
        public bool activo { get; set; }
        public Usuario()
        {

        }
        public bool guardar()
        {
            bool completo = false;
            //usu_id	usu_nombre	usu_apellido	usu_usuario	usu_contrasenia	usu_numeroEmpleado	usu_tipoUsuario_id	usu_departamento_id
            if (verificarDatos())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO Usuario VALUES (@nombre, @apellido, @usuario, @contraseña, @numeroEmpleado, @tipoUsuario, @departamento,@correo, @activo)");
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);
                comando.Parameters.AddWithValue("@numeroEmpleado", numeroEmpleado);
                comando.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                comando.Parameters.AddWithValue("@departamento", departamento);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@activo", activo);

                completo = Conexion.EjecutarComando(comando);

            }
            return completo;
        }
        public bool verificarDatos()
        {
            bool continuar = true;
            continuar = (nombre == "") ? false : continuar;
            continuar = (apellido == "") ? false : continuar;
            continuar = (usuario == "") ? false : continuar;
            continuar = (contraseña == "") ? false : continuar;
            continuar = (numeroEmpleado == 0) ? false : continuar;
            continuar = (tipoUsuario == 0) ? false : continuar;
            continuar = (departamento == 0) ? false : continuar;

            return continuar;
        }
        public DataTable obtenerCompradores()
        {
            SqlCommand comando = new SqlCommand("SELECT usu_id, usu_usuario FROM Usuario WHERE usu_departamento_id = @departamento AND usu_tipoUsuario_id = 2");
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@departamento", Secion.departamento);

            return Conexion.LeerTablaComando(comando);
        }
        /*public static DataTable cargarUsuario()
        {
            return Conexion.LeerTabla("SELECT tusu_id, tusu_nombre FROM TipoUsuario =" + TipoDeUsuario.id);
        }*/
    }
}
