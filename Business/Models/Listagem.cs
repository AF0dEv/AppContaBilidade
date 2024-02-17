using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using RegistoMovimentosSrJoaquim.Business.Controllers;
using RegistoMovimentosSrJoaquim.Persistence.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentosSrJoaquim.Business.Models
{
    internal class Listagem
    {
        // =========== CONSTRUTOR ================
        public Listagem() { }
        // =========== PROPERTIES ==================
        private AppDbContext db = AppDbContext.getInstancia();
        // ====================================== MÉTODOS ======================================

        public static decimal GetSaldoCorrente(string nomeCliente, DateTime data)
        {
            AppDbContext db = new AppDbContext();
            decimal saldoPositivo = db.Movimentos.Where(m => m.Cliente.Nome == nomeCliente && m.Tipo == 'C' && m.Data <= data).Sum(m => m.Valor);
            decimal saldoNegativo = db.Movimentos.Where(m => m.Cliente.Nome == nomeCliente && m.Tipo == 'D' && m.Data <= data).Sum(m => m.Valor);
            return saldoPositivo - saldoNegativo;
        }

        // ================================== PREENCHER CBX ====================================

        public void PreencherCbxTipos(ComboBox cbx)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("TipoNumero", typeof(string));
                dt.Columns.Add("TipoNome", typeof(string));
                dt.Rows.Add("01", "Crédito");
                dt.Rows.Add("02", "Débito");

                cbx.DataSource = dt;
                cbx.ValueMember = "TipoNumero";
                cbx.DisplayMember = "TipoNome";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void PreencherCbxMeses(ComboBox cbx) 
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MesNumero", typeof(string));
                dt.Columns.Add("MesNome", typeof(string));

                dt.Rows.Add("00", "Todos");
                dt.Rows.Add("01", "Janeiro");
                dt.Rows.Add("02", "Fevereiro");
                dt.Rows.Add("03", "Março");
                dt.Rows.Add("04", "Abril");
                dt.Rows.Add("05", "Maio");
                dt.Rows.Add("06", "Junho");
                dt.Rows.Add("07", "Julho");
                dt.Rows.Add("08", "Agosto");
                dt.Rows.Add("09", "Setembro");
                dt.Rows.Add("10", "Outubro");
                dt.Rows.Add("11", "Novembro");
                dt.Rows.Add("12", "Dezembro");

                cbx.DataSource = dt;
                cbx.ValueMember = "MesNumero";
                cbx.DisplayMember = "MesNome";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void PreencherCbxClientesMov(ComboBox cbx)
        {
            cbx.DataSource = PreencherClientes();
            cbx.DisplayMember = "Nome";
            cbx.ValueMember = "Id";
        }
        public void PreencherCbxClientesListagem(ComboBox cbx)
        {
            List<ListaClientes>? listaClientes = PreencherClientes();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Rows.Add(00, "Todos");
            foreach (ListaClientes lc in listaClientes) 
            {
                DataRow row = dt.NewRow();
                row["Id"] = lc.Id;
                row["Nome"] = lc.Nome;
                dt.Rows.Add(row);
            }
            cbx.DataSource = dt;
            cbx.DisplayMember = "Nome";
            cbx.ValueMember = "Id";

        }

        // ================================== PREENCHER DGV ====================================
    
        public List<ListaClientes>? PreencherDgvClientes()
        {
            return PreencherClientes();
        }
        public List<ListaMovimentos>? PreencherDgvMovimentos()
        {
            List<ListaMovimentos>? listaMovimentos = null;

            if (db.Movimentos is not null)
            {
                listaMovimentos = db.Movimentos.Include(m => m.Cliente).Select(m =>
                new ListaMovimentos
                {

                    Id = m.Id,
                    Data = m.Data.ToString("yyyy-MM-dd"),
                    Descricao = m.Descricao,
                    Valor = m.Valor,
                    Tipo = m.Tipo,
                    Marcacao = m.Marcacao,
                    Cliente = m.Cliente.Nome,
                    ClienteId = m.ClienteId,
                    Saldo = GetSaldoCorrente(m.Cliente.Nome, m.Data)

                }).ToList();
            }

            return listaMovimentos;
        }
        public List<ListaMovimentos>? PreencherDgvMarcados()
        {
            List<ListaMovimentos>? listaMovimentos = null;

            if (db.Movimentos is not null)
            {
                listaMovimentos = db.Movimentos.Select(m =>
                new ListaMovimentos
                {
                    Id = m.Id,
                    Data = m.Data.ToString("yyyy-MM-dd"),
                    Descricao = m.Descricao,
                    Valor = m.Valor,
                    Tipo= m.Tipo,
                    Marcacao = m.Marcacao,
                    Cliente = m.Cliente.Nome,
                    ClienteId = m.ClienteId,
                    Saldo = GetSaldoCorrente(m.Cliente.Nome, m.Data)

                }).Where(m => m.Marcacao != null).ToList();
            }

            return listaMovimentos;
        }
        public List<ListaMovimentos>? PreencherDgvLivres()
        {
            List<ListaMovimentos>? listaMovimentos = null;

            if (db.Movimentos is not null)
            {
                listaMovimentos = db.Movimentos.Select(m =>
                new ListaMovimentos
                {
                    Id = m.Id,
                    Data = m.Data.ToString("yyyy-MM-dd"),
                    Descricao = m.Descricao,
                    Valor = m.Valor,
                    Tipo = m.Tipo,
                    Marcacao = m.Marcacao,
                    Cliente = m.Cliente.Nome,
                    ClienteId = m.ClienteId,
                    Saldo = GetSaldoCorrente(m.Cliente.Nome, m.Data)

                }).Where(m => m.Marcacao == null).ToList();
            }

            return listaMovimentos;
        }
        public List<ListaClientes>? PreencherDgvEstadoPendente()
        {
            List<ListaClientes>? listaClientes = null;

            if (db.Clientes is not null)
            {
                listaClientes = db.Clientes.Select(m =>
                new ListaClientes
                {
                    Id = m.Id,
                    NIF = m.NIF,
                    Nome = m.Nome,
                    Estado = m.Estado,
                }).Where(m => m.Estado == null || m.Estado == "").ToList();
            }

            return listaClientes;
        }
        public List<ListaClientes>? PreencherDgvEstadoAtivo()
        {
            List<ListaClientes>? listaClientes = null;

            if (db.Clientes is not null)
            {
                listaClientes = db.Clientes.Select(m =>
                new ListaClientes
                {
                    Id = m.Id,
                    NIF = m.NIF,
                    Nome = m.Nome,
                    Estado = m.Estado,

                }).Where(m => m.Estado != null && m.Estado != "").ToList();
            }

            return listaClientes;
        }
        public List<ListaMovimentos>? PreencherDgvEntradas()
        {
            List<ListaMovimentos>? listaMovimentos = null;

            if (db.Movimentos is not null)
            {
                listaMovimentos = db.Movimentos.Select(m =>
                new ListaMovimentos
                {
                    Id = m.Id,
                    Data = m.Data.ToString("yyyy-MM-dd"),
                    Descricao = m.Descricao,
                    Valor = m.Valor,
                    Tipo = m.Tipo,
                    Marcacao = m.Marcacao,
                    Cliente = m.Cliente.Nome,
                    ClienteId = m.ClienteId,
                    Saldo = GetSaldoCorrente(m.Cliente.Nome, m.Data)

                }).Where(m => m.Tipo == 'C').ToList();
            }

            return listaMovimentos;
        }
        public List<ListaMovimentos>? PreencherDgvSaidas()
        {
            List<ListaMovimentos>? listaMovimentos = null;

            if (db.Movimentos is not null)
            {
                listaMovimentos = db.Movimentos.Select(m =>
                new ListaMovimentos
                {
                    Id = m.Id,
                    Data = m.Data.ToString("yyyy-MM-dd"),
                    Descricao = m.Descricao,
                    Valor = m.Valor,
                    Tipo = m.Tipo,
                    Marcacao = m.Marcacao,
                    Cliente = m.Cliente.Nome,
                    ClienteId = m.ClienteId,
                    Saldo = GetSaldoCorrente(m.Cliente.Nome, m.Data)

                }).Where(m => m.Tipo == 'D').ToList();
            }

            return listaMovimentos;
        }

        // ================================== LISTAGENS ====================================

        public List<ListaMovimentos>? ListarMovimentosClienteSelecionado(string ClienteId)
        {
            List<ListaMovimentos>? listaMovimentos = null;

            if (db.Movimentos is not null)
            {
                listaMovimentos = db.Movimentos.Where(x => x.ClienteId == Convert.ToInt16(ClienteId)).
                Select(m => new ListaMovimentos
                {
                    Id = m.Id,
                    Data = m.Data.ToString("yyyy-MM-dd"),
                    Descricao = m.Descricao,
                    Valor = m.Valor,
                    Tipo = m.Tipo,
                    Marcacao = m.Marcacao,
                    Cliente = m.Cliente.Nome,
                    ClienteId = m.ClienteId,
                    Saldo = GetSaldoCorrente(m.Cliente.Nome, m.Data)

                }).ToList();
            }

            return listaMovimentos;
        }
        public List<ListaMovimentos>? ListarMovimentosClienteMesPeriodo(string ClienteId, string? mesNumero, SelectionRange? periodoTempo, int mesPeriodo)
        {
            // mesPeriodo = 1 : MES
            // mesPeriodo = 2 : PERIODO

            List<ListaMovimentos>? listarMovimentos = null;

            if (db.Movimentos is not null && mesPeriodo == 1 && mesNumero is not null)
            {
                listarMovimentos = db.Movimentos.Where(x => x.ClienteId == Convert.ToInt16(ClienteId) && x.Data.Month == Convert.ToInt16(mesNumero)).
                Select(m => new ListaMovimentos
                {
                    Id = m.Id,
                    Data = m.Data.ToString("yyyy-MM-dd"),
                    Descricao = m.Descricao,
                    Valor = m.Valor,
                    Tipo = m.Tipo,
                    Marcacao = m.Marcacao,
                    Cliente = m.Cliente.Nome,
                    ClienteId = m.ClienteId,
                    Saldo = GetSaldoCorrente(m.Cliente.Nome, m.Data)
                }).ToList();
            }
            else if (db.Movimentos is not null && mesPeriodo == 2 && periodoTempo is not null)
            {
                DateTime dataInicio = periodoTempo.Start;
                DateTime dataFinal = periodoTempo.End;
                listarMovimentos = db.Movimentos.Where(x => x.ClienteId == Convert.ToInt16(ClienteId) && x.Data.Date >= dataInicio && x.Data.Date <= dataFinal)
                .Select(m => new ListaMovimentos
                {
                    Id = m.Id,
                    Data = m.Data.ToString("yyyy-MM-dd"),
                    Descricao = m.Descricao,
                    Valor = m.Valor,
                    Tipo = m.Tipo,
                    Marcacao = m.Marcacao,
                    Cliente = m.Cliente.Nome,
                    ClienteId = m.ClienteId,
                    Saldo = GetSaldoCorrente(m.Cliente.Nome, m.Data)

                }).ToList();
            }

            return listarMovimentos;
        }
        private List<ListaClientes>? PreencherClientes()
        {
            List<ListaClientes>? listaClientes = null;

            if (db.Clientes is not null)
            {
                listaClientes = db.Clientes.Select(m => new ListaClientes
                {
                    Id = m.Id,
                    NIF = m.NIF,
                    Nome = m.Nome,
                    Estado = m.Estado,

                }).ToList();
            }

            return listaClientes;
        }
    }
}
