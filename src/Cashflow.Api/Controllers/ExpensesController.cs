using Cashflow.Communication.Requests;
using Cashflow.Communication.Responses;
using CashFlow.Application.UseCases.Expenses.Register;
using Microsoft.AspNetCore.Mvc;

namespace Cashflow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        try
        {
            var useCase = new RegisterExpenseUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
        catch (ArgumentException ex) // Try catch para tratrar exception
        {
            var errorReponse = new ResponseErrorJson(ex.Message);
                       
            return BadRequest(errorReponse);
        }
        catch 
        {
            var errorReponse = new ResponseErrorJson("unknown error");
            

            return StatusCode(StatusCodes.Status500InternalServerError, errorReponse);
        }
       
    }
}
