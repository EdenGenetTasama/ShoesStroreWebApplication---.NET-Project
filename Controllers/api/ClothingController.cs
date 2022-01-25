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
    public class ClothingController : ApiController
    {
        ShirtsContextDataContext dbCloting = new ShirtsContextDataContext();

        // GET: api/Clothing
        public IHttpActionResult Get()
        {

            try
            {
                List<clothing> listOfAllclothing = dbCloting.clothings.ToList();
                if (listOfAllclothing !=null)
                {
                    return Ok(new { listOfAllclothing });
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

        // GET: api/Clothing/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                clothing clothingById = dbCloting.clothings.First(item => item.Id == id);
                if (clothingById !=null)
                {
                    return Ok(new { clothingById });
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

        // POST: api/Clothing
        public IHttpActionResult Post([FromBody] clothing clothingAdd)
        {
            try
            {
                dbCloting.clothings.InsertOnSubmit(clothingAdd);
                dbCloting.SubmitChanges();
                return Ok($"Add to Table , id: {clothingAdd.Id}");
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

        // PUT: api/Clothing/5
        public IHttpActionResult Put(int id, [FromBody] clothing clothingNewInfoTo)
        {
            try
            {
                clothing findByIdclothingToUpdate = dbCloting.clothings.First(item => item.Id == id);
                if (findByIdclothingToUpdate != null)
                {
                    findByIdclothingToUpdate.clothingType=clothingNewInfoTo.clothingType;
                    findByIdclothingToUpdate.clothingGender=clothingNewInfoTo.clothingGender;
                    findByIdclothingToUpdate.clothingCompany = clothingNewInfoTo.clothingCompany;
                    findByIdclothingToUpdate.clothingModel = clothingNewInfoTo.clothingModel;
                    findByIdclothingToUpdate.clothingPrice= clothingNewInfoTo.clothingPrice;
                    findByIdclothingToUpdate.clothingAmount=clothingNewInfoTo.clothingAmount;
                    findByIdclothingToUpdate.isClothingShort=clothingNewInfoTo.isClothingShort;
                    findByIdclothingToUpdate.isClothingDrifit=clothingNewInfoTo.isClothingDrifit;
                    findByIdclothingToUpdate.linkToClothing=clothingNewInfoTo.linkToClothing;

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

        // DELETE: api/Clothing/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                clothing clothingToDelete = dbCloting.clothings.First(item => item.Id == id);
                if (clothingToDelete !=null)
                {
                    dbCloting.clothings.DeleteOnSubmit(clothingToDelete);
                    dbCloting.SubmitChanges();
                    return Ok($"id Deleted: {clothingToDelete.Id}");
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
