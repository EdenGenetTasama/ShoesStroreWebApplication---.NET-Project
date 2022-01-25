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
    public class SportEquipmentController : ApiController
    {
        SportEquipmentContextDataContext sportDb = new SportEquipmentContextDataContext();

        // GET: api/SportEquipment
        public IHttpActionResult Get()
        {

            try
            {
                List<sportEquipment> listOfItems = sportDb.sportEquipments.ToList();
                //List<SportsClub> listOfItems2 = sportDb.SportsClubs.ToList();

                return Ok(new { listOfItems  });
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

        // GET: api/SportEquipment/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                sportEquipment sportEquipmentById = sportDb.sportEquipments.First(item => item.Id == id);
                if (sportEquipmentById !=null)
                {
                    return Ok(new { sportEquipmentById });
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

        // POST: api/SportEquipment
        public IHttpActionResult Post([FromBody] sportEquipment sportEquipmentAdd)
        {
            try
            {
                sportDb.sportEquipments.InsertOnSubmit(sportEquipmentAdd);
                sportDb.SubmitChanges();
                return Ok($"Add to Table , id: {sportEquipmentAdd.Id}");
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

        // PUT: api/SportEquipment/5
        public IHttpActionResult Put(int id, [FromBody] sportEquipment sportEquipmentToUpdate)
        {
            try
            {
                sportEquipment findByIdSportEquipmentToUpdate = sportDb.sportEquipments.First(item => item.Id == id);
                if (findByIdSportEquipmentToUpdate != null)
                {
                    findByIdSportEquipmentToUpdate.sportBranch=sportEquipmentToUpdate.sportBranch;
                    findByIdSportEquipmentToUpdate.productName=sportEquipmentToUpdate.productName;
                    findByIdSportEquipmentToUpdate.productCompany = sportEquipmentToUpdate.productCompany;
                    findByIdSportEquipmentToUpdate.productPrice = sportEquipmentToUpdate.productPrice;
                    findByIdSportEquipmentToUpdate.productAmount= sportEquipmentToUpdate.productAmount;
                    findByIdSportEquipmentToUpdate.SportClubsID=sportEquipmentToUpdate.SportClubsID;
                    findByIdSportEquipmentToUpdate.linkToImage=sportEquipmentToUpdate.linkToImage;
                    sportDb.SubmitChanges();
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

        // DELETE: api/SportEquipment/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                sportEquipment sportEquipmentToDelete = sportDb.sportEquipments.First(item => item.Id == id);
                if (sportEquipmentToDelete !=null)
                {
                    sportDb.sportEquipments.DeleteOnSubmit(sportEquipmentToDelete);
                    sportDb.SubmitChanges();
                    return Ok($"id Deleted: {sportEquipmentToDelete.Id}");
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
