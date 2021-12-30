using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.POO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões de tipos - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                // Classes e Métodos
                {"Membros - Atributos e Métodos", Membros.Executar},
                {"Construtores - Atributos e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Atributos e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Atributos e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Atributos e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Atributos e Métodos", DesafioAtributo.Executar},
                {"Params - Atributos e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Atributos e Métodos", ParametrosNomeados.Executar},
                {"Getters & Setters - Atributos e Métodos", GetSet.Executar},
                {"Propriedades - Atributos e Métodos", Props.Executar},
                {"Atributos Readonly - Atributos e Métodos", Readonly.Executar},
                {"Enumerações (Enum) - Atributos e Métodos", ExemploEnum.Executar},
                {"Struct - Atributos e Métodos", ExemploStruct.Executar},
                {"Struct vs Classe - Atributos e Métodos", StructVsClasse.Executar},
                {"Valor vs Referência - Atributos e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referência (Ref/Out) - Atributos e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro com Valor Padrão - Atributos e Métodos", ParametroPadrao.Executar},

                // Coleções
                {"Array - Coleções", ColecoesArray.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar}, // não aceita repetições.
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                // POO - Programação Orientada a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"Construtor \"this\" - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamneto - Orientação a Objetos", POO.Encapsulamento.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}