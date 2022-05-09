﻿using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;


Console.WriteLine("Boas vindas ao ByteBank Administração!\n");

Console.WriteLine("\n");

Console.WriteLine("### Calculando Bonificação ###");
CalcularBonificacao();

Console.ReadKey();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciadorBonificacao = new GerenciadorDeBonificacao();

    Funcionario pedro = new Designer("833.222.048-39");
    pedro.Nome = "Pedro";

    Funcionario roberta = new Diretor("159.753.398-04");
    roberta.Nome = "Roberta";

    Funcionario igor = new Auxiliar("981.198.778-53");
    igor.Nome = "Igor";

    Funcionario camila = new GerenteDeConta("326.985.628-89");
    camila.Nome = "Camila";

    Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
    guilherme.Nome = "Guilherme";

    gerenciadorBonificacao.Registrar(guilherme);
    gerenciadorBonificacao.Registrar(pedro);
    gerenciadorBonificacao.Registrar(roberta);
    gerenciadorBonificacao.Registrar(igor);
    gerenciadorBonificacao.Registrar(camila);

    Console.WriteLine("Total de bonificações do mês " +
        gerenciadorBonificacao.GetTotalBonificacao());
}
