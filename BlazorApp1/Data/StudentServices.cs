// StudentService.cs
using BlazorApp1.Models;

public class StudentService
{
    private readonly StudentDBContext _dbContext;

    public StudentService(StudentDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<StudentViewResult>> GetStudentDataAsync()
    {
        try
        {
            return await _dbContext.Procedures.StudentViewAsync();
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Error fetching student data: {ex.Message}");
            throw;
        }
    }
}
