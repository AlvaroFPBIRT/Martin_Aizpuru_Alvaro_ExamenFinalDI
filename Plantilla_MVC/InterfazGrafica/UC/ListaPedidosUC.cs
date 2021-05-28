using ObjetosTransferencia.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace InterfazGrafica.UC
{
    public partial class ListaPedidosUC : UserControl
    {
        private List<PedidoDTO> listaPedidos;

        public ListaPedidosUC(String nombreCliente)
        {
            InitializeComponent();
            // TODO: haz la peticion de los clientes y asociala a la lista y cargalo en el DataGridView
            listaPedidos=ControladorBLL.ListarPedidosCliente(nombreCliente);
            for( int i=1; i<listaPedidos.Count; i++)
            {
                this.dGV_Pedidos.Rows.Add(listaPedidos[i].IdPedido, listaPedidos[i].IdCliente, listaPedidos[i].FechaPedido, listaPedidos[i].FechaEnvio, listaPedidos[i].PrecioEnvio, listaPedidos[1].Direccion);
                
            }

            
            

        }

        public List<PedidoDTO> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

        private void dGV_Pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
