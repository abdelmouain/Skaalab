using Microsoft.AspNetCore.Mvc;
using Skalaab_Exercise4.Services;

namespace Skalaab_Exercise4.Controllers;
public class LearnResourceController : Controller
{
    private readonly LearnResourceService _learnResourceService;

    public LearnResourceController(LearnResourceService learnResourceService)
    {
        _learnResourceService = learnResourceService;
    }

    // GET: LearnResourceController
    public async Task<ActionResult> Index()
    {
        var data = await _learnResourceService.GetAllLearnResources();
        return View(data);
    }

    // GET: LearnResourceController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: LearnResourceController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: LearnResourceController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: LearnResourceController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: LearnResourceController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: LearnResourceController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: LearnResourceController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
