using System;

namespace FacadeStructural {
    class MainApp {
        static void Main() {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            //Wait for user
            Console.ReadKey();
        }
    }
}