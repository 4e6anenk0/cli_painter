namespace CliPainter.Generators
{

 class HeartGenerator
 {
    public int size;
    public char filler;
    public char background;

    public HeartGenerator(int size, char filler, char background) {
        this.size = size;
        this.filler = filler;
        this.background = background;
    }
    public void generateHeart()
    {
        if (size <= 0)
            return;
        int width = 5 * size - 2;
        char[] buf = new char[width];
        for (int i = 1 - size; i < (width + 1) / 2; i++)
        {
            int outer = Math.Abs(i), center = 2 - size - 2 * i;
            Array.Fill(buf, filler);
            Array.Fill(buf, background, 0, outer);
            
            Array.Fill(buf, background, width - outer, width - (width - outer));
            if (center > 0)
                Array.Fill(buf, background, (width - center) / 2, ((width + center) / 2) - ((width - center) / 2));
        
            Console.WriteLine(buf);
        }
    }
 }

}
