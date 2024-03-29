﻿using DomainValidation.Interfaces.Specification;
using System.Configuration;

namespace BLL_GRBL.GCodeValidation.Triangle
{
    public class TriangleBaseIsValid : ISpecification<ENT_Sender_GRBL.Triangle>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Triangle entity)
        {
            double maxAxisX = double.Parse(ConfigurationManager.AppSettings["MAX_AXIS_X_mm"]);
            return LineValidation.IsValid(entity.Base, entity.Start.X, maxAxisX);
        }
    }
}


