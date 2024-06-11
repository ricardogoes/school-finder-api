using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolFinder.Api.Helpers;
using SchoolFinder.Api.Models;
using SchoolFinder.Application.Buscador.Escolas;
using SchoolFinder.Application.Buscador.Escolas.ConsultarEscolaPeloId;
using SchoolFinder.Application.Buscador.Escolas.ConsultarEscolas;
using SchoolFinder.Application.Buscador.Localizacao.ConsultarBairros;
using SchoolFinder.Application.Buscador.Localizacao.ConsultarCidades;
using SchoolFinder.Application.Buscador.Localizacao.ConsultarEstados;
using SchoolFinder.Application.Buscador.Localizacao.ConsultarRegioes;
using SchoolFinder.Domain.Common.Entities;

namespace SchoolFinder.Api.Controllers.Buscador.v1
{
    [ApiController]
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/buscador")]
    public class BuscadorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BuscadorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("escolas")]
        [ProducesResponseType(typeof(EscolaOutput), StatusCodes.Status200OK)]
        public async Task<IActionResult> ConsultarEscolas(
            CancellationToken cancellationToken,
            [FromQuery(Name = "numero_pagina")] int? numero_pagina = null,
            [FromQuery(Name = "quantidade_registros")] int? quantidade_registros = null,
            [FromQuery(Name = "ordenacao")] string? ordenacao = null,
            [FromQuery(Name = "nome")] string? nome = null,
            [FromQuery(Name = "cnpj")] string? cnpj = null,
            [FromQuery(Name = "endereco")] string? endereco = null,
            [FromQuery(Name = "cep")] string? cep = null,
            [FromQuery(Name = "bairro_id")] long? bairro_id = null,
            [FromQuery(Name = "cidade_id")] long? cidadeId = null)
        {
            var input = new ConsultarEscolasInput(
                numeroPagina: numero_pagina ?? 1,
                quantidadeRegistros: quantidade_registros ?? 5,
                ordenacao: Utils.GetSortParam(ordenacao),
                nome: nome,
                cnpj: cnpj,
                endereco: endereco,
                bairro_id: bairro_id,
                cep: cep,
                cidadeId: cidadeId);

            var escolas = await _mediator.Send(input, cancellationToken);

            return Ok(new PaginatedApiResponse<EscolaOutput>(escolas));
        }

        [HttpGet("escolas/{id:long}")]
        [ProducesResponseType(typeof(EscolaDetalhadaOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ConsultarEscolaPeloId([FromRoute] long id, CancellationToken cancellationToken)
        {
            var escola = await _mediator.Send(new ConsultarEscolaPeloIdInput { Id = id }, cancellationToken);

            return Ok(escola);
        }

        [HttpGet("regioes")]
        [ProducesResponseType(typeof(Regiao), StatusCodes.Status200OK)]
        public async Task<IActionResult> ConsultarRegioes(
             CancellationToken cancellationToken,
             [FromQuery(Name = "id")] int? id = null,
             [FromQuery(Name = "nome")] string? nome = null)
        {
            var input = new ConsultarRegioesInput(id, nome);

            var regioes = await _mediator.Send(input, cancellationToken);

            return Ok(regioes);
        }

        [HttpGet("regioes/{id:int}/estados")]
        [ProducesResponseType(typeof(Estado), StatusCodes.Status200OK)]
        public async Task<IActionResult> ConsultarEstadosPorRegiao(int id, CancellationToken cancellationToken)
        {
            var input = new ConsultarEstadosInput(id: null, regiaoId: id, nome: null);
            var estados = await _mediator.Send(input, cancellationToken);

            return Ok(estados);
        }

        [HttpGet("estados")]
        [ProducesResponseType(typeof(Cidade), StatusCodes.Status200OK)]
        public async Task<IActionResult> ConsultaEstadoe(CancellationToken cancellationToken)
        {
            var input = new ConsultarEstadosInput(id: null, regiaoId: null, nome: null);
            var estados = await _mediator.Send(input, cancellationToken);

            return Ok(estados);
        }

        [HttpGet("estados/{id:int}/cidades")]
        [ProducesResponseType(typeof(Cidade), StatusCodes.Status200OK)]
        public async Task<IActionResult> ConsultarCidadesPorEstado(int id, CancellationToken cancellationToken)
        {
            var input = new ConsultarCidadesInput(id: null, estadoId: id, nome: null);
            var cidades = await _mediator.Send(input, cancellationToken);

            return Ok(cidades);
        }

        [HttpGet("cidades/{id:long}/bairros")]
        [ProducesResponseType(typeof(Bairro), StatusCodes.Status200OK)]
        public async Task<IActionResult> ConsultarBairrosPorCidade(int id, CancellationToken cancellationToken)
        {
            var input = new ConsultarBairrosInput(id: null, cidadeId: id, nome: null);
            var bairros = await _mediator.Send(input, cancellationToken);

            return Ok(bairros);
        }
    }
}
