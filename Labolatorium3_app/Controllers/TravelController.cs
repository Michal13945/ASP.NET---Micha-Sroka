using Labolatorium3_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium3_app.Controllers;

public class TravelController : Controller
{
    private static Dictionary<int, Travel> _travels = new Dictionary<int, Travel>();

    public ActionResult Index()
    {
        return View(_travels);
    }

    public ActionResult Details(int id)
    {
        if (_travels.TryGetValue(id, out var travel))
        {
            return View(travel);
        }
        return NotFound();
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Travel travel)
    {
        if (ModelState.IsValid)
        {
            int newId = _travels.Any() ? _travels.Keys.Max() + 1 : 1;
            travel.Id = newId;
            _travels.Add(newId, travel);
            return RedirectToAction("Index");
        }
        return View(travel);
    }

    public ActionResult Edit(int id)
    {
        if (_travels.TryGetValue(id, out var travel))
        {
            return View(travel);
        }
        return NotFound();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(Travel travel)
    {
        if (ModelState.IsValid)
        {
            if (_travels.ContainsKey(travel.Id))
            {
                _travels[travel.Id] = travel;
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        return View(travel);
    }

    public ActionResult Delete(int id)
    {
        if (_travels.TryGetValue(id, out var travel))
        {
            return View(travel);
        }
        return NotFound();
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id)
    {
        if (_travels.ContainsKey(id))
        {
            _travels.Remove(id);
            return RedirectToAction("Index");
        }
        return NotFound();
    }
}
