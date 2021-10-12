﻿using Abp.Application.Services.Dto;

namespace tls.demo.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}