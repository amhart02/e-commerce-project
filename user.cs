class User
{
    private string _name;
    private string _email;
    private string _password;
    private int _userID;
    public User(string name, string email, string password, int userID)
    {
        _name = name;
        _email = email;
        _password = password;
        _userID = userID;
    }
    public int GetUserID()
    {
        return _userID;
    }
}