using System;
using System.Collections.Generic;

namespace PokerGame
{
    /**
        This hold the player information.
        @property <see cref="string"/> walletAddress - Player's wallet address.
    */
    public class Player{
        private Wallet walletAddress;
        public Player(string walletAddress) {
            this.walletAddress = new Wallet(walletAddress);
        }

        public List<Card> CardsOnHand() {
            throw new NotImplementedException();
        }
    }
    
}