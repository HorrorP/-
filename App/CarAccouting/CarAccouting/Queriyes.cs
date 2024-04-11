using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAccouting
{
    public class Queries
    {
        private ManagementTSGContext _context;

        public Queries(ManagementTSGContext context)
        {
            _context = context;
        }

        // Запрос 1: Получить всех собственников
        public IQueryable<Собственники> GetAllOwners()
        {
            return _context.Собственники;
        }

        // Запрос 2: Получить собственника по ID (с параметром)
        public Собственники GetOwnerById(int ownerId)
        {
            return _context.Собственники.FirstOrDefault(o => o.Id == ownerId);
        }

        // Запрос 3: Получить все услуги с их стоимостью
        public IQueryable<Услуги> GetAllServicesWithCost()
        {
            return _context.Услуги;
        }

        // Запрос 4: Получить все финансовые операции за определенную дату
        public IQueryable<Финансы> GetFinancialOperationsByDate(DateTime date)
        {
            return _context.Финансы.Where(f => f.Дата == date);
        }

        // Запрос 5: Получить список сотрудников с определенной должностью
        public IQueryable<Employees> GetEmployeesByJobTitle(string jobTitle)
        {
            return _context.Employees.Where(e => e.EmployeeJobTitle == jobTitle);
        }

        // Запрос 6: Получить все финансовые операции для определенного собственника
        public IQueryable<Финансы> GetFinancialOperationsForOwner(int ownerId)
        {
            return _context.Финансы.Where(f => f.IdСобственника == ownerId);
        }

        // Запрос 7: Получить суммарную стоимость всех услуг
        //public decimal GetTotalServicesCost()
        //{
        //    return _context.Услуги.Sum(s => s.Стоимость);
        //}

        // Запрос 8: Получить список собственников, имена которых начинаются с определенной буквы
        public IQueryable<Собственники> GetOwnersByFirstLetter(string letter)
        {
            return _context.Собственники.Where(o => o.Имя.StartsWith(letter));
        }

        // Запрос 9: Получить количество сотрудников с определенной должностью
        public int GetEmployeeCountByJobTitle(string jobTitle)
        {
            return _context.Employees.Count(e => e.EmployeeJobTitle == jobTitle);
        }

        // Запрос 10: Получить последнюю финансовую операцию для каждого собственника
        public IQueryable<Финансы> GetLastFinancialOperationForEachOwner()
        {
            return _context.Финансы.GroupBy(f => f.IdСобственника)
                                   .Select(g => g.OrderByDescending(f => f.Дата).FirstOrDefault());
        }
    }
}
