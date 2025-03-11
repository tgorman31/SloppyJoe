namespace SloppyJoe;

class MenuItem
{
    public string[] Proteins = ["Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu"];
    public string[] Condiments = ["yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "French dressing"];
    public string[] Breads = ["rye", "white", "wheat", "pumpernickel", "a roll"];

    public string Description = "";
    public string Price = "";

    public void Generate()
    {
        string selectedProteins = Proteins[Random.Shared.Next(Proteins.Length)];
        string selectedCondiments = Condiments[Random.Shared.Next(Condiments.Length)];
        string selectedBreads = Breads[Random.Shared.Next(Breads.Length)];

        Description = $"{selectedProteins} with {selectedCondiments} on {selectedBreads}";

        Price = (Random.Shared.NextDouble()* 10 + 5).ToString("c");
    }
}
