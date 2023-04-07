using AutoMapper;
using BlockCypher.Application.DTOs;
using BlockCypher.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Application.Mapper
{
    public class BlockchainInfoMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BlockchainInfoResponse, Blockchain>();
                cfg.CreateMap<Blockchain, BlockchainInfoResponse>();
            });

            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}