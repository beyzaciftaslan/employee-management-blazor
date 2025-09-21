using Microsoft.EntityFrameworkCore;
using demo.Data;
using demo.Models;

namespace demo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IDbContextFactory<MyDbContext> _dbFactory;

        public EmployeeService(IDbContextFactory<MyDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        // Create - Add new employee
        public async Task<bool> CreateEmployeeAsync(Employee employee)
        {
            try
            {
                using var context = _dbFactory.CreateDbContext();
                context.Employee.Add(employee);
                await context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Read - Get all employees
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            using var context = _dbFactory.CreateDbContext();
            return await context.Employee.ToListAsync();
        }

        // Read - Get employee by ID
        public async Task<Employee?> GetEmployeeByIdAsync(int id)
        {
            using var context = _dbFactory.CreateDbContext();
            return await context.Employee.FirstOrDefaultAsync(m => m.Id == id);
        }

        // Update - Update existing employee
        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            try
            {
                using var context = _dbFactory.CreateDbContext();
                context.Attach(employee).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await EmployeeExistsAsync(employee.Id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        // Delete - Remove employee
        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            try
            {
                using var context = _dbFactory.CreateDbContext();
                var employee = await context.Employee.FindAsync(id);
                if (employee != null)
                {
                    context.Employee.Remove(employee);
                    await context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Delete - Remove employee object
        public async Task<bool> DeleteEmployeeAsync(Employee employee)
        {
            try
            {
                using var context = _dbFactory.CreateDbContext();
                context.Employee.Remove(employee);
                await context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Helper method - Check if employee exists
        public async Task<bool> EmployeeExistsAsync(int id)
        {
            using var context = _dbFactory.CreateDbContext();
            return await context.Employee.AnyAsync(e => e.Id == id);
        }

        // Get DbContext for complex operations (like QuickGrid)
        public MyDbContext CreateDbContext()
        {
            return _dbFactory.CreateDbContext();
        }
    }
}