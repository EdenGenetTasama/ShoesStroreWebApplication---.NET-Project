using ShoesStroreWebApplication__.NET_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoesStroreWebApplication__.NET_Project.Controllers.api
{
    public class ShoesController : ApiController
    {
        ShoesContextDataContext dbTableShoes = new ShoesContextDataContext();

        // GET: api/Shoes
        public IHttpActionResult Get()
        {

            try
            {
                List<Shoe> listOfAllShoes = dbTableShoes.Shoes.ToList();
                if (listOfAllShoes !=null)
                {
                    return Ok(new { listOfAllShoes });
                }

                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Shoes/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Shoe shoeById = dbTableShoes.Shoes.First(item => item.Id == id);
                if (shoeById != null)
                {

                    return Ok(new { shoeById });
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Shoes
        public IHttpActionResult Post([FromBody] Shoe ShoeToAdd)
        {
            try
            {
                dbTableShoes.Shoes.InsertOnSubmit(ShoeToAdd);
                dbTableShoes.SubmitChanges();
                return Ok($"Add to Table , id: {ShoeToAdd.Id}");

            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Shoes/5
        public IHttpActionResult Put(int id, [FromBody] Shoe shoeToUpdate)
        {
            try
            {
                Shoe findByIdShoeToUpdate = dbTableShoes.Shoes.First(item => item.Id == id);
                if (findByIdShoeToUpdate != null)
                {
                    findByIdShoeToUpdate.shoeType=shoeToUpdate.shoeType;
                    findByIdShoeToUpdate.company=shoeToUpdate.company;
                    findByIdShoeToUpdate.shoeModel = shoeToUpdate.shoeModel;
                    findByIdShoeToUpdate.shoePrice = shoeToUpdate.shoePrice;
                    findByIdShoeToUpdate.shoeAmount= shoeToUpdate.shoeAmount;
                    findByIdShoeToUpdate.isOnSall=shoeToUpdate.isOnSall;
                    findByIdShoeToUpdate.linkImage=shoeToUpdate.linkImage;
                    dbTableShoes.SubmitChanges();
                    return Ok($"Changes saved");
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Shoes/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Shoe shoeToDelete= dbTableShoes.Shoes.First(item=>item.Id == id);
                if(shoeToDelete !=null)
                {
                    dbTableShoes.Shoes.DeleteOnSubmit(shoeToDelete);
                    dbTableShoes.SubmitChanges();
                    return Ok($"id Deleted: {shoeToDelete.Id}");
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
