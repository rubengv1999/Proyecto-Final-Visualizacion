using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class PaisViewModel
    {
        public string IsoCode { get; set; }
        public string Continent { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public double TotalCases { get; set; }
        public double NewCases { get; set; }
        public double TotalDeaths { get; set; }
        public double NewDeaths { get; set; }
        public double TotalCasesPerMillion { get; set; }
        public double NewCasesPerMillion { get; set; }
        public double TotalDeathsPerMillion { get; set; }
        public double NewDeathsPerMillion { get; set; }
        public double TotalTests { get; set; }
        public double NewTests { get; set; }
        public double TotalTestsPerThousand { get; set; }
        public double NewTestsPerThousand { get; set; }
        public double NewTestsSmoothed { get; set; }
        public double NewTestsSmoothedPerThousand { get; set; }
        public string TestUnits { get; set; }
        public double StringencyIndex { get; set; }
        public double Population { get; set; }
        public double PopulationDensity { get; set; }
        public double MedianAge { get; set; }
        public double Aged65Older { get; set; }
        public double Aged70Older { get; set; }
        public double GDPPerCapita { get; set; }
        public double ExtremePoverty { get; set; }
        public double CVDDeathRate { get; set; }
        public double DiabetesPrevelance { get; set; }
        public double FemaleSmokers { get; set; }
        public double MaleSmokers { get; set; }
        public double HandwashingFacilities { get; set; }
        public double HospitalBedsPerThousand { get; set; }
        public double LifeExpectancy { get; set; }

        public PaisViewModel(string isoCode, string continent, string location, string date, double totalCases, double newCases, double totalDeaths, double newDeaths, double totalCasesPerMillion, double newCasesPerMillion, double totalDeathsPerMillion, double newDeathsPerMillion, double totalTests, double newTests, double totalTestsPerThousand, double newTestsPerThousand, double newTestsSmoothed, double newTestsSmoothedPerThousand, string testUnits, double stringencyIndex, double population, double populationDensity, double medianAge, double aged65Older, double aged70Older, double gDPPerCapita, double extremePoverty, double cVDDeathRate, double diabetesPrevelance, double femaleSmokers, double maleSmokers, double handwashingFacilities, double hospitalBedsPerThousand, double lifeExpectancy)
        {
            IsoCode = isoCode;
            Continent = continent;
            Location = location;
            Date = date;
            TotalCases = totalCases;
            NewCases = newCases;
            TotalDeaths = totalDeaths;
            NewDeaths = newDeaths;
            TotalCasesPerMillion = totalCasesPerMillion;
            NewCasesPerMillion = newCasesPerMillion;
            TotalDeathsPerMillion = totalDeathsPerMillion;
            NewDeathsPerMillion = newDeathsPerMillion;
            TotalTests = totalTests;
            NewTests = newTests;
            TotalTestsPerThousand = totalTestsPerThousand;
            NewTestsPerThousand = newTestsPerThousand;
            NewTestsSmoothed = newTestsSmoothed;
            NewTestsSmoothedPerThousand = newTestsSmoothedPerThousand;
            TestUnits = testUnits;
            StringencyIndex = stringencyIndex;
            Population = population;
            PopulationDensity = populationDensity;
            MedianAge = medianAge;
            Aged65Older = aged65Older;
            Aged70Older = aged70Older;
            GDPPerCapita = gDPPerCapita;
            ExtremePoverty = extremePoverty;
            CVDDeathRate = cVDDeathRate;
            DiabetesPrevelance = diabetesPrevelance;
            FemaleSmokers = femaleSmokers;
            MaleSmokers = maleSmokers;
            HandwashingFacilities = handwashingFacilities;
            HospitalBedsPerThousand = hospitalBedsPerThousand;
            LifeExpectancy = lifeExpectancy;
        }
    }
}
