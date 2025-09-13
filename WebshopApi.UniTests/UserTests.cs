namespace WebshopApi.UniTests;

using WebshopApi.Models;
using Moq;
using WebshopApi.Services;

public class UserTests
{
    private readonly Mock<IUserService> _userServiceMock;

    public UserTests()
    {
        _userServiceMock = new Mock<IUserService>();
    }

    [Fact]
    public async Task GetAllUsers_ShouldReturnListOfUsers()
    {
        var users = UserMockData.GetUsers();
        _userServiceMock.Setup(s => s.GetAllUsersAsync()).ReturnsAsync(users);
        var result = await _userServiceMock.Object.GetAllUsersAsync();

        Assert.IsType<List<User>>(result);
    }

    [Fact]
    public async Task GetUserById_ShouldReturnUser_WhenUserExists()
    {
        var users = UserMockData.GetUsers();
        var userId = 1;
        var expectedUser = users.First(u => u.Id == userId);

        _userServiceMock.Setup(s => s.GetUserByIdAsync(userId)).ReturnsAsync(expectedUser);

        var result = await _userServiceMock.Object.GetUserByIdAsync(userId);

        Assert.NotNull(result);
        Assert.Equal(expectedUser.Id, result!.Id);
        Assert.Equal(expectedUser.Name, result.Name);
    }

    [Fact]
    public async Task GetUserById_ShouldReturnNull_WhenUserDoesNotExist()
    {
        var userId = -1;
        _userServiceMock.Setup(s => s.GetUserByIdAsync(userId)).ReturnsAsync((User?)null);

        var result = await _userServiceMock.Object.GetUserByIdAsync(userId);

        Assert.Null(result);
    }
}
