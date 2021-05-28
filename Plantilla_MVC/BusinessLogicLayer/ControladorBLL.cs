﻿using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using ObjetosTransferencia.DTO;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public static class ControladorBLL
    {

        #region Atributos


        #endregion

        #region Constructores

        #endregion

        #region Propiedades

        #endregion

        #region Metodos


        /// <summary>
        /// Pedir datos de la lista de clientes a la BD NorthWind SQLServer
        /// </summary>
        public static List<ClienteDTO> PedirListaClientes()
        {
            // TODO: llama al metodo que pide la lista de clientes
            return AccesoDatosDAL.ListadoClientesNorthWind();
            
            throw new Exception();
        }


        /// <summary>
        /// Pedir la lista de pedidos de un clientelista de clientes a la BD NorthWind SQLServer
        /// </summary>
        public static List<PedidoDTO> ListarPedidosCliente(String nombreCliente)
        {
            // TODO: llamar al metodo que lista los pedidos
            return AccesoDatosDAL.ListadoPedidosCliente(nombreCliente);
            throw new Exception();
        }


        #endregion


    }
}
