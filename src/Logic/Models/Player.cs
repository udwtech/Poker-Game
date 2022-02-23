using System;
using System.Collections.Generic;
namespace PokerGame
{
    public class Player{
        private string walletAddress;
        public Player(string walletAddress) {
            this.walletAddress = walletAddress;
        }

        public List<Card> CardsOnHand() {
            throw new NotImplementedException();
        }
    }
    
}