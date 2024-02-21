using RegistoMovimentosSrJoaquim.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentosSrJoaquim.Business.Controllers
{
    internal class ProgramController
    {
        // ==== CONSTRUTOR =====
        public ProgramController() { }

        // ==== PROPERTIES =====
        private GestorListagem gl = new GestorListagem();
        private GestorCliente gc = new GestorCliente();
        private GestorMovimento gm = new GestorMovimento();

        // ==== MÉTODOS ========

        // ==================================== GESTOR MOVIMENTO ====================================
        public void addMovimento(DateTime data, string descricao, decimal valor, char tipo, string marcacao, int Idcliente)
        {
            gm.addMovimento(data, descricao, valor, tipo, marcacao, Idcliente);
        }
        public void updateMovimento(DateTime data, string descricao, int valor, string marcacao, int Idcliente)
        {
            gm.updateMovimento(data, descricao, valor, marcacao, Idcliente);
        }
        public void deleteMovimento(int idMovimento)
        {
            gm.deleteMovimento(idMovimento);
        }

        // ==================================== GESTOR CLIENTE ====================================
        public void addCliente(int nif, string nome, string estado)
        {
            gc.addCliente(nif, nome, estado);
        }
        public void updateCliente (int nif, string nome, string estado)
        {
            gc.updateCliente(nif, nome, estado);
        }
        public void deleteCliente(DataGridView dgv, string ClienteId)
        {
            gc.deleteCliente(ClienteId);
        }

        // ================================== GESTOR LISTAGEM ====================================

        // ==================================== METODOS GERAIS ====================================

        public void FormatarDGV(DataGridView dgv, string dgvDt)
        {
            gl.FormatarDGV(dgv, dgvDt);
        }
        public decimal GetSaldoCorrente(string nomeCliente, DateTime data)
        {
            return gl.GetSaldoCorrente(nomeCliente, data);
        }

        // ================================== PREENCHER CBX ====================================

        public void PreencherCbxTipos(ComboBox cbx)
        {
            gl.PreencherCbxTipos(cbx);
        }
        public void PreencherCbxMes(ComboBox cbx)
        {
            gl.PreenchreCbxMes(cbx);
        }
        public void PreencherCbxClientesListagem(ComboBox cbx)
        {
            gl.PreencherCbxClientesListagem(cbx);
        }
        public void PreencherCbxClientesMov(ComboBox cbx)
        {
            gl.PreencherCbxClientesMov(cbx);
        }

        // ================================== PREENCHER DGV ====================================
        public void PreencherDgvClientes(DataGridView dgvClientes)
        {
            gl.PreencherDgvClientes(dgvClientes);
        }
        public void PreencherDgvMovimentos(DataGridView dgvMovimentos)
        {
           gl.PreencherDgvMovimentos(dgvMovimentos);
        }
        public void PreencherDgvLivres(DataGridView dgvLivres)
        {
            gl.PreencherDgvLivres(dgvLivres);
        }
        public void PreencherDgvMarcados(DataGridView dgvMarcados)
        {
            gl.PreencherDgvMarcados(dgvMarcados);
        }
        public void PreencherDgvEstadoPendente(DataGridView dgvEstadoPendente)
        {
            gl.PreencherDgvEstadoPendente(dgvEstadoPendente);
        }
        public void PreencherDgvEstadoAtivo(DataGridView dgvEstadoAtivo)
        {
            gl.PreencherDgvEstadoAtivo(dgvEstadoAtivo);
        }
        public void PreencherDgvEntradas(DataGridView dgvEntradas)
        {
            gl.PreencherDgvEntradas(dgvEntradas);
        }
        public void PreencherDgvSaidas(DataGridView dgvSaidas)
        {
            gl.PreencherDgvSaidas(dgvSaidas);
        }

        // ================================== LISTAGENS ====================================
        public List<ListaMovimentos>? ListarMovimentosClienteSelecionado(string ClienteId)
        {
            return gl.ListarMovimentosClienteSelecionado(ClienteId);
        }
        public List<ListaMovimentos>? ListarMovimentosClienteMesPeriodo(string ClienteId, string? mesNumero, SelectionRange? periodoTempo, int mesPeriodo)
        {
            return gl.ListarMovimentosClienteMesPeriodo(ClienteId, mesNumero, periodoTempo, mesPeriodo);
        }
    }
}
