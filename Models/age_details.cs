namespace age_mate.Models
{
    public class age_details
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int total { get; set; }

        public age_details() 
        {
           num1  = 20;
            num2 = 31;
            total = num1+num2;
        }
    }
}
