using Nancy;

namespace usemono.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
				return View["what"];
            };

			Get["/what"] = parameters =>
			{
				return View["what"];
			};

			Get["/why"] = parameters =>
			{
				return View["why"];
			};

			Get["/how"] = parameters =>
			{
				return View["how"];
			};
        }
    }
}