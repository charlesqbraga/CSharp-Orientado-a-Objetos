﻿Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);



Musica musica2 = new Musica();
musica2.Nome = "Vertogo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;
Console.WriteLine(musica2.Disponivel);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();