using Nancy;

namespace usemono.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
				return View["index"];
            };
        }
    }
}