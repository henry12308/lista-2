/*-------------------------------------------------------------------
Questão 3: Loja de Poções
• Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que 
aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas, 
Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há 
um desconto aplicável.
• Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo 
de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. Calcule o preço total 
das poções, aplicando o desconto correspondente:
• Guerreiro recebe 10% de desconto na compra de poções de Vida.
• Mago recebe 15% de desconto na compra de poções de Mana.
• Paladino recebe 20% de desconto na compra de poções de Resistência.
• Exiba o preço total com e sem desconto.
@Lista: 02 - Condicionais
@Autor: João Henry Brito Cavalcante
@Data: 03/09/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
            string classes, tipPocao;
            int quantidade, resultados;
            double totais;
            
        Console.WriteLine ("diga a classe do seu player? (guerreiro, mago ou paladino)");
        classes = Console.ReadLine();
        
        Console.WriteLine ("diga o tipo de pocao que voce deseja comprar:(Vida, Mana ou Resistencia)");
        tipPocao = Console.ReadLine();
        
        Console.WriteLine ("diga a quantidade de pocoes que voce deseja:");
        int.TryParse(Console.ReadLine(), out quantidade);
        
        if(tipPocao == "vida")
        {
            resultados = 10 * quantidade;
            Console.WriteLine($"Resultado sem desconto:{resultados}");
        }
        if(tipPocao == "mana")
        {
        resultados = 15 * quantidade;
        Console.WriteLine($"Resultado sem desconto:{resultados}");
        }
         if(tipPocao == "resistencia")
        {
        resultados = 20 * quantidade;
        Console.WriteLine($"Resultado sem desconto :{resultados}");
        }
        if(classes == "guerreiro" && tipPocao == "vida")
        {
            resultados = (10 * quantidade);
            totais = resultados - (resultados * 0.1);
            Console.WriteLine($"O resultado sem desconto:{resultados}");
            Console.WriteLine($"Resultado com desconto:{totais}");
        }
        if(classes == "mago" && tipPocao == "mana")
        {
            resultados = (15 * quantidade);
            totais = resultados - (resultados * 0.15);
             Console.WriteLine($"O resultado sem desconto:{resultados}");
            Console.WriteLine($"Resultado com descoonto:{totais}");
        }
        if(classes == "paladino" && tipPocao == "resistencia")
        {
            resultados = (20 * quantidade);
           totais = resultados - (resultados * 0.2);
             Console.WriteLine($"O resultado sem desconto:{resultados}");
           Console.WriteLine($"Resultado com desconto:{totais}");
        }
     }
}