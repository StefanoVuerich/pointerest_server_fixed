﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repositories;
using DTO.Commands;
using DTO.Queries;

namespace PointerestPortal.Controllers
{
    public class OffertaController : ApiController
    {

        OffertaRepository _repository;

        public OffertaController()
        {
            _repository = new OffertaRepository();
        }
        // GET: api/Offerta
        public IEnumerable<OffertaQuery> GetAll()
        {
            return _repository.GetAll();

        }

        // GET: api/Offerta/5
        public IEnumerable<OffertaQuery> Get(int id)
        {
            return _repository.Get(id);
        }

        // POST: api/Offerta
        public void Post(CreateOffertaCommand createCommand)
        {
            _repository.Post(createCommand);
        }

        // PUT: api/Offerta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Offerta/5
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
