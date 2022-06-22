var path = Path.Combine(Environment.CurrentDirectory, "globo");

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