using Dapper;
using Npgsql;
using SchoolFinder.Domain.Buscador.Interfaces;
using SchoolFinder.Domain.Common.Entities;
using SchoolFinder.Domain.Common.Models;
using SchoolFinder.Domain.Common.Models.AppSettings;
using SchoolFinder.Domain.Common.ValueObjects;
using SchoolFinder.Infra.Data.Dapper.Common.Ordenacao;

namespace SchoolFinder.Infra.Data.Dapper.Buscador.Repositories
{
    public class BuscadorRepository : IBuscadorRepository
    {
        private readonly AppSettings _appSettings;

        public BuscadorRepository(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public async Task<IEnumerable<Bairro>> ConsultarBairrosAsync(Dictionary<string, object?> filters, CancellationToken cancellationToken)
        {
            using (var connection = new NpgsqlConnection(_appSettings.ConnectionStringsSettings.SchoolFinderDbConnection))
            {
                await connection.OpenAsync(cancellationToken);

                var sqlCommand = @$"SELECT id AS Id, cidade_id AS CidadeId, nome AS Nome FROM bairros b WHERE 1 = 1";

                if (filters.ContainsKey("Id") && !string.IsNullOrWhiteSpace(filters["Id"]?.ToString()))
                    sqlCommand += $" AND b.id = {filters["Id"]}";

                if (filters.ContainsKey("CidadeId") && !string.IsNullOrWhiteSpace(filters["CidadeId"]?.ToString()))
                    sqlCommand += $" AND b.cidade_id = {filters["CidadeId"]}";

                if (filters.ContainsKey("Nome") && !string.IsNullOrWhiteSpace(filters["Nome"]?.ToString()))
                    sqlCommand += $" AND b.nome LIKE '%{filters["Nome"]}%'";

                sqlCommand += " ORDER BY nome;";

                var bairros = await connection.QueryAsync<Bairro>(sqlCommand);

                await connection.CloseAsync();

                return bairros;
            }
        }

        public async Task<IEnumerable<Cidade>> ConsultarCidadesAsync(Dictionary<string, object?> filters, CancellationToken cancellationToken)
        {
            using (var connection = new NpgsqlConnection(_appSettings.ConnectionStringsSettings.SchoolFinderDbConnection))
            {
                await connection.OpenAsync(cancellationToken);

                var sqlCommand = @$"SELECT c.id AS Id, c.estado_id AS EstadoId, e.uf AS UF, c.nome_cidade AS Nome 
                                    FROM cidades c
                                    INNER JOIN estados e ON c.estado_id = e.id
                                    WHERE 1 = 1";

                if (filters.ContainsKey("Id") && !string.IsNullOrWhiteSpace(filters["Id"]?.ToString()))
                    sqlCommand += $" AND c.id = {filters["Id"]}";

                if (filters.ContainsKey("EstadoId") && !string.IsNullOrWhiteSpace(filters["EstadoId"]?.ToString()))
                    sqlCommand += $" AND c.estado_id = {filters["EstadoId"]}";

                if (filters.ContainsKey("Nome") && !string.IsNullOrWhiteSpace(filters["Nome"]?.ToString()))
                    sqlCommand += $" AND c.nome LIKE '%{filters["Nome"]}%'";

                sqlCommand += " ORDER BY c.nome_cidade;";

                var cidades = await connection.QueryAsync<Cidade>(sqlCommand);

                await connection.CloseAsync();

                return cidades;
            }
        }

        public async Task<ListaPaginadaOutput<Escola>> ConsultarEscolasPaginadoAsync(Dictionary<string, object?> filters, int pageNumber, int pageSize, string sort, CancellationToken cancellationToken)
        {
            using (var connection = new NpgsqlConnection(_appSettings.ConnectionStringsSettings.SchoolFinderDbConnection))
            {
                await connection.OpenAsync(cancellationToken);

                var sqlCommand = @$"SELECT  e.id AS Id,
                                            e.nome AS Nome,
                                            e.cnpj AS Cnpj,
                                            e.tipo_escola_id AS TipoEscolaId,
                                            te.descricao AS TipoEscola,
                                            e.tipo_localizacao_id AS TipoLocalizacaoId,
                                            tl.descricao AS TipoLocalizacao,
                                            e.status_escola_id AS StatusId,
                                            se.descricao AS Status,
                                            ee.endereco AS Endereco,
                                            ee.endereco_numero AS EnderecoNumero,
                                            ee.complemento AS Complemento,
                                            ee.bairro AS Bairro,
                                            ee.cep AS Cep,
                                            ee.cidade_id AS CidadeId,
                                            c.nome_cidade AS Cidade,
                                            ee.estado_id AS EstadoId,
                                            uf.uf AS Estado,
                                            ee.regiao_id AS RegiaoId,
                                            r.nome_regiao AS Regiao,
                                            ec.telefone AS Telefone,
                                            ec.email AS Email
                                FROM escolas e
                                INNER JOIN tipos_escolas te
                                    ON e.tipo_escola_id = te.id
                                INNER JOIN tipos_localizacao tl
                                    ON e.tipo_localizacao_id = tl.id
                                INNER JOIN status_escolas se
                                    ON e.status_escola_id = se.id
                                LEFT JOIN escolas_enderecos ee
                                    ON e.id = ee.escola_id
                                LEFT JOIN cidades c
                                    on ee.cidade_id = c.id
                                LEFT JOIN estados uf
                                    on ee.estado_id = uf.id
                                LEFT JOIN regioes r
                                    on ee.regiao_id = r.id
                                LEFT JOIN escolas_contatos ec
                                    ON e.id = ec.escola_id
                                WHERE e.status_escola_id IN (1,2)";

                if (filters.ContainsKey("Nome") && !string.IsNullOrWhiteSpace(filters["Nome"]?.ToString()))
                    sqlCommand += $" AND e.nome LIKE '%{filters["Nome"]}%'";

                if (filters.ContainsKey("Cnpj") && !string.IsNullOrWhiteSpace(filters["Cnpj"]?.ToString()))
                    sqlCommand += $" AND e.cmpj = '{filters["Cnpj"]}'";

                if (filters.ContainsKey("Endereco") && !string.IsNullOrWhiteSpace(filters["Endereco"]?.ToString()))
                    sqlCommand += $" AND ee.endereco LIKE '%{filters["Endereco"]}%'";

                if (filters.ContainsKey("BairroId") && !string.IsNullOrWhiteSpace(filters["BairroId"]?.ToString()))
                    sqlCommand += $" AND ee.bairro_id  = {filters["BairroId"]}";

                if (filters.ContainsKey("Cep") && !string.IsNullOrWhiteSpace(filters["Cep"]?.ToString()))
                    sqlCommand += $" AND ee.cep = '{filters["Cep"]}'";

                if (filters.ContainsKey("CidadeId") && !string.IsNullOrWhiteSpace(filters["CidadeId"]?.ToString()))
                    sqlCommand += $" AND ee.cidade_id = {filters["CidadeId"]}";

                sqlCommand += " ORDER BY e.nome;";

                var escolas = await connection.QueryAsync<Escola, EnderecoEscola, ContatoEscola, Escola>(
                    sqlCommand,
                    (escola, endereco, contato) =>
                    {
                        escola.SetEndereco(endereco);
                        escola.SetContato(contato);
                        return escola;
                    },
                    splitOn: "Endereco, Telefone"
                );

                await connection.CloseAsync();

                var escolasOrdenadas = OrdenadorHelper.AplicarOrdenacao(escolas, sort)!;

                return new ListaPaginadaOutput<Escola>
                (
                    totalRegistros: escolasOrdenadas.Count(),
                    items: escolasOrdenadas
                        .Skip((pageNumber - 1) * pageSize)
                        .Take(pageSize)
                );
            }
        }

        public async Task<Escola> ConsultarEscolasPeloIdAsync(long id, CancellationToken cancellationToken)
        {
            using (var connection = new NpgsqlConnection(_appSettings.ConnectionStringsSettings.SchoolFinderDbConnection))
            {
                await connection.OpenAsync(cancellationToken);

                var maxAnoCenso = await ConsultarUltimoAnoCenso(cancellationToken);

                var sqlCommand = @$"select *
                                from escola_completa_view e
                                where e.id = {id}
                                  and e.AnoCenso = {maxAnoCenso};";

                var escola = (await connection.QueryAsync<Escola, EnderecoEscola, ContatoEscola, CensoEscola, Escola>(
                    sqlCommand,
                    (escola, endereco, contato, censo) =>
                    {
                        escola.SetEndereco(endereco);
                        escola.SetContato(contato);
                        escola.SetDadosCenso(censo);
                        return escola;
                    },
                    splitOn: "Endereco, Telefone, AnoCenso"
                )).First();

                await connection.CloseAsync();

                return escola;
            }
        }

        public async Task<IEnumerable<Estado>> ConsultarEstadosAsync(Dictionary<string, object?> filters, CancellationToken cancellationToken)
        {
            using (var connection = new NpgsqlConnection(_appSettings.ConnectionStringsSettings.SchoolFinderDbConnection))
            {
                await connection.OpenAsync(cancellationToken);

                var sqlCommand = @$"SELECT e.id AS Id, e.regiao_id AS RegiaoId, e.uf || ' - ' || e.nome_estado AS Nome 
                                    FROM estados e
                                    WHERE 1 = 1";

                if (filters.ContainsKey("Id") && !string.IsNullOrWhiteSpace(filters["Id"]?.ToString()))
                    sqlCommand += $" AND e.id = {filters["Id"]}";

                if (filters.ContainsKey("RegiaoId") && !string.IsNullOrWhiteSpace(filters["RegiaoId"]?.ToString()))
                    sqlCommand += $" AND e.regiao_id = {filters["RegiaoId"]}";

                if (filters.ContainsKey("Nome") && !string.IsNullOrWhiteSpace(filters["Nome"]?.ToString()))
                    sqlCommand += $" AND e.nome LIKE '%{filters["Nome"]}%'";

                sqlCommand += " ORDER BY e.uf;";

                var estados = await connection.QueryAsync<Estado>(sqlCommand);

                await connection.CloseAsync();

                return estados;
            }
        }

        public async Task<IEnumerable<Regiao>> ConsultarRegioesAsync(Dictionary<string, object?> filters, CancellationToken cancellationToken)
        {
            using (var connection = new NpgsqlConnection(_appSettings.ConnectionStringsSettings.SchoolFinderDbConnection))
            {
                await connection.OpenAsync(cancellationToken);

                var sqlCommand = @$"SELECT r.id AS Id, r.nome_regiao AS Nome 
                                    FROM regioes r
                                    WHERE 1 = 1";

                if (filters.ContainsKey("Id") && !string.IsNullOrWhiteSpace(filters["Id"]?.ToString()))
                    sqlCommand += $" AND r.id = {filters["Id"]}";

                if (filters.ContainsKey("Nome") && !string.IsNullOrWhiteSpace(filters["Nome"]?.ToString()))
                    sqlCommand += $" AND r.nome LIKE '%{filters["Nome"]}%'";

                sqlCommand += " ORDER BY r.nome_regiao;";
                var regioes = await connection.QueryAsync<Regiao>(sqlCommand);

                await connection.CloseAsync();

                return regioes;
            }
        }

        private async Task<int> ConsultarUltimoAnoCenso(CancellationToken cancellationToken)
        {
            using (var connection = new NpgsqlConnection(_appSettings.ConnectionStringsSettings.SchoolFinderDbConnection))
            {
                await connection.OpenAsync(cancellationToken);

                var sqlAnoCensoCommand = $"select max(ano_censo) from escolas_dados_censo";

                var maxAnoCenso = await connection.QuerySingleAsync<int>(sqlAnoCensoCommand);

                await connection.CloseAsync();

                return maxAnoCenso;
            }
        }
    }
}
