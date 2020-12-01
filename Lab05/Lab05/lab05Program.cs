namespace Lab05
{
    class Program
    {
        static void Main(string[] args, int trickname)
        {
            Dog myDog = new Dog();
            myDog.Name = "Fido";

            myDog.bark();
            System.Console.WriteLine("Fido is barking");

            myDog.doTrick("Fetch");
            int trickname = 1;
            System.Console.WriteLine("Fido is so smart! Fido is doing a(n) {1}");

        }
    }
}
//a. The scope is public.
//b. Static is a method applied to a class. In the example, it is is public
//c. Return type determines the type of value returned, which is getArea.
//d. Identifier sets pretense, and is getArea.
//e. Parameters set the limits, and are height mulitplied by width.
//f. Method body is {return height * widths}
// User defined methods are cutom and handwritten, while framework provided methods have a set platform/frame.
// Static variables get initiaized only once in a class, wheras non static variables are done 0 through n times.
