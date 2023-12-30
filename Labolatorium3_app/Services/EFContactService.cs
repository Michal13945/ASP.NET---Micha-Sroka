using Data;
using Data.Entities;
using Labolatorium3_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium3_app.Services;

public class EFContactService : IContactService
{
    private AppDbContext _context;

    public EFContactService(AppDbContext context)
    {
        _context = context;
    }

    public int Add(Contact contact)
    {
        var entity = ContactMapper.ToEntity(contact);

        entity.Organization = _context.Organizations.Find(contact.OrganizationId);

        var e = _context.Contacts.Add(entity);

        _context.SaveChanges();

        return e.Entity.Id;
    }

    public void Delete(int id)
    {
        ContactEntity? find = _context.Contacts.Find(id);

        if (find != null)
        {
            _context.Contacts.Remove(find);
        }

        _context.SaveChanges();
    }

    public List<Contact> FindAll()
    {
        return _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList(); ;
    }

    public Contact? FindById(int id)
    {
        return ContactMapper.FromEntity(_context.Contacts.Find(id));
    }

    public PagingList<Contact> FindPage(int page, int size)
    {
        return PagingList<Contact>.Create(
                (p, s) => _context.Contacts
                            .OrderBy(b => b.Name)
                            .Skip((p - 1) * size)
                            .Take(s)
                            .Select(e => ContactMapper.FromEntity(e))
                            .ToList(),
                _context.Contacts.Count(),
                page,
                size);
    }

    public void Update(Contact contact)
    {
        var entity = ContactMapper.ToEntity(contact);

        entity.Organization = _context.Organizations.Find(contact.OrganizationId);

        _context.Contacts.Update(entity);

        _context.SaveChanges();
    }

    public List<OrganizationEntity> FindAllOrganizations()
    {
        return _context.Organizations.ToList();
    }
}
