namespace MC_EightToTenEndpoints.Services.RestarauntPicker;
public class RestarauntPickerService : IRestarauntPickerService
{
    public string RestarauntPickerMachine(string category)
    {

        string[] restaurants = new string[10];

        switch (category.ToUpper())
        {
            case "AMERICAN":
                restaurants[0] = "In n Out";
                restaurants[1] = "McDonalds";
                restaurants[2] = "Denny's";
                restaurants[3] = "Black Bear";
                restaurants[4] = "IHOP";
                restaurants[5] = "Apple Bees";
                restaurants[6] = "Raisin Canes";
                restaurants[7] = "Chick Fil a";
                restaurants[8] = "Habit";
                restaurants[9] = "Jack in the Box";
                break;
            case "MEXICAN":
                restaurants[0] = "Taco Bell";
                restaurants[1] = "El Pollo Loco";
                restaurants[2] = "Del Taco";
                restaurants[3] = "Las Casuelas";
                restaurants[4] = "Chipotle";
                restaurants[5] = "La Costa";
                restaurants[6] = "El Jardin";
                restaurants[7] = "La Estrella";
                restaurants[8] = "Tatos";
                restaurants[9] = "Arroyos";
                break;
            case "ASIAN":
                restaurants[0] = "Panda Express";
                restaurants[1] = "Chinese Express for Less";
                restaurants[2] = "Kitty's Kitchen";
                restaurants[3] = "Forum Dynasty";
                restaurants[4] = "The Pho";
                restaurants[5] = "Beijing Buffet";
                restaurants[6] = "Swagat";
                restaurants[7] = "Dave Wong's";
                restaurants[8] = "GK bbq";
                restaurants[9] = "Mandarin Villa Express";
                break;
            default:
                return "Not a valid input. Please select American, Mexican, or Asian as a category";
        }

        Random generator = new();
        int randNum = generator.Next(10);

        return $"You should go to {restaurants[randNum]}!!";
    }
}
