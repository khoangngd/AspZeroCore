﻿using kns.TourLand.Dto;

namespace kns.TourLand.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }

        public bool ExcludeCurrentUser { get; set; }
    }
}