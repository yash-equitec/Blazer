// StudentService.cs
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class StudentService
{
    private readonly StudentDBContext _dbContext;

    public StudentService(StudentDBContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public async Task<List<StudentTable>> GetStudentDataAsync()
    {
        try
        {
            return await _dbContext.StudentTables.FromSqlRaw("EXEC StudentView").ToListAsync();
        }
        catch (Exception ex)
        {
         
            Console.WriteLine($"Error fetching student data: {ex.Message}");
            throw; 
        }
    }
}
