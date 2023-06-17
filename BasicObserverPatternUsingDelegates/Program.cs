using System;
using System.Runtime.CompilerServices;

//link ref:https://www.youtube.com/watch?v=EBnBQv5tkg0&list=PLAE7FECFFFCBE1A54&index=16
//

class TrainSignal
{
    public Action TrainsAComing;
    public void HereComesATrain()
    {
        // there is a ton of logic here
        TrainsAComing();
    }
}

class Car
{
    public Car(TrainSignal trainSignal)
    {
        trainSignal.TrainsAComing += StopTheCar;
    }
    void StopTheCar()
    {
        Console.WriteLine("Screeeetch");
    }
}

class MainClass
{
    static void Main()
    {
        TrainSignal trainSignal = new TrainSignal();
        new Car(trainSignal);
        new Car(trainSignal);
        new Car(trainSignal);
        new Car(trainSignal);
        trainSignal.HereComesATrain();
        System.Console.WriteLine();
        trainSignal.HereComesATrain();
        System.Console.WriteLine();
        trainSignal.HereComesATrain();


    }
}