using System;
using System.Collections.Generic;
using contractor_api.Models;
using contractor_api.Repositories;

namespace contractor_api.Services
{
    public class JobsService
    {
        // extra route: get all contractors given a job id
        private readonly JobsRepository _repository;

        public JobsService(JobsRepository repository)
        {
            _repository = repository;
        }

        internal Job Create(Job newJob)
        {
            Job data = _repository.Create(newJob);
            return data;
        }

        internal IEnumerable<Job> GetAll()
        {
            IEnumerable<Job> data = _repository.GetAll();
            return data;
        }

        internal Job GetOne(int id)
        {
            Job data = _repository.GetOne(id);
            return data;
        }
    }
}