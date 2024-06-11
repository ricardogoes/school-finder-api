namespace SchoolFinder.Domain.Common.ValueObjects
{
    public class CensoEscola
    {
        public int? AnoCenso { get; private set; }
        public int? TipoEscolaPrivadaId { get; private set; }
        public string? TipoEscolaPrivada { get; private set; }
        public bool? TemVinculoSecretariaEducacao { get; private set; }
        public bool? TemVinculoSegurancaPublica { get; private set; }
        public bool? TemVinculoSecretariaSaude { get; private set; }
        public bool? TemVinculoOutroOrgao { get; private set; }
        public bool? TemParceriaPoderPublico { get; private set; }
        public int? TipoParceriaPoderPublicoId { get; private set; }
        public string? TipoParceriaPoderPublico { get; private set; }
        public int? TipoRegulamentacaoId { get; private set; }
        public string? TipoRegulamentacao { get; private set; }
        public int? TipoResponsavelRegulamentecaoId { get; private set; }
        public string? TipoResponsavelRegulamentacao { get; private set; }
        public int? TipoOcupacaoId { get; private set; }
        public string? TipoOcupacao { get; private set; }
        public bool? TemAguaPotavel { get; private set; }
        public bool? TemAbastecimentoAgua { get; private set; }
        public bool? TemAbastecimentoPocoArtesiano { get; private set; }
        public bool? TemAbastecimentoCisterna { get; private set; }
        public bool? TemAbastecimentoRio { get; private set; }
        public bool? AbastecimentoAguaInexistente { get; private set; }
        public bool? TemEnergiaRedePublica { get; private set; }
        public bool? TemEnergiaGeradorFossil { get; private set; }
        public bool? TemEnergiaRenovavel { get; private set; }
        public bool? EnergiaInexistente { get; private set; }
        public bool? TemEsgotoRedePublica { get; private set; }
        public bool? TemEsgotoFossaSeptica { get; private set; }
        public bool? TemEsgotoFossaComum { get; private set; }
        public bool? TemEsgotoFossa { get; private set; }
        public bool? EsgotoInexistente { get; private set; }
        public bool? TemLixoColetaServico { get; private set; }
        public bool? TemLixoQueima { get; private set; }
        public bool? TemLixoEnterra { get; private set; }
        public bool? TemLixoDestinoFinalPublico { get; private set; }
        public bool? TemLixoDescartaOutraArea { get; private set; }
        public bool? TemTratamentoLixoSeparacao { get; private set; }
        public bool? TemTratamentoLixoReutilizacao { get; private set; }
        public bool? TemTratamentoLixoReciclagem { get; private set; }
        public bool? TratamentoLixoInexistente { get; private set; }
        public bool? TemAlmoxarifado { get; private set; }
        public bool? TemAreaVerde { get; private set; }
        public bool? TemAuditorio { get; private set; }
        public bool? TemBanheiro { get; private set; }
        public bool? TemBanheiroEducacaoInfantil { get; private set; }
        public bool? TemBanheiroDeficientes { get; private set; }
        public bool? TemBanheiroFuncionarios { get; private set; }
        public bool? TemBanheiroChuveiro { get; private set; }
        public bool? TemBiblioteca { get; private set; }
        public bool? TemBibliotecaSalaLeitura { get; private set; }
        public bool? TemCozinha { get; private set; }
        public bool? TemDespensa { get; private set; }
        public bool? TemDormitorioAluno { get; private set; }
        public bool? TemDormitorioProfessor { get; private set; }
        public bool? TemLaboratorioCiencias { get; private set; }
        public bool? TemLaboratorioInformatica { get; private set; }
        public bool? TemLaboratorioEducacaoProfissional { get; private set; }
        public bool? TemPatioCoberto { get; private set; }
        public bool? TemPatioDescoberto { get; private set; }
        public bool? TemParqueInfantil { get; private set; }
        public bool? TemPiscina { get; private set; }
        public bool? TemQuadraEsportes { get; private set; }
        public bool? TemQuadraEsportesCoberta { get; private set; }
        public bool? TemQuadraEsportesDescoberta { get; private set; }
        public bool? TemRefeitorio { get; private set; }
        public bool? TemSalaAtelieArtes { get; private set; }
        public bool? TemSalaMusicalCoral { get; private set; }
        public bool? TemSalaEstudioDanca { get; private set; }
        public bool? TemSalaOficinaEducacaoProfissional { get; private set; }
        public bool? TemSalaDiretoria { get; private set; }
        public bool? TemSalaLeitura { get; private set; }
        public bool? TemSalaProfessor { get; private set; }
        public bool? TemSalaRepousoAluno { get; private set; }
        public bool? TemSecretaria { get; private set; }
        public bool? TemSalaAtendimentoEspecial { get; private set; }
        public bool? TemTerreirao { get; private set; }
        public bool? TemViveiro { get; private set; }
        public bool? TemAcessibilidadeCorrimao { get; private set; }
        public bool? TemAcessibilidadeElevador { get; private set; }
        public bool? TemAcessibilidadePisosTateis { get; private set; }
        public bool? TemAcessibilidadeVaosLivres { get; private set; }
        public bool? TemAcessibilidadeRampas { get; private set; }
        public bool? TemAcessibilidadeSinalSonoro { get; private set; }
        public bool? TemAcessibilidadeSinalVisual { get; private set; }
        public bool? TemAcessibilidadeSinalTatil { get; private set; }
        public bool? AcessibilidadeInexistente { get; private set; }
        public int? QtdSalas { get; private set; }
        public int? QtdSalasClimatizadas { get; private set; }
        public int? QtdSalasAcessiveis { get; private set; }
        public bool? TemEquipamentoParabolica { get; private set; }
        public bool? TemEquipamentoComputador { get; private set; }
        public bool? TemEquipamentoCopiadora { get; private set; }
        public bool? TemEquipamentoImpressora { get; private set; }
        public bool? TemEquipamentoImpressoraMultiFuncional { get; private set; }
        public bool? TemEquipamentoScanner { get; private set; }
        public bool? TemEquipamentoDvd { get; private set; }
        public int? QtdEquipamentoDvd { get; private set; }
        public bool? TemEquipamentoSom { get; private set; }
        public int? QtEquipamentoSom { get; private set; }
        public bool? TemEquipamentoTelevisao { get; private set; }
        public int? QtdEquipamentoTelevisao { get; private set; }
        public bool? TemEquipamentoLousaDigital { get; private set; }
        public int? QtdEquipamentoLousaDigital { get; private set; }
        public bool? TemEquipamentoMultimidia { get; private set; }
        public int? QtdEquipamentoMultimidia { get; private set; }
        public bool? TemDesktopAluno { get; private set; }
        public int? QtdDesktopAluno { get; private set; }
        public bool? TemComputadorPessoalAluno { get; private set; }
        public int? QtdComputadorPessoalAluno { get; private set; }
        public bool? TemTabletAluno { get; private set; }
        public int? QtdTabletAluno { get; private set; }
        public bool? TemInternet { get; private set; }
        public bool? TemInternetAlunos { get; private set; }
        public bool? TemInternetAdministrativo { get; private set; }
        public bool? TemInternetAprendizagem { get; private set; }
        public bool? TemInternetComunidade { get; private set; }
        public bool? TemInternetComputador { get; private set; }
        public bool? TemInternetDispositivosPessoais { get; private set; }
        public int? TipoRedeLocalId { get; private set; }
        public string? TipoRedeLocal { get; private set; }
        public bool? TemInternetBandaLarga { get; private set; }        
        public bool? TemProfissionaisAdministrativos { get; private set; }
        public int? QtdProfissionaisAdministrativos { get; private set; }
        public bool? TemProfissionaisServicosGerais { get; private set; }
        public int? QtdProfissionaisServicosGerais { get; private set; }
        public bool? TemProfissionaiBibliotecario { get; private set; }
        public int? QtdProfissionaiBibliotecario { get; private set; }
        public bool? TemProfissionaisSaude { get; private set; }
        public int? QtdProfissionaisSaude { get; private set; }
        public bool? TemProfissionaisCoordenador { get; private set; }
        public int? QtdProfissionaisCoordenador { get; private set; }
        public bool? TemProfissionaisFonaudiologo { get; private set; }
        public int? QtdProfissionaisFonaudiologo { get; private set; }
        public bool? TemProfissionaisNutricionista { get; private set; }
        public int? QtdProfissionaisNutricionista { get; private set; }
        public bool? TemProfissionaisPsicologo { get; private set; }
        public int? QtdProfissionaisPsicologo { get; private set; }
        public bool? TemProfissionaisAlimentacao { get; private set; }
        public int? QtdProfissionaisAlimentacao { get; private set; }
        public bool? TemProfissionaisPedagogia { get; private set; }
        public int? QtdProfissionaisPedagogia { get; private set; }
        public bool? TemProfissionaisSecretaria { get; private set; }
        public int? QtdProfissionaisSecretaria { get; private set; }
        public bool? TemProfissionaisSeguranca { get; private set; }
        public int? QtdProfissionaisSeguranca { get; private set; }
        public bool? TemProfissionaisMonitor { get; private set; }
        public int? QtdProfissionaisMonitor { get; private set; }
        public bool? TemProfissionaisGestao { get; private set; }
        public int? QtdProfissionaisGestao { get; private set; }
        public bool? TemProfissionaisAssistenteSocial { get; private set; }
        public int? QtdProfissionaisAssistenteSocial { get; private set; }
        public bool? TemAlimentacao { get; private set; }
        public bool? TemSeriesAnuais { get; private set; }
        public bool? TemPeriodosSemestrais { get; private set; }
        public bool? TemCiclosEnsinoFundamental { get; private set; }
        public bool? TemGruposNaoSeriados { get; private set; }
        public bool? TemModulos { get; private set; }
        public bool? TemAlternanciaRegularPeriodosEstudo { get; private set; }
        public bool? TemAcervoMultimidia { get; private set; }
        public bool? TemBrinquedosEducacaoInfantil { get; private set; }
        public bool? TemConjuntosMateriaisCientificos { get; private set; }
        public bool? TemEquipamentoParaAmplificacaoDifusaoSom { get; private set; }
        public bool? TemInstrumentosMusicais { get; private set; }
        public bool? TemJogosEducativos { get; private set; }
        public bool? TemMateriaisAtividadesCulturaisArtisticas { get; private set; }
        public bool? TemMateriaisEducacaoProfissional { get; private set; }
        public bool? TemMateriaisPraticaDesportivaRecreacao { get; private set; }
        public bool? TemMateriaisEducacaoIndigena { get; private set; }
        public bool? TemMateriaisEducacaoEtnicoRacial { get; private set; }
        public bool? TemMateriaisEducacaoCampo { get; private set; }
        public bool? TemProgramaBrasilAlfabetizado { get; private set; }
        public bool? EscolaAbreFinalSemanaComunidade { get; private set; }
        public bool? TemExameSolicitacaoNovosAlunos { get; private set; }
        public bool? TemReservaVagasRenda { get; private set; }
        public bool? TemReservaVagasEsscolaPublica { get; private set; }
        public bool? TemReservaVagasPcd { get; private set; }
        public bool? ReservaInexistente { get; private set; }
        public bool? TemRedesSociais { get; private set; }
        public bool? TemEspacoIntegracaoComunidade { get; private set; }
        public bool? TemOrgaoAssociacaoPais { get; private set; }
        public bool? TemOrgaoAssociacaoPaisEMestres { get; private set; }
        public bool? TemOrgaoConselhoEscolar { get; private set; }
        public bool? TemOrgaoGremilEstudantil { get; private set; }
        public bool? TemOutrosOrgaos { get; private set; }
        public bool? OrgaosInexistentes { get; private set; }
        public int? TipoPropostaPedagogicaId { get; private set; }
        public string? TipoPropostaPedagogica { get; private set; }
        public int? TipoAtendimentoEducacionalEspecializadoId { get; private set; }
        public string? TipoAtendimentoEducacionalEspecializado { get; private set; }
        public int? TipoAtividadeComplementarId { get; private set; }
        public string? TipoAtividadeComplementar { get; private set; }
        public bool? TemEscolarizacao { get; private set; }
        public bool? TemMediacaoPresencial { get; private set; }
        public bool? TemMediacaoSemiPresencial { get; private set; }
        public bool? TemMediacaoEad { get; private set; }
        public bool? TemEducacaoRegular { get; private set; }
        public bool? TemPeriodoDiurno { get; private set; }
        public bool? TemPeriodoNoturno { get; private set; }
        public bool? TemPeriodoEad { get; private set; }
        public bool? TemEducacaoBasica { get; private set; }
        public bool? TemEducacaoInfantil { get; private set; }
        public bool? TemEducacaoInfantilCreche { get; private set; }
        public bool? TemEducacaoInfantilPre { get; private set; }
        public bool? TemEnsinoFundamental { get; private set; }
        public bool? TemEnsinoFundamentalAnosIniciais { get; private set; }
        public bool? TemEnsinoFundamentalAnosFinais { get; private set; }
        public bool? TemEnsinoMedio { get; private set; }
        public bool? TemEnsinoProfissionalizante { get; private set; }
        public bool? TemEnsinoProfissionalizanteTecnico { get; private set; }
        public bool? TemEducacaoJovensAdultos { get; private set; }
        public bool? TemEducacaoJovensAdultosFundamental { get; private set; }
        public bool? TemEducacaoJovensAdultosMedio { get; private set; }
        public bool? TemEducacaoEspecial { get; private set; }
        public bool? TemEducacaoEspecialClasseComum { get; private set; }
        public bool? TemEducacaoEspecialClasseExclusiva { get; private set; }

        public CensoEscola()
        {            
        }

        public CensoEscola(int? anoCenso, int? tipoEscolaPrivadaId, string? tipoEscolaPrivada, bool? temVinculoSecretariaEducacao, bool? temVinculoSegurancaPublica, bool? temVinculoSecretariaSaude, bool? temVinculoOutroOrgao, bool? temParceriaPoderPublico, int? tipoParceriaPoderPublicoId, string? tipoParceriaPoderPublico, int? tipoRegulamentacaoId, string? tipoRegulamentacao, int? tipoResponsavelRegulamentecaoId, string? tipoResponsavelRegulamentacao, int? tipoOcupacaoId, string? tipoOcupacao, bool? temAguaPotavel, bool? temAbastecimentoAgua, bool? temAbastecimentoPocoArtesiano, bool? temAbastecimentoCisterna, bool? temAbastecimentoRio, bool? abastecimentoAguaInexistente, bool? temEnergiaRedePublica, bool? temEnergiaGeradorFossil, bool? temEnergiaRenovavel, bool? energiaInexistente, bool? temEsgotoRedePublica, bool? temEsgotoFossaSeptica, bool? temEsgotoFossaComum, bool? temEsgotoFossa, bool? esgotoInexistente, bool? temLixoColetaServico, bool? temLixoQueima, bool? temLixoEnterra, bool? temLixoDestinoFinalPublico, bool? temLixoDescartaOutraArea, bool? temTratamentoLixoSeparacao, bool? temTratamentoLixoReutilizacao, bool? temTratamentoLixoReciclagem, bool? tratamentoLixoInexistente, bool? temAlmoxarifado, bool? temAreaVerde, bool? temAuditorio, bool? temBanheiro, bool? temBanheiroEducacaoInfantil, bool? temBanheiroDeficientes, bool? temBanheiroFuncionarios, bool? temBanheiroChuveiro, bool? temBiblioteca, bool? temBibliotecaSalaLeitura, bool? temCozinha, bool? temDespensa, bool? temDormitorioAluno, bool? temDormitorioProfessor, bool? temLaboratorioCiencias, bool? temLaboratorioInformatica, bool? temLaboratorioEducacaoProfissional, bool? temPatioCoberto, bool? temPatioDescoberto, bool? temParqueInfantil, bool? temPiscina, bool? temQuadraEsportes, bool? temQuadraEsportesCoberta, bool? temQuadraEsportesDescoberta, bool? temRefeitorio, bool? temSalaAtelieArtes, bool? temSalaMusicalCoral, bool? temSalaEstudioDanca, bool? temSalaOficinaEducacaoProfissional, bool? temSalaDiretoria, bool? temSalaLeitura, bool? temSalaProfessor, bool? temSalaRepousoAluno, bool? temSecretaria, bool? temSalaAtendimentoEspecial, bool? temTerreirao, bool? temViveiro, bool? temAcessibilidadeCorrimao, bool? temAcessibilidadeElevador, bool? temAcessibilidadePisosTateis, bool? temAcessibilidadeVaosLivres, bool? temAcessibilidadeRampas, bool? temAcessibilidadeSinalSonoro, bool? temAcessibilidadeSinalVisual, bool? temAcessibilidadeSinalTatil, bool? acessibilidadeInexistente, int? qtdSalas, int? qtdSalasClimatizadas, int? qtdSalasAcessiveis, bool? temEquipamentoParabolica, bool? temEquipamentoComputador, bool? temEquipamentoCopiadora, bool? temEquipamentoImpressora, bool? temEquipamentoImpressoraMultiFuncional, bool? temEquipamentoScanner, bool? temEquipamentoDvd, int? qtdEquipamentoDvd, bool? temEquipamentoSom, int? qtEquipamentoSom, bool? temEquipamentoTelevisao, int? qtdEquipamentoTelevisao, bool? temEquipamentoLousaDigital, int? qtdEquipamentoLousaDigital, bool? temEquipamentoMultimidia, int? qtdEquipamentoMultimidia, bool? temDesktopAluno, int? qtdDesktopAluno, bool? temComputadorPessoalAluno, int? qtdComputadorPessoalAluno, bool? temTabletAluno, int? qtdTabletAluno, bool? temInternet, bool? temInternetAlunos, bool? temInternetAdministrativo, bool? temInternetAprendizagem, bool? temInternetComunidade, bool? temInternetComputador, bool? temInternetDispositivosPessoais, int? tipoRedeLocalId, string? tipoRedeLocal, bool? temInternetBandaLarga, bool? temProfissionaisAdministrativos, int? qtdProfissionaisAdministrativos, bool? temProfissionaisServicosGerais, int? qtdProfissionaisServicosGerais, bool? temProfissionaiBibliotecario, int? qtdProfissionaiBibliotecario, bool? temProfissionaisSaude, int? qtdProfissionaisSaude, bool? temProfissionaisCoordenador, int? qtdProfissionaisCoordenador, bool? temProfissionaisFonaudiologo, int? qtdProfissionaisFonaudiologo, bool? temProfissionaisNutricionista, int? qtdProfissionaisNutricionista, bool? temProfissionaisPsicologo, int? qtdProfissionaisPsicologo, bool? temProfissionaisAlimentacao, int? qtdProfissionaisAlimentacao, bool? temProfissionaisPedagogia, int? qtdProfissionaisPedagogia, bool? temProfissionaisSecretaria, int? qtdProfissionaisSecretaria, bool? temProfissionaisSeguranca, int? qtdProfissionaisSeguranca, bool? temProfissionaisMonitor, int? qtdProfissionaisMonitor, bool? temProfissionaisGestao, int? qtdProfissionaisGestao, bool? temProfissionaisAssistenteSocial, int? qtdProfissionaisAssistenteSocial, bool? temAlimentacao, bool? temSeriesAnuais, bool? temPeriodosSemestrais, bool? temCiclosEnsinoFundamental, bool? temGruposNaoSeriados, bool? temModulos, bool? temAlternanciaRegularPeriodosEstudo, bool? temAcervoMultimidia, bool? temBrinquedosEducacaoInfantil, bool? temConjuntosMateriaisCientificos, bool? temEquipamentoParaAmplificacaoDifusaoSom, bool? temInstrumentosMusicais, bool? temJogosEducativos, bool? temMateriaisAtividadesCulturaisArtisticas, bool? temMateriaisEducacaoProfissional, bool? temMateriaisPraticaDesportivaRecreacao, bool? temMateriaisEducacaoIndigena, bool? temMateriaisEducacaoEtnicoRacial, bool? temMateriaisEducacaoCampo, bool? temProgramaBrasilAlfabetizado, bool? escolaAbreFinalSemanaComunidade, bool? temExameSolicitacaoNovosAlunos, bool? temReservaVagasRenda, bool? temReservaVagasEsscolaPublica, bool? temReservaVagasPcd, bool? reservaInexistente, bool? temRedesSociais, bool? temEspacoIntegracaoComunidade, bool? temOrgaoAssociacaoPais, bool? temOrgaoAssociacaoPaisEMestres, bool? temOrgaoConselhoEscolar, bool? temOrgaoGremilEstudantil, bool? temOutrosOrgaos, bool? orgaosInexistentes, int? tipoPropostaPedagogicaId, string? tipoPropostaPedagogica, int? tipoAtendimentoEducacionalEspecializadoId, string? tipoAtendimentoEducacionalEspecializado, int? tipoAtividadeComplementarId, string? tipoAtividadeComplementar, bool? temEscolarizacao, bool? temMediacaoPresencial, bool? temMediacaoSemiPresencial, bool? temMediacaoEad, bool? temEducacaoRegular, bool? temPeriodoDiurno, bool? temPeriodoNoturno, bool? temPeriodoEad, bool? temEducacaoBasica, bool? temEducacaoInfantil, bool? temEducacaoInfantilCreche, bool? temEducacaoInfantilPre, bool? temEnsinoFundamental, bool? temEnsinoFundamentalAnosIniciais, bool? temEnsinoFundamentalAnosFinais, bool? temEnsinoMedio, bool? temEnsinoProfissionalizante, bool? temEnsinoProfissionalizanteTecnico, bool? temEducacaoJovensAdultos, bool? temEducacaoJovensAdultosFundamental, bool? temEducacaoJovensAdultosMedio, bool? temEducacaoEspecial, bool? temEducacaoEspecialClasseComum, bool? temEducacaoEspecialClasseExclusiva)
        {
            AnoCenso = anoCenso;
            TipoEscolaPrivadaId = tipoEscolaPrivadaId;
            TipoEscolaPrivada = tipoEscolaPrivada;
            TemVinculoSecretariaEducacao = temVinculoSecretariaEducacao;
            TemVinculoSegurancaPublica = temVinculoSegurancaPublica;
            TemVinculoSecretariaSaude = temVinculoSecretariaSaude;
            TemVinculoOutroOrgao = temVinculoOutroOrgao;
            TemParceriaPoderPublico = temParceriaPoderPublico;
            TipoParceriaPoderPublicoId = tipoParceriaPoderPublicoId;
            TipoParceriaPoderPublico = tipoParceriaPoderPublico;
            TipoRegulamentacaoId = tipoRegulamentacaoId;
            TipoRegulamentacao = tipoRegulamentacao;
            TipoResponsavelRegulamentecaoId = tipoResponsavelRegulamentecaoId;
            TipoResponsavelRegulamentacao = tipoResponsavelRegulamentacao;
            TipoOcupacaoId = tipoOcupacaoId;
            TipoOcupacao = tipoOcupacao;
            TemAguaPotavel = temAguaPotavel;
            TemAbastecimentoAgua = temAbastecimentoAgua;
            TemAbastecimentoPocoArtesiano = temAbastecimentoPocoArtesiano;
            TemAbastecimentoCisterna = temAbastecimentoCisterna;
            TemAbastecimentoRio = temAbastecimentoRio;
            AbastecimentoAguaInexistente = abastecimentoAguaInexistente;
            TemEnergiaRedePublica = temEnergiaRedePublica;
            TemEnergiaGeradorFossil = temEnergiaGeradorFossil;
            TemEnergiaRenovavel = temEnergiaRenovavel;
            EnergiaInexistente = energiaInexistente;
            TemEsgotoRedePublica = temEsgotoRedePublica;
            TemEsgotoFossaSeptica = temEsgotoFossaSeptica;
            TemEsgotoFossaComum = temEsgotoFossaComum;
            TemEsgotoFossa = temEsgotoFossa;
            EsgotoInexistente = esgotoInexistente;
            TemLixoColetaServico = temLixoColetaServico;
            TemLixoQueima = temLixoQueima;
            TemLixoEnterra = temLixoEnterra;
            TemLixoDestinoFinalPublico = temLixoDestinoFinalPublico;
            TemLixoDescartaOutraArea = temLixoDescartaOutraArea;
            TemTratamentoLixoSeparacao = temTratamentoLixoSeparacao;
            TemTratamentoLixoReutilizacao = temTratamentoLixoReutilizacao;
            TemTratamentoLixoReciclagem = temTratamentoLixoReciclagem;
            TratamentoLixoInexistente = tratamentoLixoInexistente;
            TemAlmoxarifado = temAlmoxarifado;
            TemAreaVerde = temAreaVerde;
            TemAuditorio = temAuditorio;
            TemBanheiro = temBanheiro;
            TemBanheiroEducacaoInfantil = temBanheiroEducacaoInfantil;
            TemBanheiroDeficientes = temBanheiroDeficientes;
            TemBanheiroFuncionarios = temBanheiroFuncionarios;
            TemBanheiroChuveiro = temBanheiroChuveiro;
            TemBiblioteca = temBiblioteca;
            TemBibliotecaSalaLeitura = temBibliotecaSalaLeitura;
            TemCozinha = temCozinha;
            TemDespensa = temDespensa;
            TemDormitorioAluno = temDormitorioAluno;
            TemDormitorioProfessor = temDormitorioProfessor;
            TemLaboratorioCiencias = temLaboratorioCiencias;
            TemLaboratorioInformatica = temLaboratorioInformatica;
            TemLaboratorioEducacaoProfissional = temLaboratorioEducacaoProfissional;
            TemPatioCoberto = temPatioCoberto;
            TemPatioDescoberto = temPatioDescoberto;
            TemParqueInfantil = temParqueInfantil;
            TemPiscina = temPiscina;
            TemQuadraEsportes = temQuadraEsportes;
            TemQuadraEsportesCoberta = temQuadraEsportesCoberta;
            TemQuadraEsportesDescoberta = temQuadraEsportesDescoberta;
            TemRefeitorio = temRefeitorio;
            TemSalaAtelieArtes = temSalaAtelieArtes;
            TemSalaMusicalCoral = temSalaMusicalCoral;
            TemSalaEstudioDanca = temSalaEstudioDanca;
            TemSalaOficinaEducacaoProfissional = temSalaOficinaEducacaoProfissional;
            TemSalaDiretoria = temSalaDiretoria;
            TemSalaLeitura = temSalaLeitura;
            TemSalaProfessor = temSalaProfessor;
            TemSalaRepousoAluno = temSalaRepousoAluno;
            TemSecretaria = temSecretaria;
            TemSalaAtendimentoEspecial = temSalaAtendimentoEspecial;
            TemTerreirao = temTerreirao;
            TemViveiro = temViveiro;
            TemAcessibilidadeCorrimao = temAcessibilidadeCorrimao;
            TemAcessibilidadeElevador = temAcessibilidadeElevador;
            TemAcessibilidadePisosTateis = temAcessibilidadePisosTateis;
            TemAcessibilidadeVaosLivres = temAcessibilidadeVaosLivres;
            TemAcessibilidadeRampas = temAcessibilidadeRampas;
            TemAcessibilidadeSinalSonoro = temAcessibilidadeSinalSonoro;
            TemAcessibilidadeSinalVisual = temAcessibilidadeSinalVisual;
            TemAcessibilidadeSinalTatil = temAcessibilidadeSinalTatil;
            AcessibilidadeInexistente = acessibilidadeInexistente;
            QtdSalas = qtdSalas;
            QtdSalasClimatizadas = qtdSalasClimatizadas;
            QtdSalasAcessiveis = qtdSalasAcessiveis;
            TemEquipamentoParabolica = temEquipamentoParabolica;
            TemEquipamentoComputador = temEquipamentoComputador;
            TemEquipamentoCopiadora = temEquipamentoCopiadora;
            TemEquipamentoImpressora = temEquipamentoImpressora;
            TemEquipamentoImpressoraMultiFuncional = temEquipamentoImpressoraMultiFuncional;
            TemEquipamentoScanner = temEquipamentoScanner;
            TemEquipamentoDvd = temEquipamentoDvd;
            QtdEquipamentoDvd = qtdEquipamentoDvd;
            TemEquipamentoSom = temEquipamentoSom;
            QtEquipamentoSom = qtEquipamentoSom;
            TemEquipamentoTelevisao = temEquipamentoTelevisao;
            QtdEquipamentoTelevisao = qtdEquipamentoTelevisao;
            TemEquipamentoLousaDigital = temEquipamentoLousaDigital;
            QtdEquipamentoLousaDigital = qtdEquipamentoLousaDigital;
            TemEquipamentoMultimidia = temEquipamentoMultimidia;
            QtdEquipamentoMultimidia = qtdEquipamentoMultimidia;
            TemDesktopAluno = temDesktopAluno;
            QtdDesktopAluno = qtdDesktopAluno;
            TemComputadorPessoalAluno = temComputadorPessoalAluno;
            QtdComputadorPessoalAluno = qtdComputadorPessoalAluno;
            TemTabletAluno = temTabletAluno;
            QtdTabletAluno = qtdTabletAluno;
            TemInternet = temInternet;
            TemInternetAlunos = temInternetAlunos;
            TemInternetAdministrativo = temInternetAdministrativo;
            TemInternetAprendizagem = temInternetAprendizagem;
            TemInternetComunidade = temInternetComunidade;
            TemInternetComputador = temInternetComputador;
            TemInternetDispositivosPessoais = temInternetDispositivosPessoais;
            TipoRedeLocalId = tipoRedeLocalId;
            TipoRedeLocal = tipoRedeLocal;
            TemInternetBandaLarga = temInternetBandaLarga;
            TemProfissionaisAdministrativos = temProfissionaisAdministrativos;
            QtdProfissionaisAdministrativos = qtdProfissionaisAdministrativos;
            TemProfissionaisServicosGerais = temProfissionaisServicosGerais;
            QtdProfissionaisServicosGerais = qtdProfissionaisServicosGerais;
            TemProfissionaiBibliotecario = temProfissionaiBibliotecario;
            QtdProfissionaiBibliotecario = qtdProfissionaiBibliotecario;
            TemProfissionaisSaude = temProfissionaisSaude;
            QtdProfissionaisSaude = qtdProfissionaisSaude;
            TemProfissionaisCoordenador = temProfissionaisCoordenador;
            QtdProfissionaisCoordenador = qtdProfissionaisCoordenador;
            TemProfissionaisFonaudiologo = temProfissionaisFonaudiologo;
            QtdProfissionaisFonaudiologo = qtdProfissionaisFonaudiologo;
            TemProfissionaisNutricionista = temProfissionaisNutricionista;
            QtdProfissionaisNutricionista = qtdProfissionaisNutricionista;
            TemProfissionaisPsicologo = temProfissionaisPsicologo;
            QtdProfissionaisPsicologo = qtdProfissionaisPsicologo;
            TemProfissionaisAlimentacao = temProfissionaisAlimentacao;
            QtdProfissionaisAlimentacao = qtdProfissionaisAlimentacao;
            TemProfissionaisPedagogia = temProfissionaisPedagogia;
            QtdProfissionaisPedagogia = qtdProfissionaisPedagogia;
            TemProfissionaisSecretaria = temProfissionaisSecretaria;
            QtdProfissionaisSecretaria = qtdProfissionaisSecretaria;
            TemProfissionaisSeguranca = temProfissionaisSeguranca;
            QtdProfissionaisSeguranca = qtdProfissionaisSeguranca;
            TemProfissionaisMonitor = temProfissionaisMonitor;
            QtdProfissionaisMonitor = qtdProfissionaisMonitor;
            TemProfissionaisGestao = temProfissionaisGestao;
            QtdProfissionaisGestao = qtdProfissionaisGestao;
            TemProfissionaisAssistenteSocial = temProfissionaisAssistenteSocial;
            QtdProfissionaisAssistenteSocial = qtdProfissionaisAssistenteSocial;
            TemAlimentacao = temAlimentacao;
            TemSeriesAnuais = temSeriesAnuais;
            TemPeriodosSemestrais = temPeriodosSemestrais;
            TemCiclosEnsinoFundamental = temCiclosEnsinoFundamental;
            TemGruposNaoSeriados = temGruposNaoSeriados;
            TemModulos = temModulos;
            TemAlternanciaRegularPeriodosEstudo = temAlternanciaRegularPeriodosEstudo;
            TemAcervoMultimidia = temAcervoMultimidia;
            TemBrinquedosEducacaoInfantil = temBrinquedosEducacaoInfantil;
            TemConjuntosMateriaisCientificos = temConjuntosMateriaisCientificos;
            TemEquipamentoParaAmplificacaoDifusaoSom = temEquipamentoParaAmplificacaoDifusaoSom;
            TemInstrumentosMusicais = temInstrumentosMusicais;
            TemJogosEducativos = temJogosEducativos;
            TemMateriaisAtividadesCulturaisArtisticas = temMateriaisAtividadesCulturaisArtisticas;
            TemMateriaisEducacaoProfissional = temMateriaisEducacaoProfissional;
            TemMateriaisPraticaDesportivaRecreacao = temMateriaisPraticaDesportivaRecreacao;
            TemMateriaisEducacaoIndigena = temMateriaisEducacaoIndigena;
            TemMateriaisEducacaoEtnicoRacial = temMateriaisEducacaoEtnicoRacial;
            TemMateriaisEducacaoCampo = temMateriaisEducacaoCampo;
            TemProgramaBrasilAlfabetizado = temProgramaBrasilAlfabetizado;
            EscolaAbreFinalSemanaComunidade = escolaAbreFinalSemanaComunidade;
            TemExameSolicitacaoNovosAlunos = temExameSolicitacaoNovosAlunos;
            TemReservaVagasRenda = temReservaVagasRenda;
            TemReservaVagasEsscolaPublica = temReservaVagasEsscolaPublica;
            TemReservaVagasPcd = temReservaVagasPcd;
            ReservaInexistente = reservaInexistente;
            TemRedesSociais = temRedesSociais;
            TemEspacoIntegracaoComunidade = temEspacoIntegracaoComunidade;
            TemOrgaoAssociacaoPais = temOrgaoAssociacaoPais;
            TemOrgaoAssociacaoPaisEMestres = temOrgaoAssociacaoPaisEMestres;
            TemOrgaoConselhoEscolar = temOrgaoConselhoEscolar;
            TemOrgaoGremilEstudantil = temOrgaoGremilEstudantil;
            TemOutrosOrgaos = temOutrosOrgaos;
            OrgaosInexistentes = orgaosInexistentes;
            TipoPropostaPedagogicaId = tipoPropostaPedagogicaId;
            TipoPropostaPedagogica = tipoPropostaPedagogica;
            TipoAtendimentoEducacionalEspecializadoId = tipoAtendimentoEducacionalEspecializadoId;
            TipoAtendimentoEducacionalEspecializado = tipoAtendimentoEducacionalEspecializado;
            TipoAtividadeComplementarId = tipoAtividadeComplementarId;
            TipoAtividadeComplementar = tipoAtividadeComplementar;
            TemEscolarizacao = temEscolarizacao;
            TemMediacaoPresencial = temMediacaoPresencial;
            TemMediacaoSemiPresencial = temMediacaoSemiPresencial;
            TemMediacaoEad = temMediacaoEad;
            TemEducacaoRegular = temEducacaoRegular;
            TemPeriodoDiurno = temPeriodoDiurno;
            TemPeriodoNoturno = temPeriodoNoturno;
            TemPeriodoEad = temPeriodoEad;
            TemEducacaoBasica = temEducacaoBasica;
            TemEducacaoInfantil = temEducacaoInfantil;
            TemEducacaoInfantilCreche = temEducacaoInfantilCreche;
            TemEducacaoInfantilPre = temEducacaoInfantilPre;
            TemEnsinoFundamental = temEnsinoFundamental;
            TemEnsinoFundamentalAnosIniciais = temEnsinoFundamentalAnosIniciais;
            TemEnsinoFundamentalAnosFinais = temEnsinoFundamentalAnosFinais;
            TemEnsinoMedio = temEnsinoMedio;
            TemEnsinoProfissionalizante = temEnsinoProfissionalizante;
            TemEnsinoProfissionalizanteTecnico = temEnsinoProfissionalizanteTecnico;
            TemEducacaoJovensAdultos = temEducacaoJovensAdultos;
            TemEducacaoJovensAdultosFundamental = temEducacaoJovensAdultosFundamental;
            TemEducacaoJovensAdultosMedio = temEducacaoJovensAdultosMedio;
            TemEducacaoEspecial = temEducacaoEspecial;
            TemEducacaoEspecialClasseComum = temEducacaoEspecialClasseComum;
            TemEducacaoEspecialClasseExclusiva = temEducacaoEspecialClasseExclusiva;

            Validate();
        }

        //TODO: Implementar...
        private void Validate()
        {

        }
    }
}
