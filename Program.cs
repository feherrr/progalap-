//VÁLTOZOK 
//csharptutorial.hu

byte kisSzam = 128;
short nagyobbszam = 32767;
int szam = 48484848;
long hatalmasSzam = 98989898988;

bool igazE = false;

char betu = 'a';
string nevem = "Dajana";

double pi = 3.14;
float pi2 = 3.14f;


//valtozo deklaralasa
int eletKor;

//inicilizalas - ertekadas
eletKor = 42;

int kor = 26;

//valtozo egymashoz rendelese 
int evszam = 2023;
int ideiEvszam = evszam;

//kiiras a konzolra
//Console.WriteLine(ideiEvszam);

//több valtozo kiirasa a konzolra
//konkatenacio
string kiiras = "Az évszám: " + evszam;
//Console.WriteLine(kiiras);

//feladat 
int eletkor = 26;
//Console.WriteLine("Az én korom " + eletkor);


//alapmuveletek - muveletek sorrendjet figyelembe veszi 
//c# preceedencia tablazat - muveleti sorrend
int eredmeny = 2 * 3 + 5 - 7;
int erdmeny2 = 2 * (3 + 5) - 7;
//Console.WriteLine(eredmeny);

//roviditesek
int number = 5;
number = number + 1; //5 + 1 = 6
number += 1; //6 + 1 = 7
number++; //7 + 1 = 8
//Console.WriteLine(number);

//tovabi roviditesek: *=, -=, /=, --


//maradekkepzes mod %
//Console.WriteLine(12 % 3); //0, annyi a maradek 


//string interpolacio
int felnott = 18;
string interpolalt = $"Ha felnott vagy, elmultal {felnott}.";
//Console.WriteLine(interpolalt);


//KONVERTALAS
int bigNum = 203;
byte smallNum = (byte) bigNum;
//Console.WriteLine(smallNum);
//figyeljunk a tulcsordulasra!

String strNum = "253";
int intNum = int.Parse(strNum);
//Console.WriteLine(intNum);

//egész -> tört
int nemTort = 39;
double deTort = nemTort;
//Console.WriteLine(deTort);

//tört -> egész 
double tort = 55.3;
int egesz = (int) tort; //55 lesz, levagja a tizedes pont utani reszt 
//Console.WriteLine(egesz);

//szovegbol -> tort
//STRINGNEL MINDIG VESSZOT ADJUNK MEG PONT HELYETT
string celsius = "27,3";
double tegnapFok = 32.4;
double maFok = Convert.ToDouble(celsius);
//Console.WriteLine("Ma " + (tegnapFok - maFok) + "C fokkal hidegebb van ");

//szoveg -> logika
string ezKamu = "true";
bool trueStory = Convert.ToBoolean(ezKamu);
//Console.WriteLine(trueStory);

//barmibol szoveg
int year = 2019;
string ev1 = evszam.ToString();
string ev2 = Convert.ToString(year);
Console.WriteLine("ev1: " + ev1 + " ev2: " + ev2);