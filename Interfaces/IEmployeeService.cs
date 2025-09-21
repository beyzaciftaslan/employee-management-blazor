using demo.Data;
using demo.Models;

namespace demo.Services
{
    public interface IEmployeeService
    {
        // Create - Add new employee
        Task<bool> CreateEmployeeAsync(Employee employee);

        // Read - Get all employees
        Task<List<Employee>> GetAllEmployeesAsync();

        // Read - Get employee by ID
        Task<Employee?> GetEmployeeByIdAsync(int id);

        // Update - Update existing employee
        Task<bool> UpdateEmployeeAsync(Employee employee);

        // Delete - Remove employee by ID
        Task<bool> DeleteEmployeeAsync(int id);

        // Delete - Remove employee object
        Task<bool> DeleteEmployeeAsync(Employee employee);

        // Helper method - Check if employee exists
        Task<bool> EmployeeExistsAsync(int id);

        // Get DbContext for complex operations (like QuickGrid)
        MyDbContext CreateDbContext();
    }
}