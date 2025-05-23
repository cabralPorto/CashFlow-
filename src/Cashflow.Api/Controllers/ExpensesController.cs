﻿using Cashflow.Communication.Requests;
using CashFlow.Application.UseCases.Expenses.Register;
using Microsoft.AspNetCore.Mvc;

namespace Cashflow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Register(
        [FromServices] IRegisterExpenseUseCase useCase, 
        [FromBody] RequestRegisterExpenseJson request)
    {
        var response = await useCase.Execute(request);
        return Created(string.Empty, response);
    }
}
