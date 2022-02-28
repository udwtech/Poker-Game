using System;

namespace PokerGame
{
    public class Wallet
    {
        private string walletAddress;
        private string imgUrl;
        public Wallet(string walletAddress)
        {
            
        }

        public void SetImageUrl(string imgUrl)
        {
            this.imgUrl = imgUrl;
        }

        private bool IsWalletValid()
        {
            throw new NotImplementedException();
        }
    }
}