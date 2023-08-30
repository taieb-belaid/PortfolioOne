using Microsoft.AspNetCore.Mvc;
namespace PortFolioOne.controllers;

public class FolioControllers : Controller
{
    [HttpGet("")]
    public string Index()
    {
        return  "This is my INDEX";
    }

    [HttpGet("projects")]
    public string Prohects()
    {
        return "These are my projects";
    }

    [HttpGet("contact")]
    public string Contact()
    {
        return "this is my contact";
    }
}