using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
namespace PalTracker
{
    [Route("/time-entries")]
    public class TimeEntryController  : ControllerBase
    {
        ITimeEntryRepository _repo;
        public TimeEntryController(ITimeEntryRepository repo)
        {
            _repo=repo;
        }
        [HttpPost]
        public IActionResult Create([FromBody] TimeEntry timeEntry)
        {
            var createdTimeEntry = _repo.Create(timeEntry);
            return CreatedAtRoute("GetTimeEntry", new {id = timeEntry.id}, createdTimeEntry);
        }

         [HttpGet("{id}", Name = "GetTimeEntry")]
        public IActionResult Read(int id){
             return _repo.Contains(id) ? (IActionResult) Ok(_repo.Find(id)) : NotFound();
        }
        // public bool Contains(int id){
        //      return _repo.Contains(id);
        // }
        [HttpGet]
        public IActionResult List(){
            return Ok(_repo.List());
             //return (IActionResult) Ok(_repo.List());
          //  return new ActionResult<List<TimeEntry>>(_repo.List());
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]TimeEntry entry){

             if(!_repo.Contains(id))
            {
                return (IActionResult)NotFound();
            }
            var updatedEntry=_repo.Update(id,entry);

             return  Ok(updatedEntry);
            //return new ActionResult<TimeEntry>(_repo.Update(id,entry));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){

            if(!_repo.Contains(id))
            {
                return (IActionResult)NotFound();
            }
            _repo.Delete(id);
            return (IActionResult) NoContent();
        }
    }
}