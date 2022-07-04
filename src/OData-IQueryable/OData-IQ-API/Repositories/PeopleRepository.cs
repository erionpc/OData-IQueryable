using Microsoft.EntityFrameworkCore;
using OData_IQ_API.Abstractions.Data;
using OData_IQ_API.DbContexts;
using OData_IQ_API.DTOs;
using OData_IQ_API.DTOs.Requests;
using OData_IQ_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.Repositories
{
    public class PeopleRepository : BaseRepository, IPeopleRepository 
    {
        public PeopleRepository(RecordStoreDbContext dataContext) : base(dataContext)
        {
        }

        public Task<List<PersonDto>> GetAll(PeopleSearchRequestDto searchCriteria)
        {
            return DataContext.People!
                .Where(x =>
                    searchCriteria.Id.HasValue ? x.Id == searchCriteria.Id : true &&
                    searchCriteria.Email != null ? x.Email!.Equals(searchCriteria.Email, StringComparison.InvariantCultureIgnoreCase) : true &&
                    searchCriteria.EmailLike != null ? x.Email!.Contains(searchCriteria.EmailLike) : true &&
                    searchCriteria.Name != null ? x.Name!.Equals(searchCriteria.Name, StringComparison.InvariantCultureIgnoreCase) : true &&
                    searchCriteria.NameLike != null ? x.Name!.Contains(searchCriteria.NameLike) : true &&
                    searchCriteria.Surname != null ? x.Surname!.Equals(searchCriteria.Surname, StringComparison.InvariantCultureIgnoreCase) : true &&
                    searchCriteria.SurnameLike != null ? x.Surname!.Contains(searchCriteria.SurnameLike) : true &&
                    searchCriteria.DateOfBirth.HasValue ? x.DateOfBirth == searchCriteria.DateOfBirth : true &&
                    searchCriteria.DateOfBirthBefore.HasValue ? x.DateOfBirth < searchCriteria.DateOfBirthBefore : true &&
                    searchCriteria.DateOfBirthAfter.HasValue ? x.DateOfBirth > searchCriteria.DateOfBirthAfter : true
                )
                .Select(p => p.MapToDto())
                .ToListAsync();
        }

        public IQueryable<PersonDto> Query() =>
            DataContext.People!
            .Select(p => new PersonDto()
            {
                Id = p.Id,
                Email = p.Email,
                Name = p.Name,
                Surname = p.Surname,
                DateOfBirth = p.DateOfBirth
            });

        public IQueryable<PersonDto> Query_expandedMapping()
        {
            IEnumerable<RatingDto> emptyRatings = new List<RatingDto>();

            return
                DataContext.People!
                .Include("Records")
                .Include($"Records.Record")
                .Include($"Records.Record.Record")
                .Include($"Records.Record.Record.Ratings")
                .Include($"Records.Record.Record.Ratings.RatedByPerson")
                .Include($"Records.Record.Store")
                .Include($"Records.Record.Store.Ratings")
                .Include($"Records.Record.Store.Ratings.RatedByPerson")
                .Include($"Records.Record.Store.Records")
                .Include($"Records.Record.Store.Records.Ratings")
                .Include($"Records.Record.Store.Records.Ratings.RatedByPerson")
                .Select(p => new PersonDto() 
                {
                    Id = p.Id,
                    Email = p.Email,
                    Name = p.Name,
                    Surname = p.Surname,
                    DateOfBirth = p.DateOfBirth,
                    Records = p.Records.Select(r => new PersonMusicRecordDto()
                    {
                        Id = r.Id,
                        DateBought = r.DateBought,                     
                        StoreRecord = r.Record == null ? null : new StoreMusicRecordDto() 
                        {
                            Id = r.Record.Id,
                            DateFirstArrived = r.Record.DateFirstArrived,
                            Record = r.Record.Record == null ? null : new MusicRecordDto() 
                            {
                                Id = r.Record.Record.Id,
                                Artist = r.Record.Record.Artist,
                                Title = r.Record.Record.Title,
                                Year = r.Record.Record.Year,
                                Ratings = !r.Record.Record.Ratings.Any() ? null :
                                    r.Record.Record.Ratings.Select(x => new RatingDto()
                                    {
                                        Id = x.Id,
                                        RatedByPerson = x.RatedByPerson == null ? null : new PersonDto()
                                        {
                                            Id = x.RatedByPerson.Id,
                                            DateOfBirth = x.RatedByPerson.DateOfBirth,
                                            Email = x.RatedByPerson.Email,
                                            Name = x.RatedByPerson.Name,
                                            Surname = x.RatedByPerson.Surname
                                        },
                                        RatedDate = x.RatedDate,
                                        Value = x.Value
                                    })
                            },
                            Store = r.Record.Store == null ? null : new RecordStoreDto()
                            {
                                Id = r.Record.Store.Id,
                                Name = r.Record.Store.Name,
                                StoreAddress = r.Record.Store.StoreAddress == null ? null : new AddressDto()
                                {
                                    City = r.Record.Store.StoreAddress.City,
                                    Country = r.Record.Store.StoreAddress.Country,
                                    PostalCode = r.Record.Store.StoreAddress.PostalCode,
                                    Street = r.Record.Store.StoreAddress.Street
                                },
                                StoreUri = r.Record.Store.StoreUri,
                                Tags = r.Record.Store.Tags,
                                Ratings = !r.Record.Store.Ratings.Any() ? null :
                                    r.Record.Store.Ratings.Select(x => new RatingDto()
                                    {
                                        Id = x.Id,
                                        RatedByPerson = x.RatedByPerson == null ? null : new PersonDto()
                                        {
                                            Id = x.RatedByPerson.Id,
                                            DateOfBirth = x.RatedByPerson.DateOfBirth,
                                            Email = x.RatedByPerson.Email,
                                            Name = x.RatedByPerson.Name,
                                            Surname = x.RatedByPerson.Surname
                                        },
                                        RatedDate = x.RatedDate,
                                        Value = x.Value
                                    }),
                                Records = r.Record.Store.Records.Select(x => new MusicRecordDto()
                                {
                                    Id = x.Id,
                                    Artist = x.Artist,
                                    Title = x.Title,
                                    Year = x.Year,
                                    Ratings = !x.Ratings.Any() ? null :
                                        x.Ratings.Select(y => new RatingDto()
                                        {
                                            Id = y.Id,
                                            RatedByPerson = y.RatedByPerson == null ? null : new PersonDto()
                                            {
                                                Id = y.RatedByPerson.Id,
                                                DateOfBirth = y.RatedByPerson.DateOfBirth,
                                                Email = y.RatedByPerson.Email,
                                                Name = y.RatedByPerson.Name,
                                                Surname = y.RatedByPerson.Surname
                                            },
                                            RatedDate = y.RatedDate,
                                            Value = y.Value
                                        })
                                })
                            }
                        }
                    }),
                });
        }
    }
}
