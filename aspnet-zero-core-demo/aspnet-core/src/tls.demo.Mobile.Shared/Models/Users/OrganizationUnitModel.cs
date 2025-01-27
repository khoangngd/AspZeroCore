﻿using Abp.AutoMapper;
using tls.demo.Organizations.Dto;

namespace tls.demo.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}