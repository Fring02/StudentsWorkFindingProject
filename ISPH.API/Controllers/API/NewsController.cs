﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ISPH.Core.DTO;
using ISPH.Core.Models;
using ISPH.Infrastructure;
using ISPH.Infrastructure.Repositories;
using ISPH.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ISPH.API.Controllers
{
    [Route("[controller]/")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsRepository _repos;
        public NewsController(INewsRepository repos)
        {
            _repos = repos;
        }

        [HttpGet]
        public async Task<IList<News>> GetAllNewsAsync()
        {
            return await _repos.GetAll();
        }

        [HttpGet("id={id}")]
        public async Task<News> GetNewsByIdAsync(int id)
        {
            return await _repos.GetById(id);
        }

        [HttpPost("add")]
        [Authorize(Roles = RoleType.Admin)]
        public async Task<IActionResult> AddNewsAsync(NewsDTO newsDTO)
        {
            if (!ModelState.IsValid) return BadRequest("Fill all fields");
            News news = new News()
            {
                Title = newsDTO.Title,
                PublishDate = newsDTO.PublishDate.GetValueOrDefault(),
                Description = newsDTO.Description
            };

            if (await _repos.HasEntity(news)) return BadRequest("These news already exist");
            if (await _repos.Create(news)) return Ok("Added new news");

            return BadRequest("Failed to add news");
        }

        [HttpPut("id={id}/update")]
        [Authorize(Roles = RoleType.Admin)]
        public async Task<IActionResult> UpdateNewsAsync(NewsDTO newsDTO, int id)
        {
            if (!ModelState.IsValid) return BadRequest("Fill all fields");

            News news = await _repos.GetById(id);
            if (news == null) return BadRequest("These news doesn't exist");
            news.Title = newsDTO.Title;
            news.PublishDate = newsDTO.PublishDate.GetValueOrDefault();
            news.Description = newsDTO.Description;

            if (_repos.Update(news)) return Ok("Updated news");
            return BadRequest("Failed to update news");
        }

        [HttpDelete("id={id}/delete")]
        [Authorize(Roles = RoleType.Admin)]
        public async Task<IActionResult> DeleteNewsAsync(int id)
        {
            News news = await _repos.GetById(id);
            if (news == null) return BadRequest("These news are already deleted");
            if (await _repos.Delete(news)) return Ok("Deleted news");
            return BadRequest("Failed to delete news");
        }
    }
}
