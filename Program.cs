

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

Console.WriteLine("\n");

void TestaBadaHallen()
{
    Console.WriteLine("Testar att båda hållen hänger ihop");

    Course matematik = new("Matematik", 3);
    Course svenska = new("Svenska", 3);
    Student kim = new("Kim");
    Student linnea = new("Linnea");

    kim.Join(matematik);       // via studenten
    svenska.Enroll(kim);       // via kursen – välkomstmeddelande
    matematik.Enroll(linnea);  // välkomstmeddelande

    Console.WriteLine(matematik);  // Matematik (2 / 3 platser)
    matematik.RollCall();          // Kim, Linnea
    Console.WriteLine(svenska);    // Svenska (1 / 3 platser)
    svenska.RollCall();            // Kim

    Console.WriteLine("Kims schema:");
    kim.Schedule();                // Matematik, Svenska
    Console.WriteLine("Linneas schema:");
    linnea.Schedule();             // Matematik

    kim.Leave(svenska);            // Kim lämnar via studenten
    Console.WriteLine(svenska);    // Svenska (0 / 3 platser) – borta även ur kursen
    Console.WriteLine("Kims schema efter Leave:");
    kim.Schedule();                // bara Matematik
}
TestaBadaHallen();
