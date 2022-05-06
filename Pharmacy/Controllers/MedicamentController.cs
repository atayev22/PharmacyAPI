
using BLogics.Service;
using DTO;
using Microsoft.AspNetCore.Mvc;


namespace APIurok.Controllers
{


    [ApiController]
    [Route("[controller]")]


    public class MedicamentController : Controller
    {

        private IMedicamentService carService;

        public MedicamentController(IMedicamentService carService)
        {
            this.carService = carService;
        } 

        [HttpGet("Get")]
        public IEnumerable<MedicamentDTO> GetCars()
        {
            return carService.Get();
        }


        [HttpGet("Get/{id}")]
        public MedicamentDTO GetACar([FromRoute] int id)
        {
         
            return carService.Get(id) ;
        }



        [HttpPost("Add")]
        public void AddCar(MedicamentDTO car)
        {           
            carService.Add(car);
        }

        [HttpPut("Update")]
        public void UpdateCar([FromBody] MedicamentDTO car)
        {
  
            carService.Update(car);
            
        }

        [HttpDelete("Delete/{id}")]
        public void DeleteCar([FromRoute] int id)
        {
           
             carService.Delete(id);
        }


    }
}
