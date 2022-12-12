using Microsoft.EntityFrameworkCore;

namespace Api.Models;

public class UserData
{
    public List<UserData> userDataList = new List<UserData>();
    public int Id { get; set; }
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public int phoneNum { get; set; }

    public UserData(){}

    public UserData(int _userID, string _firstName, string _lastName, int _phoneNum)
    {
        this.Id = _userID;
        this.firstName = _firstName;
        this.lastName = _lastName;
        this.phoneNum = _phoneNum;
    }

    public void createTestData()
    {
        userDataList.Add(new UserData(0, "John", "Smith", 12345678));
        userDataList.Add(new UserData(1, "Jane", "Doe", 87654321));
        userDataList.Add(new UserData(3, "John", "Doe", 111111));
    }
}
