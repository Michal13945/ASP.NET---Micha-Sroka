using Data.Entities;
using Labolatorium3_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium3_app.Services;

public interface IContactService
{
    int Add(Contact book);
    void Delete(int id);
    void Update(Contact book);
    List<Contact> FindAll();
    PagingList<Contact> FindPage(int page, int size);
    Contact? FindById(int id);
    List<OrganizationEntity> FindAllOrganizations();
}
