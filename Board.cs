using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Drawing;

namespace Checkers
{
    public class Board
    {/*
      * Класс Board отвечает за действия на доске. Содержит клетки, информацию о фигурах на доске.
      * Присутствует расчет и выбор хода компьютера.
      */
        public Board()
        {
            #region Dict Of Cells
            Cell A1 = new Cell(BLACK, "A1");
            dictOfCells.Add(A1.CellName, A1);
            Cell B1 = new Cell(WHITE, "B1");
            dictOfCells.Add(B1.CellName, B1);
            Cell C1 = new Cell(BLACK, "C1");
            dictOfCells.Add(C1.CellName, C1);
            Cell D1 = new Cell(WHITE, "D1");
            dictOfCells.Add(D1.CellName, D1);
            Cell E1 = new Cell(BLACK, "E1");
            dictOfCells.Add(E1.CellName, E1);
            Cell F1 = new Cell(WHITE, "F1");
            dictOfCells.Add(F1.CellName, F1);
            Cell G1 = new Cell(BLACK, "G1");
            dictOfCells.Add(G1.CellName, G1);
            Cell H1 = new Cell(WHITE, "H1");
            dictOfCells.Add(H1.CellName, H1);
            
            Cell H2 = new Cell(BLACK, "H2");
            dictOfCells.Add(H2.CellName, H2);
            Cell G2 = new Cell(WHITE, "G2");
            dictOfCells.Add(G2.CellName, G2);
            Cell F2 = new Cell(BLACK, "F2");
            dictOfCells.Add(F2.CellName, F2);
            Cell E2 = new Cell(WHITE, "E2");
            dictOfCells.Add(E2.CellName, E2);
            Cell D2 = new Cell(BLACK, "D2");
            dictOfCells.Add(D2.CellName, D2);
            Cell C2 = new Cell(WHITE, "C2");
            dictOfCells.Add(C2.CellName, C2);
            Cell B2 = new Cell(BLACK, "B2");
            dictOfCells.Add(B2.CellName, B2);
            Cell A2 = new Cell(WHITE, "A2");
            dictOfCells.Add(A2.CellName, A2);
            
            Cell A3 = new Cell(BLACK, "A3");
            dictOfCells.Add(A3.CellName, A3);
            Cell B3 = new Cell(WHITE, "B3");
            dictOfCells.Add(B3.CellName, B3);
            Cell C3 = new Cell(BLACK, "C3");
            dictOfCells.Add(C3.CellName, C3);
            Cell D3 = new Cell(WHITE, "D3");
            dictOfCells.Add(D3.CellName, D3);
            Cell E3 = new Cell(BLACK, "E3");
            dictOfCells.Add(E3.CellName, E3);
            Cell F3 = new Cell(WHITE, "F3");
            dictOfCells.Add(F3.CellName, F3);
            Cell G3 = new Cell(BLACK, "G3");
            dictOfCells.Add(G3.CellName, G3);
            Cell H3 = new Cell(WHITE, "H3");
            dictOfCells.Add(H3.CellName, H3);
            
            Cell H4 = new Cell(BLACK, "H4");
            dictOfCells.Add(H4.CellName, H4);
            Cell G4 = new Cell(WHITE, "G4");
            dictOfCells.Add(G4.CellName, G4);
            Cell F4 = new Cell(BLACK, "F4");
            dictOfCells.Add(F4.CellName, F4);
            Cell E4 = new Cell(WHITE, "E4");
            dictOfCells.Add(E4.CellName, E4);
            Cell D4 = new Cell(BLACK, "D4");
            dictOfCells.Add(D4.CellName, D4);
            Cell C4 = new Cell(WHITE, "C4");
            dictOfCells.Add(C4.CellName, C4);
            Cell B4 = new Cell(BLACK, "B4");
            dictOfCells.Add(B4.CellName, B4);
            Cell A4 = new Cell(WHITE, "A4");
            dictOfCells.Add(A4.CellName, A4);
            
            Cell A5 = new Cell(BLACK, "A5");
            dictOfCells.Add(A5.CellName, A5);
            Cell B5 = new Cell(WHITE, "B5");
            dictOfCells.Add(B5.CellName, B5);
            Cell C5 = new Cell(BLACK, "C5");
            dictOfCells.Add(C5.CellName, C5);
            Cell D5 = new Cell(WHITE, "D5");
            dictOfCells.Add(D5.CellName, D5);
            Cell E5 = new Cell(BLACK, "E5");
            dictOfCells.Add(E5.CellName, E5);
            Cell F5 = new Cell(WHITE, "F5");
            dictOfCells.Add(F5.CellName, F5);
            Cell G5 = new Cell(BLACK, "G5");
            dictOfCells.Add(G5.CellName, G5);
            Cell H5 = new Cell(WHITE, "H5");
            dictOfCells.Add(H5.CellName, H5);
           
            Cell H6 = new Cell(BLACK, "H6");
            dictOfCells.Add(H6.CellName, H6);
            Cell G6 = new Cell(WHITE, "G6");
            dictOfCells.Add(G6.CellName, G6);
            Cell F6 = new Cell(BLACK, "F6");
            dictOfCells.Add(F6.CellName, F6);
            Cell E6 = new Cell(WHITE, "E6");
            dictOfCells.Add(E6.CellName, E6);
            Cell D6 = new Cell(BLACK, "D6");
            dictOfCells.Add(D6.CellName, D6);
            Cell C6 = new Cell(WHITE, "C6");
            dictOfCells.Add(C6.CellName, C6);
            Cell B6 = new Cell(BLACK, "B6");
            dictOfCells.Add(B6.CellName, B6);
            Cell A6 = new Cell(WHITE, "A6");
            dictOfCells.Add(A6.CellName, A6);
            
            Cell A7 = new Cell(BLACK, "A7");
            dictOfCells.Add(A7.CellName, A7);
            Cell B7 = new Cell(WHITE, "B7");
            dictOfCells.Add(B7.CellName, B7);
            Cell C7 = new Cell(BLACK, "C7");
            dictOfCells.Add(C7.CellName, C7);
            Cell D7 = new Cell(WHITE, "D7");
            dictOfCells.Add(D7.CellName, D7);
            Cell E7 = new Cell(BLACK, "E7");
            dictOfCells.Add(E7.CellName, E7);
            Cell F7 = new Cell(WHITE, "F7");
            dictOfCells.Add(F7.CellName, F7);
            Cell G7 = new Cell(BLACK, "G7");
            dictOfCells.Add(G7.CellName, G7);
            Cell H7 = new Cell(WHITE, "H7");
            dictOfCells.Add(H7.CellName, H7);
            
            Cell H8 = new Cell(BLACK, "H8");
            dictOfCells.Add(H8.CellName, H8);
            Cell G8 = new Cell(WHITE, "G8");
            dictOfCells.Add(G8.CellName, G8);
            Cell F8 = new Cell(BLACK, "F8");
            dictOfCells.Add(F8.CellName, F8);
            Cell E8 = new Cell(WHITE, "E8");
            dictOfCells.Add(E8.CellName, E8);
            Cell D8 = new Cell(BLACK, "D8");
            dictOfCells.Add(D8.CellName, D8);
            Cell C8 = new Cell(WHITE, "C8");
            dictOfCells.Add(C8.CellName, C8);
            Cell B8 = new Cell(BLACK, "B8");
            dictOfCells.Add(B8.CellName, B8);
            Cell A8 = new Cell(WHITE, "A8");
            dictOfCells.Add(A8.CellName, A8);

            #endregion

            #region ListOfWhiteCheckerLocations

            //listOfWhiteCheckerLocations.Add("A1");
            //listOfWhiteCheckerLocations.Add("A3");
            //listOfWhiteCheckerLocations.Add("B2");
            //listOfWhiteCheckerLocations.Add("C1");
            //listOfWhiteCheckerLocations.Add("C3");
            //listOfWhiteCheckerLocations.Add("D2");
            //listOfWhiteCheckerLocations.Add("E1");
            //listOfWhiteCheckerLocations.Add("E3");
            //listOfWhiteCheckerLocations.Add("F2");
            //listOfWhiteCheckerLocations.Add("G1");
            //listOfWhiteCheckerLocations.Add("G3");
            //listOfWhiteCheckerLocations.Add("H2");
            //#endregion
            //#region ListOfBlackCheckerLocations

            //listOfBlackCheckerLocations.Add("A7");
            //listOfBlackCheckerLocations.Add("B6");
            //listOfBlackCheckerLocations.Add("B8");
            //listOfBlackCheckerLocations.Add("C7");
            //listOfBlackCheckerLocations.Add("D6");
            //listOfBlackCheckerLocations.Add("D8");
            //listOfBlackCheckerLocations.Add("E7");
            //listOfBlackCheckerLocations.Add("F6");
            //listOfBlackCheckerLocations.Add("F8");
            //listOfBlackCheckerLocations.Add("G7");
            //listOfBlackCheckerLocations.Add("H6");
            //listOfBlackCheckerLocations.Add("H8");
            #endregion

            #region List of white checkers

            //Checker checker1 = new Checker(WHITE, "A1");
            //listOfWhiteCheckers.Add(checker1);
            //Checker checker2 = new Checker(WHITE, "A3");
            //listOfWhiteCheckers.Add(checker2);
            //Checker checker3 = new Checker(WHITE, "B2");
            //listOfWhiteCheckers.Add(checker3);
            //Checker checker4 = new Checker(WHITE, "C1");
            //listOfWhiteCheckers.Add(checker4);
            //Checker checker5 = new Checker(WHITE, "C3");
            //listOfWhiteCheckers.Add(checker5);
            //Checker checker6 = new Checker(WHITE, "D2");
            //listOfWhiteCheckers.Add(checker6);
            //Checker checker7 = new Checker(WHITE, "E1");
            //listOfWhiteCheckers.Add(checker7);
            //Checker checker8 = new Checker(WHITE, "E3");
            //listOfWhiteCheckers.Add(checker8);
            //Checker checker9 = new Checker(WHITE, "F2");
            //listOfWhiteCheckers.Add(checker9);
            //Checker checker10 = new Checker(WHITE, "G1");
            //listOfWhiteCheckers.Add(checker10);
            //Checker checker11 = new Checker(WHITE, "G3");
            //listOfWhiteCheckers.Add(checker11);
            //Checker checker12 = new Checker(WHITE, "H2");
            //listOfWhiteCheckers.Add(checker12);
            #endregion
            #region List of black checkers

            //Checker checker13 = new Checker(BLACK, "A7");
            //listOfBlackCheckers.Add(checker13);
            //Checker checker14 = new Checker(BLACK, "B6");
            //listOfBlackCheckers.Add(checker14);
            //Checker checker15 = new Checker(BLACK, "B8");
            //listOfBlackCheckers.Add(checker15);
            //Checker checker16 = new Checker(BLACK, "C7");
            //listOfBlackCheckers.Add(checker16);
            //Checker checker17 = new Checker(BLACK, "D6");
            //listOfBlackCheckers.Add(checker17);
            //Checker checker18 = new Checker(BLACK, "D8");
            //listOfBlackCheckers.Add(checker18);
            //Checker checker19 = new Checker(BLACK, "E7");
            //listOfBlackCheckers.Add(checker19);
            //Checker checker20 = new Checker(BLACK, "F6");
            //listOfBlackCheckers.Add(checker20);
            //Checker checker21 = new Checker(BLACK, "F8");
            //listOfBlackCheckers.Add(checker21);
            //Checker checker22 = new Checker(BLACK, "G7");
            //listOfBlackCheckers.Add(checker22);
            //Checker checker23 = new Checker(BLACK, "H6");
            //listOfBlackCheckers.Add(checker23);
            //Checker checker24 = new Checker(BLACK, "H8");
            //listOfBlackCheckers.Add(checker24);
            #endregion
           
            
        }

        public bool IsStartMove = false;
        public Move currentMove = new Move();
        public Dictionary<string, Cell> dictOfCells = new Dictionary<string, Cell>();
        public string[] massOfWhiteCheckerLocations = new string[12];
        public string[] massOfBlackCheckerLocations = new string[12];
       
        public Move ComputerMove() // Основной метод, содержащий распределение функциональности
        {
            Move currentMove = new Move();
            List<Move> listOfMoves = new List<Move>();
            GetListOfMoves(listOfMoves, BLACK);
            currentMove = Estimate(listOfMoves);
            currentMove.ColorOfMovedChecker = BLACK;
            return currentMove;
        }

        public void ChangeOfMassOfCheckers(Move curMove)
        {
            for (int i = 0; i < 12 ; i++)
            {
                if (curMove.ColorOfMovedChecker == BLACK)
                {
                    if (massOfBlackCheckerLocations[i] == curMove.MoveFrom)
                    {
                        dictOfCells[massOfBlackCheckerLocations[i]].IsChecker = false;
                        massOfBlackCheckerLocations[i] = curMove.MoveTo;
                        dictOfCells[massOfBlackCheckerLocations[i]].IsChecker = true;
                        dictOfCells[massOfBlackCheckerLocations[i]].CheckColor = BLACK;
                        break;
                    }
                }
                if (curMove.ColorOfMovedChecker == WHITE)
                {
                    if (massOfWhiteCheckerLocations[i] == curMove.MoveFrom)
                    {
                        dictOfCells[massOfWhiteCheckerLocations[i]].IsChecker = false;
                        massOfWhiteCheckerLocations[i] = curMove.MoveTo;
                        dictOfCells[massOfWhiteCheckerLocations[i]].IsChecker = true;
                        dictOfCells[massOfWhiteCheckerLocations[i]].CheckColor = WHITE;
                        break;
                    }
                }
            }
        }

        public bool IsAttackElse(Move curMove)
        {
            bool flag = false;
            string beginLocation = curMove.MoveFrom;
            curMove.MoveFrom = curMove.MoveTo;
            Point moveFromPoint = new Point(dictOfCells[curMove.MoveFrom].coord.X, dictOfCells[curMove.MoveFrom].coord.Y);
            for (int x = moveFromPoint.X - 2; x <= moveFromPoint.X + 2; x += 4)
            {
                for (int y = moveFromPoint.Y - 2; y <= moveFromPoint.Y + 2; y += 4)
                {
                    Point tempEndLocationPoint = new Point(x, y);
                    if (IsOnBoard(tempEndLocationPoint))
                    {
                        curMove.MoveTo = GetLocation(tempEndLocationPoint);
                        if (curMove.MoveTo == beginLocation)
                            break;
                        IsAttack(curMove);
                        if (curMove.IsAttack)
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                if (flag == true)
                    break;
            }
            return flag;
        }

        public void IsAttack(Move curMove)
        {
            string locationOdDeletedChecker = curMove.LocationOfdeletedChecker;
            if ((dictOfCells[curMove.MoveFrom].coord.X - dictOfCells[curMove.MoveTo].coord.X == 2
                ||
                dictOfCells[curMove.MoveFrom].coord.X - dictOfCells[curMove.MoveTo].coord.X == -2)
                &&
                dictOfCells[locationOdDeletedChecker].IsChecker == true
                &&
                dictOfCells[locationOdDeletedChecker].CheckColor == BLACK
                &&
                IsEmptyLocation(curMove.MoveTo))
            {
                curMove.LocationOfdeletedChecker = locationOdDeletedChecker;
                curMove.IsAttack = true;
            }
            else
            {
                curMove.IsAttack = false;
                curMove.LocationOfdeletedChecker = null;
            }
           
        }

        public bool IsAttackMove
        {
            get { return _isAttackMove; }
            set { _isAttackMove = value; }
        } // ???

        private Move Estimate(List<Move> lstOfMoves)
        {
            Move resMove = new Move();
            resMove.EstimateOfProfit = 0;
            foreach (Move item in lstOfMoves) // check IsAttackMove
            {
                if (item.EstimateOfProfit > resMove.EstimateOfProfit)
                {
                    resMove = item;
                }
            }
            return resMove;
        }

        private void GetListOfMoves(List<Move> lstOfMoves, string colorOfMovedCheckers) // Получение списка ходов всех шашек
        {
            for (int i = 0; i < 12; i++)
            {
                if(colorOfMovedCheckers == BLACK)
                {
                    if (massOfBlackCheckerLocations[i] != null)
                    {
                        GetMovesOfChecker(massOfBlackCheckerLocations[i], dictOfCells[massOfBlackCheckerLocations[i]].CheckColor, lstOfMoves);
                        Move curMove = new Move();
                        curMove.ColorOfMovedChecker = dictOfCells[massOfBlackCheckerLocations[i]].CheckColor;
                        curMove.MoveFrom = massOfBlackCheckerLocations[i];
                        GetAttackMovesOfChecker(curMove);
                        if(curMove.IsAttack)
                            lstOfMoves.Add(curMove);
                    }
                }
                if (colorOfMovedCheckers == WHITE)
                { 
                
                }
            }
        }

        private void GetMovesOfChecker(string locationFrom, string checkerColor, List<Move> lstOfMoves) // Получение ходов конкретной шашки
        {
            Move curMove = new Move();
            curMove.ColorOfMovedChecker = checkerColor;
            curMove.MoveFrom = locationFrom;
            Point moveFromPoint = new Point(dictOfCells[locationFrom].coord.X, dictOfCells[locationFrom].coord.Y);
            Point tempEndLocationPoint = new Point();
            for (int x = moveFromPoint.X - 1; x <= moveFromPoint.X + 1 ; x+=2)
            {
                for (int y = moveFromPoint.Y - 1; y <= moveFromPoint.Y + 1; y+=2)
                {
                    tempEndLocationPoint = new Point(x, y);
                    if (IsOnBoard(tempEndLocationPoint))
                    {
                        curMove.MoveTo = GetLocation(tempEndLocationPoint);
                        if (IsValidMove(curMove))                   // Обычный ход, удовлетворяющий правилам игры 
                        {
                            curMove.EstimateOfProfit = 0.5;
                            lstOfMoves.Add(curMove.Clone() as Move);
                        }
                    }
                }
            }
        }

        private void GetAttackMovesOfChecker(Move curMove)  // Есть возможность и потребность разделить этот мето на более мелкие ( например можно вынести логику определения IsMultiKill, этот метод также потребуется для пользовательского хода)
        {   
            Point moveFromPoint = new Point(dictOfCells[curMove.MoveFrom].coord.X, dictOfCells[curMove.MoveFrom].coord.Y);
            Point tempEndLocationPoint = new Point();
            for (int x = moveFromPoint.X - 2; x <= moveFromPoint.X + 2; x+=4)
            {
                for (int y = moveFromPoint.Y - 2; y <= moveFromPoint.Y + 2; y+=4)
                {
                    tempEndLocationPoint = new Point(x, y);
                    if (IsOnBoard(tempEndLocationPoint))
                    {
                        curMove.MoveTo = GetLocation(tempEndLocationPoint);
                        if (!IsNewLocationOfMultiAttack(curMove))
                            break;
                        if (IsValidAttackMove(curMove))                   // Обычный ход, удовлетворяющий правилам игры 
                        {
                            if (curMove.endLocations == null) curMove.endLocations = curMove.MoveFrom + "-" + curMove.MoveTo + "-";
                            else
                            {
                                curMove.endLocations += curMove.MoveTo + "-";
                            }
                            curMove.EstimateOfProfit += 1.0;
                            curMove.MoveFrom = curMove.MoveTo;
                            GetAttackMovesOfChecker(curMove);
                            curMove.IsAttack = true;   //----------------------------------<<<       // Это реально нужно???
                            break;
                        }
                    }
                }
                if (curMove.IsAttack)
                    break;
            }
        }

        private bool IsValidMove(Move checkedMove)              // Проверка хода на соответствие правилам игры
        {
            bool validFlag = false;
            bool checkerValidflag = IsCheckersMove(checkedMove);
            bool emptylocationTo = IsEmptyLocation(checkedMove.MoveTo);
            if(checkerValidflag && emptylocationTo)
            {
                validFlag = true;
            }
            else
            {
            
            }
            return validFlag;
        }

        private bool IsCheckersMove(Move checkedMove)       // Проверка валидности хода по правилам для шашки
        {
            bool validFlag = false;
            if (dictOfCells[checkedMove.MoveFrom].coord.Y - dictOfCells[checkedMove.MoveTo].coord.Y == 1
                &&
                (dictOfCells[checkedMove.MoveTo].coord.X - dictOfCells[checkedMove.MoveFrom].coord.X == 1
                 ||
                  dictOfCells[checkedMove.MoveFrom].coord.X - dictOfCells[checkedMove.MoveTo].coord.X == 1))
            {
                validFlag = true;
            }
            return validFlag;
        }

        private bool IsNewLocationOfMultiAttack(Move curMove)
        {
            bool flag = false;
            if(curMove.endLocations != null)
                flag = curMove.endLocations.Contains(curMove.MoveTo);       // exception null reference           
            return !flag;
        }

        private bool IsEmptyLocation(string location)       // Проверка на пустоту клетки
        {
            bool validFlag = false;
            if (!dictOfCells[location].IsChecker)
            {
                validFlag = true;
            }

            return validFlag;
        }

        private bool IsValidAttackMove(Move checkedMove)        // Проверка на атакующий ход
        {
            if (checkedMove.MoveTo == "G5")
            {
                ;
            }
            bool validFlag = false;
            Point endLocationPoint =  new Point (dictOfCells[checkedMove.MoveTo].coord.X, dictOfCells[checkedMove.MoveTo].coord.Y); // Положение шашки после атаки
            //string endLocationString = checkedMove.MoveTo;
            Point deletedLocationPoint = GetPointDeletedCheckerLocation(checkedMove);
            if (IsEmptyLocation(checkedMove.MoveTo)
                &&
                !IsEmptyLocation(GetLocation(deletedLocationPoint))
                &&
                dictOfCells[GetLocation(deletedLocationPoint)].CheckColor == WHITE)
            {
                validFlag = true;// кандидат на атакующий ход
            }
            
            return validFlag;
        }

        private Point GetPointDeletedCheckerLocation(Move attackMove)     // Расчет положения шашки после атакующего хода
        {
            int newX = (dictOfCells[attackMove.MoveTo].coord.X + dictOfCells[attackMove.MoveFrom].coord.X)/2;
            int newY = (dictOfCells[attackMove.MoveTo].coord.Y + dictOfCells[attackMove.MoveFrom].coord.Y)/2; ;
            Point deletedCheckerLocationPoint = new Point(newX, newY);
            return deletedCheckerLocationPoint;
        }

        private bool IsCheckersAttackMove(Move checkedMove)             // Проверка на атакующий ход шашки
        {
            bool validFlag = false;
            // Проверка атакующего хода во все четыре стороны
            if ((dictOfCells[checkedMove.MoveFrom].coord.Y - dictOfCells[checkedMove.MoveTo].coord.Y == 1
                ||
                dictOfCells[checkedMove.MoveTo].coord.Y - dictOfCells[checkedMove.MoveFrom].coord.Y == 1)
                &&
                (dictOfCells[checkedMove.MoveTo].coord.X - dictOfCells[checkedMove.MoveFrom].coord.X == 1
                 ||
                  dictOfCells[checkedMove.MoveFrom].coord.X - dictOfCells[checkedMove.MoveTo].coord.X == 1))
            {
                validFlag = true;
            }
            return validFlag;
        }

        private bool IsOnBoard(Point curPoint) // Решить где использовать этот метод *_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*______????
        { 
            bool flag = false;
            if (curPoint.X >= 1 && curPoint.X <= 8)
                if (curPoint.Y >= 1 && curPoint.Y <= 8)
                    flag = true;
            return flag;
        }

        private bool IsOnBoard(string location)
        {
            bool flag = false;
            Point curPoint = new Point(dictOfCells[location].coord.X, dictOfCells[location].coord.Y);
            if (curPoint.X >= 1 && curPoint.X <= 8)
                if (curPoint.Y >= 1 && curPoint.Y <= 8)
                    flag = true;
            return flag;
        }

        private bool IsAllowMove(int x, int y, string colorOfMovedChecker)
        {
            bool flag = false;
            return flag;
        }   // ???

        private string GetLocation(Point curPoint)
        {
            string resLocation;
            char tempCharX = (char)(curPoint.X + 64);
            char tempCharY = (char)(curPoint.Y + 48);
            resLocation = tempCharX.ToString() + tempCharY.ToString();
            return resLocation;
        }

        private bool _isAttackMove = false;
        private const string WHITE = "white";
        private const string BLACK = "black";
        private Controller myContr = new Controller();

        private void RefreshState()
        { 
        
        }

        private void CreateNewGame()
        { 
        
        }

        

        private void KillFigure()
        { 
        
        }

        
    }
}
