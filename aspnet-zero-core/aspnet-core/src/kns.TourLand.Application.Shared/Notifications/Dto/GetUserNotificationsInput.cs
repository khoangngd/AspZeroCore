﻿using System;
using Abp.Notifications;
using kns.TourLand.Dto;

namespace kns.TourLand.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}