using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }


        public void Run()
        {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            Console.SetCursorPosition(2, 16);

            Console.Write("player X");

            Console.SetCursorPosition(2, 17);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 18);

            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();

            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

            /////////////////////////////////////////////////////////////////////////////

            Console.SetCursorPosition(35, 16);

            Console.Write("player O");

            Console.SetCursorPosition(35, 17);

            Console.Write("Please Enter Row: ");
            row = Console.ReadLine();

            Console.SetCursorPosition(35, 18);


            Console.Write("Please Enter Column: ");
            column = Console.ReadLine();

            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);

            ///////////////////////////////////////////////////////////////////////

            Console.SetCursorPosition(2, 16);

            Console.Write("player X");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var rowe = Console.ReadLine();

            Console.SetCursorPosition(2, 21);

            Console.Write("Please Enter Column: ");
            var columne = Console.ReadLine();

            _boardRenderer.AddMove(int.Parse(rowe), int.Parse(columne), PlayerEnum.X, true);

            //////////////////////////////////////////////////////////////////////

            Console.SetCursorPosition(35, 16);

            Console.Write("player O");

            Console.SetCursorPosition(35, 20);

            Console.Write("Please Enter Row: ");
            row = Console.ReadLine();

            Console.SetCursorPosition(35, 21);


            Console.Write("Please Enter Column: ");
            column = Console.ReadLine();

            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);

            //////////////////////////////////////////////////////////////////////////////

            Console.SetCursorPosition(2, 16);

            Console.Write("player X");

            Console.SetCursorPosition(2, 23);

            Console.Write("Please Enter Row: ");
            var rowv = Console.ReadLine();

            Console.SetCursorPosition(2, 24);

            Console.Write("Please Enter Column: ");
            var columnv = Console.ReadLine();

            _boardRenderer.AddMove(int.Parse(rowv), int.Parse(columnv), PlayerEnum.X, true);



            ///////////////////////////////////////////////////////////////////////////////////

            Console.SetCursorPosition(35, 16);

            Console.Write("player O");

            Console.SetCursorPosition(35, 23);

            Console.Write("Please Enter Row: ");
            row = Console.ReadLine();

            Console.SetCursorPosition(35, 24);


            Console.Write("Please Enter Column: ");
            column = Console.ReadLine();

            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);


        }
        





    }

   
}  
