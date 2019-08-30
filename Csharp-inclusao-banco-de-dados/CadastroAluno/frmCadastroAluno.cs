using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Cadastro_Aluno_Modelo;
using Cadastro_Aluno_Controle;

namespace CadastroAluno
{
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            mdlAluno _mdlAluno = new mdlAluno();
            _mdlAluno.Nome = txtNome.Text;
            _mdlAluno.CPF = txtCPF.Text;
            _mdlAluno.RG = txtRG.Text;

            ctlAluno _ctlAluno = new ctlAluno();

            bool retorno = _ctlAluno.Cadastrar(_mdlAluno.Nome, _mdlAluno.RG, _mdlAluno.CPF);
        }
    }
}
