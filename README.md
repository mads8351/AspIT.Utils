# AspIT.Utils
Diverse funktioner der gør livet nemmere for en .NET udvikler.

AspIT.Utils solution består af en række forskellige projects:
- AspIT.Utils: Her erklæres typer der udvider funktionaliteten i namespace System, f.eks. extension methods til de typer der er erklæret i namespace System.
- AspIT.Utils.Numerics: Her erklæres typer der udvider funktionaliteten for numeriske beregninger.
- AspIT.Utils.CommonBusinessRules: Her erklæres typer der implementerer gængse forretnings regler, som f.eks. at et navn kun indeholder bogstaver osv. 
- AspIT.Utils.CommonBusinessTypes: Her erklæres typer der oftests anvendes i en applikation, såsom UserCredentials, og Person osv.

MARA godkender alt der pushes og sørger for merging med master branch. Du er volkommen til at forke løs. Alt skal unit testes før det kan merges i master branch. Til hvert project skal der være et Unit Test project som hedder det samme som det project der skal testes, dog med suffix ".Tests". Hver struct/class bør testes i sin egen Test class. Hvert function member bør testes i sin egen test method.
