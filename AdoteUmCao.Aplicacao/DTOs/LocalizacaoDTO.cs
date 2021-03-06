﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoteUmCao.Infraestrutura.Entidades;

namespace AdoteUmCao.Aplicacao.DTOs
{
    public class LocalizacaoDTO
    {
        public LocalizacaoDTO()
        {

        }

        public LocalizacaoDTO(Localizacao localizacao)
        {
            this.Id = localizacao.Id;
            this.DscEndereco = localizacao.DscEndereco;
            this.Latitude = (double)localizacao.Latitude;
            this.Longitude = (double)localizacao.Longitude;
            this.GeoLocalizacao = localizacao.GeoLocalizacao;
        }

        public int Id { get; set; }
        public string DscEndereco { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string GeoLocalizacao { get; set; }
    }
}
