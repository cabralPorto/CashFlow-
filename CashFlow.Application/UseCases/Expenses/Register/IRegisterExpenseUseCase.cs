﻿using Cashflow.Communication.Requests;
using Cashflow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;
public interface IRegisterExpenseUseCase
{
    Task <ResponseRegisteredExpenseJson> Execute(RequestRegisterExpenseJson request);
}
