using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace contractor_api.Repositories
{
    // ON CREATE THE MODEL GIVEN TO CREATE WILL BE DIFFERENT THAN THE ONE CREATE
    public class ContractorJobRepository
    {
        private readonly IDbConnection _db;

        public ContractorJobRepository(IDbConnection db)
        {
            _db = db;
        }

        public ContractorJob Create(ContractorJob newCB)
        {
            string sql = @"
            INSERT INTO contractor_job(contractorId, jobId)
            VALUES (@ContractorId, @JobId);
            SELECT LAST_INSERT_ID();";
            newCB.Id = _db.ExecuteScalar<int>(sql, newCB);
            return newCB;
        }

        public ContractorJobRepository GetOne(int id)
        {
            string sql = @"";
            ContractorJob data = _db.Query();
            return data;
        }
        public string Delete(int id)
        {
            string sql = "
             ";
             int deleted = _db.Execute(sql, new { id });
            if (deleted == 1)
            {
                return "Successfully Deleted";
            }
            else
            {
                throw new System.Exception("Invalid Id");
            }
        }
    }
}