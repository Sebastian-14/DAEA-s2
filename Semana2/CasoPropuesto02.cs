using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Semana2
{
    public partial class CasoPropuesto02 : Form
    {
        public CasoPropuesto02()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Sebas"].ConnectionString);


        public void ListaPedidos()
        {
            Console.WriteLine("iniciando");
            using (SqlDataAdapter Df = new SqlDataAdapter("Select * from Pedidos", cn))
            {
                using (DataSet Da = new DataSet())
                {
                    // Llenar el DataSet mediante el método FILL del SqlAdapter
                    Df.Fill(Da, "Pedidos");
                    // Mostrar los datos en el control DataGridView
                    DgListaPedidos.DataSource = Da.Tables["Pedidos"];
                }
            }
        }

        private void CasoPropuesto02_Load(object sender, EventArgs e)
        {
            ListaPedidos();
        }

        private void DgListaPedidos_DoubleClick(object sender, EventArgs e)
        {
            int Codigo;
            Codigo = Convert.ToInt32(DgListaPedidos.CurrentRow.Cells[0].Value);
            using (SqlCommand cmd = new SqlCommand("Usp_Detalle_Pedido", cn))
            {
                using (SqlDataAdapter Da = new SqlDataAdapter())
                {
                    Da.SelectCommand = cmd;
                    Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Da.SelectCommand.Parameters.AddWithValue("@idpedido", Codigo);
                    using (DataSet df = new DataSet())
                    {
                        Da.Fill(df, "detallespedidos");
                        //mostrar los datos en el datagriedview
                        DgListaProductos.DataSource = df.Tables["detallespedidos"];
                    }
                }
            }
        }
    }
}
