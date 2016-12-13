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
        int _betValue;
        public BlackJackTafelForm()
        {
            InitializeComponent();
            _bankRoll = 100;
            _betValue = 0;
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
            nudBet.Value = _betValue;
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            if (nudBet.Value > 0)
            {
                _betValue = (int)nudBet.Value;

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
                else
                {
                    _dealerHand.Add(_deck.GiveCard());
                    btnPass_Click(sender, e);
                }
            }
        }

        private void nudBet_ValueChanged(object sender, EventArgs e)
        {
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
                    _bankRoll += _betValue;
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
                            _bankRoll += _betValue;
                            boodschap = "You Win";
                        }
                        else
                        {
                            boodschap = "You lose";
                            _bankRoll -= _betValue;
                            nudBet.Value = 0;
                        }
                    }
                }  
            }
            else { boodschap = "You are Busted";  }
            ShowPlayers();
            MessageBox.Show(boodschap);
            SetupPlayers();
            this.Invalidate();
        }

        private void ShowPlayers()
        {
            pbDealer.Image = _dealerHand.Picture;
            pbPlayer.Image = _playerHand.Picture;
            tbBankRoll.Text = _bankRoll.ToString();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            int v = (int) nudBet.Value;
            if( _bankRoll-v>=0)
            {
                _betValue = 2 * v;
                _playerHand.Add(_deck.GiveCard());
                btnPass_Click(sender, e);
            }
            ShowPlayers();            
        }

        private void btnExtraCard_Click(object sender, EventArgs e)
        {
            _playerHand.Add(_deck.GiveCard());
            if(_playerHand.isBusted)
            {
                btnPass_Click(sender, e);
            }
            ShowPlayers();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("help.pdf");
        }
    }
}
