namespace CliPainter.Generators
{


    class CircleGenerator
    {
        public int size;
        public char filler;
        public char background;

        public CircleGenerator(int size, char filler, char background)
        {
            this.size = size;
            this.filler = filler;
            this.background = background;
        }

        public void generatorCircle()
        {
            if (size <= 0)
                return;

            int diameter = 2 * size;
            int centerX = size -1;
            int centerY = size -1;

            for (int y = 0; y < diameter; y++)
            {
                char[] i = new char[diameter];
                Array.Fill(i, background);

                for (int x = 0; x < diameter; x++)
                {
                    int dx = x - centerX;
                    int dy = y - centerY;
                    double distance = Math.Sqrt(dx * dx + dy * dy);

                    if (distance <= size - 0.5)
                    {
                        i[x] = filler;
                    } 
                }
                Console.WriteLine(new string(i));
            }
        }
    }
}