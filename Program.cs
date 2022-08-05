// Exercício do cusso do Nélio Alves "Pessoa Mais Velha";
// Esse porgrama o usuário irá digitar o nome e a idade na mesma linha de uma quantidade "N" de pessoas;
// Depois o progrma irá mostrar na tela a pessoa masi velha;


int N = int.Parse(Console.ReadLine());
//Vetores;
string [] Pessoa = new string[N];
int [] Idade = new int[N];

// Leitura de dados;
for (int i = 0; i < N; i ++)
{
    string [] X = Console.ReadLine().Split(' ');
    Pessoa[i] = X[0];
    Idade[i] = int.Parse(X[1]);
}

int IdadeDoMaisVelho = Idade[0];
int PessoaMaisVelha = 0;
// Comando para separar a pessoa mais velha;
for (int i = 0; i < N; i++)
{
    if (Idade[i] > IdadeDoMaisVelho)
    {
        IdadeDoMaisVelho = Idade[i];
        PessoaMaisVelha = i;
    }
}
Console.WriteLine("Pessoa mais velha é: " + Pessoa[PessoaMaisVelha]);