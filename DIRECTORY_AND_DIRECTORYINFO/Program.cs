CriarDiretoriosGlobo();
CriarArquivos();

string origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");

string destino = Path.Combine(Environment.CurrentDirectory, "globo", "America do Sul", "Brasil", "brasil.txt" );

string destino2 = Path.Combine(Environment.CurrentDirectory, "globo", "America do Sul", "RENAMEBRASIL.txt" );

MoverArquivo(origem, destino);
CopiarArquivo(origem, destino2);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
  if (!File.Exists(pathOrigem))
  {
    System.Console.WriteLine("Não existe arquivo na origem");
    return;
  }

  if (File.Exists(pathDestino))
  {
    System.Console.WriteLine("Aquivo já existe na pasta de destino");
    return;
  }

  File.Copy(pathOrigem, pathDestino);
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
  if (!File.Exists(pathOrigem))
  {
    System.Console.WriteLine("Não existe arquivo na origem");
    return;
  }

  if (File.Exists(pathDestino))
  {
    System.Console.WriteLine("Aquivo já existe na pasta de destino");
    return;
  }

  File.Move(pathOrigem, pathDestino);
}

static void CriarArquivos()
{
  var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
  if(!File.Exists(path)){
    using var sw = File.CreateText(path);
    sw.WriteLine("População: 213MM");
    sw.WriteLine("IDH: teste");
    sw.WriteLine("Teste atualizados");
  }
}

static void CriarDiretoriosGlobo()
{
  var path = Path.Combine(Environment.CurrentDirectory, "globo");
  if(!Directory.Exists(path))
  {
    var dirGlobo = Directory.CreateDirectory(path);

    var americaNorte = dirGlobo.CreateSubdirectory("America do Norte");
    var americaCentral = dirGlobo.CreateSubdirectory("America Central");
    var americaSul = dirGlobo.CreateSubdirectory("America do Sul");


    americaNorte.CreateSubdirectory("USA");
    americaNorte.CreateSubdirectory("Mexico");
    americaNorte.CreateSubdirectory("Canada");


    americaCentral.CreateSubdirectory("Costa Rica");
    americaCentral.CreateSubdirectory("Panama");

    americaSul.CreateSubdirectory("Brasil");
    americaSul.CreateSubdirectory("Argentina");
    americaSul.CreateSubdirectory("Paraguai");
  }
}