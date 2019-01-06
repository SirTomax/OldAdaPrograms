using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopSign_Almost
{
    class Program
    {
        // Method to draw a characters
        static void Draw_Chars(char ch, int iter)
        {
            for(int i = 1; i <= iter; i++)
            { Console.Write(ch);};
        }

        // Method to draw an entier row
        static void Draw_Row(char Bef_ch, int Bef, char First_ch, int Between, char Between_ch, char last_ch, bool Elon)
        {
            Draw_Chars(Bef_ch, Bef); // Draw characters before first
            Console.Write(First_ch); // Draw starting char 
            Draw_Chars(Between_ch,Between); // Draw content chars, between first and last
            Console.Write(last_ch); // Draw last char
            if (Elon == true) // New line ?
                Console.Write("\n");
        }

        // Main method
        static void Main(string[] args)
        {
            while (true)
            {
                int main_iter = 2;

                // Get user input
                Console.Write("Enter an integer between 1 and 14: ");
                main_iter = Convert.ToInt32(Console.ReadLine());

                // Draw top of stop sign
                Draw_Row(' ', main_iter * 2, '+', main_iter * 4 - 1, '-', '+', true);

                // draw row 2 to row n-1 of stop sign (the content)
                for (int i = 1; i <= main_iter; i++)
                {
                    Draw_Row(' ', 0, ' ', main_iter * 2 - 1, ' ', '|', false);
                    Draw_Row(' ', main_iter - 1, ' ', main_iter * 2 - 2, 'S', 'S', false);
                    Draw_Row(' ', main_iter, '|', main_iter * 2 - 1, ' ', ' ', true);
                }

                // Draw last row -> Bottom of stop sign
                Draw_Row(' ', main_iter * 2, '+', main_iter * 4 - 1, '-', '+', true);
            }
        }
    }
}
