﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfmvvmcrud.ViewModel;

namespace wpfmvvmcrud.Model
{
    public class Funcionario : BaseNotifyPropertyChanged, ICloneable
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetField(ref _id, value); }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetField(ref _nome, value); }
        }

        private string _sobrenome;
        public string Sobrenome
        {
            get { return _sobrenome; }
            set { SetField(ref _sobrenome, value); }
        }

        private DateTime _dataNascimento;
        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { SetField(ref _dataNascimento, value); }
        }

        private Sexo _sexo;
        public Sexo Sexo
        {
            get { return _sexo; }
            set { SetField(ref _sexo, value); }
        }

        private EstadoCivil _estadoCivil;
        public EstadoCivil EstadoCivil
        {
            get { return _estadoCivil; }
            set { _estadoCivil = value; }
        }

        private DateTime _dataAdmissao;
        public DateTime DataAdmissao
        {
            get { return _dataAdmissao; }
            set { SetField(ref _dataAdmissao, value); }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
