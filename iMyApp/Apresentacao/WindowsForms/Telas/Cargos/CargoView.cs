using Database.Repositorios;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsForms.Telas.Cargos
{
    public partial class CargoView : Form
    {
        public CargoView()
        {
            InitializeComponent();
        }

        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            groupBoxCargo.Visible = !groupBoxCargo.Visible;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtCargo.Text;
            var status = chkStatus.Checked;

            var novoCargo = new Cargo(nome, status);


            var cargoRepository = new CargoRepository();

            var resultado = cargoRepository.Inserir(novoCargo);

            gvCargos.DataSource = cargoRepository.ObterTodos();

            if (resultado)
            {
                MessageBox.Show("Cargo cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar o cargo");
            }

        }

        private void CargoView_Load(object sender, EventArgs e)
        {
            var cargoRepository = new CargoRepository();
            var dataTable = cargoRepository.ObterTodos();
            gvCargos.DataSource = dataTable;
        }



        private void gvCargos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cargoRepository = new CargoRepository();
            DataGridViewRow row = gvCargos.Rows[e.RowIndex];

            if (gvCargos.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resultado = cargoRepository.Deletar(int.Parse(row.Cells[1].Value.ToString()));
                };
                return;
            }

            if (e.RowIndex >= 0)
            {
                groupBoxCargo.Show();
               
                txtCargo.Text = row.Cells[1].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(row.Cells[2].Value.ToString());
            }


        }
    }
}
