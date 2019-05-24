﻿using AutoMapper;
using Hilton.HotelManagement.AppServices;
using Hilton.HotelManagement.AppServices.HotelOperations.Reservations.Dtos;
using Hilton.HotelManagement.HotelOperations;

namespace Hilton.HotelManagement
{
    public class HotelManagementApplicationAutoMapperProfile : Profile
    {
        public HotelManagementApplicationAutoMapperProfile()
        {
            //Configure your AutoMapper mapping configuration here...
            CreateMappingsReservation();
        }

        private void CreateMappingsReservation()
        {
            CreateMap<ReservationCreateDto, Reservation>();

            CreateMap<Reservation, ReservationDto>();

            CreateMap<ReservationUpdateDto, Reservation>();
        }
    }
}
