class GoldStar : User
{
    private int _goldStarID;
    public GoldStar(string name, string email, string password, int userID, int goldStarID) : base(name, email, password, userID)
    {
        _goldStarID = goldStarID;
    }
}