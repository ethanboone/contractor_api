using System;
using System.Collections.Generic;
using System.Linq;
using contractor_api.Models;
using contractor_api.Repositories;

namespace contractor_api.Services
{
    public class ContractorJobService
    {
        // ON CREATE THE MODEL GIVEN TO CREATE WILL BE DIFFERENT THAN THE ONE CREATE
        private readonly ContractorJobRepository _repo;

        public ContractorJobService(ContractorJobRepository repo)
        {
            _repo = repo;
        }

        internal ContractorJob Create(ContractorJob newCB)
        {
            ContractorJob data = _repo.Create(newCB);
            return data;
        }

        internal ContractorJob GetOne(int id)
        {
            ContractorJob data = _repo.GetOne(id);
            return data;
        }

        internal string Delete(int id)
        {
            string data = _repo.Delete(id);
            return data;
        }
    }
}