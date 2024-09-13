﻿using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
        public TimeSpan DataUltimoMovimento { get; set; }

        public Estoque()
        {
            
        }
        public Estoque(decimal quantidade, TimeSpan dataUltimoMovimento)
        {
            Quantidade = quantidade;
            DataUltimoMovimento = dataUltimoMovimento;
        }
        public Estoque(Produto produto, decimal quantidade, TimeSpan dataUltimoMovimento)
        {
            Produto = produto;
            Quantidade = quantidade;
            DataUltimoMovimento = dataUltimoMovimento;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert estoques (quantidade, data_ultimo_movimento) values ('{Quantidade}','{DataUltimoMovimento}')";
            cmd.ExecuteNonQuery();
        }

        public static List<Estoque> ObterLista()
        {
            List<Estoque> lista = new List<Estoque>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from estoques";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        Produto.ObterPorId(dr.GetInt32(0)),
                        dr.GetDecimal(1),
                        dr.GetTimeSpan(2)
                        )
                    );
            }
            return lista;
        }

        public void Atualizar()
        {

        }
    }
}
