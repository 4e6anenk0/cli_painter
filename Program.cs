using System;
using CliPainter.Generators;

class Program
{
    static void Main(string[] args)
    {   
        //Heart
        Console.ForegroundColor = ConsoleColor.Red;
        HeartGenerator smallHeart = new HeartGenerator(size: 1, filler: '$', background: '•');
        smallHeart.generateHeart();
        HeartGenerator bigHeart = new HeartGenerator(size: 5, filler: '@', background: '•');
        bigHeart.generateHeart();
        HeartGenerator cuteHeart = new HeartGenerator(size: 5, filler: '\u2665', background: '\u2661');
        cuteHeart.generateHeart();
        HeartGenerator binaryHeart = new HeartGenerator(size: 5, filler: '1', background: '0');
        binaryHeart.generateHeart();
        //Square
        SquareGenerator bigSquare = new SquareGenerator(size: 20, background: '•');
        bigSquare.generateSquare();
        //Rhombus
        RhombusGenerator bigRhombus = new RhombusGenerator(size: 10, filler: '$', background: '•');
        bigRhombus.generateRhombus(); 
        //Circle
        CircleGenerator bigCircle = new CircleGenerator(size: 10, filler:'$', background: '•' );
        bigCircle.generatorCircle();
    }
}   