using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using contractor_api.Models;
using Dapper;

namespace contractor_api.Repositories
{
    public class JobsRepository
    {
        // extra route: get all contractors given a job id
        private readonly IDbConnection _db;

        public JobsRepository(IDbConnection db)
        {
            _db = db;
        }

        public Job Create(Job newJob)
        {
            string sql = @"
            INSERT INTO jobs
            (name)
            VALUES
            (@name);
            SELECT_LAST_INSERT_ID();";
            newJob.Id = _db.ExecuteScalar<int>(sql, newJob);
            return newJob;
        }

        public IEnumerable<Job> GetAll()
        {
            string sql = @"
            SELECT * FROM jobs;";
            return _db.Query<Job>(sql);
        }

        public Job GetOne(int id)
        {
            string sql = @"
            SELECT * FROM jobs WHERE id = @id;";
            return _db.QueryFirstOrDefault<Job>(sql, new { id });
        }
    }
}
