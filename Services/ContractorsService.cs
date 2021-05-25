using System;
using System.Collections.Generic;
using contractor_api.Models;
using contractor_api.Repositories;

namespace contractor_api.Services
{
    public class ContractorsService
    {
        // extra route: get all jobs given a contractor id
        private readonly ContractorsRepository _repository;

        public ContractorsService(ContractorsRepository repository)
        {
            _repository = repository;
        }

        internal Contractor Create(Contractor newContractor)
        {
            Contractor data = _repository.Create(newContractor);
            return data;
        }

        internal IEnumerable<Contractor> GetAll()
        {
            IEnumerable<Contractor> data = _repository.GetAll();
            return data;
        }

        internal Contractor GetOne(int id)
        {
            Contractor data = _repository.GetOne(id);
            return data;
        }
    }
}