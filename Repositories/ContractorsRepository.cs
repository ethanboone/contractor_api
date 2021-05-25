using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using contractor_api.Models;
using Dapper;

namespace contractor_api.Repositories
{
    // extra route: get all jobs given a contractor id
    public class ContractorsRepository
    {
        private readonly IDbConnection _db;

        public ContractorsRepository(IDbConnection db)
        {
            _db = db;
        }

        public Contractor Create(Contractor newContractor)
        {
            string sql = @"
            INSERT INTO contractors
            (name)
            VALUES
            (@name);
            SELECT_LAST_INSERT_ID();";
            newContractor.Id = _db.ExecuteScalar<int>(sql, newContractor);
            return newContractor;
        }

        public IEnumerable<Contractor> GetAll()
        {
            string sql = @"
            SELECT * FROM contractors;";
            return _db.Query<Contractor>(sql);
        }

        public Contractor GetOne(int id)
        {
            string sql = @"
            SELECT * FROM contractors WHERE id = @id;";
            return _db.QueryFirstOrDefault<Contractor>(sql, new { id });
        }
    }
}