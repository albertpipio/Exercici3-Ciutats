//Fase 1

console.log(" --- FASE 1 ---");
console.log();

let ciutat1 = "";
let ciutat2 = "";
let ciutat3 = "";
let ciutat4 = "";
let ciutat5 = "";
let ciutat6 = "";

console.log("Escriu el nom de la primera ciutat: ");
var ciutat1 = console.ReadLine();

console.log("Escriu el nom de la segona ciutat: ");
var ciutat2 = console.ReadLine();

console.log("Escriu el nom de la tercera ciutat: ");
var ciutat3 = console.ReadLine();

console.log("Escriu el nom de la quarta ciutat: ");
var ciutat4 = console.ReadLine();

console.log("Escriu el nom de la cinquena ciutat: ");
var ciutat5 = console.ReadLine();

console.log("Escriu el nom de la sisena ciutat: ");
var ciutat6 = console.ReadLine();

console.log("Les ciutats que has escrit són: " + ciutat1 + ", " + ciutat2 + ", " + ciutat3 + ", " + ciutat4 + ", " + ciutat5 + ", i " + ciutat6 + ".");

console.log();

//Fi Fase 1

//Fase 2

console.log(" --- FASE 2 ---");
console.log();

let arrayCiutats = [6];

let arrayCiutats = arrayCiutats[0];
let arrayCiutats = arrayCiutats[1];
let arrayCiutats = arrayCiutats[2];
let arrayCiutats = arrayCiutats[3];
let arrayCiutats = arrayCiutats[4];
let arrayCiutats = arrayCiutats[5];

arrayCiutats.sort();

console.log("Aquestes són les ciutats per ordre alfabètic: ");

for (i = 0; i < arrayCiutats.Length; i++)
{
    console.log(arrayCiutats[i]);
}

console.log();

//Fi Fase 2

//Fase 3

console.log(" --- FASE 3 ---");
console.log();

var arrayCiutatsModificades = [6];

arrayCiutatsModificades[0] = ciutat1.replace("a", "4");
arrayCiutatsModificades[1] = ciutat2.replace("a", "4");
arrayCiutatsModificades[2] = ciutat3.replace("a", "4");
arrayCiutatsModificades[3] = ciutat4.replace("a", "4");
arrayCiutatsModificades[4] = ciutat5.replace("a", "4");
arrayCiutatsModificades[5] = ciutat6.replace("a", "4");
            
arrayCiutatsModificades.sort();

console.log("Aquest és l'array modificat i per ordre alfabètic: ");

for (i = 0; i < arrayCiutatsModificades.Length; i++)
{
    console.log(arrayCiutatsModificades[i]);
}

console.log();

//Fi Fase 3

//Fase 4

console.log(" --- FASE 4 ---");
console.log();

var arrayCiutat1 = [ciutat1.Length];
var arrayCiutat2 = [ciutat2.Length];
var arrayCiutat3 = [ciutat3.Length];
var arrayCiutat4 = [ciutat4.Length];
var arrayCiutat5 = [ciutat5.Length];
var arrayCiutat6 = [ciutat6.Length];

for (i = ciutat1.Length -1; i >= 0; i--)
{
    arrayCiutat1[i] = ciutat1.substring(i, 1);
}

for (i = ciutat1.Length -1; i >= 0; i--)
{
    console.log(arrayCiutat1[i]);
}

for (i = ciutat2.Length -1; i >= 0; i--)
{
    arrayCiutat2[i] = ciutat2.substring(i, 1);
}

console.log();

for (i = ciutat2.Length -1; i >= 0; i--)
{
    console.log(arrayCiutat2[i]);
}

console.log();

for (i = ciutat3.Length -1; i >= 0; i--)
{
    arrayCiutat3[i] = ciutat3.substring(i, 1);
}

for (i = ciutat3.Length -1; i >= 0; i--)
{
    console.log(arrayCiutat3[i]);
}

console.log();

for (i = ciutat4.Length -1; i >= 0; i--)
{
    arrayCiutat4[i] = ciutat4.substring(i, 1);
}

for (i = ciutat4.Length -1; i >= 0; i--)
{
    console.log(arrayCiutat4[i]);
}

console.log();

for (i = ciutat5.Length -1; i >= 0; i--)
{
    arrayCiutat5[i] = ciutat5.substring(i, 1);
}

for (i = ciutat5.Length -1; i >= 0; i--)
{
    console.log(arrayCiutat5[i]);
}

console.log();

for (i = ciutat6.Length -1; i >= 0; i--)
{
    arrayCiutat6[i] = ciutat6.substring(i, 1);
}

for (i = ciutat6.Length -1; i >= 0; i--)
{
    console.log(arrayCiutat6[i]);
}

//Fi Fase 4