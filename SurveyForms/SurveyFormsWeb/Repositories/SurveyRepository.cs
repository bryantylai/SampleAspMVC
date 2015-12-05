using SurveyFormsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsWeb.Repositories
{
    public class SurveyRepository
    {
        private DatabaseEntities _dataEntities;

        public SurveyRepository()
        {
            _dataEntities = new DatabaseEntities();
        }

        public List<string> List()
        {
            return _dataEntities.Surveys.Select(s => s.Name).ToList();
        }

        public bool Add(Survey survey)
        {
            _dataEntities.Surveys.Add(survey);

            return _dataEntities.SaveChanges() > 1;
        }
    }
}
