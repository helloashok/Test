using Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermediate
{


    public class SeedData
    {


        public static void SeedQualification(EmployeeContext context, ILoggerFactory logger)
        {
            try
            {
                if (!context.QualificationLists.Any())
                {
                    var qualification = new List<QualificationList>{
                   new QualificationList{QualificationName="SLc"},
                   new QualificationList{QualificationName="Intermediate"},
                   new QualificationList{QualificationName="BE"},
                   new QualificationList{QualificationName="ME"},
                   new QualificationList{QualificationName="PHD"}


               };
                    context.QualificationLists.AddRange(qualification);
                    context.SaveChanges();
                }


            }
            catch (Exception ex)
            {

                var log = logger.CreateLogger<SeedData>();
                log.LogError(ex.Message);
            }


        }

    }
}
