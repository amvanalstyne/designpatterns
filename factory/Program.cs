using factory;
Simulate();
//includes an observer pattern, 

static void Simulate(){
    CountingDuckFactory factory = new CountingDuckFactory();
    IQuackable mallardDuck = factory.CreateMallardDuck();
    IQuackable redheadDuck = factory.CreateRedheadDuck(); 
    IQuackable rubberDuck = factory.CreateRubberDuck();
    IQuackable duckCall = factory.CreateDuckCall();
    IQuackable gooseDuck = new GooseAdapter(new Goose());
    System.Console.WriteLine("Simulation Starting");
    SimulateDuckCall(mallardDuck);
    SimulateDuckCall(redheadDuck);
    SimulateDuckCall(duckCall);
    SimulateDuckCall(rubberDuck);
    SimulateDuckCall(gooseDuck);
    System.Console.WriteLine("The Ducks Quacked "+ QuackCounter.GetNumberOfQuacks() + " times.");
}

static void SimulateDuckCall(IQuackable duck){
    duck.Quack();
}