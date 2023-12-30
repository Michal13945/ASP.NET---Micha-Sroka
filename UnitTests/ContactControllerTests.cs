namespace UnitTests;

[TestClass]
public class ContactControllerTests
{
    [TestMethod]
    public void Privacy_Returns_View()
    {
        // Arrange
        var controller = new HomeController();

        // Act
        var result = controller.Privacy();

        // Assert
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task Index_Returns_View_With_Contacts()
    {
        // Arrange
        var contacts = new List<Contact>()
        {
            new Contact
            {
                Id = 1,
                Name = "Test",
                Birth = DateTime.Now,
                Created = DateTime.Now,
                Phone = "123123123",
                OrganizationId = 1,
                Priority = 0,
                Email = "test@test.test"
            },
            new Contact
            {
                Id = 2,
                Name = "Test2",
                Birth = DateTime.Now,
                Created = DateTime.Now,
                Phone = "321321321",
                OrganizationId = 1,
                Priority = 0,
                Email = "test2@test2.test2"
            }
        };

        var mockService = new Mock<IContactService>();
        mockService.Setup(s => s.FindAll()).Returns(contacts);
        var controller = new ContactController(mockService.Object);

        // Act
        var result = await controller.Index() as ViewResult;

        // Assert
        Assert.IsNotNull(result);
        var model = result.Model as IEnumerable<Contact>;
        Assert.IsNotNull(model);
        Assert.IsTrue(contacts.Count == model.Count());
    }

    [TestMethod]
    public void Create_GET_Returns_View()
    {
        // Arrange
        var mockService = new Mock<IContactService>();
        var controller = new ContactController(mockService.Object);

        // Act
        var result = controller.Create() as ViewResult;

        // Assert
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Create_POST_Adds_Contact_And_Redirects()
    {
        // Arrange
        var mockService = new Mock<IContactService>();
        var controller = new ContactController(mockService.Object);
        var newContact = new Contact
        {
            Id = 1,
            Name = "Test",
            Birth = DateTime.Now,
            Created = DateTime.Now,
            Phone = "123123123",
            OrganizationId = 1,
            Priority = 0,
            Email = "test@test.test"
        };


        // Act
        var result = controller.Create(newContact) as RedirectToActionResult;

        // Assert
        Assert.IsNotNull(result);
        mockService.Verify(s => s.Add(It.IsAny<Contact>()), Times.Once);
        Assert.AreEqual("Index", result.ActionName);
    }

    [TestMethod]
    public void Delete_POST_Deletes_Contact_And_Redirects()
    {
        // Arrange
        var mockService = new Mock<IContactService>();
        var controller = new ContactController(mockService.Object);

        var newContact = new Contact
        {
            Id = 1,
            Name = "Test",
            Birth = DateTime.Now,
            Created = DateTime.Now,
            Phone = "123123123",
            OrganizationId = 1,
            Priority = 0,
            Email = "test@test.test"
        };

        var createResult = controller.Create(newContact) as RedirectToActionResult;


        var contactToDelete = new Contact
        {
            Id = 1,
            Name = "Test",
            Birth = DateTime.Now,
            Created = DateTime.Now,
            Phone = "123123123",
            OrganizationId = 1,
            Priority = 0,
            Email = "test@test.test"
        };

        // Act
        var deleteResult = controller.Delete(contactToDelete) as RedirectToActionResult;

        // Assert
        Assert.IsNotNull(deleteResult);
        mockService.Verify(s => s.Delete(It.IsAny<int>()), Times.Once);
        Assert.AreEqual("Index", deleteResult.ActionName);
    }

    [TestMethod]
    public void Create_POST_InvalidModel_Returns_View()
    {
        // Arrange
        var mockService = new Mock<IContactService>();
        var controller = new ContactController(mockService.Object);
        controller.ModelState.AddModelError("errorKey", "errorMessage");

        // Act
        var result = controller.Create(new Contact()) as ViewResult;

        // Assert
        Assert.IsNotNull(result);
        Assert.IsFalse(result.ViewData.ModelState.IsValid);
    }
}