using Negocio.Entidades;
using Negocio.Repository;

namespace WindowsForms.Telas.Cargos
{
    public partial class CargoView : Form
    {
        private readonly ICargoRepository _cargoRepository;

        public CargoView(ICargoRepository cargoRepository)
        {
            InitializeComponent();
            _cargoRepository = cargoRepository; 
        }

        /// <summary>
        /// Exibe a GroupBox para cadastrar um cargo
        /// </summary>  
        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            groupBoxCargo.Visible = !groupBoxCargo.Visible;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtCargo.Text;
            var status = chkStatus.Checked;

            var novoCargo = new Cargo(nome, status);

            var resultado = _cargoRepository.Incluir(novoCargo);

            gvCargos.DataSource = _cargoRepository.ObterTodos();

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
            var dataTable = _cargoRepository.ObterTodos();
            gvCargos.DataSource = dataTable;
        }



        private void gvCargos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = gvCargos.Rows[e.RowIndex];

            if (gvCargos.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resultado = _cargoRepository.Deletar(int.Parse(row.Cells[1].Value.ToString()));
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