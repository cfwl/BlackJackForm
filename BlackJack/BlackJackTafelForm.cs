using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CardLibrary;
using CardLibrary.BlackJack;

namespace BlackJack
{
    public partial class BlackJackTafelForm : Form
    {
        BlackJackHand _playerHand;
        BlackJackHand _dealerHand;

        BlackJackDeck _deck;

        int _bankRoll;
        public BlackJackTafelForm()
        {
            InitializeComponent();
            _bankRoll = 100;
            _lastBetValue = 0;
            SetupPlayers();
            tbBankRoll.Text = _bankRoll.ToString();

        }

        private void SetupPlayers()
        {
            _deck = new BlackJackDeck(5);
            _deck.Shuffle();
            _playerHand = new BlackJackHand();
            _dealerHand = new BlackJackHand();
            pbDealer.Image = null;
            pbPlayer.Image = null;
            btnDeal.Visible = true;
            btnDouble.Visible = false;
            btnPass.Visible = false;
            btnExtraCard.Visible = false;
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            if (nudBet.Value > 0)
            {
                nudBet.ReadOnly = true;
                btnDeal.Visible = false;
                _playerHand.Add(_deck.GiveCard());
                _dealerHand.Add(_deck.GiveCard());
                _playerHand.Add(_deck.GiveCard());

                pbDealer.Image = _dealerHand.Picture;
                pbPlayer.Image = _playerHand.Picture;

                if(!_playerHand.isBlackJack)
                {
                    btnPass.Visible = true;
                    btnExtraCard.Visible = true;
                    if(_playerHand.isDubbleAble)
                    {
                        btnDouble.Visible = true;
                    }
                }
            }
        }

        int _lastBetValue;

        private void nudBet_ValueChanged(object sender, EventArgs e)
        {
            int v = (int)nudBet.Value;
            _bankRoll -= (v - _lastBetValue);
            if (_bankRoll < 0)
            {
                _bankRoll += (v - _lastBetValue);
            }
            else
            {
                _lastBetValue = (int)nudBet.Value;
            }
            tbBankRoll.Text = _bankRoll.ToString();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            string boodschap = string.Empty;

            if (!_playerHand.isBusted)
            {
                // Dealer krijgt kaarten
                _dealerHand.Add(_deck.GiveCard()); // tweede kaart
                while (!_dealerHand.isBusted && _dealerHand.Score < 17)
                {
                    _dealerHand.Add(_deck.GiveCard());
                }

                if (_dealerHand.isBusted)
                {
                    boodschap = "You win";
                }
                else
                {
                    if (_dealerHand.Score == _playerHand.Score)
                    {
                        // niets wordt er uitbetaald
                        boodschap = "it is a Tie";
                    }
                    else
                    {
                        if (_dealerHand.Score < _playerHand.Score)
                        {
                            _bankRoll += (int)(2 * nudBet.Value);
                            boodschap = "You Win";
                        }
                        else
                        {
                            boodschap = "You lose";
                        }
                    }
                }  
            }
            else { boodschap = "You are Busted"; }
            ShowPlayers();
            MessageBox.Show(boodschap);
            SetupPlayers();
            this.Invalidate();
        }

        private void ShowPlayers()
        {
            pbDealer.Image = _dealerHand.Picture;
            pbPlayer.Image = _playerHand.Picture;
        }
    }
}
