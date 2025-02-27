﻿using ProjetoDDD.Application;
using ProjetoDDD.Application.Interfaces;
using ProjetoDDD.Domain.Interfaces.Repository;
using ProjetoDDD.Domain.Interfaces.Service;
using ProjetoDDD.Domain.Services;
using ProjetoDDD.Infra.Data.Context;
using ProjetoDDD.Infra.Data.Interfaces;
using ProjetoDDD.Infra.Data.Repository;
using ProjetoDDD.Infra.Data.UoW;
using SimpleInjector;

namespace ProjetoDDD.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            // App
            container.RegisterPerWebRequest<IClienteAppService, ClienteAppService>();

            // Domain
            container.RegisterPerWebRequest<IContaService, ContaService>();
            container.RegisterPerWebRequest<IPerfilService, PerfilService>();
            container.RegisterPerWebRequest<IComentarioService, ComentarioService>();
            container.RegisterPerWebRequest<IPublicacaoService, PublicacaoService>();

            // Infra Dados
            container.RegisterPerWebRequest<IContaRepository, ContaRepository>();
            container.RegisterPerWebRequest<IPerfilRepository, PerfilRepository>();
            container.RegisterPerWebRequest<IPublicacaoRepository, PublicacaoRepository>();
            container.RegisterPerWebRequest<IComentarioRepository, ComentarioRepository>();

            container.RegisterPerWebRequest<IUnitOfWork, UnitOfWork>();
            container.RegisterPerWebRequest<ProjetoDDDContext>();

            //container.Register(typeof (IRepository<>), typeof (Repository<>));
        }
    }
}