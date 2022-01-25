using ShoesStroreWebApplication__.NET_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;

namespace ShoesStroreWebApplication__.NET_Project.Controllers.api
{
    public class ShirtsController : ApiController
    {
        ShirtsContextDataContext dbCloting = new ShirtsContextDataContext();

        // GET: api/Shirts
        public IHttpActionResult Get()
        {
            try
            {
                List<clothing> listOfShirts = dbCloting.clothings.Where(item => item.clothingType == "Shirt").ToList();
                return Ok(new { listOfShirts });
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

        // GET: api/Shirts/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                clothing ShirtById = dbCloting.clothings.Where(item => item.clothingType == "Shirt").First(item => item.Id ==  id);
                return Ok(new { ShirtById });
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

        // POST: api/Shirts
        public IHttpActionResult Post([FromBody] clothing shirtToAdd)
        {
            try
            {
                dbCloting.clothings.InsertOnSubmit(shirtToAdd);
                dbCloting.SubmitChanges();
                return Ok($"Add to Table , id: {shirtToAdd.Id}");
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
        // PUT: api/Shirts/5
        public IHttpActionResult Put(int id, [FromBody] clothing shirtToUpdate)
        {
            try
            {
                clothing findItemToUpdate = dbCloting.clothings.Where(item => item.clothingType == "Shirt").First(item => item.Id ==  id);
                if (findItemToUpdate != null)
                {
                    findItemToUpdate.clothingType=shirtToUpdate.clothingType;
                    findItemToUpdate.clothingGender=shirtToUpdate.clothingGender;
                    findItemToUpdate.clothingCompany = shirtToUpdate.clothingCompany;
                    findItemToUpdate.clothingModel = shirtToUpdate.clothingModel;
                    findItemToUpdate.clothingPrice= shirtToUpdate.clothingPrice;
                    findItemToUpdate.clothingAmount=shirtToUpdate.clothingAmount;
                    findItemToUpdate.isClothingShort=shirtToUpdate.isClothingShort;
                    findItemToUpdate.isClothingDrifit=shirtToUpdate.isClothingDrifit;
                    findItemToUpdate.linkToClothing=shirtToUpdate.linkToClothing;

                    dbCloting.SubmitChanges();
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

        // DELETE: api/Shirts/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                clothing shirtToDelete = dbCloting.clothings.Where(item => item.clothingType == "Shirt").First(item => item.Id ==  id);
                if (shirtToDelete !=null)
                {
                    dbCloting.clothings.DeleteOnSubmit(shirtToDelete);
                    dbCloting.SubmitChanges();
                    return Ok($"id Deleted: {shirtToDelete.Id}");
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
