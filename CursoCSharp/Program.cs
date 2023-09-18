using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using static CursoCSharp.ClassesEMetodos.CarroOpcional;
using static CursoCSharp.ClassesEMetodos.Coordenada;
using static CursoCSharp.OO.Samsung;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Exceções;
using CursoCSharp.API;
using CursoCSharp.Tópicos_Avançados;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                
                //Estruturas de Controle
                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura For/Each - Estrutura de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estrutura de Controle", EstruturaBreak.Executar},
                {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar},

                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo  - Classes e Métodos", DesafioAtributo.Executar},
                {"Params  - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados  - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set  - Classes e Métodos", GetSet.Executar},
                {"Propriedades - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor vs Referencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},


                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", Colecoes.Produto.ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},


                //OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},
                
                //Métodos e Funções
                {"Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar},
                {"Lambda Como Delegate - Métodos & Funções", LambdasDelegate.Executar},
                {"Usandos Delegates - Métodos & Funções", UsandoDelegate.Executar},
                {"Delegates como Função Anonima - Métodos & Funções", DelegateFuncAnonima.Executar},
                {"Delegate como Paramêtros - Métodos & Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos & Funções", MetodosDeExtensao.Executar},
                
                
                //Exceções
                {"Primeira Exceção - Exceçoes", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceçoes", ExcecoesPersonalizadas.Executar},
                
                //API
                {"Primeiro Arquivo - API", ExtensaoString.PrimeiroArquivo.Executar},
                {"Lendo Arquivos - API", LendoArquivos.Executar},
                {"Exemplo FileInfo - API", ExemploFileInfo.Executar},
                {"Diretórios - API", Diretorios.Executar},
                {"ExemploDirectoryInfo - API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - API", ExemploPath.Executar},
                {"Exemplo DateTime - API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - API", ExemploTimeSpan.Executar},
                
                //Tópicos Avançados
                { "LINQ - Tópicos Avançados", LINQ.Executar},
                { "LINQ2 - Tópicos Avançados", LINQ2.Executar},
                { "Nullables - Tópicos Avançados", Nullables.Executar},
                { "Genéricos - Tópicos Avançados", Genericos.Executar},
                { "Dynamics - Tópicos Avançados", Dynamics.Executar},
            });
            central.SelecionarEExecutar();
        }
    } 

}