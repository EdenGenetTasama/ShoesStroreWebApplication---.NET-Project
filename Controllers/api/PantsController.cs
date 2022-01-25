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

    public class PantsController : ApiController
    {
        ShirtsContextDataContext dbCloting = new ShirtsContextDataContext();
        // GET: api/Pants
        public IHttpActionResult Get()
        {
            try
            {
                List<clothing> listOfPants = dbCloting.clothings.Where(item => item.clothingType == "Pants").ToList();
                return Ok(new { listOfPants });
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

        // GET: api/Pants/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                clothing PantsById = dbCloting.clothings.Where(item => item.clothingType == "Pants").First(item => item.Id ==  id);
                return Ok(new { PantsById });
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

        // POST: api/Pants
        public IHttpActionResult Post([FromBody] clothing pantsToAdd)
        {
            try
            {
                dbCloting.clothings.InsertOnSubmit(pantsToAdd);
                dbCloting.SubmitChanges();
                return Ok($"Add to Table , id: {pantsToAdd.Id}");
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

        // PUT: api/Pants/5
        public IHttpActionResult Put(int id, [FromBody] clothing pantsToUpdate)
        {
            try
            {
                clothing findItemToUpdate = dbCloting.clothings.Where(item => item.clothingType == "Pants").First(item => item.Id ==  id);
                if (findItemToUpdate != null)
                {
                    findItemToUpdate.clothingType=pantsToUpdate.clothingType;
                    findItemToUpdate.clothingGender=pantsToUpdate.clothingGender;
                    findItemToUpdate.clothingCompany = pantsToUpdate.clothingCompany;
                    findItemToUpdate.clothingModel = pantsToUpdate.clothingModel;
                    findItemToUpdate.clothingPrice= pantsToUpdate.clothingPrice;
                    findItemToUpdate.clothingAmount=pantsToUpdate.clothingAmount;
                    findItemToUpdate.isClothingShort=pantsToUpdate.isClothingShort;
                    findItemToUpdate.isClothingDrifit=pantsToUpdate.isClothingDrifit;
                    findItemToUpdate.linkToClothing=pantsToUpdate.linkToClothing;

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

        // DELETE: api/Pants/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                clothing pantsToDelete = dbCloting.clothings.Where(item => item.clothingType == "Pants").First(item => item.Id ==  id);
                if (pantsToDelete !=null)
                {
                    dbCloting.clothings.DeleteOnSubmit(pantsToDelete);
                    dbCloting.SubmitChanges();
                    return Ok($"id Deleted: {pantsToDelete.Id}");
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
