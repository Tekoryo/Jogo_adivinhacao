
String Letreiro = @"
▄▀█ █▀▄ █ █░█ █ █▄░█ █░█ ▄▀█   █▀█   █▄░█ █░█ █▀▄▀█ █▀▀ █▀█ █▀█
█▀█ █▄▀ █ ▀▄▀ █ █░▀█ █▀█ █▀█   █▄█   █░▀█ █▄█ █░▀░█ ██▄ █▀▄ █▄█";
void Titulo(){
    Console.WriteLine(Letreiro);
}

int FinalizandoOJogo = 0;
int NumeroDeTentativas = 5;
int numeroSecreto = NumeroAleatorio();

int NumeroAleatorio()
{

    Random NumeroRandomico = new Random();

    int ValorSecreto = NumeroRandomico.Next(1,100);
    return ValorSecreto;
}

void VerificadorDeNumero(int numeroDigitado)
{

    if(numeroDigitado < numeroSecreto){
        Console.WriteLine("Numero Digitado e maior que o numero secreto!");
        Tentativas();
    }else if(numeroDigitado > numeroSecreto){
        Console.WriteLine("Numero Digitado e menor que o numero secreto!");
        Tentativas();
    }else{
        Console.WriteLine("Você Ganhou!\n Fim de Jogo!");
        FinalizandoOJogo = 1;
    }
}

void Tentativas(){
    NumeroDeTentativas--;

    if(NumeroDeTentativas == 0){
        FinalizandoOJogo = 1;
        Console.WriteLine("Você Perdeu!\n O numero secreto é: "+ numeroSecreto +" \nJogue novamente para ganhar! ");
        return;
    }

    Console.WriteLine("\nTentativas Restantes: " + NumeroDeTentativas);

}

bool Acabou(int G)
{
    
    int finalizar = G;

    if(finalizar == 1 || finalizar == 1)return true;
    return false;
}

Titulo();
Console.WriteLine("\n");

do{
    Console.WriteLine("Digite um numero inteiro: ");
    string NumeroEscolhido = Console.ReadLine()!;
    int NumeroEscolhidoNumerico = int.Parse(NumeroEscolhido);
    VerificadorDeNumero(NumeroEscolhidoNumerico);

}while(!Acabou(FinalizandoOJogo));