namespace Assessment_2.Controllers
{
    using Assessment_2.Data;

    using DevExtreme.AspNet.Data;
    using DevExtreme.AspNet.Mvc;

    using Microsoft.AspNetCore.Mvc;

    public class PersonWebAPIController : Controller
    {
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(MockData.GetPeople(), loadOptions);
        }
    }
}
