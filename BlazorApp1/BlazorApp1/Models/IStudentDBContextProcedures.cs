﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using BlazorApp1.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public partial interface IStudentDBContextProcedures
    {
        Task<List<PaginationResult>> PaginationAsync(int? PageSize, int? PageNumber, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> RestoreDataAsync(int? Student_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SoftDeleteResult>> SoftDeleteAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> StudentAddAsync(string Student_Name, DateTime? Student_DOB, int? Student_Age, string Student_Gender, int? Student_Mobile, string Student_Address, bool? IsDeleted, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> StudentDeleteAsync(int? Student_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> StudentUpdateAsync(int? Student_ID, string Student_Name, DateTime? Student_DOB, int? Student_Age, string Student_Gender, int? Student_Mobile, string Student_Address, bool? IsDeleted, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<StudentViewResult>> StudentViewAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
