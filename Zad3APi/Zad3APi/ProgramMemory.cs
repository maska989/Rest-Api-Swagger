namespace Zad3APi
{
    /// <summary>
    /// Klasa z danymi Dependecy Injection
    /// 
    /// </summary>
    public class ProgramMemory
    {
        public string Test = "Test";
        public Dictionary<Guid,string> Pokoje = new Dictionary<Guid,string>();
        public Dictionary<Guid,string> Osoby = new Dictionary<Guid,string>();
        public Dictionary<Guid, Guid> Ewidencja = new Dictionary<Guid,Guid>();
        


        public ProgramMemory()
        {

           
               Pokoje.Add(Guid.NewGuid(),"101");
               Pokoje.Add(Guid.NewGuid(),"102");
               Pokoje.Add(Guid.NewGuid(),"103");
               Pokoje.Add(Guid.NewGuid(),"104");
               Pokoje.Add(Guid.NewGuid(),"105");
               Pokoje.Add(Guid.NewGuid(),"106");
                
       


            Osoby.Add(Guid.NewGuid(), "Klaudiusz Wiśniewski");
            Osoby.Add(Guid.NewGuid(), "Adrian Zieliński");
            Osoby.Add(Guid.NewGuid(), "Błażej Kołodziej");
            Osoby.Add(Guid.NewGuid(), "Dariusz Pietrzak");
            Osoby.Add(Guid.NewGuid(), "Dobromił Górski");
            Osoby.Add(Guid.NewGuid(), "Jacek Włodarczyk");
            Osoby.Add(Guid.NewGuid(), "Mirosław Krajewska");
            Osoby.Add(Guid.NewGuid(), "Dobromił Kowalski");
            Osoby.Add(Guid.NewGuid(), "Daniel Rutkowski");
            Osoby.Add(Guid.NewGuid(), "Maciej Pawlak");

            Ewidencja.Add(Pokoje.First().Key,Osoby.First().Key);

        }

    }


}
