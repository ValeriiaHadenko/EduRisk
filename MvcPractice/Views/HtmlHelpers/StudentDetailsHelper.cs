using Microsoft.AspNetCore.Html;
using MvcPractice.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

using static MvcPractice.Models.StudentTypes;


namespace MvcPractice.Views.HtmlHelpers
{
	public static class StudentDetailsHelper
	{
		public static IHtmlContent StudentDetails(this IHtmlHelper html, Student student)
        {

            var content = new HtmlContentBuilder()

                .AppendHtml("<div><dl class='row'>")

                .AppendHtml($"<dt class='col-2 py-2'>Marital Status</dt><dd class='col-sm-10'>{MaritalStatus[student.Status]}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Application Mode:</dt><dd class='col-sm-10'>{ApplicationMode[student.ApplicationMode]}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Application Order</dt><dd class='col-sm-10'>{student.ApplicationOrder}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Course</dt><dd class='col-sm-10'>{Course[student.Course]}</dd>")
                .AppendHtml($"<dt class='col-3 py-2'>Daytime/evening attendance</dt><dd class='col-sm-9'>{Attendance[student.Attendance]}</dd>")
                .AppendHtml($"<dt class='col-3 py-2'>Previous qualification</dt><dd class='col-sm-9'>{EducationLevel[student.PreviousQualification]}</dd>")
                .AppendHtml($"<dt class='col-3 py-2'>Previous qualification (grade)</dt><dd class='col-sm-9'>{student.PreviousGrade}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Nacionality</dt><dd class='col-sm-10'>{Nationality[student.Nacionality]}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Mother's qualification</dt><dd class='col-sm-10'>{EducationLevel[student.MothersQualification]}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Father's qualification</dt><dd class='col-sm-10'>{EducationLevel[student.FathersQualification]}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Mother's occupation</dt><dd class='col-sm-10'>{Occupation[student.MothersOccupation]}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Father's occupation</dt><dd class='col-sm-10'>{Occupation[student.FathersOccupation]}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Admission grade</dt><dd class='col-sm-10'>{student.AdmissionGrade}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Displaced</dt><dd class='col-sm-10'>{student.IsDisplaced}</dd>")
                .AppendHtml($"<dt class='col-3 py-2'>Educational special needs</dt><dd class='col-sm-9'>{student.HasSpecialNeeds}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Debtor</dt><dd class='col-sm-10'>{student.IsDebtor}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Tuition fees up to date</dt><dd class='col-sm-10'>{student.AreTuitionFeesUpToDate}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Gender</dt><dd class='col-sm-10'>{Gender[student.Gender]}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Scholarship holder</dt><dd class='col-sm-10'>{student.IsScholarshipHolder}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>Age at enrollment</dt><dd class='col-sm-10'>{student.Age}</dd>")
                .AppendHtml($"<dt class='col-2 py-2'>International<dd class='col-sm-10'>{student.IsInternational}</dd>")
                .AppendHtml($"<dt class='col-3'>Curricular units 1st sem (credited)</dt><dd class='col-sm-9'>{student.CreditedUnits1stSem}</dd>")
                .AppendHtml($"<dt class='col-3'>Curricular units 1st sem (enrolled)</dt><dd class='col-sm-9'>{student.EnrolledUnits1stSem}</dd>")
                .AppendHtml($"<dt class='col-3'>Curricular units 1st sem (evaluations)</dt><dd class='col-sm-9'>{student.EvaluationsUnits1stSem}</dd>")
                .AppendHtml($"<dt class='col-3'>Curricular units 1st sem (approved)</dt><dd class='col-sm-9'>{student.ApprovedUnits1stSem}</dd>")
                .AppendHtml($"<dt class='col-3'>Curricular units 1st sem (grade)</dt><dd class='col-sm-9'>{student.GradeUnits1stSem}</dd>")
                .AppendHtml($"<dt class='col-4 pb-2'>Curricular units 1st sem (without evaluations)</dt><dd class='col-sm-8'>{student.WithoutEvaluationsUnits1stSem}</dd>")
                .AppendHtml($"<dt class='col-3'>Curricular units 2nd sem (credited)</dt><dd class='col-sm-9'>{student.CreditedUnits2ndSem}</dd>")
                .AppendHtml($"<dt class='col-3'>Curricular units 2nd sem (enrolled)</dt><dd class='col-sm-9'>{student.EnrolledUnits2ndSem}</dd>")
                .AppendHtml($"<dt class='col-3'>Curricular units 2nd sem (evaluations)</dt><dd class='col-sm-9'>{student.EvaluationsUnits2ndSem}</dd>")
                .AppendHtml($"<dt class='col-3'>Curricular units 2nd sem (approved)</dt><dd class='col-sm-9'>{student.ApprovedUnits2ndSem}</dd>")
                .AppendHtml($"<dt class='col-3'>Curricular units 2nd sem (grade)</dt><dd class='col-sm-9'>{student.GradeUnits2ndSem}</dd>")
                .AppendHtml($"<dt class='col-4 pb-2'>Curricular units 2nd sem (without evaluations)</dt><dd class='col-sm-8'>{student.WithoutEvaluationsUnits2ndSem}</dd>")
                .AppendHtml($"<dt class='col-2'>Unemployment rate</dt><dd class='col-sm-10'>{student.UnemploymentRate}</dd>")
                .AppendHtml($"<dt class='col-2'>Inflation rate</dt><dd class='col-sm-10'>{student.InflationRate}</dd>")
                .AppendHtml($"<dt class='col-2'>GDP</dt><dd class='col-sm-10'>{student.GDP}</dd>")


                .AppendHtml($"<dt class='col-sm-2'>Course Status</dt><dd class='col-sm-10'>{student.Target}</dd>")

                .AppendHtml("</dl></div>");

            return content;
        }


	}
}

