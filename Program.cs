

void TestaKapacitet()
{
    Console.WriteLine("Testar kapacitetsregeln");

    Course matematik = new("Matematik", 2); // skapar kursen matematik med max 2 studenter
    Student kim = new("Kim"); // ny student skapas - Kim
    Student linnea = new("Linnea"); // n y student skapas - Linnea
    Student sid = new("Sid"); // ny student skapas - Sid, kommer inte komma med pga maxantalet

    kim.Join(matematik); // Kim läggs till i matematik
    matematik.Enroll(linnea); // Linnea läggs till i matematik
    matematik.Enroll(sid);  // Sid försöker läggas till men är inte med på rollcall
    matematik.RollCall();
}
TestaKapacitet();

Console.WriteLine("\n");

void TestaDubblettskydd()
{
    Console.WriteLine("Testar skydd mot dubbletter");

    Course matematik = new("Matematik", 2);
    Student kim = new("Kim");

    kim.Join(matematik);
    kim.Join(matematik);

    matematik.RollCall();
}
TestaDubblettskydd();

Console.WriteLine("\n");

void TestaBorttagning()
{
    Console.WriteLine("Testar borttagning");

    Course matematik = new("Matematik", 2);
    Student kim = new("Kim");
    Student linnea = new("Linnea");
    Student sid = new("Sid");

    kim.Join(matematik);
    matematik.Enroll(linnea);
    matematik.Enroll(sid); // klassen är full Sid kommer inte komma med
    
    matematik.Remove(linnea); // linnea var med - tas bort
    linnea.Leave(matematik); // körs igen - ingen krash

    matematik.Remove(sid); // Sid var aldrig med - ingen krasch
    sid.Leave(matematik); // samma här - ingen krasch

    matematik.RollCall(); // ska bara visa Kim

}
TestaBorttagning();


/*
// skapar en ny kurs "matematik" med max 2 studenter
Course matematik = new("Matematik", 2);

// lägger till Kim och Linnea i matematik
Student kim = new("Kim");
kim.Join(matematik);

Student linnea = new("Linnea");
matematik.Enroll(linnea);

// försöker lägga till Sid men kursen är full
Student sid = new("Sid");
matematik.Enroll(sid);

// RollCall och Schedule testade
matematik.RollCall();
kim.Schedule();

// testar ingen krasch och Leave, Remove
matematik.Remove(linnea);
linnea.Leave(matematik);

// uppdaterad lista av studenter i matematik
matematik.RollCall();

*/
