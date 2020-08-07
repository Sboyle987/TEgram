﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Favorite
    {
        public int UserId { get; set; }
        public int PhotoId { get; set; }

        public Favorite(int passedPhotoId)
        {
            PhotoId = passedPhotoId;

        }
    }
}
