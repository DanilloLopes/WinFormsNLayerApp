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

namespace WindowsForms.Telas.Cargos
{
    public partial class CargoView : Form
    {
        int id = -1;
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

            var cargo = new Cargo(nome, status);

            txtCargo.Text = cargo.CriadoPor;

            var cargoRepository = new CargoRepository();
            if(id == -1)
            {
                var resultado = cargoRepository.Inserir(cargo);

                if (resultado)
                {
                    MessageBox.Show("Cargo Cadastrado com Sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro! Verifique e Tente Novamente.");
                }
            }
            else
            {
                var resultado = cargoRepository.Atualizar(cargo, id);
                if (resultado)
                {
                    MessageBox.Show("Cargo Atualizado com Sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro! Verifique e Tente Novamente.");
                }
            }
            


        }

        private void CargoView_Load(object sender, EventArgs e)
        {
            InformacoesTabelaCargo();
        }


        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            InformacoesTabelaCargo();
        }

        private void InformacoesTabelaCargo()
        {
            var cargoRepository = new CargoRepository();

            var obterTodos = cargoRepository.ObterTodos();

            gvCargos.DataSource = obterTodos;
        }

        private void gvCargos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                groupBoxCargo.Show();
                DataGridViewRow row = gvCargos.Rows[e.RowIndex];
                txtCargo.Text = row.Cells[1].Value.ToString();
                id = Convert.ToInt32(row.Cells[0].Value);
                chkStatus.Checked = Convert.ToBoolean(row.Cells[2].Value.ToString());
            }
            
        }
    }
}
