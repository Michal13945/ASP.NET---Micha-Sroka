﻿using Microsoft.AspNetCore.Mvc;

namespace Labolatorium3_app.Models
{
    public interface IContactService
    {
        int Add(Contact book);
        void Delete(int id);
        void Update(Contact book);
        List<Contact> FindAll();
        Contact? FindById(int id);
    }
}
