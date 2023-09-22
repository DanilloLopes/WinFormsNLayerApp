using Database.Repositorios;
using Negocio.Entidades;
using Negocio.Validators;
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
            txtCargo.Clear();
            groupBoxCargo.Visible = !groupBoxCargo.Visible;
            btnSalvar.Text = "Cadastrar";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;


            var nome = txtCargo.Text;
            var status = chkStatus.Checked;

            var cargo = new Cargo(nome, status);

            var erros = Validacoes.ValidationErros(cargo);

            foreach(var erro in erros)
            {
                MessageBox.Show(erro.ErrorMessage);
                return;
            }

            var cargoRepository = new CargoRepository();


            switch (botao.Text)
            {
                case "Cadastrar":
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
                        break;
                    }
                case "Atualizar":
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
                        break;
                    }
                default:
                    break;
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
            DataGridViewRow row = gvCargos.Rows[e.RowIndex];
            var cargoRepository = new CargoRepository();

            if (gvCargos.Columns[e.ColumnIndex].Name == "Deletar")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resulatdo = cargoRepository.Deletar(Convert.ToInt32(row.Cells[1].Value));
                    MessageBox.Show("Registro deletado com sucesso!");
                };
                return;
            }

            if (e.RowIndex >= 0)
            {
                btnSalvar.Text = "Atualizar";
                groupBoxCargo.Show();
                id = Convert.ToInt32(row.Cells[1].Value);
                txtCargo.Text = row.Cells[2].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(row.Cells[3].Value.ToString());
            }

        }
        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

            var nome = txtCargo.Text;
            var cargo = new CargoRepository();

            var reader = cargo.Complemento(nome);

            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();


            foreach (var i in reader)
            {
                autoCompleteStringCollection.Add(i);
            }

            txtCargo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCargo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCargo.AutoCompleteCustomSource = autoCompleteStringCollection;
        }
    }
}
