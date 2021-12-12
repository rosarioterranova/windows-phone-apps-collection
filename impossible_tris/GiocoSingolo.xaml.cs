﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Tris_Classic
{
    public partial class GiocoSingolo : PhoneApplicationPage
    {
        int[,] board = new int[3,3]; //matrice di cui 0 = nessun pezzo, 1 = croce, 2 = cerchio
        int turnoGiocatore=1;
        bool finePartita = false;

        public GiocoSingolo()
        {
            InitializeComponent();

            for (int i = 0; i < board.GetLength(0); i++) //riempio la matrice con 0
                for (int j = 0; j < board.GetLength(1); j++)
                    board[i,j] = 0;
        }

        public bool controlloVincitaGiocatore()
        {
            if (board[0, 0] == 1 && board[0, 1] == 1 && board[0, 2] == 1) //controllo righe
            {
                return true;
            }
            else if (board[1, 0] == 1 && board[1, 1] == 1 && board[1, 2] == 1)
            {
                return true;
            }
            else if (board[2, 0] == 1 && board[2, 1] == 1 && board[2, 2] == 1)
            {
                return true;
            }
            else if (board[0, 0] == 1 && board[1, 0] == 1 && board[2, 0] == 1) //controllo colonne
            {
                return true;
            }
            else if (board[0, 1] == 1 && board[1, 1] == 1 && board[2, 1] == 1)
            {
                return true;
            }
            else if (board[0, 2] == 1 && board[1, 2] == 1 && board[2, 2] == 1)
            {
                return true;
            }
            else if (board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 1) //controllo diagonali
            {
                return true;
            }
            else if (board[0, 2] == 1 && board[1, 1] == 1 && board[2, 0] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool controlloVincitaPC()
        {
            if (board[0, 0] == 2 && board[0, 1] == 2 && board[0, 2] == 2) //controllo righe
            {
                return true;
            }
            else if (board[1, 0] == 2 && board[1, 1] == 2 && board[1, 2] == 2)
            {
                return true;
            }
            else if (board[2, 0] == 2 && board[2, 1] == 2 && board[2, 2] == 2)
            {
                return true;
            }
            else if (board[0, 0] == 2 && board[1, 0] == 2 && board[2, 0] == 2) //controllo colonne
            {
                return true;
            }
            else if (board[0, 1] == 2 && board[1, 1] == 2 && board[2, 1] == 2)
            {
                return true;
            }
            else if (board[0, 2] == 2 && board[1, 2] == 2 && board[2, 2] == 2)
            {
                return true;
            }
            else if (board[0, 0] == 2 && board[1, 1] == 2 && board[2, 2] == 2) //controllo diagonali
            {
                return true;
            }
            else if (board[0, 2] == 2 && board[1, 1] == 2 && board[2, 0] == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool pezzoOccupato(int x, int y)
        {
            if (board[x, y] == 0)
                return false;
            else
                return true;
        }

        public bool boardPiena()
        {
            for (int i = 0; i < board.GetLength(0); i++)
                for (int j = 0; j < board.GetLength(1); j++)
                    if (board[i, j] == 0)
                        return false;
            return true;
        }

        //Click dell'utente
        private void sel00_Click(object sender, RoutedEventArgs e)
        {
            if (finePartita == false)
            {
                if (pezzoOccupato(0, 0) == false && turnoGiocatore == 1)
                {

                    croce00.Opacity = 100;
                    board[0, 0] = 1;
                    turnoGiocatore = 2;
                    if (controlloVincitaGiocatore() == true)
                    {
                        MessageBox.Show("Hai vinto!", "Complimenti", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    IA();
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (controlloVincitaPC() == true)
                    {
                        MessageBox.Show("Hai perso!", "Che peccato", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                }
            }
        }

        private void sel01_Click(object sender, RoutedEventArgs e)
        {
            if(finePartita==false)
            {
                if (pezzoOccupato(0, 1) == false && turnoGiocatore == 1)
                {

                    croce01.Opacity = 100;
                    board[0, 1] = 1;
                    turnoGiocatore = 2;
                    if (controlloVincitaGiocatore() == true)
                    {
                        MessageBox.Show("Hai vinto!", "Complimenti", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    IA();
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (controlloVincitaPC() == true)
                    {
                        MessageBox.Show("Hai perso!", "Che peccato", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                }
            }
        }

        private void sel02_Click(object sender, RoutedEventArgs e)
        {
            if(finePartita==false)
            {
                if (pezzoOccupato(0, 2) == false && turnoGiocatore == 1)
                {
                    croce02.Opacity = 100;
                    board[0, 2] = 1;
                    turnoGiocatore = 2;
                    if (controlloVincitaGiocatore() == true)
                    {
                        MessageBox.Show("Hai vinto!", "Complimenti", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    IA();
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (controlloVincitaPC() == true)
                    {
                        MessageBox.Show("Hai perso!", "Che peccato", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                }
            }
        }

        private void sel10_Click(object sender, RoutedEventArgs e)
        {
            if(finePartita==false)
            {
                if (pezzoOccupato(1, 0) == false && turnoGiocatore == 1)
                {

                    croce10.Opacity = 100;
                    board[1, 0] = 1;
                    turnoGiocatore = 2;
                    if (controlloVincitaGiocatore() == true)
                    {
                        MessageBox.Show("Hai vinto!", "Complimenti", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    IA();
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (controlloVincitaPC() == true)
                    {
                        MessageBox.Show("Hai perso!", "Che peccato", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                }
            }
        }

        private void sel11_Click(object sender, RoutedEventArgs e)
        {
            if(finePartita==false)
            {
                if (pezzoOccupato(1, 1) == false && turnoGiocatore == 1)
                {

                    croce11.Opacity = 100;
                    board[1, 1] = 1;
                    turnoGiocatore = 2;
                    if (controlloVincitaGiocatore() == true)
                    {
                        MessageBox.Show("Hai vinto!", "Complimenti", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    IA();
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (controlloVincitaPC() == true)
                    {
                        MessageBox.Show("Hai perso!", "Che peccato", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                }
            }
        }

        private void sel12_Click(object sender, RoutedEventArgs e)
        {
            if(finePartita==false)
            {
                if (pezzoOccupato(1, 2) == false && turnoGiocatore == 1)
                {

                    croce12.Opacity = 100;
                    board[1, 2] = 1;
                    turnoGiocatore = 2;
                    if (controlloVincitaGiocatore() == true)
                    {
                        MessageBox.Show("Hai vinto!", "Complimenti", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    IA();
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (controlloVincitaPC() == true)
                    {
                        MessageBox.Show("Hai perso!", "Che peccato", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                }
            }
        }

        private void sel20_Click(object sender, RoutedEventArgs e)
        {
            if(finePartita==false)
            {
                if (pezzoOccupato(2, 0) == false && turnoGiocatore == 1)
                {

                    croce20.Opacity = 100;
                    board[2, 0] = 1;
                    turnoGiocatore = 2;
                    if (controlloVincitaGiocatore() == true)
                    {
                        MessageBox.Show("Hai vinto!", "Complimenti", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    IA();
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (controlloVincitaPC() == true)
                    {
                        MessageBox.Show("Hai perso!", "Che peccato", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                }
            }
        }

        private void sel21_Click(object sender, RoutedEventArgs e)
        {
            if(finePartita==false)
            {
                if (pezzoOccupato(2, 1) == false && turnoGiocatore == 1)
                {

                    croce21.Opacity = 100;
                    board[2, 1] = 1;
                    turnoGiocatore = 2;
                    if (controlloVincitaGiocatore() == true)
                    {
                        MessageBox.Show("Hai vinto!", "Complimenti", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    IA();
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (controlloVincitaPC() == true)
                    {
                        MessageBox.Show("Hai perso!", "Che peccato", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                }
            }
        }

        private void sel22_Click(object sender, RoutedEventArgs e)
        {
            if(finePartita==false)
            {
                if (pezzoOccupato(2, 2) == false && turnoGiocatore == 1)
                {

                    croce22.Opacity = 100;
                    board[2, 2] = 1;
                    turnoGiocatore = 2;
                    if (controlloVincitaGiocatore() == true)
                    {
                        MessageBox.Show("Hai vinto!", "Complimenti", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    IA();
                    if (boardPiena() == true)
                    {
                        MessageBox.Show("Pareggio!", "Niente da fare", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                    if (controlloVincitaPC() == true)
                    {
                        MessageBox.Show("Hai perso!", "Che peccato", MessageBoxButton.OK);
                        finePartita = true;
                        return;
                    }
                }
            }
        }

        //Click dell'IA
        public void IA()
        { 
                //ATTACCO

                //mosse d'attacco orizzontali
                if (board[0, 0] == 0 && board[0, 1] == 2 && board[0, 2] == 2)
                {
                    board[0, 0] = 2;
                    cerchio00.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 0] == 2 && board[0, 1] == 0 && board[0, 2] == 2)
                {
                    board[0, 1] = 2;
                    cerchio01.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 0] == 2 && board[0, 1] == 2 && board[0, 2] == 0)
                {
                    board[0, 2] = 2;
                    cerchio02.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[1, 0] == 0 && board[1, 1] == 2 && board[1, 2] == 2)
                {
                    board[1, 0] = 2;
                    cerchio10.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[1, 0] == 2 && board[1, 1] == 0 && board[1, 2] == 2)
                {
                    board[1, 1] = 2;
                    cerchio11.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[1, 0] == 2 && board[1, 1] == 2 && board[1, 2] == 0)
                {
                    board[1, 2] = 2;
                    cerchio12.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[2, 0] == 0 && board[2, 1] == 2 && board[2, 2] == 2)
                {
                    board[2, 0] = 2;
                    cerchio20.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[2, 0] == 2 && board[2, 1] == 0 && board[2, 2] == 2)
                {
                    board[2, 1] = 2;
                    cerchio21.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[2, 0] == 2 && board[2, 1] == 2 && board[2, 2] == 0)
                {
                    board[2, 2] = 2;
                    cerchio22.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }

                //mosse d'attacco verticali
                if (board[0, 0] == 0 && board[1, 0] == 2 && board[2, 0] == 2)
                {
                    board[0, 0] = 2;
                    cerchio00.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 0] == 2 && board[1, 0] == 0 && board[2, 0] == 2)
                {
                    board[1, 0] = 2;
                    cerchio10.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 0] == 2 && board[1, 0] == 2 && board[2, 0] == 0)
                {
                    board[2, 0] = 2;
                    cerchio20.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 1] == 0 && board[1, 1] == 2 && board[2, 1] == 2)
                {
                    board[0, 1] = 2;
                    cerchio01.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 1] == 2 && board[1, 1] == 0 && board[2, 1] == 2)
                {
                    board[1, 1] = 2;
                    cerchio11.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 1] == 2 && board[1, 1] == 2 && board[2, 1] == 0)
                {
                    board[2, 1] = 2;
                    cerchio21.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 2] == 0 && board[1, 2] == 2 && board[2, 2] == 2)
                {
                    board[0, 2] = 2;
                    cerchio02.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 2] == 2 && board[1, 2] == 0 && board[2, 2] == 2)
                {
                    board[1, 2] = 2;
                    cerchio12.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 2] == 2 && board[1, 2] == 2 && board[2, 2] == 0)
                {
                    board[2, 2] = 2;
                    cerchio22.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }

                //mosse d'attacco obbligue
                if (board[0, 0] == 0 && board[1, 1] == 2 && board[2, 2] == 2)
                {
                    board[0, 0] = 2;
                    cerchio00.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 0] == 2 && board[1, 1] == 0 && board[2, 2] == 2)
                {
                    board[1, 1] = 2;
                    cerchio11.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 0] == 2 && board[1, 1] == 2 && board[2, 2] == 0)
                {
                    board[2, 2] = 2;
                    cerchio22.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 2] == 0 && board[1, 1] == 2 && board[2, 0] == 2)
                {
                    board[0, 2] = 2;
                    cerchio02.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 2] == 2 && board[1, 1] == 0 && board[2, 0] == 2)
                {
                    board[1, 1] = 2;
                    cerchio11.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 2] == 2 && board[1, 1] == 2 && board[2, 0] == 0)
                {
                    board[2, 0] = 2;
                    cerchio20.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }

                //DIFESA

                //mosse di difesa orizzontali
                if (board[0, 0] == 0 && board[0, 1] == 1 && board[0, 2] == 1)
                {
                    board[0, 0] = 2;
                    cerchio00.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 0] == 1 && board[0, 1] == 0 && board[0, 2] == 1)
                {
                    board[0, 1] = 2;
                    cerchio01.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 0] == 1 && board[0, 1] == 1 && board[0, 2] == 0)
                {
                    board[0, 2] = 2;
                    cerchio02.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[1, 0] == 0 && board[1, 1] == 1 && board[1, 2] == 1)
                {
                    board[1, 0] = 2;
                    cerchio10.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[1, 0] == 1 && board[1, 1] == 0 && board[1, 2] == 1)
                {
                    board[1, 1] = 2;
                    cerchio11.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[1, 0] == 1 && board[1, 1] == 1 && board[1, 2] == 0)
                {
                    board[1, 2] = 2;
                    cerchio12.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[2, 0] == 0 && board[2, 1] == 1 && board[2, 2] == 1)
                {
                    board[2, 0] = 2;
                    cerchio20.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[2, 0] == 1 && board[2, 1] == 0 && board[2, 2] == 1)
                {
                    board[2, 1] = 2;
                    cerchio21.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[2, 0] == 1 && board[2, 1] == 1 && board[2, 2] == 0)
                {
                    board[2, 2] = 2;
                    cerchio22.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }

                //mosse di difesa verticali
                if (board[0, 0] == 0 && board[1, 0] == 1 && board[2, 0] == 1)
                {
                    board[0, 0] = 2;
                    cerchio00.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 0] == 1 && board[1, 0] == 0 && board[2, 0] == 1)
                {
                    board[1, 0] = 2;
                    cerchio10.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 0] == 1 && board[1, 0] == 1 && board[2, 0] == 0)
                {
                    board[2, 0] = 2;
                    cerchio20.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 1] == 0 && board[1, 1] == 1 && board[2, 1] == 1)
                {
                    board[0, 1] = 2;
                    cerchio01.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 1] == 1 && board[1, 1] == 0 && board[2, 1] == 1)
                {
                    board[1, 1] = 2;
                    cerchio11.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 1] == 1 && board[1, 1] == 1 && board[2, 1] == 0)
                {
                    board[2, 1] = 2;
                    cerchio21.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 2] == 0 && board[1, 2] == 1 && board[2, 2] == 1)
                {
                    board[0, 2] = 2;
                    cerchio02.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 2] == 1 && board[1, 2] == 0 && board[2, 2] == 1)
                {
                    board[1, 2] = 2;
                    cerchio12.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 2] == 1 && board[1, 2] == 1 && board[2, 2] == 0)
                {
                    board[2, 2] = 2;
                    cerchio22.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }

                //mosse di difesa obbligue
                if (board[0, 0] == 0 && board[1, 1] == 1 && board[2, 2] == 1)
                {
                    board[0, 0] = 2;
                    cerchio00.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 0] == 1 && board[1, 1] == 0 && board[2, 2] == 1)
                {
                    board[1, 1] = 2;
                    cerchio11.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 0)
                {
                    board[2, 2] = 2;
                    cerchio22.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 2] == 0 && board[1, 1] == 1 && board[2, 0] == 1)
                {
                    board[0, 2] = 2;
                    cerchio02.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 2] == 1 && board[1, 1] == 0 && board[2, 0] == 1)
                {
                    board[1, 1] = 2;
                    cerchio11.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }
                if (board[0, 2] == 1 && board[1, 1] == 1 && board[2, 0] == 0)
                {
                    board[2, 0] = 2;
                    cerchio20.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }

            //primo pezzo centrale
            if (turnoGiocatore == 2)
            {
                if (board[1, 1] == 0)
                {
                    board[1, 1] = 2;
                    cerchio11.Opacity = 100;
                    turnoGiocatore = 1;
                    return;
                }

            //difesa speciale
                if (turnoGiocatore == 2)
                {
                    if (board[2, 2] == 1 || board[0, 2] == 1 || board[2, 2] == 1 || board[0, 0] == 1 || board[2, 0] == 1)
                    {
                        if (board[1, 2] == 0)
                        {
                            board[1, 2] = 2;
                            cerchio12.Opacity = 100;
                            turnoGiocatore = 1;
                            return;
                        }
                        else if (board[0, 1] == 0)
                        {
                            board[0, 1] = 2;
                            cerchio01.Opacity = 100;
                            turnoGiocatore = 1;
                            return;
                        }
                        else if (board[0, 1] == 0)
                        {
                            board[0, 1] = 2;
                            cerchio01.Opacity = 100;
                            turnoGiocatore = 1;
                            return;
                        }
                        else if (board[1, 2] == 0)
                        {
                            board[1, 2] = 2;
                            cerchio12.Opacity = 100;
                            turnoGiocatore = 1;
                            return;
                        }

                    }
                }

            //secondo pezzo laterale
                if (turnoGiocatore == 2)
                {
                    if (board[2, 0] == 0)
                    {
                        board[2, 0] = 2;
                        cerchio20.Opacity = 100;
                        turnoGiocatore = 1;
                        return;
                    }
                }

                //mossa random (in caso non sia possibile attacare o difendere)
                Random random = new Random();
                int casuale = random.Next(1, 10);
                bool pezzoMossoRandom = false;
                while (pezzoMossoRandom == false){
                casuale = random.Next(1, 10);
                        switch (casuale)
                        {
                            case 1:
                                if (pezzoOccupato(0, 0) == false)
                                {
                                    board[0, 0] = 2;
                                    cerchio00.Opacity = 100;
                                    turnoGiocatore = 1;
                                    pezzoMossoRandom = true;
                                    return;
                                }
                                break;
                            case 2:
                                if (pezzoOccupato(0, 1) == false)
                                {
                                    board[0, 1] = 2;
                                    cerchio01.Opacity = 100;
                                    turnoGiocatore = 1;
                                    pezzoMossoRandom = true;
                                    return;
                                }
                                break;
                            case 3:
                                if (pezzoOccupato(0, 2) == false)
                                {
                                    board[0, 2] = 2;
                                    cerchio02.Opacity = 100;
                                    turnoGiocatore = 1;
                                    pezzoMossoRandom = true;
                                    return;
                                }
                                break;
                            case 4:
                                if (pezzoOccupato(1, 0) == false)
                                {
                                    board[1, 0] = 2;
                                    cerchio10.Opacity = 100;
                                    turnoGiocatore = 1;
                                    pezzoMossoRandom = true;
                                    return;
                                }
                                break;
                            case 5:
                                if (pezzoOccupato(1, 1) == false)
                                {
                                    board[1, 1] = 2;
                                    cerchio11.Opacity = 100;
                                    turnoGiocatore = 1;
                                    pezzoMossoRandom = true;
                                    return;
                                }
                                break;
                            case 6:
                                if (pezzoOccupato(1, 2) == false)
                                {
                                    board[1, 2] = 2;
                                    cerchio12.Opacity = 100;
                                    turnoGiocatore = 1;
                                    pezzoMossoRandom = true;
                                    return;
                                }
                                break;
                            case 7:
                                if (pezzoOccupato(2, 0) == false)
                                {
                                    board[2, 0] = 2;
                                    cerchio20.Opacity = 100;
                                    turnoGiocatore = 1;
                                    pezzoMossoRandom = true;
                                    return;
                                }
                                break;
                            case 8:
                                if (pezzoOccupato(2, 1) == false)
                                {
                                    board[2, 1] = 2;
                                    cerchio21.Opacity = 100;
                                    turnoGiocatore = 1;
                                    pezzoMossoRandom = true;
                                    return;
                                }
                                break;
                            case 9:
                                if (pezzoOccupato(2, 2) == false)
                                {
                                    board[2, 2] = 2;
                                    cerchio22.Opacity = 100;
                                    turnoGiocatore = 1;
                                    pezzoMossoRandom = true;
                                    return;
                                }
                                break;
                    }
                }  
            }//fine if
        }

        private void New_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Vuoi iniziare una nuova partita?", "Nuova partita", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                for (int i = 0; i < board.GetLength(0); i++) //riempio la matrice con 0
                    for (int j = 0; j < board.GetLength(1); j++)
                        board[i, j] = 0;
                finePartita = false;
                turnoGiocatore = 1;
                croce00.Opacity = 0;
                croce01.Opacity = 0;
                croce02.Opacity = 0;
                croce10.Opacity = 0;
                croce11.Opacity = 0;
                croce12.Opacity = 0;
                croce20.Opacity = 0;
                croce21.Opacity = 0;
                croce22.Opacity = 0;
                cerchio00.Opacity = 0;
                cerchio01.Opacity = 0;
                cerchio02.Opacity = 0;
                cerchio10.Opacity = 0;
                cerchio11.Opacity = 0;
                cerchio12.Opacity = 0;
                cerchio20.Opacity = 0;
                cerchio21.Opacity = 0;
                cerchio22.Opacity = 0;
            }
        }
    }
}