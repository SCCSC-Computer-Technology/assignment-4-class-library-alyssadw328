namespace AWalker_Lab4
{
    //Alyssa Walker
    //CPT 206
    //Lab 4 - Class Library
    public class State
    {
        //create a state class and include all properties
        public int StateID { get; set; }
        public string StateName { get; set; }
        public int Population { get; set; }
        public string StateFlag { get; set; }
        public string StateFlower { get; set; }
        public string StateBird { get; set; }
        public string StateColors { get; set; }
        public string LargestCities { get; set; }
        public string StateCapitol { get; set; }
        public int MedianIncome { get; set; }
        public float ComputerJobs { get; set; }

       
        //constructor initializing properties
        public State(int stateID, string stateName, int population, string stateFlag, string stateFlower, string stateBird, string stateColors, string largestCities, string stateCapitol, int medianIncome, float computerJobs)
        {
            StateID = stateID;
            StateName = stateName;
            Population = population;
            StateFlag = stateFlag;
            StateFlower = stateFlower;
            StateBird = stateBird;
            StateColors = stateColors;
            LargestCities = largestCities;
            StateCapitol = stateCapitol;
            MedianIncome = medianIncome;
            ComputerJobs = computerJobs;
        }
    }
}
