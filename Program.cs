class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input x1 = : ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Input y1 = : ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Input w1 = : ");
        double w1 = double.Parse(Console.ReadLine());
        Console.Write("Input h1 = : ");
        double h1 = double.Parse(Console.ReadLine());
        Console.Write("Input x2 = : ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Input y2 = : ");
        double y2 = double.Parse(Console.ReadLine());
        Console.Write("Input w2 = : ");
        double w2 = double.Parse(Console.ReadLine());
        Console.Write("Input h2 = : ");
        double h2 = double.Parse(Console.ReadLine());

        double left1 = x1 - w1 /2 ;
        double left2 = x2 - w2 /2 ;
        double overlapleft = Math.Max(left1,left2);
        double right1 = x1 + w1 /2 ;
        double right2 = x2 + w2 /2 ;
        double overlapright = Math.Min(right1,right2);
        double top1 = y1 - h1 /2 ;
        double top2 = y2 - h2 /2 ;
        double overlaptop = Math.Max(top1,top2);
        double bottom1 = y1 + h1 /2;
        double bottom2 = y2 + h2 /2;
        double overlapbottom = Math.Min(bottom1,bottom2);
        double overlapw = overlapright - overlapleft;
        double overlaph = overlapbottom - overlaptop;
        double overlapmeasure = overlapw * overlaph;
        if(overlapmeasure >= 8){
            Console.WriteLine("Too Much Overlapping");
        }
        else if(overlapw <= 0 && overlaph <= 0){
            Console.WriteLine("No Overlapping");
        }
        else  {
            Console.WriteLine("Not Much Overlapping");
        }
    }
}