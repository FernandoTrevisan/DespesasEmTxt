using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace despesas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblTotal.Text = total.ToString("c");
            BtnDTodos.Visible = false;
            BtnDTodos.Enabled = false;
            BtnMTodos.Visible = false;
            BtnMTodos.Enabled = false;
            BtnBaixar.Enabled = false;

            label3.Visible = false;
            lblSelecao.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDespesas.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dgvDespesas.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgvDespesas.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgvDespesas.Columns.Insert(3, new DataGridViewTextBoxColumn());

            dgvDespesas.Columns[0].Name = "";
            dgvDespesas.Columns[1].Name = "Código";
            dgvDespesas.Columns[2].Name = "Descrição";
            dgvDespesas.Columns[3].Name = "Valor";

            dgvDespesas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDespesas.ReadOnly = true;
            dgvDespesas.AllowUserToAddRows = false;
            dgvDespesas.AllowUserToDeleteRows = false;
            dgvDespesas.AllowUserToOrderColumns = true;

            dgvDespesas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDespesas.Columns[3].DefaultCellStyle.Format = "###,###,##0.00";
        }

        double total = 0;
        double total_s = 0;

        private void BtnImportar_Click(object sender, EventArgs e)
        {
            dgvDespesas.RowCount = 0;

            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();

            StreamReader arquivo = File.OpenText(ofdArquivo.FileName);

            String linha;

            while ((linha = arquivo.ReadLine()) != null)
            {
                string[] dados = linha.Split(';');
                string codigo = dados[0];
                string descricao = dados[1];
                double valor = double.Parse(dados[2]);

                dgvDespesas.Rows.Add(false, codigo, descricao, valor);
                total += valor;
            }

            BtnMTodos.Enabled = true;
            BtnDTodos.Enabled = true;
            BtnDTodos.Visible = true;
            BtnMTodos.Visible = true;
            BtnBaixar.Enabled = true;
            lblTotal.Text = total.ToString("c");
        }

        private void dgvDespesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Visible = true;
            lblSelecao.Visible = true;

            if (dgvDespesas.RowCount > 0 && e.ColumnIndex == 0)
            {
                if (Boolean.Parse(dgvDespesas.CurrentRow.Cells[0].Value.ToString()) == false)
                {
                    dgvDespesas.CurrentRow.Cells[0].Value = true;
                    total_s += double.Parse(dgvDespesas.CurrentRow.Cells[3].Value.ToString());
                } else
                {
                    dgvDespesas.CurrentRow.Cells[0].Value = false;
                    total_s -= double.Parse(dgvDespesas.CurrentRow.Cells[3].Value.ToString());
                }
            }
            lblSelecao.Text = total_s.ToString("c");
        }

        private void BtnMTodos_Click(object sender, EventArgs e)
        {
            BtnMTodos.Enabled = false;
            BtnDTodos.Enabled = true;
            BtnBaixar.Enabled = true;
            label3.Visible = true;
            lblSelecao.Visible = true;

            total_s = 0;

            // Repetition system
            foreach(DataGridViewRow linha in dgvDespesas.Rows)
            {
                linha.Cells[0].Value = true;
                total_s += double.Parse(linha.Cells[3].Value.ToString());
            }
            lblSelecao.Text = total_s.ToString("c");
        }

        private void BtnDTodos_Click(object sender, EventArgs e)
        {
            BtnDTodos.Enabled = false;
            BtnMTodos.Enabled = true;
            BtnBaixar.Enabled = false;
            label3.Visible = false;
            lblSelecao.Visible = false;

            total_s = 0;

            foreach(DataGridViewRow linha in dgvDespesas.Rows)
            {
                linha.Cells[0].Value = false;
            }
            lblSelecao.Text = total_s.ToString("c");
        }

        private void BtnBaixar_Click(object sender, EventArgs e)
        {
            for (int i = dgvDespesas.RowCount - 1; i >= 0; i--)
            {
                if (Boolean.Parse(dgvDespesas.Rows[i].Cells[0].Value.ToString()) == true)
                {
                    total_s -= Convert.ToDouble(dgvDespesas.Rows[i].Cells[3].Value);
                    total -= Convert.ToDouble(dgvDespesas.Rows[i].Cells[3].Value);
                    dgvDespesas.Rows.Remove(dgvDespesas.Rows[i]);
                }
            }
            lblSelecao.Text = total_s.ToString("c");
            lblTotal.Text = total.ToString("c");
        }
    }
}
