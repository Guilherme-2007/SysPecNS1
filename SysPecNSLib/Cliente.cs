﻿using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Cliente
    {
        //nome, cpf, telefone, email, data_nasc, data_cad, ativo
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int? Cpf { get; set; }
        public int? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime? Data_Nasc { get; set; }

        //public DateOnly(int year, int month, int day) Data_Nasc {get; set;}

        public DateTime Data_Cad { get; set; }
        public bool Ativo { get; set; }

        public DateTime? AtivoDate { get; set;}



        public Cliente()
        {
            //Construtor vazio
        }

        public Cliente(int id, string nome, int cpf, int telefone, string email, DateTime data_Nasc, DateTime data_Cad, bool ativo )
        {
            //Construtor com todos os campos
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = data_Nasc;
            Data_Cad = data_Cad;
            Ativo = ativo;

        }

        public Cliente(string nome, int cpf, int telefone, string email, DateTime data_Nasc, DateTime data_Cad, bool ativo)
        {
            //Construtor sem o ID, para inserção
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = data_Nasc;
            Data_Cad = data_Cad;
            Ativo = ativo;

        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", Data_Nasc);
            
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }


        }

        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                cliente = new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetInt32(2),
                   dr.GetInt32(3),
                   dr.GetString(4),
                   dr.GetDateTime(5),
                   dr.GetDateTime(6),//data_Cad
                   dr.GetBoolean(7)
                   );

            }
            return cliente;
        }

        public static List<Cliente> ObterLista(string? nome = "") 
        {
            List<Cliente> lista = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;
            if(nome == "")
            {
                comandosSQL.CommandText = "select * from clientes order by nome";
            }
            else
            {
                comandosSQL.CommandText = $"select * from clientes where nome like '%{nome}%' order by nome";
            }

            var dr = comandosSQL.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetInt32(2),
                   dr.GetInt32(3),
                   dr.GetString(4),
                   dr.GetDateTime(5),
                   dr.GetDateTime(6),//data_Cad
                   dr.GetBoolean(7)
                    )
                    
               );
            }
            return lista;

        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", Data_Nasc);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            
        }

        public static void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set ativo = 1 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }



    }
}
