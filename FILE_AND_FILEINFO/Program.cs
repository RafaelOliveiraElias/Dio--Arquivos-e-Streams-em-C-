using static System.Console;

WriteLine("digite o nome do Arquivo");
var nome = ReadLine();
nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");


CriarArquivo(path);

WriteLine("digite o Enter para finalizar");
ReadLine();

static string LimparNome(string nome)
{
  foreach (var @char in Path.GetInvalidFileNameChars())
  {
    nome = nome.Replace(@char, '-');
  }
  return nome;
}

static void CriarArquivo(string path)
{
  try
  {
    using var sw = File.CreateText(path);
    sw.WriteLine("Linha teste 1 2 3 testando");
    sw.WriteLine("Linha teste 1 2 3 testando");
    sw.WriteLine("Linha teste 1 2 3 testando");
  }
  catch 
  {
    
    WriteLine("Nome do arquivo inválido");
  }
  
}

// var sw = File.CreateText(path);

// // flush escrvei linha por linha 
// sw.WriteLine("Linha teste 1 2 3 testando");
// sw.Flush();

// sw.WriteLine("Linha teste 1 2 3 testando");
// sw.Flush();

// sw.WriteLine("Linha teste 1 2 3 testando");
// sw.WriteLine("Linha teste 1 2 3 testando");
// sw.WriteLine("Linha teste 1 2 3 testando");
// sw.Flush();

