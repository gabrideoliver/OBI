 int x0a1 = 3, y0a1 = 4, x1a1 = 3, y1a1 = 4, x0a2 = 2, y0a2 = 3, x1a2 = 2, y1a2 = 3;

            bool saida;

            if (x0a1 <= x0a2 && y0a1 <= y0a2 && x1a1 <= x1a2 && y1a1 <= y1a2 && x1a1 >= y0a2 && y1a1 >= x0a2  )
            {
                saida = true;
            }
             else 
            { 
             saida  = false;
            }
          
            Console.WriteLine(saida);
