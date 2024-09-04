class Fotboll{

static void Main(){
    Spel();
    Console.ReadLine();
}
static void Spel(){


Console.WriteLine("Ronaldo och Messi går förbi");
Console.WriteLine("Skakar du Ronaldos hand eller Messis hand?");
String Hand = Console.ReadLine().ToLower();

if(Hand == "ronaldos") {
    Console.WriteLine("Ronaldo ger dig hans tröja");
    Console.WriteLine("Säljer du tröjan eller behålled du den?");
    String troja = Console.ReadLine().ToLower();
    if(troja == "säljer"){
        Console.WriteLine("Du säljer den för miljoner och lever livet tills du dör");
    }
    else if (troja == "behåller") {
        Console.WriteLine("Du blir rånad på tröjan på vägen där ifrån och blir hemlös");
    }
}
else if (Hand == "messis") {
    Console.WriteLine("Messis Bodyguard slammar ner dig i marken");
    Console.WriteLine("Försöker du gå fram igen eller går du där ifrån?");
    String vart = Console.ReadLine().ToLower();
    if(vart == "fram igen"){
        Console.WriteLine("Messis bodyguard slammar dig igen och du dör");
    }
    else if (vart == "går ifrån"){
        Console.WriteLine("Messis bodyguard slammar dig igen och du dör");
    }
    else {
          Console.WriteLine("Messis bodyguard slammar dig igen och du dör");
    }
}
else {
    Console.WriteLine("Ronaldo och Messi går förbi dig");
}

String fortsattning = Console.ReadLine().ToLower();

if(fortsattning == "jag bryr mig inte"){
    Console.WriteLine("DU FÅR DÖ ÄNDÅ");
}
else {
    Console.WriteLine("Easy W!");
}

Spel();

Console.ReadLine();
}
}

