public class Person {
    private int age;
    
    public int Age {
        get { return age; }
        set { 
            if (value >= 0) {
                age = value;
            } else {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }
    }
    
    public Person(int initialAge) {
        Age = initialAge;
    }
    
    public void amIOld() {
        if (Age < 13) {
            Console.WriteLine("You are young.");
        } else if (Age < 18) {
            Console.WriteLine("You are a teenager.");
        } else {
            Console.WriteLine("You are old.");
        }
    }
    
    public void yearPasses() {
        Age++;
    }
}
