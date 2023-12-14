using CsvHelper.Configuration.Attributes;

namespace MvcPractice.Models
{
    public class Student
    {
        [Name("ID")]
        public string ID { get; set; }

        [Name("Marital status")]
        public int Status { get; set; }

        [Name("Application mode")]
        public int ApplicationMode { get; set; }

        [Name("Application order")]
        public int ApplicationOrder { get; set; }

        public int Course { get; set; }

        [Name("Daytime/evening attendance")]
        public int Attendance { get; set; }

        [Name("Previous qualification")]
        public int PreviousQualification { get; set; }

        [Name("Previous qualification (grade)")]
        public double PreviousGrade { get; set; }

        public int Nacionality { get; set; }

        [Name("Mother's qualification")]
        public int MothersQualification { get; set; }

        [Name("Father's qualification")]
        public int FathersQualification { get; set; }

        [Name("Mother's occupation")]
        public int MothersOccupation { get; set; }

        [Name("Father's occupation")]
        public int FathersOccupation { get; set; }

        [Name("Admission grade")]
        public double AdmissionGrade { get; set; }

        [Name("Displaced")]
        public bool IsDisplaced { get; set; }

        [Name("Educational special needs")]
        public bool HasSpecialNeeds { get; set; }

        [Name("Debtor")]
        public bool IsDebtor { get; set; }

        [Name("Tuition fees up to date")]
        public bool AreTuitionFeesUpToDate { get; set; }

        [Name("Gender")]
        public int Gender { get; set; }

        [Name("Scholarship holder")]
        public bool IsScholarshipHolder { get; set; }

        [Name("Age at enrollment")]
        public int Age { get; set; }

        [Name("International")]
        public bool IsInternational { get; set; }

        [Name("Curricular units 1st sem (credited)")]
        public int CreditedUnits1stSem { get; set; }

        [Name("Curricular units 1st sem (enrolled)")]
        public int EnrolledUnits1stSem { get; set; }

        [Name("Curricular units 1st sem (evaluations)")]
        public int EvaluationsUnits1stSem { get; set; }

        [Name("Curricular units 1st sem (approved)")]
        public int ApprovedUnits1stSem { get; set; }

        [Name("Curricular units 1st sem (grade)")]
        public double GradeUnits1stSem { get; set; }

        [Name("Curricular units 1st sem (without evaluations)")]
        public int WithoutEvaluationsUnits1stSem { get; set; }

        [Name("Curricular units 2nd sem (credited)")]
        public int CreditedUnits2ndSem { get; set; }

        [Name("Curricular units 2nd sem (enrolled)")]
        public int EnrolledUnits2ndSem { get; set; }

        [Name("Curricular units 2nd sem (evaluations)")]
        public int EvaluationsUnits2ndSem { get; set; }

        [Name("Curricular units 2nd sem (approved)")]
        public int ApprovedUnits2ndSem { get; set; }

        [Name("Curricular units 2nd sem (grade)")]
        public double GradeUnits2ndSem { get; set; }

        [Name("Curricular units 2nd sem (without evaluations)")]
        public int WithoutEvaluationsUnits2ndSem { get; set; }

        [Name("Unemployment rate")]
        public double UnemploymentRate { get; set; }

        [Name("Inflation rate")]
        public double InflationRate { get; set; }

        public double GDP { get; set; }

        public string Target { get; set; }

    }

}

